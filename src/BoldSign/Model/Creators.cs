// <copyright file="Creators.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>
namespace BoldSign.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The creator details.
    /// </summary>
    [DataContract]
    public class Creators
    {
        /// <summary>
        /// Gets or sets the creator email.
        /// </summary>
        [DataMember(Name = "createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the creator user id.
        /// </summary>
        [DataMember(Name = "userId")]
        public string UserId { get; set; }
    }
}