// <copyright file="ApiRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Text;
    using BoldSign.Api.Resources;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    ///     The recipient  details  model.
    /// </summary>
    [DataContract]
    public class ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiRequest"/> class.
        /// </summary>
        /// <param name="localVarPath">The request path .</param>
        /// <param name="localVarQueryParams"> The query params .</param>
        /// <param name="localVarPostBody">The post body value.</param>
        /// <param name="localVarHeaderParams">The header params.</param>
        /// <param name="localVarFormParams">The form params.</param>
        /// <param name="localVarFileParams">The file params.</param>
        /// <param name="localVarHttpContentType">The content type.</param>
        /// <param name="localVarFileUrlParams">The file url params.</param>
        public ApiRequest(
            string localVarPath = default,
            List<KeyValuePair<string, string>> localVarQueryParams = default,
            object localVarPostBody = default,
            Dictionary<string, string> localVarHeaderParams = default,
            Dictionary<string, string> localVarFormParams = default,
            Dictionary<string, List<IDocumentFile>> localVarFileParams = default,
            string localVarHttpContentType = default,
            Dictionary<string, Uri> localVarFileUrlParams = default)
        {
            this.LocalVarPath = localVarPath;
            this.LocalVarQueryParams = localVarQueryParams;
            this.LocalVarPostBody = localVarPostBody;
            this.LocalVarHeaderParams = localVarHeaderParams;
            this.LocalVarFormParams = localVarFormParams;
            this.LocalVarFileParams = localVarFileParams;
            this.LocalVarHttpContentType = localVarHttpContentType;
            this.LocalVarFileUrlParams = localVarFileUrlParams;
        }

        /// <summary>
        ///  Gets or sets the path.
        /// </summary>
        /// <value>Gets the path.</value>
        [DataMember(Name = "localVarPath", EmitDefaultValue = true)]
        public string LocalVarPath { get; set; }

        /// <summary>
        ///  Gets or sets the query parameters.
        /// </summary>
        /// <value>Gets the query parameters.</value>
        [DataMember(Name = "localVarQueryParams", EmitDefaultValue = true)]
        public List<KeyValuePair<string, string>> LocalVarQueryParams { get; set; }

        /// <summary>
        ///  Gets or sets the post body .
        /// </summary>
        /// <value>Gets the value of post body .</value>
        [DataMember(Name = "localVarPostBody", EmitDefaultValue = true)]
        public object LocalVarPostBody { get; set; }

        /// <summary>
        ///  Gets or sets the header params .
        /// </summary>
        /// <value>Gets the value of header params .</value>
        [DataMember(Name = "localVarHeaderParams", EmitDefaultValue = true)]
        public Dictionary<string, string> LocalVarHeaderParams { get; set; }

        /// <summary>
        ///  Gets or sets the form params .
        /// </summary>
        /// <value>Gets the value of form params .</value>
        [DataMember(Name = "localVarFormParams", EmitDefaultValue = true)]
        public Dictionary<string, string> LocalVarFormParams { get; set; }

        /// <summary>
        /// Gets or sets the file params.
        /// </summary>
        [DataMember(Name = "localVarFileParams", EmitDefaultValue = true)]
        public Dictionary<string, List<IDocumentFile>> LocalVarFileParams { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        [DataMember(Name = "localVarHttpContentType", EmitDefaultValue = true)]
        public string LocalVarHttpContentType { get; set; }

        /// <summary>
        /// Gets or sets the file url params.
        /// </summary>
        [DataMember(Name = "localVarFileUrlParams", EmitDefaultValue = true)]
        public Dictionary<string, Uri> LocalVarFileUrlParams { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
