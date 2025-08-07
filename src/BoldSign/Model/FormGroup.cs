// <copyright file="FormGroup.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

using System.IO;
using System.Linq;
using BoldSign.Api.Resources;

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// The form group DTO.
    /// </summary>
    [DataContract]
    public class FormGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormGroup"/> class.
        /// </summary>
        /// <param name="groupNames">The list of group names.</param>
        /// <param name="groupValidation">The group validation type.</param>
        public FormGroup(List<string> groupNames, GroupValidation groupValidation)
        {
            this.GroupNames = groupNames ?? throw new ArgumentNullException(nameof(groupNames));
            this.GroupValidation = groupValidation;

            if (this.GroupNames.Count == 0)
            {
                throw new ArgumentException($"{nameof(this.GroupNames)} cannot be empty");
            }
        }

        /// <summary>
        /// Gets or sets or minimum count of checkbox selection.
        /// </summary>
        [DataMember(Name = "minimumCount", EmitDefaultValue = false)]
        public int? MinimumCount { get; set; }

        /// <summary>
        /// Gets or sets or maximum count of checkbox selection.
        /// </summary>
        [DataMember(Name = "maximumCount", EmitDefaultValue = false)]
        public int? MaximumCount { get; set; }

        /// <summary>
        /// Gets or sets the DataSync of the checkbox.
        /// </summary>
        [DataMember(Name = "dataSyncTag", EmitDefaultValue = false)]
        public string DataSyncTag { get; set; }

        /// <summary>
        /// Gets or sets the group names of the checkbox.
        /// </summary>
        [DataMember(Name = "groupNames", EmitDefaultValue = false)]
        public List<string> GroupNames { get; set; }

        /// <summary>
        /// <para>Gets or sets the Group Validation type.</para>
        /// </summary>
        [DataMember(Name = "groupValidation", EmitDefaultValue = false)]
        public GroupValidation GroupValidation { get; set; }
    }
}
