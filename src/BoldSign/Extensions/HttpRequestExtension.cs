// <copyright file="HttpRequestExtension.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Extensions
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using BoldSign.Api;
    using BoldSign.Api.Resources;

    /// <summary>
    /// The http request extension.
    /// </summary>
    public static class HttpRequestExtension
    {
        /// <summary>
        /// Adds the form parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="key">The key.</param>
        /// <param name="content">The content.</param>
        public static void AddFormParameter(this MultipartFormDataContent value, string key, string content)
        {
            if (value is null || string.IsNullOrEmpty(key))
            {
                throw new ApiException(415, ApiValidationMessages.UnsupportedMediaType);
            }

            if (string.IsNullOrEmpty(content))
            {
                return;
            }

            value.Add(new StringContent(content), key);
        }

        /// <summary>
        /// Adds the file parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="content">The path value.</param>
        /// <param name="key">The key.</param>
        public static void AddFileParameter(this MultipartFormDataContent value, string content, string key)
        {
            if (value is null || string.IsNullOrEmpty(key))
            {
                throw new ApiException(415, ApiValidationMessages.UnsupportedMediaType);
            }

            var fileName = Path.GetFileName(content);
            using var fileStream = new FileStream(content, FileMode.Open, FileAccess.Read);
            using var memoryStream = new MemoryStream();
            fileStream.CopyTo(memoryStream);
            var fileBytes = memoryStream.ToArray();

            var fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = key,
                FileName = fileName,
            };
            value.Add(fileContent);
        }

        /// <summary>
        /// Extracts the byte array.
        /// </summary>
        /// <param name="input">The input stream.</param>
        /// <returns>The byte array.</returns>
        public static byte[] ReadAsBytes(this Stream input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            byte[] buffer = new byte[16384];
            using (MemoryStream memoryStream = new MemoryStream())
            {
                int count;
                while ((count = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    memoryStream.Write(buffer, 0, count);
                }

                return memoryStream.ToArray();
            }
        }
    }
}
