// <copyright file="TemplateCc.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook.Template
{
    using Newtonsoft.Json;

    /// <summary>
    /// The template CC.
    /// </summary>
    public class TemplateCc
    {
        /// <summary>
        /// Gets or sets recipient Email address.
        /// </summary>
        [JsonProperty("emailAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets recipient User Id.
        /// </summary>
        [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }
    }
}
