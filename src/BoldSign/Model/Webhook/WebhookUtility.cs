// <copyright file="WebhookUtility.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>


namespace BoldSign.Model.Webhook
{
    using System.Collections.Generic;
    using BoldSign.Api.Converters;
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using BoldSign.Api;
    using BoldSign.Api.Resources;

    /// <summary>
    /// The webhook event utility.
    /// </summary>
    public static class WebhookUtility
    {
        /// <summary>
        /// The BoldSign event header.
        /// </summary>
        public const string BoldSignEventHeader = "X-BoldSign-Event";

        /// <summary>
        /// The BoldSign signature header.
        /// </summary>
        public const string BoldSignSignatureHeader = "X-BoldSign-Signature";

        /// <summary>
        /// The SafeUtf8 encoder.
        /// </summary>
        internal static readonly UTF8Encoding SafeUtf8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        private const int DefaultTimeTolerance = 300;

        /// <summary>
        /// Parses a JSON string from a BoldSign webhook into a <see cref="WebhookEvent"/> object.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <returns>The deserialized <see cref="WebhookEvent"/>.</returns>
        public static WebhookEvent ParseEvent(string json)
        {
            var webhookEvent = JsonConvert.DeserializeObject<WebhookEvent>(
                json,
                new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter>
                    {
                        new WebhookObjectConverter(),
                    },
                    DateParseHandling = DateParseHandling.DateTime,
                });

            return webhookEvent;
        }

        /// <summary>
        /// Comparing the hmac signature by request header.
        /// </summary>
        /// <param name="json">The json payload from the webhook request.</param>
        /// <param name="signatureHeader">The signature header (Key name: <see cref="BoldSignSignatureHeader"/>) from the webhook request.</param>
        /// <param name="secretKey">The webhook secret key.</param>
        /// <param name="tolerance">The timestamp tolerance (defaults to 300 seconds).</param>
        /// <exception cref="ArgumentNullException">Thrown when one of the required input is null or empty.</exception>
        /// <exception cref="BoldSignSignatureException">Thrown when there is mismatch in signature comparison.</exception>
        public static void ValidateSignature(string json, string signatureHeader, string secretKey, long tolerance = DefaultTimeTolerance)
        {
            ValidateSignature(json, signatureHeader, secretKey, tolerance, ToEpochTimeSeconds(DateTime.UtcNow));
        }

        private static void ValidateSignature(string json, string signatureHeader, string secretKey, long tolerance, long utcNow)
        {
            if (string.IsNullOrEmpty(json))
            {
                throw new ArgumentNullException(nameof(json));
            }

            if (string.IsNullOrEmpty(signatureHeader))
            {
                throw new ArgumentNullException(nameof(signatureHeader));
            }

            if (string.IsNullOrEmpty(secretKey))
            {
                throw new ArgumentNullException(nameof(secretKey));
            }

            var hmacSignature = ParseBoldSignSignature(signatureHeader);
            string signature;

            try
            {
                signature = GenerateHmacSignature(secretKey, json, hmacSignature["t"].FirstOrDefault());
            }
            catch (EncoderFallbackException)
            {
                throw new BoldSignSignatureException(ApiValidationMessages.WrongSignature);
            }

            if (IsSignatureMatched(signature, hmacSignature["s0"]) == false
                && IsSignatureMatched(signature, hmacSignature["s1"]) == false)
            {
                throw new BoldSignSignatureException(ApiValidationMessages.NotValidSignature);
            }

            var timestamp = Convert.ToInt32(hmacSignature["t"].FirstOrDefault(), NumberFormatInfo.CurrentInfo);

            if (Math.Abs(utcNow - timestamp) > tolerance)
            {
                throw new BoldSignSignatureException(ApiValidationMessages.NotInAllowedTolerance);
            }
        }

        private static ILookup<string, string> ParseBoldSignSignature(string signatureHeader)
        {
            static Tuple<string, string> ParsePair(string pairStr)
            {
                var pair = pairStr.Trim().Split(new[] { '=' }, 2);

                if (pair.Length != 2)
                {
                    throw new BoldSignSignatureException("Unexpected characters found while parsing signature header");
                }

                return new Tuple<string, string>(pair[0], pair[1]);
            }

            return signatureHeader.Trim().Split(',').Select(ParsePair).ToLookup(item => item.Item1, item => item.Item2);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "HMAC signature contains lower case only.")]
        private static string GenerateHmacSignature(string secretKey, string payload, string timestamp)
        {
            var secretBytes = SafeUtf8.GetBytes(secretKey);
            var payloadBytes = SafeUtf8.GetBytes($"{timestamp}.{payload}");

            using var cryptographer = new HMACSHA256(secretBytes);
            var hash = cryptographer.ComputeHash(payloadBytes);

            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
        }

        private static bool IsSignatureMatched(string signature, IEnumerable<string> signatures)
        {
            return signatures.Any(key => SecureEquals(key, signature));
        }

        private static bool SecureEquals(string key, string signature)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (signature == null)
            {
                throw new ArgumentNullException(nameof(signature));
            }

            if (key.Length != signature.Length)
            {
                return false;
            }

            int num = 0;

            for (int index = 0; index < key.Length; ++index)
            {
                num |= (int)key[index] ^ (int)signature[index];
            }

            return num == 0;
        }

        private static long ToEpochTimeSeconds(DateTime dateTime)
        {
            var date = dateTime.ToUniversalTime();
            var ticks = date.Ticks - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).Ticks;
            var ts = ticks / TimeSpan.TicksPerSecond;

            return ts;
        }
    }
}
