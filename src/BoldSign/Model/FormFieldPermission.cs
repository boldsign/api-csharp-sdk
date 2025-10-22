// <copyright file="FormFieldPermission.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>
namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The form field permissions options.
    /// </summary>
    [DataContract]
    public class FormFieldPermission
    {
        /// <summary>
        ///  Gets or sets a value indicating whether to can add form fields to signer while sending a template.
        /// </summary>
        [DataMember(Name = "canAdd", EmitDefaultValue = true)]
        public bool CanAdd { get; set; } = true;

        /// <summary>
        ///  Gets or sets a value indicating whether to can modify form fields while sending a template.
        /// </summary>
        [DataMember(Name = "canModify", EmitDefaultValue = true)]
        public bool CanModify { get; set; } = true;

        /// <summary>
        ///  Gets or sets a value indicating whether to can modify the default values of form fields while sending a template.
        /// </summary>
        [DataMember(Name = "canModifyDefaultValue", EmitDefaultValue = false)]
        public bool CanModifyDefaultValue { get; set; }
    }
}
