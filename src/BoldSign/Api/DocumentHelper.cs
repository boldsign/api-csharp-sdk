// <copyright file="DocumentHelper.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BoldSign.Api.Model;
    using BoldSign.Api.Resources;
    using BoldSign.Model;

    /// <summary>
    /// The Document helper.
    /// </summary>
    public static class DocumentHelper
    {
        /// <summary>
        /// Validate the file upload request document request.
        /// </summary>
        /// <param name="request">The request model.</param>
        public static void ValidateFiles(IDocumentUpload request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var files = request.Files ?? new List<IDocumentFile>();
            var fileUrls = request.FileUrls ?? new List<Uri>();

            var isFillingEmbedded = request is EmbeddedDocumentRequest { SendViewOption: PageViewOption.FillingPage, }
                || request is CreateEmbeddedTemplateRequest { ViewOption: PageViewOption.FillingPage, };

            var isEmptyFileFillingPage = isFillingEmbedded && files.Count == 0 && fileUrls.Count == 0;

            if (isEmptyFileFillingPage && HasAnyFormFields(request))
            {
                var errorMessage = request is SendForSign
                    ? ApiValidationMessages.NoSignerFormFieldsWhenNoFile
                    : ApiValidationMessages.NoRoleFormFieldsWhenNoFile;

                throw new ApiException(422, errorMessage);
            }

            if ((files.Count > 0 && fileUrls.Count > 0) || (!isFillingEmbedded && files.Count == 0 && fileUrls.Count == 0))
            {
                var errorMessage = files.Count > 0 && fileUrls.Count > 0
                    ? ApiValidationMessages.BothFileParamUsed
                    : ApiValidationMessages.MissingFileInput;

                throw new ApiException(422, errorMessage);
            }
        }

        private static bool HasAnyFormFields(IDocumentUpload request)
        {
            return (request is SendForSign s && s.Signers?.Any(x => x.FormFields != null && x.FormFields.Any()) == true)
                || (request is CreateTemplateRequest c && c.Roles?.Any(x => x.FormFields != null && x.FormFields.Any()) == true);
        }
    }
}
