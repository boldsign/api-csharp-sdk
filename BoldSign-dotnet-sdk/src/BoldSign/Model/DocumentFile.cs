namespace BoldSign.Model
{
    /// <summary>
    /// The document file.
    /// </summary>
    internal class DocumentFile
    {
        /// <summary>
        ///     Gets or sets data to use as the file's contents.
        /// </summary>
        public byte[] FileData { get; set; }

        /// <summary>
        ///     Gets or sets filename.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        ///     <para>Gets or sets content type of the document (ex: application/pdf).</para>
        ///     <para>Please refer documentation for the supported content type.</para>
        /// </summary>
        public string ContentType { get; set; }
    }
}
