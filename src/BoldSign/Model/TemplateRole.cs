// <copyright file="TemplateRole.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using BoldSign.Api.Resources;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    ///    Template role  DTO.
    /// </summary>
    [DataContract]
    public class TemplateRole
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRole" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name. (required).</param>
        /// <param name="index">Gets or sets the role index. (required).</param>
        /// <param name="defaultSignerName">Gets or sets the role signer name. (required).</param>
        /// <param name="defaultSignerEmail">Gets or sets the  role signer email address. (required).</param>
        /// <param name="signerOrder">Gets or sets the signer order..</param>
        /// <param name="signerType">signerType.</param>
        /// <param name="formFields">Gets or sets the formFields..</param>
        /// <param name="hostEmail">Gets or sets the hostEmail.</param>
        /// <param name="language">Gets or sets the Language.</param>
        /// <param name="imposeAuthentication">Gets or sets the authentication type of template.</param>
        /// <param name="allowRoleDelete">Gets or sets the allow permission to role delete option  of template.</param>
        /// <param name="allowRoleEdit">Gets or sets the allow permission to role edit option  of template.</param>
        [Obsolete("The language-based constructor is deprecated. Please use the new constructor: TemplateRole( int roleIndex, string name, string defaultSignerName = default, string defaultSignerEmail = default, int signerOrder = default, SignerType signerType = SignerType.Signer, List<FormField> formFields = default, string hostEmail = default, ImposeAuthentication imposeAuthentication = ImposeAuthentication.None, bool allowRoleEdit = true, bool allowRoleDelete = true, Locales locale = Locales.EN)")]
        public TemplateRole(
            string name,
            int index,
            string defaultSignerName = default,
            string defaultSignerEmail = default,
            int signerOrder = default,
            SignerType signerType = SignerType.Signer,
            List<FormField> formFields = default,
            string hostEmail = default,
            Languages language = Languages.None,
            ImposeAuthentication imposeAuthentication = ImposeAuthentication.None,
            bool allowRoleEdit = true,
            bool allowRoleDelete = true)
        {
            // to ensure "name" is required (not null)
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidDataException(ApiValidationMessages.RoleName);
            }

            this.Name = name;
            this.Index = index;
            this.DefaultSignerName = defaultSignerName;

            this.DefaultSignerEmail = defaultSignerEmail;

            this.SignerOrder = signerOrder;
            this.SignerType = signerType;

            this.FormFields = formFields;
            this.HostEmail = hostEmail;
            this.Language = language;
            this.ImposeAuthentication = imposeAuthentication;
            this.AllowRoleDelete = allowRoleDelete;
            this.AllowRoleEdit = allowRoleEdit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRole" /> class.
        /// </summary>
        /// <param name="roleIndex">Gets or sets the role index. (required).</param>
        /// <param name="name">Gets or sets the name. (required).</param>
        /// <param name="defaultSignerName">Gets or sets the role signer name.</param>
        /// <param name="defaultSignerEmail">Gets or sets the  role signer email address.</param>
        /// <param name="signerOrder">Gets or sets the signer order.</param>
        /// <param name="signerType">signerType.</param>
        /// <param name="formFields">Gets or sets the formFields.</param>
        /// <param name="hostEmail">Gets or sets the hostEmail.</param>
        /// <param name="imposeAuthentication">Gets or sets the authentication type of template.</param>
        /// <param name="allowRoleDelete">Gets or sets the allow permission to role delete option  of template.</param>
        /// <param name="allowRoleEdit">Gets or sets the allow permission to role edit option  of template.</param>
        /// <param name="locale">Gets or sets the locale.</param>
        public TemplateRole(
            int roleIndex,
            string name,
            string defaultSignerName = default,
            string defaultSignerEmail = default,
            int signerOrder = default,
            SignerType signerType = SignerType.Signer,
            List<FormField> formFields = default,
            string hostEmail = default,
            ImposeAuthentication imposeAuthentication = ImposeAuthentication.None,
            bool allowRoleEdit = true,
            bool allowRoleDelete = true,
            Locales locale = Locales.EN)
        {
            // to ensure "name" is required (not null)
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidDataException(ApiValidationMessages.RoleName);
            }

            this.Index = roleIndex;
            this.Name = name;
            this.DefaultSignerName = defaultSignerName;
            this.DefaultSignerEmail = defaultSignerEmail;
            this.SignerOrder = signerOrder;
            this.SignerType = signerType;
            this.FormFields = formFields;
            this.HostEmail = hostEmail;
            this.ImposeAuthentication = imposeAuthentication;
            this.AllowRoleDelete = allowRoleDelete;
            this.AllowRoleEdit = allowRoleEdit;
            this.Locale = locale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRole" /> class.
        /// </summary>
        public TemplateRole()
        {

        }


        /// <summary>
        /// Gets or sets the role Name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Index value.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the Default Signer Name.
        /// </summary>
        [DataMember(Name = "defaultSignerName", EmitDefaultValue = false)]
        public string DefaultSignerName { get; set; }

        /// <summary>
        /// Gets or sets the Default signer Email.
        /// </summary>
        [DataMember(Name = "defaultSignerEmail", EmitDefaultValue = false)]
        public string DefaultSignerEmail { get; set; }

        /// <summary>
        /// Gets or sets the signer order value.
        /// </summary>
        [DataMember(Name = "signerOrder", EmitDefaultValue = false)]
        public int SignerOrder { get; set; }

        /// <summary>
        /// <para>Gets or sets the signer type.</para>
        /// <para>Defaults to Signer.</para>
        /// </summary>
        [DataMember(Name = "signerType", EmitDefaultValue = false)]
        public SignerType SignerType { get; set; }

        /// <summary>
        /// Gets or sets the default Host Email.
        /// </summary>
        [DataMember(Name = "hostEmail", EmitDefaultValue = false)]
        public string HostEmail { get; set; }

        /// <summary>
        /// Gets or sets Languages such as English, French, Spanish, German.
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        [Obsolete("language is deprecated, please use locale instead")]
        public Languages Language { get; set; }

        /// <summary>
        /// Gets or sets locale such as EN, FR, ES.
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = true)]
        public Locales Locale { get; set; }

        /// <summary>
        /// Gets or sets the Authentication Type such as None ,Access Code, EmailOTP.
        /// </summary>
        [DataMember(Name = "imposeAuthentication", EmitDefaultValue = true)]
        public ImposeAuthentication ImposeAuthentication { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the allow configure fields.
        /// </summary>
        [DataMember(Name = "allowFieldConfiguration", EmitDefaultValue = false)]
        public bool AllowFieldConfiguration { get; set; }

        /// <summary>
        /// Gets or sets document Form fields such as Sign, Checkbox, Radio buttons etc.
        /// </summary>
        [DataMember(Name = "formFields", EmitDefaultValue = true)]
        public IEnumerable<FormField> FormFields { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the allow role edit option is enabled or disabled.
        /// </summary>
        [DataMember(Name = "allowRoleEdit", EmitDefaultValue = true)]
        public bool AllowRoleEdit { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether  the enable  allow role delete option is enabled or disabled.
        /// </summary>
        [DataMember(Name = "allowRoleDelete", EmitDefaultValue = true)]
        public bool AllowRoleDelete { get; set; } = true;

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public PhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets the delivery mode of the signer.
        /// </summary>
        [DataMember(Name = "deliveryMode", EmitDefaultValue = true)]
        public DeliveryMode DeliveryMode { get; set; } = DeliveryMode.Email;

        /// <summary>
        /// Gets or sets the Recipient Notification Settings.
        /// </summary>
        [DataMember(Name = "recipientNotificationSettings", EmitDefaultValue = false)]
        public RecipientNotificationSettings RecipientNotificationSettings { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable qualified electronic signature the document signer.
        /// </summary>
        [DataMember(Name = "enableQes", EmitDefaultValue = false)]
        public bool? EnableQes { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
