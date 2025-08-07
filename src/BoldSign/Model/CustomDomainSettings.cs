// <copyright file="BrandSettings.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents custom domain settings.
    /// </summary>
    public class CustomDomainSettings
    {
        /// <summary>
        /// Gets or sets the domain name.
        /// </summary>
        [DataMember(Name = "domainName", EmitDefaultValue = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets the from name.
        /// </summary>
        [DataMember(Name = "fromName", EmitDefaultValue = true)]
        public string FromName { get; set; }
    }
}
