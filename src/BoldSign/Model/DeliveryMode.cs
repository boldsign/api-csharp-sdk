// <copyright file="DeliveryMode.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Signature request delivery mode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryMode
    {
        /// <summary>
        /// The enum for Email sign request type.
        /// </summary>
        [EnumMember(Value = "Email")]
        Email = 0,

        /// <summary>
        /// The enum for SMS sign request type.
        /// </summary>
        [EnumMember(Value = "SMS")]
        SMS = 1,

        /// <summary>
        /// The enum for Email and SMS sign request type.
        /// </summary>
        [EnumMember(Value = "EmailAndSMS")]
        EmailAndSMS = 2,

        /// <summary>
        /// The enum for WhatsApp request type.
        /// </summary>
        [EnumMember(Value = "WhatsApp")]
        WhatsApp = 3,
    }
}
