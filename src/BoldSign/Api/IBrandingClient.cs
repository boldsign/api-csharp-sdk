// <copyright file="IBrandingClient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System.Threading.Tasks;
    using BoldSign.Model;

    /// <summary>
    ///    Represents a collection of functions to interact with the API endpoints. The functions perform actions such as creating brand, deleting brand, listing the brand and so on.
    /// </summary>
    public interface IBrandingClient : IApiAccessor
    {
        /// <summary>
        ///     create the brand.
        /// </summary>
        /// <param name="createBrandData">createBrandData.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>BrandingData.</returns>
        BrandingData CreateBrand(BrandSettings createBrandData);

        /// <summary>
        ///     create the brand.
        /// </summary>
        /// <param name="createBrandData">createBrandData.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>ApiResponse of Object(BrandingData).</returns>
        ApiResponse<BrandingData> CreateBrandWithHttpInfo(BrandSettings createBrandData);

        /// <summary>
        ///     edit the brand.
        /// </summary>
        /// <param name="brandId">brandId.</param>
        /// <param name="editBrandData">editBrandData.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>BrandingData.</returns>
        BrandingData EditBrand(string brandId, BrandSettings editBrandData);

        /// <summary>
        ///     edit the brand.
        /// </summary>
        /// <param name="brandId">brandId.</param>
        /// <param name="editBrandData">editBrandData.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>ApiResponse of Object(BrandingData).</returns>
        ApiResponse<BrandingData> EditBrandWithHttpInfo(string brandId, BrandSettings editBrandData);

        /// <summary>
        ///     Reset the default brand when a particular brand’s ID is given as input.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        void ResetDefaultBrand(string brandId);

        /// <summary>
        ///    Reset the default brand when a particular brand’s ID is given as input.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> ResetDefaultBrandWithHttpInfo(string brandId);

        /// <summary>
        ///     list the brand.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>BrandingRecords.</returns>
        BrandingRecords ListBrand();

        /// <summary>
        ///     list the brand.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>ApiResponse of BrandRecords.</returns>
        ApiResponse<BrandingRecords> ListBrandWithHttpInfo();

        /// <summary>
        ///     Delete the brand when a particular brand’s ID is given as input.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        void DeleteBrand(string brandId);

        /// <summary>
        ///     Delete the brand when a particular brand’s ID is given as input.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> DeleteBrandWithHttpInfo(string brandId);

        /// <summary>
        ///     create the brand.
        /// </summary>
        /// <param name="createBrandData">createBrandData.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of BrandingData.</returns>
        Task<BrandingData> CreateBrandAsync(BrandSettings createBrandData);

        /// <summary>
        ///     create the brand.
        /// </summary>
        /// <param name="createBrandData">createBrandData.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (BrandingResult).</returns>
        Task<ApiResponse<BrandingData>> CreateBrandAsyncWithHttpInfo(BrandSettings createBrandData);

        /// <summary>
        ///     edit the brand.
        /// </summary>
        /// <param name="brandId">brandId.</param>
        /// <param name="editBrandData">editBrandData.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of BrandingData.</returns>
        Task<BrandingData> EditBrandAsync(string brandId, BrandSettings editBrandData);

        /// <summary>
        ///     edit the brand.
        /// </summary>
        /// <param name="brandId">brandId.</param>
        /// <param name="editBrandData">editBrandData.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of BrandingData.</returns>
        Task<ApiResponse<BrandingData>> EditBrandAsyncWithHttpInfo(string brandId, BrandSettings editBrandData);

        /// <summary>
        ///     Reset the default brand when a particular brand’s ID is given as input.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        /// <returns>Task of void.</returns>
        Task ResetDefaultBrandAsync(string brandId);

        /// <summary>
        ///     Reset the default brand when a particular brand’s ID is given as input.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        /// <returns>Task of ApiResponse.</returns>
        Task<ApiResponse<object>> ResetDefaultBrandWithHttpInfoAsync(string brandId);

        /// <summary>
        ///     list the brand.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of BrandingRecords.</returns>
        Task<BrandingRecords> ListBrandAsync();

        /// <summary>
        ///     list the brand.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (BrandingRecords).</returns>
        Task<ApiResponse<BrandingRecords>> ListBrandAsyncWithHttpInfo();

        /// <summary>
        ///     Delete the brand.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        /// <returns>Task of void.</returns>
        Task DeleteBrandAsync(string brandId);

        /// <summary>
        ///     Delete the brand.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        /// <returns>Task of ApiResponse.</returns>
        Task<ApiResponse<object>> DeleteBrandAsyncWithHttpInfo(string brandId);

        /// <summary>
        /// Get the brand.
        /// </summary>
        /// <param name="brandId">brandId.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of BrandDetails.</returns>
        Task<BrandDetails> GetBrandDetailsAsync(string brandId);

        /// <summary>
        /// Get the brand.
        /// </summary>
        /// <param name="brandId">brandId.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of BrandDetails.</returns>
        Task<ApiResponse<BrandDetails>> GetBrandDetailsAsyncWithHttpInfo(string brandId);

        /// <summary>
        /// Get the brand.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        /// <returns>ApiResponse of BrandDetails.</returns>
        ApiResponse<BrandDetails> GetBrandDetailsWithHttpInfo(string brandId);

        /// <summary>
        /// Get the brand.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="brandId">Brand Id.</param>
        /// <returns>BrandDetails.</returns>
        BrandDetails GetBrandDetails(string brandId);
    }
}
