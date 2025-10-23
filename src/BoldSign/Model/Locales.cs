// <copyright file="Locales.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The Locales.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Locales
    {
        /// <summary>
        /// English.
        /// </summary>
        [EnumMember(Value = "EN")]
        EN,

        /// <summary>
        /// Norwegian.
        /// </summary>
        [EnumMember(Value = "NO")]
        NO,

        /// <summary>
        /// French.
        /// </summary>
        [EnumMember(Value = "FR")]
        FR,

        /// <summary>
        /// German.
        /// </summary>
        [EnumMember(Value = "DE")]
        DE,

        /// <summary>
        /// Spanish.
        /// </summary>
        [EnumMember(Value = "ES")]
        ES,

        /// <summary>
        /// Bulgarian.
        /// </summary>
        [EnumMember(Value = "BG")]
        BG,

        /// <summary>
        /// Czech.
        /// </summary>
        [EnumMember(Value = "CS")]
        CS,

        /// <summary>
        /// Danish.
        /// </summary>
        [EnumMember(Value = "DA")]
        DA,

        /// <summary>
        /// Italian.
        /// </summary>
        [EnumMember(Value = "IT")]
        IT,

        /// <summary>
        /// Dutch.
        /// </summary>
        [EnumMember(Value = "NL")]
        NL,

        /// <summary>
        /// Polish.
        /// </summary>
        [EnumMember(Value = "PL")]
        PL,

        /// <summary>
        /// Portuguese.
        /// </summary>
        [EnumMember(Value = "PT")]
        PT,

        /// <summary>
        /// Romanian.
        /// </summary>
        [EnumMember(Value = "RO")]
        RO,

        /// <summary>
        /// Russian.
        /// </summary>
        [EnumMember(Value = "RU")]
        RU,

        /// <summary>
        /// Swedish.
        /// </summary>
        [EnumMember(Value = "SV")]
        SV,

        /// <summary>
        /// Inherit from template.
        /// </summary>
        [EnumMember(Value = "Default")]
        Default,

        /// <summary>
        /// Japanese.
        /// </summary>
        [EnumMember(Value = "JA")]
        JA,

        /// <summary>
        /// Thai.
        /// </summary>
        [EnumMember(Value = "TH")]
        TH,

        /// <summary>
        /// Simplified Chinese.
        /// </summary>
        [EnumMember(Value = "ZH_CN")]
#pragma warning disable CA1707
        ZH_CN,
#pragma warning restore CA1707

        /// <summary>
        /// Traditional Chinese.
        /// </summary>
        [EnumMember(Value = "ZH_TW")]
#pragma warning disable CA1707
        ZH_TW,
#pragma warning restore CA1707
    }
}
