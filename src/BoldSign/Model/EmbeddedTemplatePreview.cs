// <copyright file="EmbeddedTemplatePreview.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The Embedded Template Preview.
    /// </summary>
    [DataContract]
    public class EmbeddedTemplatePreview
    {
        /// <summary>
        /// Gets or sets embedded template Preview url.
        /// </summary>
        /// <value>Gets or sets Template Preview url.</value>
        [DataMember(Name = "templateUrl", EmitDefaultValue = true)]
        public Uri TemplateUrl { get; set; }
    }
}