/* 
 * BoldSign API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace BoldSign.Model.Webhook
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
    /// The document signer.
    /// </summary>
    [DataContract]
    public class SignerDetails
    {
        /// <summary>
        /// Gets or sets the signer name.
        /// </summary>
        /// <value>Gets or sets the signer name.</value>
        [DataMember(Name = "signerName", EmitDefaultValue = false)]
        public string SignerName { get; set; }

        /// <summary>
        /// Gets or sets the signer role.
        /// </summary>
        /// <value>Gets or sets the signer role.</value>
        [DataMember(Name = "signerRole", EmitDefaultValue = false)]
        public string SignerRole { get; set; }

        /// <summary>
        /// Gets or sets the signer email.
        /// </summary>
        /// <value>Gets or sets the signer email.</value>
        [DataMember(Name = "signerEmail", EmitDefaultValue = false)]
        public string SignerEmail { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public SignerStatus Status { get; set; }

        /// <summary>
        /// Gets a value indicating whether authentication is enabled for the signer.
        /// </summary>
        /// <value>Gets a value indicating whether authentication is enabled for the signer.</value>
        [DataMember(Name = "enableAccessCode", EmitDefaultValue = false)]
        public bool? EnableAccessCode { get; private set; }

        /// <summary>
        /// &lt;br&gt;Gets or sets a value indicating whether authentication is failed.  &lt;br&gt;When value is null, Authentication is not enabled for the signer.  &lt;br&gt;When value is true, Authentication is failed by the signer.  &lt;br&gt;When value is false, Authentication is enabled for the signer.
        /// </summary>
        /// <value>&lt;br&gt;Gets or sets a value indicating whether authentication is failed.  &lt;br&gt;When value is null, Authentication is not enabled for the signer.  &lt;br&gt;When value is true, Authentication is failed by the signer.  &lt;br&gt;When value is false, Authentication is enabled for the signer.</value>
        [DataMember(Name = "isAuthenticationFailed", EmitDefaultValue = false)]
        public bool? IsAuthenticationFailed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether email OTP authentication is enabled.
        /// </summary>
        /// <value>Gets or sets a value indicating whether email OTP authentication is enabled.</value>
        [DataMember(Name = "enableEmailOTP", EmitDefaultValue = false)]
        public bool? EnableEmailOTP { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether delivery is failed.
        /// </summary>
        /// <value>Gets or sets a value indicating whether delivery is failed.</value>
        [DataMember(Name = "isDeliveryFailed", EmitDefaultValue = false)]
        public bool? IsDeliveryFailed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is viewed.
        /// </summary>
        /// <value>Gets or sets a value indicating whether is viewed.</value>
        [DataMember(Name = "isViewed", EmitDefaultValue = false)]
        public bool? IsViewed { get; set; }

        /// <summary>
        /// Gets or sets the order of the signer.
        /// </summary>
        /// <value>Gets or sets the order of the signer.</value>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or sets the signer type.
        /// </summary>
        /// <value>Gets or sets the signer type.</value>
        [DataMember(Name = "signerType", EmitDefaultValue = false)]
        public string SignerType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is reassigned.
        /// </summary>
        /// <value>Gets or sets a value indicating whether is reassigned.</value>
        [DataMember(Name = "isReassigned", EmitDefaultValue = false)]
        public bool? IsReassigned { get; set; }

        /// <summary>
        /// Gets or sets the reassign message.
        /// </summary>
        /// <value>Gets or sets the reassign message.</value>
        [DataMember(Name = "reassignMessage", EmitDefaultValue = false)]
        public string ReassignMessage { get; set; }

        /// <summary>
        /// &lt;br&gt;Gets or sets document declined message by the signer.
        /// </summary>
        /// <value>&lt;br&gt;Gets or sets document declined message by the signer.</value>
        [DataMember(Name = "declineMessage", EmitDefaultValue = false)]
        public string DeclineMessage { get; set; }
    }
}
