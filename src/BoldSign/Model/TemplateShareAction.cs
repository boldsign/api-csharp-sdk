// <copyright file="TemplateShareAction.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Enum for permission actions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TemplateShareAction
    {
        /// <summary>
        /// grant permission to a team.
        /// </summary>
        [EnumMember(Value = "Grant")]
        Grant = 1,

        /// <summary>
        /// revoke permission from a team.
        /// </summary>
        [EnumMember(Value = "Revoke")]
        Revoke = 2,
    }
}
