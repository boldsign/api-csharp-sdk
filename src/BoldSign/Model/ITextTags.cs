// <copyright file="ITextTags.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// The text tag model.
    /// </summary>
    public interface ITextTags
    {
        /// <summary>
        /// <para>
        /// Gets or sets a value indicating whether to convert the text tags to form fields.
        /// </para>
        /// <para>
        /// It is recommended to set your text tags color to match your background color, in most cases,
        /// it will be white on white.
        /// </para>
        /// </summary>
        bool UseTextTags { get; set; }

        /// <summary>
        /// Gets or sets the text tags definitions declared in the list can be used in the document by using the definition ID.
        /// </summary>
        List<TextTagDefinition> TextTagDefinitions { get; set; }
    }
}
