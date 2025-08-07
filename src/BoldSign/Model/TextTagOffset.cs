// <copyright file="TextTagOffset.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Text Tag offset.
    /// </summary>
    [DataContract]
    public class TextTagOffset
    {
        /// <summary>
        /// Gets or sets the offsetX of textTagOffset.
        /// </summary>
        /// <value>Gets or sets the offsetX.</value>
        [DataMember(Name = "offsetX", EmitDefaultValue = false)]
        public double OffsetX { get; set; }

        /// <summary>
        /// Gets or sets the offsetY of textTagOffset.
        /// </summary>
        /// <value>Gets or sets the offsetY.</value>
        [DataMember(Name = "offsetY", EmitDefaultValue = false)]
        public double OffsetY { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}