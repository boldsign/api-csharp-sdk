using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BoldSign.Model
{
    /// <summary>
    /// The document file stream result.
    /// </summary>
    public class DocumentFileStream : IDocumentFile
    {
        /// <summary>
        ///     Gets or sets data to use as the file's contents.
        /// </summary>
        public Stream FileData { get; set; }

        /// <summary>
        ///     Gets or sets filename of the document.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        ///     <para>Gets or sets content type of the document (ex: application/pdf).</para>
        ///     <para>Please refer documentation for the supported content type.</para>
        /// </summary>
        public string ContentType { get; set; }
    }
}
