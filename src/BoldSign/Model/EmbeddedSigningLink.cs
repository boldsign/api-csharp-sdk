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
    ///     Contains Embedded Signing Link for a document signer.
    /// </summary>
    [DataContract]
    public class EmbeddedSigningLink
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmbeddedSigningLink" /> class.
        /// </summary>
        /// <param name="signLink">Gets or sets sign link for the signer..</param>
        public EmbeddedSigningLink(string signLink = default)
        {
            this.SignLink = signLink;
            this.SignLink = signLink;
        }

        /// <summary>
        ///     Gets or sets embedded sign link for the signer.
        /// </summary>
        /// <value>Gets or sets sign link for the signer.</value>
        [DataMember(Name = "signLink", EmitDefaultValue = true)]
        public string SignLink { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

    }
}
