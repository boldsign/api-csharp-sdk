using System;
using System.Collections.Generic;
using System.Text;

namespace BoldSign.Model
{
    /// <summary>
    /// The document file path.
    /// </summary>
    public class DocumentFilePath : IDocumentFile
    {
        /// <summary>
        ///     <para>Gets or sets content type of the document (ex: application/pdf).</para>
        ///     <para>Please refer documentation for the supported content type.</para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        public string FilePath { get; set; }

        public long Filesize()
        {
            long _fileSize = new System.IO.FileInfo(FilePath).Length;
            return _fileSize;
        }
    }
}
