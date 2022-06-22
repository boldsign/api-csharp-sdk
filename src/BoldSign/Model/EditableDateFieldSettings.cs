// <copyright file="EditableDateFieldSettings.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System;
    using System.IO;
    using System.Runtime.Serialization;
    using BoldSign.Api.Resources;
    using Newtonsoft.Json;

    /// <summary>
    /// EditableDateFieldSettings.
    /// </summary>
    [DataContract]
    public class EditableDateFieldSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditableDateFieldSettings" /> class.
        /// </summary>
        /// <param name="dateFormat">Gets or sets the dateFormat.</param>
        /// <param name="minDate">Gets or sets the minDate.</param>
        /// <param name="maxDate">Gets or sets the maxDate.</param>
        public EditableDateFieldSettings(string dateFormat = default, DateTime? minDate = default(DateTime?), DateTime? maxDate = default(DateTime?))
        {
            if (string.IsNullOrEmpty(dateFormat))
            {
                throw new InvalidDataContractException(ApiValidationMessages.EditableDateFormatRequired);
            }

            if ((minDate != null && maxDate == null) || (minDate == null && maxDate != null))
            {
                throw new InvalidDataException(ApiValidationMessages.BothFieldsRequired);
            }
            else if (minDate > maxDate)
            {
                throw new InvalidDataException(ApiValidationMessages.MaxDateValidation);
            }

            this.DateFormat = dateFormat;
            this.MinDate = minDate;
            this.MaxDate = maxDate;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="EditableDateFieldSettings" /> class.
        /// </summary>
        [JsonConstructor]
        protected EditableDateFieldSettings()
        {
        }

        /// <summary>
        /// Gets or sets the DateFormat and it's only applicable for DateSigned field and for  EditableDateFieldSettings field.
        /// Please use the pre-defiened DateFormat.
        /// <Example>Supported formats:
        /// MM/dd/yyyy, dd/MM/yyyy, dd-MMM-yyyy, MMM-dd-yyyy, MMM dd,yyyy, dd MMM,yyyy, yyyy,MMM dd, yyyy/MM/dd, dd-MM-yyyy, MM-dd-yyyy, yyyy-MM-dd.
        /// </Example>
        /// <value>The default value is date format specified in the business profile.</value>
        /// </summary>
        [DataMember(Name = "dateFormat", EmitDefaultValue = false)]
        public string DateFormat { get; set; }

        /// <summary>
        /// Gets or sets the MinDate and it's only applicable for EditableDateFieldSettings.
        /// </summary>
        /// <value>Gets the value of EditableDateFieldSettings.</value>
        [DataMember(Name = "minDate", EmitDefaultValue = false)]
        public DateTime? MinDate { get; set; }

        /// <summary>
        /// Gets or sets the MaxDate and it's only applicable for EditableDateFieldSettings.
        /// </summary>
        /// <value>Gets the value of EditableDateFieldSettings.</value>
        [DataMember(Name = "maxDate", EmitDefaultValue = false)]
        public DateTime? MaxDate { get; set; }
    }
}
