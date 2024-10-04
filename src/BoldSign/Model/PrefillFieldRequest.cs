// <copyright file="PrefillFieldRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    ///  Pre fill field request.
    /// </summary>
    [DataContract]
    public class PrefillFieldRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PrefillFieldRequest" /> class.
        /// </summary>
        /// <param name="documentId">Gets or sets the document id.</param>
        public PrefillFieldRequest(string documentId)
        {
            this.DocumentId = documentId;
        }

        /// <summary>
        ///     Gets or sets the document Id.
        /// </summary>
        /// <value>Gets or sets the document id.</value>
        [DataMember(Name = "documentId", EmitDefaultValue = true)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the form field ID.
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<PrefillField> Fields { get; set; }

        /// <summary>
        /// Gets or sets the on behalf of user.
        /// </summary>
        [DataMember(Name = "onBehalfOf", EmitDefaultValue = true)]
        public string OnBehalfOf { get; set; }
    }
}
