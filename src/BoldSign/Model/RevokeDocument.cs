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
    ///     The turn down document action DTO such as Revoke or Decline the document.
    /// </summary>
    [DataContract]
    public class RevokeDocument
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RevokeDocument" /> class.
        /// </summary>
        [JsonConstructor]
        protected RevokeDocument()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RevokeDocument" /> class.
        /// </summary>
        /// <param name="message">Gets or sets the message. (required).</param>
        public RevokeDocument(string message = default)
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for RevokeDocument and cannot be null");
            }

            this.Message = message;
        }

        /// <summary>
        /// Gets or sets the revoke message.
        /// </summary>
        /// <value>Gets or sets the message.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}