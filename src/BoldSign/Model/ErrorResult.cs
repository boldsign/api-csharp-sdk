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
    ///     Error Action Result used when the request is not successful.
    /// </summary>
    [DataContract]
    public class ErrorResult
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ErrorResult" /> class.
        /// </summary>
        /// <param name="error">Gets or sets error message..</param>
        public ErrorResult(string error = default)
        {
            this.Error = error;
            this.Error = error;
        }

        /// <summary>
        ///     Gets or sets error message.
        /// </summary>
        /// <value>Gets or sets error message.</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
