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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     Represents FieldType in the document.
    /// </summary>
    /// <value>Represents FieldType.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldType
    {
        /// <summary>
        ///     Enum Signature for value: Signature
        /// </summary>
        [EnumMember(Value = "Signature")]
        Signature = 1,

        /// <summary>
        ///     Enum Initial for value: Initial
        /// </summary>
        [EnumMember(Value = "Initial")]
        Initial = 2,

        /// <summary>
        ///     Enum CheckBox for value: CheckBox
        /// </summary>
        [EnumMember(Value = "CheckBox")]
        CheckBox = 3,

        /// <summary>
        ///     Enum TextBox for value: TextBox
        /// </summary>
        [EnumMember(Value = "TextBox")]
        TextBox = 4,

        /// <summary>
        ///     Enum Label for value: Label
        /// </summary>
        [EnumMember(Value = "Label")]
        Label = 5,

        /// <summary>
        ///     Enum DatePicker for value: DatePicker
        /// </summary>
        [EnumMember(Value = "DateSigned")]
        DateSigned = 6,

        /// <summary>
        ///     Enum RadioButton for value: RadioButton
        /// </summary>
        [EnumMember(Value = "RadioButton")]
        RadioButton = 7,

        /// <summary>
        ///     Enum Image for value: Image
        /// </summary>
        [EnumMember(Value = "Image")]
        Image = 8,

        /// <summary>
        ///     Enum Attachment for value: Attachment
        /// </summary>
        [EnumMember(Value = "Attachment")]
        Attachment = 9,
        
        /// <summary>
        ///     Enum EditableDate for value: EditableDate
        /// </summary>
        [EnumMember(Value = "EditableDate")]
        EditableDate = 10,

        /// <summary>
        ///     Enum Hyperlink for value: Hyperlink
        /// </summary>
        [EnumMember(Value = "Hyperlink")]
        Hyperlink = 11,

        /// <summary>
        ///     Enum Dropdown for value: Dropdown
        /// </summary>
        [EnumMember(Value = "Dropdown")]
        Dropdown = 12,

        /// <summary>
        /// Enum Title for value: Title
        /// </summary>
        [EnumMember(Value = "Title")]
        Title = 13,

        /// <summary>
        ///     Enum Company for value: Company
        /// </summary>
        [EnumMember(Value = "Company")]
        Company = 14,
    }
}
