// <copyright file="ChangeRecipient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Text;
    using BoldSign.Api.Resources;
    using Newtonsoft.Json;

    /// <summary>
    ///     The recipient  details  model.
    /// </summary>
    [DataContract]
    public class ChangeRecipient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeRecipient"/> class.
        /// </summary>
        /// <param name="newSignerName">The signer name .</param>
        /// <param name="reason"> reason for the name change .</param>
        /// <param name="oldSignerEmail">Gets or sets the signer email.</param>
        /// <param name="newSignerEmail">gets or sets the new mail id of recipient .</param>
        /// <param name="signerOrder">
        ///     Gets or sets the signer&#39;s order.  When signer order is enabled for a document, this order is
        ///     used to target that particular order with given signer email. (optional).
        /// </param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        public ChangeRecipient(string newSignerName, string reason, string oldSignerEmail, string newSignerEmail, int? signerOrder = default, string onBehalfOf = default)
        {
            // to ensure "signer name" is required (not null)
            if (string.IsNullOrEmpty(newSignerName))
            {
                throw new InvalidDataException(ApiValidationMessages.SignerNameRequired);
            }

            this.NewSignerName = newSignerName;

            // to ensure "reason" is required (not null)
            if (string.IsNullOrEmpty(reason))
            {
                throw new InvalidDataException(ApiValidationMessages.ReasonRequired);
            }

            this.Reason = reason;

            // to ensure "oldsignermail" is required (not null)
            if (string.IsNullOrEmpty(oldSignerEmail))
            {
                throw new InvalidDataException(ApiValidationMessages.OldSignerEmailRequired);
            }

            this.OldSignerEmail = oldSignerEmail;

            // to ensure "newmailid" is required (not null)
            if (string.IsNullOrEmpty(newSignerEmail))
            {
                throw new InvalidDataException(ApiValidationMessages.NewSignerEmailAddressRequired);
            }

            this.NewSignerEmail = newSignerEmail;

            // to ensure "oldSignermail"and "newSignermail" are not as same
            if (oldSignerEmail.ToUpperInvariant() == newSignerEmail.ToUpperInvariant())
            {
                throw new InvalidDataException(ApiValidationMessages.SameSignerEmailNotAllowed);
            }

            // to ensure "signerorder" is not null and positive )
            if (signerOrder != null && signerOrder <= 0)
            {
                throw new InvalidDataException(ApiValidationMessages.SignerOrderPositiveValue);
            }

            this.Order = signerOrder;
            this.OnBehalfOf = onBehalfOf;
        }

        /// <summary>
        ///  Gets or sets the from name .
        /// </summary>
        /// <value>Gets the value of fromname.</value>
        [Required]
        [DataMember(Name = "newSignerName", EmitDefaultValue = true)]
        public string NewSignerName { get; set; }

        /// <summary>
        ///  Gets or sets the reason .
        /// </summary>
        /// <value>Gets the value of reason .</value>
        [Required]
        [DataMember(Name = "reason", EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        ///  Gets or sets the oldsignermail .
        /// </summary>
        /// <value>Gets the value of reason .</value>
        [Required]
        [DataMember(Name = "oldSignerEmail", EmitDefaultValue = true)]
        public string OldSignerEmail { get; set; }

        /// <summary>
        ///  Gets or sets the newmail id .
        /// </summary>
        /// <value>Gets the value of reason .</value>
        [Required]
        [DataMember(Name = "newSignerEmail", EmitDefaultValue = true)]
        public string NewSignerEmail { get; set; }

        /// <summary>
        ///  Gets or sets the from name .
        /// </summary>
        /// <value>Gets the value of signer Order .</value>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or sets the on behalf of email.
        /// </summary>
        [DataMember(Name = "onBehalfOf", EmitDefaultValue = true)]
        public string OnBehalfOf { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
