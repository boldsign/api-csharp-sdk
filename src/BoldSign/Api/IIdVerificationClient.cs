// <copyright file="IIdVerificationClient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System.IO;
    using System.Threading.Tasks;
    using BoldSign.Model.IdVerification;

    /// <summary>
    ///  Represents a collection of functions to interact with the API endpoints. The functions perform actions such as get report, get image and create embedded verification url.
    /// </summary>
    public interface IIdVerificationClient : IApiAccessor
    {
        /// <summary>
        /// Retrieve the ID verification report for the specified document signer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="verificationReportRequest">Gets or sets verification report request.</param>
        /// <returns>A Id Verification Report.</returns>
        IdReport GetReport(string documentId, VerificationReportRequest verificationReportRequest = default);

        /// <summary>
        /// Retrieve the ID verification report for the specified document signer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="verificationReportRequest">Gets or sets verification report request.</param>
        /// <returns>A ApiResponse of Id Verification Report.</returns>
        ApiResponse<IdReport> GetReportWithHttpInfo(string documentId, VerificationReportRequest verificationReportRequest = default);

        /// <summary>
        /// Retrieve the uploaded ID verification document or selfie image for the specified document signer using the file ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="verificationImageRequest">Gets or sets verification image request.</param>
        /// <returns>A Id Verification Images in File Stream.</returns>
        Stream GetImage(string documentId, VerificationImageRequest verificationImageRequest = default);

        /// <summary>
        /// Retrieve the uploaded ID verification document or selfie image for the specified document signer using the file ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="verificationImageRequest">Gets or sets verification image request.</param>
        /// <returns>A ApiResponse of Id Verification Images in File Stream.</returns>
        ApiResponse<Stream> GetImageWithHttpInfo(string documentId, VerificationImageRequest verificationImageRequest = default);

        /// <summary>
        /// Generate a URL that embeds manual ID verification for the specified document signer into your application.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="embeddedVerificationRequest">Gets or sets embedded verification request.</param>
        /// <returns>Embedded Verification Url.</returns>
        EmbeddedVerificationCreated CreateEmbeddedVerificationUrl(string documentId, EmbeddedVerificationRequest embeddedVerificationRequest = default);

        /// <summary>
        /// Generate a URL that embeds manual ID verification for the specified document signer into your application.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="embeddedVerificationRequest">Gets or sets embedded verification request.</param>
        /// <returns>A ApiResponse of Embedded Verification Url.</returns>
        ApiResponse<EmbeddedVerificationCreated> CreateEmbeddedVerificationUrlWithHttpInfo(string documentId, EmbeddedVerificationRequest embeddedVerificationRequest = default);

        /// <summary>
        /// Retrieve the ID verification report for the specified document signer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="verificationReportRequest">Gets or sets verification report request.</param>
        /// <returns>A Task of Id Verification Report.</returns>
        Task<IdReport> GetReportAsync(string documentId, VerificationReportRequest verificationReportRequest = default);

        /// <summary>
        /// Retrieve the ID verification report for the specified document signer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="verificationReportRequest">Gets or sets verification report request.</param>
        /// <returns>A Task of ApiResponse of Id Verification Report.</returns>
        Task<ApiResponse<IdReport>> GetReportWithHttpInfoAsync(string documentId, VerificationReportRequest verificationReportRequest = default);

        /// <summary>
        /// Retrieve the uploaded ID verification document or selfie image for the specified document signer using the file ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="verificationImageRequest">Gets or sets verification image request.</param>
        /// <returns>A Task of Id Verification Images in File Stream.</returns>
        Task<Stream> GetImageAsync(string documentId, VerificationImageRequest verificationImageRequest = default);

        /// <summary>
        /// Retrieve the uploaded ID verification document or selfie image for the specified document signer using the file ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="verificationImageRequest">Gets or sets verification image request.</param>
        /// <returns>A Task of ApiResponse of Id Verification Images in File Stream.</returns>
        Task<ApiResponse<Stream>> GetImageWithHttpInfoAsync(string documentId, VerificationImageRequest verificationImageRequest = default);

        /// <summary>
        /// Generate a URL that embeds manual ID verification for the specified document signer into your application.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="embeddedVerificationRequest">Gets or sets embedded verification request.</param>
        /// <returns>A Task of Embedded Verification Url.</returns>
        Task<EmbeddedVerificationCreated> CreateEmbeddedVerificationUrlAsync(string documentId, EmbeddedVerificationRequest embeddedVerificationRequest = default);

        /// <summary>
        /// Generate a URL that embeds manual ID verification for the specified document signer into your application.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="embeddedVerificationRequest">Gets or sets embedded verification request.</param>
        /// <returns>Task of ApiResponse of Embedded Verification Url.</returns>
        Task<ApiResponse<EmbeddedVerificationCreated>> CreateEmbeddedVerificationUrlWithHttpInfoAsync(string documentId, EmbeddedVerificationRequest embeddedVerificationRequest = default);
    }
}
