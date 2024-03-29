// <copyright file="SharedTemplateDetail.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

/*
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///     The shared template details have functions that define the team id, access type of shared template.
    /// </summary>
    [DataContract]
    public class SharedTemplateDetail
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SharedTemplateDetail" /> class.
        /// </summary>
        /// <param name="teamId">Gets or sets shared template's teamId..</param>
        /// <param name="accessType">Gets or sets shared template's access Type..</param>
        public SharedTemplateDetail(string teamId = default(string), TemplateAccessType accessType = default(TemplateAccessType))
        {
            this.TeamId = teamId;
            this.AccessType = accessType;
        }

        /// <summary>
        ///     Gets or sets recipient Team Id.
        /// </summary>
        /// <value> Gets the value of recipient Team Id.</value>
        [DataMember(Name = "teamId", EmitDefaultValue = true)]
        public string TeamId { get; set; }

        /// <summary>
        ///     Gets or sets recipient Access Type.
        /// </summary>
        /// <value> Gets the value of recipient Access Type.</value>
        [DataMember(Name = "accessType", EmitDefaultValue = true)]
        public TemplateAccessType AccessType { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
