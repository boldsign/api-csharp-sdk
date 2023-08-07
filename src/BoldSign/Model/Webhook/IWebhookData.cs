// <copyright file="IWebhookData.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model.Webhook
{
    using Newtonsoft.Json;

    /// <summary>
    /// The webhook data base type.
    /// </summary>
    public interface IWebhookData
    {
        /// <summary>
        /// Gets or sets the object name.
        /// </summary>
        [JsonProperty("object")]
        public string ObjectType { get; set; }
    }
}
