// <copyright file="TemplateSigner.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook.Template
{
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    /// The template role details .
    /// </summary>
    public class TemplateSigner
    {
        /// <summary>
        /// Gets or sets name of the signer.
        /// </summary>
        [JsonProperty("signerName")]
        public string SignerName { get; set; }

        /// <summary>
        /// Gets or sets role of the signer.
        /// </summary>
        [JsonProperty("signerRole")]
        public string SignerRole { get; set; }

        /// <summary>
        /// Gets or sets email address of the signer.
        /// </summary>
        [JsonProperty("signerEmail")]
        public string SignerEmail { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether authentication is enabled for the signer.
        /// </summary>
        [JsonProperty("enableAccessCode")]
        public bool EnableAccessCode { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether email OTP authentication is enabled.
        /// </summary>
        [JsonProperty("enableEmailOTP")]
        public bool EnableEmailOTP { get; set; }

                /// <summary>
        /// Gets or sets status of the signer.
        /// </summary>
        [JsonProperty("status")]
        public SignerStatus Status { get; set; }

        /// <summary>
        ///     Gets or sets the user id.
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the value is used to define the siging order of the signer.
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets SignerType.
        /// </summary>
        [JsonProperty("signerType")]
        public string SignerType { get; set; }

        /// <summary>
        ///     Gets or sets the host user email.
        /// </summary>
        [JsonProperty("hostEmail")]
        public string HostEmail { get; set; }

        /// <summary>
        ///     Gets or sets the host user name.
        /// </summary>
        [JsonProperty("hostName")]
        public string HostName { get; set; }

        /// <summary>
        ///     Gets or sets the host user id.
        /// </summary>
        [JsonProperty("hostUserId")]
        public string HostUserId { get; set; }
    }
}
