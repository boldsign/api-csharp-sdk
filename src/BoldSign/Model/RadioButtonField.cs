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
    public class RadioButtonField : FormField
    {

        /// <summary>
        ///     Initializes a new instance of the <see cref="RadioButtonField" /> class.
        /// </summary>
        [JsonConstructor]
        protected RadioButtonField()
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
        public RadioButtonField(string name = default,int pageNumber = default, Rectangle bounds = default, bool isRequired = default, string value = default, FontFamily font = FontFamily.Helvetica, int fontSize = default, string fontHexColor = default, bool isBoldFont = default, bool isItalicFont = default, bool isUnderLineFont = default, int lineHeight = default, int characterLimit = default, string groupName = default) : base(name: name, type: FieldType.RadioButton, pageNumber: pageNumber, bounds: bounds, isRequired: isRequired, value: value, font: font, fontSize: fontSize, fontHexColor: fontHexColor, isBoldFont: isBoldFont, isItalicFont: isItalicFont, isUnderLineFont: isUnderLineFont, lineHeight: lineHeight, characterLimit: characterLimit)
        {
            this.GroupName = groupName;
        }

        /// <summary>
        /// Gets the form field type.It is a read only property.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override FieldType Type
        {
            get => base.m_type;
            set { throw new Exception("Read only"); }
        }

        /// <summary>
        /// Gets or sets the group name for the radio button field.
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public new string GroupName { get; set; }
    }
}
