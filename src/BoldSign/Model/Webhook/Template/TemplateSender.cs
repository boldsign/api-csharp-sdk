// <copyright file="TemplateSender.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook.Template
{
    using Newtonsoft.Json;

    /// <summary>
    /// The TemplateSender.
    /// </summary>
    public class TemplateSender : TemplateCc
    {
        /// <summary>
        /// Gets or sets recipient Name.
        /// </summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }
}
