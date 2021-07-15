using BoldSign.Api.Resources;
using BoldSign.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace BoldSign.Model
{
    /// <summary>
    /// TextBoxField
    /// </summary>
    [DataContract]
    public class DateSignedField : FormField
    {

        /// <summary>
        ///     Initializes a new instance of the <see cref="DateSignedField" /> class.
        /// </summary>
        [JsonConstructor]
        protected DateSignedField()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateSignedField" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name.</param>
        /// <param name="pageNumber">Gets or sets the page number.</param>
        /// <param name="bounds">Gets or sets the bounds (required).</param>
        /// <param name="isRequired">Gets or sets a value indicating whether the field is required.</param>
        /// <param name="value">Gets or sets the value.</param>
        /// <param name="fontSize">Gets or sets the fontSize.</param>
        /// <param name="font">Gets or sets the font (required).</param>
        /// <param name="fontHexColor">Gets or sets the fontHexColor.</param>
        /// <param name="isBoldFont">Gets or sets a value indicating whether the font style is bold.</param>
        /// <param name="isItalicFont">Gets or sets a value indicating whether the font style is italic.</param>
        /// <param name="isUnderLineFont">Gets or sets a value indicating whether the font style is underline.</param>
        /// <param name="lineHeight">Gets or sets the lineHeight.</param>
        /// <param name="dateFormat">Gets or sets the dateFormat.</param>
        public DateSignedField(string name = default, int pageNumber = default, Rectangle bounds = default, bool isRequired = default, string value = default, FontFamily font = FontFamily.Helvetica, int fontSize = default, string fontHexColor = default, bool isBoldFont = default, bool isItalicFont = default, bool isUnderLineFont = default, int lineHeight = default, string dateFormat = default) : base(name: name, type: FieldType.DateSigned, pageNumber: pageNumber,bounds: bounds, isRequired: isRequired, value: value, font: font, fontSize: fontSize, fontHexColor: fontHexColor, isBoldFont: isBoldFont, isItalicFont: isItalicFont, isUnderLineFont: isUnderLineFont, lineHeight: lineHeight)
        {
            this.DateFormat = dateFormat;
        }
        /// <summary>
        /// Gets or sets the DateFormat and it's only applicable for DateSigned field.
        /// Please use the pre-defiened DateFormat.
        /// <Example>Supported formats:
        /// MM/dd/yyyy, dd/MM/yyyy, dd-MMM-yyyy, MMM-dd-yyyy, MMM dd,yyyy, dd MMM,yyyy, yyyy,MMM dd, yyyy/MM/dd, dd-MM-yyyy, MM-dd-yyyy, yyyy-MM-dd.
        /// </Example>
        /// <value>The default value is date format specified in the business profile.</value>
        /// </summary>
        [DataMember(Name = "dateFormat", EmitDefaultValue = false)]
        public string DateFormat { get; set; }

        /// <summary>
        /// Gets the form field type.It is a read only property.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override FieldType Type
        {
            get => base.m_type;
            set { throw new Exception("Read only"); }
        }

    }
}
