// <copyright file="TemplateGroupSigner.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook.Template
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Template Group Signer Webhook object.
    /// </summary>
    public class TemplateGroupSigner
    {
        /// <summary>
        ///  Gets the signer email.
        /// </summary>
        [JsonProperty("signerEmail")]
        public string SignerEmail  { get; set; }

        /// <summary>
        /// Gets the signer name.
        /// </summary>
        [JsonProperty("signerName")]
        public string SignerName  { get; set; }
    }
}

