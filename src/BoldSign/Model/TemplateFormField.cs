// <copyright file="TemplateFormField.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using BoldSign.Api.Resources;
    using BoldSign.Model;

    /// <summary>
    /// The template form field properties.
    /// </summary>
    [DataContract]
    public class TemplateFormField
    {
        /// <summary>
        ///     FieldType type.
        /// </summary>
#pragma warning disable CA1051 // Do not declare visible instance fields
        protected FieldType mType;
#pragma warning restore CA1051 // Do not declare visible instance fields
        /// <summary>
        ///     Initializes a new instance of the <see cref="TemplateFormField"/> class.
        /// </summary>
        /// <param name="fieldType">fieldType.</param>
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
        /// <param name="groupName">Gets or sets the groupName.</param>
        /// <param name="id">Gets or sets the id.</param>
        /// <param name="dropdownOptions">dropdownOptions.</param>
        /// <param name="placeholder">placeHolder.</param>
        /// <param name="attachmentInfo">Gets or sets the attachmentInfo.</param>
        /// <param name="imageInfo">Gets or sets the imageInfo.</param>
        /// <param name="editableDateFieldSettings">Gets or sets the editableDateFieldSettings.</param>
        /// <param name="dateFormat">Gets or sets the dateFormat..</param>>
        /// <param name="validationType">Gets or sets the validationType..</param>
        /// <param name="validationCustomRegex">Gets or sets the validationCustomRegex..</param>>
        /// <param name="validationCustomRegexMessage">Gets or sets the validationCustomRegexMessage..</param>>
        /// <param name="dataSyncTag">Gets or sets the dataSyncTag.</param>
        /// <param name="isReadOnly">Gets or sets a value indicating whether is read only mode.</param>
        /// <param name="conditionalRules">Gets or sets the conditionalRules.</param>
        /// <param name="textAlign">Gets or sets the textAlign.</param>
        /// <param name="textDirection">Gets or sets the direction of the text.</param>
        /// <param name="characterSpacing">Gets or sets the space of the character.</param>
        /// <param name="type">Gets or sets the fieldType.</param>
        /// <param name="hyperlinkText">Gets or sets the hyperlinkText.</param>
        /// <param name="label">Gets or sets the label value.</param>
        /// <param name="timeFormat">Gets or sets the timeFormat.</param>
        public TemplateFormField(FieldType fieldType = default, int pageNumber = default, Rectangle bounds = default, bool isRequired = default, string value = default, FontFamily font = FontFamily.Helvetica, int fontSize = default, string fontHexColor = default, bool isBoldFont = default, bool isItalicFont = default, bool isUnderLineFont = default, int lineHeight = default, int characterLimit = default, string id = default, AttachmentInfo attachmentInfo = default(AttachmentInfo), ImageInfo imageInfo = default(ImageInfo), EditableDateFieldSettings editableDateFieldSettings = default(EditableDateFieldSettings), string groupName = default, List<string> dropdownOptions = default(List<string>), string placeholder = default(string), string dateFormat = default, BoldSign.Model.ValidationType validationType = default(BoldSign.Model.ValidationType), string validationCustomRegex = default(string), string validationCustomRegexMessage = default(string), string dataSyncTag = default, bool isReadOnly = default, List<ConditionalRule> conditionalRules = default(List<ConditionalRule>), TextAlign textAlign = TextAlign.Left, TextDirection textDirection = TextDirection.LTR, float characterSpacing = default, string type = default, string hyperlinkText = default, string label = default, string timeFormat = default)
        {
            this.mType = fieldType;
            this.PageNumber = pageNumber;
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
            this.AttachmentInfo = attachmentInfo;
            this.ImageInfo = imageInfo;
            this.EditableDateFieldSettings = editableDateFieldSettings;
            this.GroupName = groupName;
            this.DropdownOptions = dropdownOptions;
            this.Placeholder = placeholder;
            this.DateFormat = dateFormat;
            this.ValidationType = validationType;
            this.ValidationCustomRegex = validationCustomRegex;
            this.ValidationCustomRegexMessage = validationCustomRegexMessage;
            this.DataSyncTag = dataSyncTag;
            this.IsReadOnly = isReadOnly;
            this.ConditionalRules = conditionalRules;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.CharacterSpacing = characterSpacing;
            this.FieldType = type;
            this.HyperlinkText = hyperlinkText;
            this.Label = label;
            this.TimeFormat = timeFormat;
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
        /// <value>Gets the value of page number.</value>
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
        /// Gets or sets the EditableDateFieldSettings Information.
        /// </summary>
        [DataMember(Name = "editableDateFieldSettings", EmitDefaultValue = false)]
        public EditableDateFieldSettings EditableDateFieldSettings { get; set; }

        /// <summary>
        /// Gets or Sets ValidationType.
        /// </summary>
        [DataMember(Name = "validationType", EmitDefaultValue = false)]
        public BoldSign.Model.ValidationType ValidationType { get; set; }

        /// <summary>
        /// Gets or Sets ValidationCustomRegex.
        /// </summary>
        [DataMember(Name = "validationCustomRegex", EmitDefaultValue = false)]
        public string ValidationCustomRegex { get; set; }

        /// <summary>
        /// Gets or Sets ValidationCustomRegexMessage.
        /// </summary>
        [DataMember(Name = "validationCustomRegexMessage", EmitDefaultValue = false)]
        public string ValidationCustomRegexMessage { get; set; }

        /// <summary>
        /// Gets or sets the DateFormat and it's only applicable for DateSigned field and for  EditableDate field.
        /// Please use the pre-defined DateFormat.
        /// <Example>Supported formats:
        /// MM/dd/yyyy, dd/MM/yyyy, dd-MMM-yyyy, MMM-dd-yyyy, MMM dd,yyyy, dd MMM,yyyy, yyyy,MMM dd, yyyy/MM/dd, dd-MM-yyyy, MM-dd-yyyy, yyyy-MM-dd.
        /// </Example>
        /// <value>The default value is date format specified in the business profile.</value>
        /// </summary>
        [DataMember(Name = "dateFormat", EmitDefaultValue = false)]
        public string DateFormat { get; set; }

        /// <summary>
        /// Gets or sets the TimeFormat and it's only applicable for DateSigned field.
        /// Please use the pre-defined TimeFormat.
        /// <Example>Supported formats:
        /// hh:mm tt, h:mm tt, HH:mm, H:mm.
        /// </Example>
        /// <value>The default value is time format specified in the business profile.</value>
        /// </summary>
        [DataMember(Name = "timeFormat", EmitDefaultValue = false)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// Gets or Sets Placeholder value.
        /// </summary>
        [DataMember(Name = "placeholder", EmitDefaultValue = false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or Sets Dropdown Options.
        /// </summary>
        [DataMember(Name = "dropdownOptions", EmitDefaultValue = false)]
        public List<string> DropdownOptions { get; set; }

        /// <summary>
        ///     Gets or sets the form field type.
        /// </summary>
        [DataMember(Name = "fieldType", EmitDefaultValue = true)]
        [Obsolete("Type is deprecated, please use FieldType instead.")]
        public virtual FieldType Type
        {
            get { return this.mType; }
            set { this.mType = value; }
        }

        /// <summary>
        /// Gets or sets the group name for the radio button field.
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        ///     Gets or sets the Label for radio button fields.
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the data sync tag value and it's only applicable for textbox, image, dropdown, checkbox fields, it won't affect the other fields.
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
        ///     Gets or sets a value indicating whether is read only mode.
        /// </summary>
        /// <value>Gets or sets a value indicating whether is readOnlyMode.</value>
        [DataMember(Name = "isReadOnly", EmitDefaultValue = false)]
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the textAlign.
        /// </summary>
        [DataMember(Name = "textAlign", EmitDefaultValue = true)]
        public TextAlign TextAlign { get; set; }

        /// <summary>
        /// Gets or sets the direction of the text.
        /// </summary>
        [DataMember(Name = "textDirection", EmitDefaultValue = true)]
        public TextDirection TextDirection { get; set; }

        /// <summary>
        /// Gets or sets the character spacing.
        /// </summary>
        /// <value>Gets the value of character spacing.</value>
        [DataMember(Name = "characterSpacing", EmitDefaultValue = true)]
        public float CharacterSpacing { get; set; }

        /// <summary>
        /// Gets or sets the field type.
        /// </summary>
        /// <value>Gets the value of field type.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string FieldType { get; set; }

        /// <summary>
        /// Gets or sets the hyperlink text.
        /// </summary>
        /// <value>Gets the value of hyperlink text.</value>
        [DataMember(Name = "hyperlinkText", EmitDefaultValue = true)]
        public string HyperlinkText { get; set; }

        /// <summary>
        /// Gets or sets the background hex color.
        /// The BackgroundHexColor property allows you to set the background color of a label field using hexadecimal color codes ("#FF5733"). The default color is transparent or no background color.
        /// Default value is null.
        /// </summary>
        /// <value>Gets the value of backgroundColor.</value>
        [DataMember(Name = "backgroundHexColor", EmitDefaultValue = false)]
        public string BackgroundHexColor { get; set; }

        /// <summary>
        /// Gets or sets the tab index position .
        /// </summary>
        [DataMember(Name = "tabIndex", EmitDefaultValue = true)]
        public int TabIndex { get; set; }

        /// <summary>
        /// Gets or sets the formula settings.
        /// </summary>
        [DataMember(Name = "formulaFieldSettings", EmitDefaultValue = false)]
        public FormulaFieldSettings FormulaFieldSettings { get; set; }

        /// <summary>
        /// Gets or sets the resize option.
        /// </summary>
        [DataMember(Name = "resizeOption", EmitDefaultValue = true)]
        public ResizeOptions? ResizeOption { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to allow form fields to edit while sending document.
        /// </summary>
        [DataMember(Name = "allowEditFormField", EmitDefaultValue = true)]
        public bool AllowEditFormField { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to allow form fields to delete while sending document.
        /// </summary>
        [DataMember(Name = "allowDeleteFormField", EmitDefaultValue = true)]
        public bool AllowDeleteFormField { get; set; }

        /// <summary>
        /// Gets or sets field collaboration settings.
        /// </summary>
        [DataMember(Name = "collaborationSettings", EmitDefaultValue = true)]
        public CollaborationSettings CollaborationSettings { get; set; }

    }
}
