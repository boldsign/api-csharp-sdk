// <copyright file="FormFieldPermission.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook.Template
{
    using Newtonsoft.Json;

    /// <summary>
    /// The template field permission details .
    /// </summary>
    public class FormFieldPermission
    {
        /// <summary>
        /// Gets or sets a value indicating whether new form fields can be added.
        /// </summary>
        [JsonProperty("canAdd")]
        public bool CanAdd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether existing form fields can be modified.
        /// </summary>
        [JsonProperty("canModify")]
        public bool CanModify { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether default values of form fields can be set.
        /// </summary>
        [JsonProperty("canModifyDefaultValue")]
        public bool CanModifyDefaultValue { get; set; }
    }
}
