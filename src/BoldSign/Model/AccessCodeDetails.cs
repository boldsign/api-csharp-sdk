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
    using System.IO;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///     The access code model.
    /// </summary>
    [DataContract]
    public class AccessCodeDetails
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AccessCodeDetails" /> class.
        /// </summary>
        /// <param name="accessCode">Gets or sets the access code. (required).</param>
        public AccessCodeDetails(string accessCode = default)
        {
            // to ensure "accessCode" is required (not null)
            if (accessCode == null)
            {
                throw new InvalidDataException("accessCode is a required property for AccessCodeDetails and cannot be null");
            }

            this.AccessCode = accessCode;
        }

        /// <summary>
        ///  Gets or sets the access code.
        /// </summary>
        /// <value>Gets or sets the access code.</value>
        [DataMember(Name = "accessCode", EmitDefaultValue = true)]
        public string AccessCode { get; set; }


        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
