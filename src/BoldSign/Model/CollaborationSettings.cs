// <copyright file="CollaborationSettings.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Collaboration settings for form fields .
    /// </summary>
    [DataContract]
    public class CollaborationSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether is required or not for collaborated signers.
        /// </summary>
        [DataMember(Name = "isRequired", EmitDefaultValue = false)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field should require signer approval or not.
        /// </summary>
        [DataMember(Name = "requireSignerApproval", EmitDefaultValue = false)]
        public bool? RequireSignerApproval { get; set; }

        /// <summary>
        /// Gets or sets a value whether the initials field is required or not when editing collaborative fields.
        /// </summary>
        [DataMember(Name = "RequireInitial", EmitDefaultValue = false)]
        public bool? RequireInitial { get; set; }

        /// <summary>
        /// Gets or sets the list of recipient's Ids who can collaborate on editing this field.
        /// </summary>
        [DataMember(Name = "allowedSigners", EmitDefaultValue = false)]
        public List<string> AllowedSigners { get; set; }

    }
}
