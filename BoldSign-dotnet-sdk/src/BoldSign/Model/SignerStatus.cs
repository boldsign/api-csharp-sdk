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
    ///     Defines SignerStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SignerStatus
    {
        /// <summary>
        ///     Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        ///     Enum NotCompleted for value: NotCompleted
        /// </summary>
        [EnumMember(Value = "NotCompleted")]
        NotCompleted = 2,

        /// <summary>
        ///     Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 3,

        /// <summary>
        ///     Enum Declined for value: Declined
        /// </summary>
        [EnumMember(Value = "Declined")]
        Declined = 4,
    }
}
