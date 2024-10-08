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
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///    The signer properties include the authentication code for the singer, email address, name, role, and so on.
    /// </summary>
    [DataContract]
    public class DocumentSigner
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DocumentSigner" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name. (required).</param>
        /// <param name="emailAddress">Gets or sets the email address. (required).</param>
        /// <param name="privateMessage">Gets or sets the private message..</param>
        /// <param name="authenticationCode">Gets or sets the authentication code..</param>
        /// <param name="signerOrder">Gets or sets the signer order..</param>
        /// <param name="enableEmailOTP">Gets or sets a value indicating whether to enable email OTP..</param>
        /// <param name="signerType">signerType.</param>
        /// <param name="signerRole">Gets or sets the signer role..</param>
        /// <param name="formFields">Gets or sets the formFields..</param>
        /// <param name="hostEmail">Gets or sets the hostEmail.</param>
        /// <param name="language">Gets or sets the Language.</param>
        /// <param name="authenticationType">Gets or sets the authentication type.</param>
        /// <param name="phoneNumber">Gets or sets the phone number.</param>
        [Obsolete("The language-based constructor is deprecated. Please use the new constructor: DocumentSigner(string signerName, SignerType signerType = BoldSign.Model.SignerType.Signer, string signerEmail = default, string privateMessage = default, string authenticationCode = default, int signerOrder = default, bool enableEmailOTP = default, List<FormField> formFields = default(List<FormField>), string hostEmail = default, Locales locale = Locales.EN)")]
        public DocumentSigner(string name, string emailAddress, string privateMessage = default, string authenticationCode = default, int signerOrder = default, bool enableEmailOTP = default, SignerType signerType = BoldSign.Model.SignerType.Signer, List<FormField> formFields = default(List<FormField>), string hostEmail = default, Languages language = Languages.None, AuthenticationType authenticationType = AuthenticationType.None, PhoneNumber phoneNumber = default)
        {
            // to ensure "name" is required (not null)
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidDataException("name is a required property for DocumentSigner and cannot be null");
            }

            this.Name = name;

            // to ensure "emailAddress" is required (not null)
            if (string.IsNullOrEmpty(emailAddress))
            {
                throw new InvalidDataException("emailAddress is a required property for DocumentSigner and cannot be null");
            }

            this.EmailAddress = emailAddress;

            this.PrivateMessage = privateMessage;
            this.AuthenticationCode = authenticationCode;
            this.SignerOrder = signerOrder;
            this.EnableEmailOTP = enableEmailOTP;
            this.SignerType = signerType;
            this.FormFields = formFields;
            this.HostEmail = hostEmail;
            this.Language = language;
            this.AuthenticationType = authenticationType;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSigner" /> class.
        /// </summary>
        /// <param name="signerName">Gets or sets the signer Name. (required).</param>
        /// <param name="signerType">signerType.</param>
        /// <param name="signerEmail">Gets or sets the signer Email.</param>
        /// <param name="privateMessage">Gets or sets the private message.</param>
        /// <param name="authenticationCode">Gets or sets the authentication code.</param>
        /// <param name="signerOrder">Gets or sets the signer order.</param>
        /// <param name="enableEmailOTP">Gets or sets a value indicating whether to enable email OTP.</param>
        /// <param name="formFields">Gets or sets the formFields.</param>
        /// <param name="hostEmail">Gets or sets the hostEmail.</param>
        /// <param name="locale">Gets or sets the locale.</param>
        /// <param name="authenticationType">Gets or sets the authentication type.</param>
        /// <param name="phoneNumber">Gets or sets the phone number.</param>
        public DocumentSigner(string signerName, SignerType signerType = BoldSign.Model.SignerType.Signer, string signerEmail = default, string privateMessage = default, string authenticationCode = default, int signerOrder = default, bool enableEmailOTP = default, List<FormField> formFields = default(List<FormField>), string hostEmail = default, Locales locale = Locales.EN,  AuthenticationType authenticationType = AuthenticationType.None, PhoneNumber phoneNumber = default)
        {
            // to ensure "name" is required (not null)
            if (string.IsNullOrEmpty(signerName))
            {
                throw new InvalidDataException("signerName is a required property for DocumentSigner and cannot be null");
            }

            this.Name = signerName;
            this.SignerType = signerType;
            this.EmailAddress = signerEmail;
            this.PrivateMessage = privateMessage;
            this.AuthenticationCode = authenticationCode;
            this.SignerOrder = signerOrder;
            this.EnableEmailOTP = enableEmailOTP;
            this.FormFields = formFields;
            this.HostEmail = hostEmail;
            this.Locale = locale;
            this.AuthenticationType = authenticationType;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSigner" /> class.
        /// </summary>
        public DocumentSigner()
        {

        }

        /// <summary>
        ///  Gets or sets the type of signer.
        /// </summary>
        [DataMember(Name = "signerType", EmitDefaultValue = false)]
        public SignerType? SignerType { get; set; }

        /// <summary>
        ///     Gets or sets the Host email address of the Host.
        /// </summary>
        /// <value>Gets or sets the Host email address.</value>
        [DataMember(Name = "hostemail", EmitDefaultValue = false)]
        public string HostEmail { get; set; }

        /// <summary>
        ///  Gets or sets the signer name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the email address of the signer.
        /// </summary>
        /// <value>Gets or sets the email address.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        ///     Gets or sets the private message.
        /// </summary>
        /// <value>Gets or sets the private message.</value>
        [DataMember(Name = "privateMessage", EmitDefaultValue = true)]
        public string PrivateMessage { get; set; }

        /// <summary>
        ///     Gets or sets the authentication code.
        /// </summary>
        /// <value>Gets or sets the authentication code.</value>
        [DataMember(Name = "authenticationCode", EmitDefaultValue = true)]
        public string AuthenticationCode { get; set; }

        /// <summary>
        ///     Gets or sets the order in which the signers needs to sign the document.
        /// </summary>
        /// <value>Gets or sets the signer order.</value>
        [DataMember(Name = "signerOrder", EmitDefaultValue = false)]
        public int SignerOrder { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether to enable email OTP for signing.
        /// </summary>
        /// <value>Gets or sets a value indicating whether to enable email OTP.</value>
        [DataMember(Name = "enableEmailOTP", EmitDefaultValue = false)]
        public bool EnableEmailOTP { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the allow field configuration.
        /// </summary>
        [DataMember(Name = "allowFieldConfiguration", EmitDefaultValue = false)]
        public bool AllowFieldConfiguration { get; set; }

        /// <summary>
        /// Gets or sets form fields assigned to signer.
        /// </summary>
        /// <value>Gets or sets document Form fields such as Sign, Checkbox, Radio buttons etc.</value>
        [DataMember(Name = "formFields", EmitDefaultValue = false)]
        public List<FormField> FormFields { get; set; }

        /// <summary>
        /// Gets or sets the signer language.
        /// </summary>
        /// <value>Gets or sets the language of the signer.</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        [Obsolete("Language is deprecated, please use Locale instead.")]
        public Languages Language { get; set; }

        /// <summary>
        /// Gets or sets  signer locale.
        /// <value>Gets or sets the locale of the signer.</value>
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public Locales Locale { get; set; }

        /// <summary>
        /// Gets or Sets the delivery mode of the signer.
        /// </summary>
        [DataMember(Name = "deliveryMode", EmitDefaultValue = true)]
        public DeliveryMode DeliveryMode { get; set; } = DeliveryMode.Email;

        /// <summary>
        /// Gets or sets the authentication type.
        /// Defaults to None.
        /// </summary>
        [DataMember(Name = "authenticationType", EmitDefaultValue = true)]
        public AuthenticationType AuthenticationType { get; set; } = AuthenticationType.None;

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public PhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the Recipient Notification Settings.
        /// </summary>
        /// <value>Gets or sets the Recipient Notification Settings of the signer.</value>
        [DataMember(Name = "recipientNotificationSettings", EmitDefaultValue = false)]
        public RecipientNotificationSettings RecipientNotificationSettings { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
