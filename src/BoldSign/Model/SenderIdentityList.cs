// <copyright file="SenderIdentityList.cs" company="Syncfusion Inc">
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
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The sender identity list view model.
    /// </summary>
    [DataContract]
    public class SenderIdentityList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SenderIdentityList" /> class.
        /// </summary>
        /// <param name="pageDetails">pageDetails.</param>
        /// <param name="result">Gets or sets the sender identity list result.</param>
        public SenderIdentityList(PageDetails pageDetails = default, List<SenderIdentityViewModel> result = default)
        {
            this.Result = result;
            this.PageDetails = pageDetails;
        }

        /// <summary>
        ///  Gets or Sets the page details.
        /// </summary>
        [DataMember(Name = "pageDetails", EmitDefaultValue = false)]
        public PageDetails PageDetails { get; set; }

        /// <summary>
        ///  Gets or sets the sender identity results.
        /// </summary>
        /// <value>Gets or sets the sender identity result.</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public List<SenderIdentityViewModel> Result { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
