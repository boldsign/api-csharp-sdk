using BoldSign.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BoldSign.Model
{
    public interface IFormField
    {

        /// <summary>
        ///     Gets or Sets form field type.
        /// </summary>
        [DataMember(Name = "fieldType", EmitDefaultValue = true)]
        public FieldType Type { get; set; }

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
    }
}
