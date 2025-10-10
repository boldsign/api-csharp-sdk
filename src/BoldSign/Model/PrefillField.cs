// <copyright file="PrefillField.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    ///  Pre fill field.
    /// </summary>
    public class PrefillField
    {
        /// <summary>
        /// Gets or sets the form field ID.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the form field value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }
    }
}
