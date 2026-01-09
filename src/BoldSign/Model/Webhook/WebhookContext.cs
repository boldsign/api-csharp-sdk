// <copyright file="WebhookContext.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook
{
    using System.Runtime.Serialization;
    using BoldSign.Model.Webhook;
    using Newtonsoft.Json;

    /// <summary>
    ///  The webhook context.
    /// </summary>
    [DataContract]
    public class WebhookContext
    {
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        [JsonProperty("eventType")]
        public WebHookEventType EventType { get; set; }

        /// <summary>
        /// Gets or sets the webhook actor details.
        /// </summary>
        [DataMember(Name = "actor", EmitDefaultValue = false)]
        [JsonProperty("actor")]
        public WebhookActorDetails Actor { get; set; }

        /// <summary>
        /// Gets or sets the previousState.
        /// </summary>
        [DataMember(Name = "previousState", EmitDefaultValue = false)]
        [JsonProperty("previousState")]
        public dynamic PreviousState { get; set; }
    }
}
