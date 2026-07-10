// <copyright file="GroupOption.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The group option.
    /// </summary>
    public class GroupOption
    {
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it gets or sets isSelected.
        /// </summary>
        [DataMember(Name = "isSelected", EmitDefaultValue = false)]
        public bool IsSelected { get; set; }
    }
}
