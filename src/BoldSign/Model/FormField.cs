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
    using System.Runtime.Serialization;
    using System.Text;
    using System.Text.RegularExpressions;
    using BoldSign.Api.Model;
    using BoldSign.Api.Resources;
    using Newtonsoft.Json;

    /// <summary>
    ///     The form field properties include character limit, font, font size, and so on.
    /// </summary>
    [DataContract]
    public class FormField : IFormField
    {
        protected FieldType m_type;
        /// <summary>
        ///     Initializes a new instance of the <see cref="FormField" /> class.
        /// </summary>
        [JsonConstructor]
        protected FormField()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FormField" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="type">fieldType (required).</param>
        /// <param name="pageNumber">Gets or sets the page number. (required).</param>
        /// <param name="bounds">bounds (required).</param>
        /// <param name="isRequired">Gets or sets a value indicating whether is required..</param>
        /// <param name="value">Gets or sets the value..</param>
        /// <param name="dataSyncTag">Gets or sets the dataSyncTag.</param>
        [Obsolete("Name is deprecated, please use Id instead")]
        public FormField(string name = default, FieldType type = default, int pageNumber = default, Rectangle bounds = default, bool isRequired = default, string value = default, FontFamily font = FontFamily.Helvetica, int fontSize = default, string fontHexColor = default, bool isBoldFont = default, bool isItalicFont = default, bool isUnderLineFont = default, int lineHeight = default, int characterLimit = default, string dataSyncTag = default)
        {

            // to ensure "fieldType" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException(ApiValidationMessages.FieldTypeRequired);
            }

            this.m_type = type;

            // to ensure "pageNumber" is required (not null)
            if (pageNumber == null)
            {
                throw new InvalidDataException(ApiValidationMessages.PageNumberRquired);
            }

            this.PageNumber = pageNumber;

            // to ensure "bounds" is required (not null)
            if (bounds == null)
            {
                throw new InvalidDataException(ApiValidationMessages.BoundsRequired);
            }

            this.Bounds = bounds;

            this.Value = value;
            this.Name = name;
            this.IsRequired = isRequired;
            this.FontHexColor = fontHexColor;
            this.IsBoldFont = isBoldFont;
            this.IsItalicFont = isItalicFont;
            this.IsUnderLineFont = isUnderLineFont;
            this.LineHeight = lineHeight;
            this.CharacterLimit = characterLimit;
            this.Font = font;
            this.FontSize = fontSize;
            this.DataSyncTag = dataSyncTag;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FormField" /> class.
        /// </summary>
        /// <param name="type">fieldType (required).</param>
        /// <param name="pageNumber">Gets or sets the page number. (required).</param>
        /// <param name="bounds">bounds (required).</param>
        /// <param name="isRequired">Gets or sets a value indicating whether is required..</param>
        /// <param name="value">Gets or sets the value..</param>
        /// <param name="font">Gets or sets the font.</param>
        /// <param name="fontSize">Gets or sets the fontSize.</param>
        /// <param name="fontHexColor">Gets or sets the fontHexColor.</param>
        /// <param name="isBoldFont">Gets or sets the isBoldFont.</param>
        /// <param name="isItalicFont">Gets or sets the isItalicFont.</param>
        /// <param name="isUnderLineFont">Gets or sets the isUnderLineFont.</param>
        /// <param name="lineHeight">Gets or sets the lineHeight.</param>
        /// <param name="characterLimit">Gets or sets the characterLimit.</param>
        /// <param name="id">Gets or sets the id.</param>
        /// <param name="attachmentInfo">Gets or sets the attachmentInfo.</param>
        /// <param name="imageInfo">Gets or sets the imageInfo.</param>
        /// <param name="editableDateFieldSettings">Gets or sets the editableDateFieldSettings.</param>
        /// <param name="hyperlinkText">Gets or sets the hyperlinkText.</param>
        /// <param name="dataSyncTag">Gets or sets the dataSyncTag.</param>
        /// <param name="isReadOnly">Gets or sets a value indicating whether is read only mode.</param>
        /// <param name="conditionalRules">Gets or sets the conditionalRules.</param>
        /// <param name="textAlign">Gets or sets the textAlign.</param>
        /// <param name="textDirection">Gets or sets the direction of the text.</param>
        /// <param name="characterSpacing">Gets or sets the space of the character.</param>
        public FormField(FieldType type = default, int pageNumber = default, Rectangle bounds = default, bool isRequired = default, string value = default, FontFamily font = FontFamily.Helvetica, int fontSize = default, string fontHexColor = default, bool isBoldFont = default, bool isItalicFont = default, bool isUnderLineFont = default, int lineHeight = default, int characterLimit = default, string id = default, AttachmentInfo attachmentInfo = default(AttachmentInfo), ImageInfo imageInfo = default(ImageInfo), EditableDateFieldSettings editableDateFieldSettings = default(EditableDateFieldSettings), string hyperlinkText = default, string dataSyncTag = default, bool isReadOnly = default, List<ConditionalRule> conditionalRules = default, TextAlign textAlign = Api.Model.TextAlign.Left, TextDirection textDirection = TextDirection.LTR, float characterSpacing = default)
        {
            // to ensure "fieldType" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException(ApiValidationMessages.FieldTypeRequired);
            }

            this.m_type = type;

            // to ensure "pageNumber" is required (not null)
            if (pageNumber == null)
            {
                throw new InvalidDataException(ApiValidationMessages.PageNumberRquired);
            }

            this.PageNumber = pageNumber;

            // to ensure "bounds" is required (not null)
            if (bounds == null)
            {
                throw new InvalidDataException(ApiValidationMessages.BoundsRequired);
            }

            this.Bounds = bounds;
            this.Value = value;
            this.IsRequired = isRequired;
            this.FontHexColor = fontHexColor;
            this.IsBoldFont = isBoldFont;
            this.IsItalicFont = isItalicFont;
            this.IsUnderLineFont = isUnderLineFont;
            this.LineHeight = lineHeight;
            this.CharacterLimit = characterLimit;
            this.Font = font;
            this.FontSize = fontSize;
            this.Id = id;
            this.HyperlinkText = hyperlinkText;
            this.IsReadOnly = isReadOnly;
            this.DataSyncTag = dataSyncTag;
            this.ConditionalRules = conditionalRules;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.CharacterSpacing = characterSpacing;
            if (type == FieldType.Attachment && attachmentInfo == null)
            {
                throw new InvalidDataException(ApiValidationMessages.AttachmentInformationRequired);
            }

            this.AttachmentInfo = attachmentInfo;
            if (type == FieldType.Image && imageInfo == null)
            {
                throw new InvalidDataException(ApiValidationMessages.ImageInformationRequired);
            }

            this.ImageInfo = imageInfo;
            if (type == FieldType.EditableDate && editableDateFieldSettings == null)
            {
                throw new InvalidDataException(ApiValidationMessages.EditableDateInformationRequired);
            }

            this.EditableDateFieldSettings = editableDateFieldSettings;

            if (type == FieldType.Hyperlink)
            {
                if (string.IsNullOrEmpty(hyperlinkText) && string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataContractException(ApiValidationMessages.BothHyperlinkFieldsRequired);
                }

                if (string.IsNullOrEmpty(hyperlinkText) && !string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataContractException(ApiValidationMessages.HyperlinkLabelFieldsRequired);
                }

                if (!string.IsNullOrEmpty(hyperlinkText) && string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataContractException(ApiValidationMessages.HyperlinkValueFieldsRequired);
                }

                string regex = @"(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
                var isValid = Regex.IsMatch(value, regex);
                if (!isValid)
                {
                    throw new InvalidDataContractException(ApiValidationMessages.EnterValidURL);
                }
            }
        }

        /// <summary>
        ///     Gets the form field type.
        /// </summary>
        [DataMember(Name = "fieldType", EmitDefaultValue = true)]
        public virtual FieldType Type
        {
            get { return m_type; }
            set { m_type = value; }
        }

        /// <summary>
        ///     Gets or Sets id in form field.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets font name for the content in form field.
        /// </summary>
        [DataMember(Name = "font", EmitDefaultValue = true)]
        public FontFamily Font { get; set; }

        /// <summary>
        ///     Gets or sets the font color in hex code.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "fontHexColor", EmitDefaultValue = true)]
        public string FontHexColor { get; set; }

        /// <summary>
        ///     Gets or sets the form field name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [Obsolete("Name is deprecated, please use Id instead")]
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the page number.
        /// </summary>
        /// <value>Gets or sets the page number.</value>
        [DataMember(Name = "pageNumber", EmitDefaultValue = true)]
        public int PageNumber { get; set; }

        /// <summary>
        ///     Gets or sets the font size.
        /// </summary>
        /// <value>Gets or sets the page number.</value>
        [DataMember(Name = "fontSize", EmitDefaultValue = true)]
        public int FontSize { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the font style is bold.
        /// </summary>
        /// <value>Gets or sets a value indicating whether is required.</value>
        [DataMember(Name = "isBoldFont", EmitDefaultValue = false)]
        public bool IsBoldFont { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the font style is italic.
        /// </summary>
        /// </summary>
        /// <value>Gets or sets a value indicating whether is required.</value>
        [DataMember(Name = "isItalicFont", EmitDefaultValue = false)]
        public bool IsItalicFont { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the font style is underline.
        /// </summary>
        /// <value>Gets or sets a value indicating whether is required.</value>
        [DataMember(Name = "isUnderLineFont", EmitDefaultValue = false)]
        public bool IsUnderLineFont { get; set; }

        /// <summary>
        ///     Gets or Sets bounds of the form field.
        /// </summary>
        [DataMember(Name = "bounds", EmitDefaultValue = true)]
        public Rectangle Bounds { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the field is required.
        /// </summary>
        /// <value>Gets or sets a value indicating whether is required.</value>
        [DataMember(Name = "isRequired", EmitDefaultValue = false)]
        public bool IsRequired { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether is read only mode.
        /// </summary>
        /// <value>Gets or sets a value indicating wherther is read only mode.</value>
        [DataMember(Name = "isReadOnly", EmitDefaultValue = false)]
        public bool IsReadOnly { get; set; }

        /// <summary>
        ///     Gets or sets the Value to be set to the form field (if required).
        /// </summary>
        /// <value>Gets or sets the value.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        ///     Gets or sets the line height for the contents in form field.
        /// </summary>
        /// <value>Gets or sets the page number.</value>
        [DataMember(Name = "lineHeight", EmitDefaultValue = true)]
        public int LineHeight { get; set; }

        /// <summary>
        ///     Gets or sets the character limit.
        /// </summary>
        /// <value>Gets or sets the line height.</value>
        [DataMember(Name = "characterLimit", EmitDefaultValue = true)]
        public int CharacterLimit { get; set; }

        /// <summary>
        ///     Gets or sets the AttachmentInfo.
        /// </summary>
        /// <value>Gets or sets the Attachment Information.</value>
        [DataMember(Name = "AttachmentInfo", EmitDefaultValue = true)]
        public AttachmentInfo AttachmentInfo { get; set; }

        /// <summary>
        ///     Gets or sets the ImageInfo.
        /// </summary>
        /// <value>Gets or sets the Image Information.</value>
        [DataMember(Name = "ImageInfo", EmitDefaultValue = true)]
        public ImageInfo ImageInfo { get; set; }

        /// <summary>
        /// Gets or sets the EditableDateFieldSettings Information. .
        /// </summary>
        [DataMember(Name = "editableDateFieldSettings", EmitDefaultValue = false)]
        public EditableDateFieldSettings EditableDateFieldSettings { get; set; }

        /// <summary>
        /// Gets or sets the HyperlinkText to be set to the form field (if required).
        /// </summary>
        /// <value>Gets or sets the HyperlinkText.</value>
        [DataMember(Name = "hyperlinkText", EmitDefaultValue = true)]
        public string HyperlinkText { get; set; }

        /// <summary>
        /// Gets or sets the data sync tag value, this property helps to group the similar element types and it's only applicable for textbox, image, dropdown, checkbox fields, it won't affect the other fields.
        /// </summary>
        /// <value>Gets or sets the DataSyncTag.</value>
        [DataMember(Name = "dataSyncTag", EmitDefaultValue = true)]
        public string DataSyncTag { get; set; }

        /// <summary>
        /// Gets or sets the conditional rules value, this property helps to frame rules.
        /// </summary>
        [DataMember(Name = "conditionalRules", EmitDefaultValue = false)]
        public List<ConditionalRule> ConditionalRules { get; set; }

        /// <summary>
        /// Gets or sets the TextAlign to be set to the form field.
        /// </summary>
        /// <value>Gets or sets the TextAlign.</value>
        [DataMember(Name = "textAlign", EmitDefaultValue = true)]
        public TextAlign TextAlign { get; set; }

        /// <summary>
        /// Gets or sets the direction of the text.
        /// </summary>
        /// <value>Gets or sets the direction of the text.</value>
        [DataMember(Name = "textDirection", EmitDefaultValue = true)]
        public TextDirection TextDirection { get; set; }

        /// <summary>
        /// Gets or sets the space of the character.
        /// </summary>
        /// <value>Gets or sets the characterSpacing.</value>
        [DataMember(Name = "characterSpacing", EmitDefaultValue = true)]
        public float CharacterSpacing { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

        /// <summary>
        /// Gets or sets the background hex color.
        /// The BackgroundHexColor property allows you to set the background color of a label field using hexadecimal color codes ("#FF5733"). The default color is transparent or no background color.
        /// Default value is null.
        /// </summary>
        /// <value>Gets or sets the Backgroundcolor Value.</value>
        [DataMember(Name = "backgroundHexColor", EmitDefaultValue = true)]
        public string BackgroundHexColor { get; set; }

        /// <summary>
        /// Gets or sets the Tab Index.
        /// </summary>
        [DataMember(Name = "tabIndex", EmitDefaultValue = false)]
        [Range(-1, int.MaxValue, ErrorMessage = "The minimum value must be -1 or higher")]
        public int? TabIndex { get; set; }
    }
}
