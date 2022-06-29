// <copyright file="AddAuthenticationAccessCodeDetails.cs" company="Syncfusion Inc">
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
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Runtime.Serialization;
    using BoldSign.Api.Resources;
    using Newtonsoft.Json;

    /// <summary>
    ///     The access code model.
    /// </summary>
    [DataContract]
    public class AddAuthenticationAccessCodeDetails
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AddAuthenticationAccessCodeDetails" /> class.
        /// </summary>
        /// <param name="emailId">Gets or sets the emailId.</param>
        /// <param name="order">Gets or sets the zOrder.</param>
        /// <param name="accessCode">Gets or sets the access code.</param>
        /// <param name="authenticationType">Gets or sets the authentication type.</param>
        public AddAuthenticationAccessCodeDetails(string emailId, int? order, string accessCode = "", AuthenticationType authenticationType = default)
        {
            // to ensure "accessCode" is required (not null) for AuthenticationType AccessCode.
            if (string.IsNullOrEmpty(accessCode) && authenticationType == AuthenticationType.AccessCode)
            {
                throw new InvalidDataException(ApiValidationMessages.AccessCodePropertyRequired);
            }

            // to ensure "accessCode" is not required for AuthenticationType EmailOTP.
            if (!string.IsNullOrEmpty(accessCode) && authenticationType == AuthenticationType.EmailOTP)
            {
                throw new InvalidDataException(ApiValidationMessages.AccessCodePropertyNoRequired);
            }

            this.EmailId = emailId;
            this.Order = order;
            this.AccessCode = accessCode;
            this.AuthenticationType = authenticationType;
        }

        /// <summary>
        /// Gets or sets the signer email.
        /// </summary>
        [Required]
        [DataMember(Name = "emailId", EmitDefaultValue = true)]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the ZOrder.
        /// </summary>
        [Range(1, 50)]
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public int? Order { get; set; }

        /// <summary>
        ///  Gets or sets the access code.
        /// </summary>
        /// <value>Gets the value of access code.</value>
        [DataMember(Name = "accessCode", EmitDefaultValue = true)]
        public string AccessCode { get; set; }

        /// <summary>
        /// Gets or sets the authenticationType.
        /// </summary>
        [Required]
        [DataMember(Name = "authenticationType", EmitDefaultValue = true)]
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}