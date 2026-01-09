// <copyright file="GroupSignerSettings.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the contact groups settings data for group signers.
    /// </summary>
    public class GroupSignerSettings
    {
        /// <summary>
        /// Gets a value indicating whether it is enabled for adding new group signer recipients in embedded page.
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets the allowed directories.
        /// </summary>
        [DataMember(Name = "allowedDirectories", EmitDefaultValue = false)]
        [JsonProperty("allowedDirectories")]
        public List<string> AllowedDirectories { get; set; }
    }
}
