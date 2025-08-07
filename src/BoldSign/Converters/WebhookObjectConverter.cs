// <copyright file="WebhookObjectConverter.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

using BoldSign.Api.Model.Webhook.Template;

namespace BoldSign.Api.Converters
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reflection;
    using BoldSign.Model.Webhook;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The webhook data serializer.
    /// </summary>
    public class WebhookObjectConverter : JsonConverter
    {
        /// <summary>
        /// Gets the object type.
        /// </summary>
        public static readonly IReadOnlyDictionary<string, Type> ObjectsToTypes = new ReadOnlyDictionary<string, Type>(
            new Dictionary<string, Type>
            {
                { WebhookConstants.Document, typeof(DocumentEvent) },
                { WebhookConstants.SenderIdentity, typeof(SenderIdentityEvent) },
                { WebhookConstants.Template, typeof(TemplateEvent) },
                { WebhookConstants.IdentityVerification, typeof(IdentityVerificationEvent) },
            });

        private static readonly Type WebhookEventDataType = typeof(IWebhookData);

        /// <summary>
        /// Gets the object type.
        /// </summary>
        /// <param name="dataType">The webhook data type filter.</param>
        /// <param name="objectValue">The object value.</param>
        /// <returns>The object type.</returns>
        public static Type GetWebhookDataType(Type dataType, string objectValue)
        {
            if (string.IsNullOrEmpty(objectValue) || !ObjectsToTypes.TryGetValue(objectValue, out var concreteType))
            {
                return null;
            }

            return dataType.GetTypeInfo().IsAssignableFrom(concreteType.GetTypeInfo()) ? concreteType : null;
        }

        /// <inheritdoc/>
        public override bool CanConvert(Type objectType)
        {
            return objectType == WebhookEventDataType;
        }

        /// <inheritdoc/>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (serializer == null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var jsonObject = JObject.Load(reader);

            if (!jsonObject.ContainsKey(WebhookConstants.ObjectType)
                || jsonObject[WebhookConstants.ObjectType] == null)
            {
                return null;
            }

            var objectValue = (string)jsonObject[WebhookConstants.ObjectType];
            var dataType = GetWebhookDataType(objectType, objectValue);

            if (dataType == null)
            {
                return null;
            }

            using var subReader = jsonObject.CreateReader();

            return serializer.Deserialize(subReader, dataType);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (serializer == null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            serializer.Serialize(writer, value);
        }
    }
}
