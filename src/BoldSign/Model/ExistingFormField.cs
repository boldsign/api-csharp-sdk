/* 
 * BoldSign API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace BoldSign.Model
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Existing Form Fields details.
    /// </summary>
    [DataContract]
    public class ExistingFormField
    {
        public ExistingFormField()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExistingFormField" /> class.
        /// </summary>
        /// <param name="index">Gets or sets the signer order..</param>
        /// <param name="value">Gets or sets the signer role..</param>
        /// <param name="isReadOnly">Gets or sets a value indicating whether is read only mode.</param>
        public ExistingFormField(int index = default, string value = default, bool isReadOnly = default)
        {
            this.Index = index;
            this.Value = value;
            this.IsReadOnly = isReadOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExistingFormField"/> class.
        /// </summary>
        /// <param name="id">Gets oe sets the id.</param>
        /// <param name="value">Gets or sets the signer role.</param>
        /// <param name="isReadOnly">Gets or sets a value indicating whether is read only mode.</param>
        public ExistingFormField(string id = default, string value = default, bool isReadOnly = default)
        {
            this.Id = id;
            this.Value = value;
            this.IsReadOnly = isReadOnly;
        }

        /// <summary>
        /// Gets or sets the signer order.
        /// </summary>
        /// <value>Gets or sets the signer order.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [Obsolete("Name is deprecated, please use Id instead")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>Gets the value of id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the signer role.
        /// </summary>
        /// <value>Gets or sets the signer role.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsReadOnly.
        /// </summary>
        [DataMember(Name = "isReadOnly", EmitDefaultValue = true)]
        public bool IsReadOnly { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
