// <copyright file="CheckboxValidationSettings.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The checkbox validation settings.
    /// </summary>
    public class CheckboxValidationSettings
    {
        /// <summary>
        /// Gets or sets the conditionType.
        /// </summary>
        [DataMember(Name = "validationType", EmitDefaultValue = false)]
        public GroupValidation ValidationType { get; set; }

        /// <summary>
        /// Gets or sets the min selection.
        /// </summary>
        [DataMember(Name = "minSelection", EmitDefaultValue = true)]
        public int? MinSelection { get; set; }

        /// <summary>
        /// Gets or sets the max selection.
        /// </summary>
        [DataMember(Name = "maxSelection", EmitDefaultValue = true)]
        public int? MaxSelection { get; set; }
    }
}
