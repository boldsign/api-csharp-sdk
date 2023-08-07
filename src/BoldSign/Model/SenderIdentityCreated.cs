// <copyright file="SenderIdentityCreated.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Sender identity created action result.
    /// </summary>
    [DataContract]
    public class SenderIdentityCreated
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SenderIdentityCreated" /> class.
        /// </summary>
        /// <param name="senderIdentityId">Gets or sets sender identity id.</param>
        public SenderIdentityCreated(string senderIdentityId = default)
        {
            this.SenderIdentityId = senderIdentityId;
        }

        /// <summary>
        /// Gets or sets the sender identity id for a created identity.
        /// </summary>
        /// <value>Gets or sets the sender identity id.</value>
        [DataMember(Name = "senderIdentityId", EmitDefaultValue = true)]
        public string SenderIdentityId { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
