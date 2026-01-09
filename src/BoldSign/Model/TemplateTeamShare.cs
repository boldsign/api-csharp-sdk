namespace BoldSign.Api.Model
{

    using System.Runtime.Serialization;
    using BoldSign.Model;
    using Newtonsoft.Json;

    [DataContract]
    public class TemplateTeamShare
    {
        /// <summary>
        ///     Gets or sets recipient Team Id.
        /// </summary>
        /// <value> Gets the value of recipient Team Id.</value>
        [DataMember(Name = "teamId", EmitDefaultValue = true)]
        public string TeamId { get; set; }

        /// <summary>
        ///     Gets or sets recipient Access Type.
        /// </summary>
        /// <value> Gets the value of recipient Access Type.</value>
        [DataMember(Name = "accessType", EmitDefaultValue = true)]
        [JsonProperty("accessType")]
        public TemplateAccessType AccessType { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
