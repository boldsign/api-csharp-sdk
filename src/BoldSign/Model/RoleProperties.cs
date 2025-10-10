// <copyright file="RoleProperties.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    /// Role properties.
    /// </summary>
    [DataContract]
    public class RoleProperties
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleProperties"/> class.
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
        /// <param name="enableAccessCode">Gets or sets indicating whether enable access code recipients.</param>
        /// <param name="enableEmailOTP">Gets or sets a value indicating whether enable email otp recipients..</param>
        /// <param name="imposeAuthentication">Gets or sets the authentication type of template.</param>
        /// <param name="allowRoleDelete">Gets or sets the allow permission to role delete option  of template.</param>
        /// <param name="allowRoleEdit">Gets or sets the allow permission to role edit option  of template.</param>
        /// <param name="locale">Gets or sets the locale.</param>
        /// <param name="enableQes">Gets or sets the allow permission to enableQes.</param>
        public RoleProperties(
    string name,
    int index,
    string defaultSignerName = default,
    string defaultSignerEmail = default,
    int signerOrder = default,
    SignerType signerType = SignerType.Signer,
    List<TemplateFormField> formFields = default,
    string hostEmail = default,
    Languages language = Languages.English,
    bool enableAccessCode = default,
    bool enableEmailOTP = default,
    ImposeAuthentication imposeAuthentication = ImposeAuthentication.None,
    bool allowRoleEdit = true,
    bool allowRoleDelete = true,
    Locales locale = Locales.EN,
    bool enableQes = default)
        {
            this.Name = name;
            this.Index = index;
            this.DefaultSignerName = defaultSignerName;

            this.DefaultSignerEmail = defaultSignerEmail;

            this.SignerOrder = signerOrder;
            this.SignerType = signerType;

            this.FormFields = formFields;
            this.HostEmail = hostEmail;
            this.Language = language;
            this.EnableAccessCode = enableAccessCode;
            this.EnableEmailOTP = enableEmailOTP;
            this.ImposeAuthentication = imposeAuthentication;
            this.AllowRoleDelete = allowRoleDelete;
            this.AllowRoleEdit = allowRoleEdit;
            this.Locale = locale;
            this.EnableQes = enableQes;
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
        /// Gets or sets the phone number.
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public PhoneNumber PhoneNumber { get; set; }

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
        /// Gets or sets a value indicating whether enable access code recipients.
        /// </summary>
        [DataMember(Name = "enableAccessCode", EmitDefaultValue = true)]
        public bool EnableAccessCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether enable email otp recipients.
        /// </summary>
        [DataMember(Name = "enableEmailOTP", EmitDefaultValue = true)]
        public bool EnableEmailOTP { get; set; }

        /// <summary>
        /// Gets or sets the Authentication Type such as None ,Access Code, EmailOTP.
        /// </summary>
        [DataMember(Name = "imposeAuthentication", EmitDefaultValue = true)]
        public ImposeAuthentication ImposeAuthentication { get; set; }

        /// <summary>
        /// Gets or Sets a delivery mode.
        /// </summary>
        /// <value>Gets or sets the delivery mode.</value>
        [DataMember(Name = "deliveryMode", EmitDefaultValue = true)]
        public DeliveryMode DeliveryMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the allow configure fields.
        /// </summary>
        [DataMember(Name = "allowFieldConfiguration", EmitDefaultValue = false)]
        public bool AllowFieldConfiguration { get; set; }

        /// <summary>
        /// Gets or sets document Form fields such as Sign, Checkbox, Radio buttons etc.
        /// </summary>
        [DataMember(Name = "formFields", EmitDefaultValue = true)]
        public IEnumerable<TemplateFormField> FormFields { get; set; }

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
        /// Gets or sets a value indicating whether the fields can be configured.
        /// </summary>
        [DataMember(Name = "enableQes", EmitDefaultValue = true)]
        public bool EnableQes { get; set; }

        /// <summary>
        /// Gets or sets the Recipient Notification Settings.
        /// </summary>
        /// <value>Gets or sets the Recipient Notification Settings of the signer.</value>
        [DataMember(Name = "recipientNotificationSettings", EmitDefaultValue = false)]
        public RecipientNotificationSettings RecipientNotificationSettings { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
