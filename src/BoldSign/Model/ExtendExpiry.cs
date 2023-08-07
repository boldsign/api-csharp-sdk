// <copyright file="ExtendExpiry.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Runtime.Serialization;
    using BoldSign.Api.Resources;
    using Newtonsoft.Json;

    /// <summary>
    /// The Extend Expiry Model.
    /// </summary>
    [DataContract]
    public class ExtendExpiry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendExpiry" /> class.
        /// </summary>
        /// <param name="newExpiryValue">
        /// The new expiry date should be specified in yyyy-MM-dd format, and the document will always be set to expire at midnight on the specified date.
        /// </param>
        /// <param name="warnPrior">
        /// If null, the existing configuration will be used.
        /// If true, one day before the expiration date, a warning email will be sent.
        /// If false, a warning email will not be sent one day before the expiration date.
        /// </param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of email.</param>
        public ExtendExpiry(string newExpiryValue, bool? warnPrior, string onBehalfOf = default)
        {
            this.NewExpiryValue = newExpiryValue;
            this.WarnPrior = warnPrior;
            this.OnBehalfOf = onBehalfOf;
        }

        /// <summary>
        /// Gets or sets the new expiry date.
        /// The new expiry date should be specified in yyyy-MM-dd format, and the document will always be set to expire at midnight on the specified date.
        /// </summary>
        [DataMember(Name = "newExpiryValue", EmitDefaultValue = true)]
        [Required]
        public string NewExpiryValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to send warning one day prior to the expiry date.
        /// If null, the existing configuration will be used.
        /// If true, one day before the expiration date, a warning email will be sent.
        /// If false, a warning email will not be sent one day before the expiration date.
        /// </summary>
        [DataMember(Name = "warnPrior", EmitDefaultValue = true)]
        public bool? WarnPrior { get; set; }

        /// <summary>
        /// Gets or sets the on behalf ofemail.
        /// </summary>
        [DataMember(Name = "onBehalfOf", EmitDefaultValue = true)]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
