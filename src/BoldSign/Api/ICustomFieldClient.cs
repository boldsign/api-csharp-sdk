// <copyright file="ICustomFieldClient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System.Threading.Tasks;
    using BoldSign.Model;

    /// <summary>
    ///    Represents a collection of functions to interact with the API endpoints. The functions perform actions such as creating custom field, deleting custom field, editing custom field and so on.
    /// </summary>
    public interface ICustomFieldClient : IApiAccessor
    {
        /// <summary>
        /// Creates a custom field for the specified brand.
        /// </summary>
        /// <param name="brandCustomFieldDetails">The brand custom fields class.</param>
        /// <returns>Return the custom message.</returns>
        CustomFieldMessage CreateCustomField(BrandCustomFieldDetails brandCustomFieldDetails);

        /// <summary>
        /// Created a custom field for the specified brand.
        /// </summary>
        /// <param name="brandCustomFieldDetails">The brand custom fields class.</param>
        /// <returns>Return the custom message.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        ApiResponse<CustomFieldMessage> CreateCustomFieldWithHttpInfo(BrandCustomFieldDetails brandCustomFieldDetails);

        /// <summary>
        /// Creates a custom field for the specified brand.
        /// </summary>
        /// <param name="brandCustomFieldDetails">The brand custom fields class.</param>
        /// <returns>Return the custom message.</returns>
        Task<CustomFieldMessage> CreateCustomFieldAsync(BrandCustomFieldDetails brandCustomFieldDetails);

        /// <summary>
        /// Creates a custom field for the specified brand.
        /// </summary>
        /// <param name="brandCustomFieldDetails">The brand custom fields class.</param>
        /// <returns>Return the custom message.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        Task<ApiResponse<CustomFieldMessage>> CreateCustomFieldAsyncWithHttpInfo(BrandCustomFieldDetails brandCustomFieldDetails);

        /// <summary>
        /// Edits a custom field for the specified brand.
        /// </summary>
        /// <param name="customFieldId">The custom field id.</param>
        /// <param name="brandCustomFieldDetails">The brand custom fields class.</param>
        /// <returns>Return the custom message.</returns>
        CustomFieldMessage EditCustomField(string customFieldId, BrandCustomFieldDetails brandCustomFieldDetails);

        /// <summary>
        /// Edits a custom field for the specified brand.
        /// </summary>
        /// <param name="customFieldId">The custom field id.</param>
        /// <param name="brandCustomFieldDetails">The brand custom fields class.</param>
        /// <returns>Return the custom message.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        ApiResponse<CustomFieldMessage> EditCustomFieldWithHttpInfo(string customFieldId, BrandCustomFieldDetails brandCustomFieldDetails);

        /// <summary>
        /// Edits a custom field for the specified brand.
        /// </summary>
        /// <param name="customFieldId">The custom field id.</param>
        /// <param name="brandCustomFieldDetails">The brand custom fields class.</param>
        /// <returns>Return the custom message.</returns>
        Task<CustomFieldMessage> EditCustomFieldAsync(string customFieldId, BrandCustomFieldDetails brandCustomFieldDetails);

        /// <summary>
        /// Edits a custom field for the specified brand.
        /// </summary>
        /// <param name="customFieldId">The custom field id.</param>
        /// <param name="brandCustomFieldDetails">The brand custom fields class.</param>
        /// <returns>Return the custom field message.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        Task<ApiResponse<CustomFieldMessage>> EditCustomFieldAsyncWithHttpInfo(string customFieldId, BrandCustomFieldDetails brandCustomFieldDetails);

        /// <summary>
        /// Deletes the custom field for the specified brand.
        /// </summary>
        /// <param name="customFieldId">The custom field id.</param>
        /// <returns>Return the custom field message.</returns>
        CustomFieldMessage DeleteCustomField(string customFieldId);

        /// <summary>
        /// Deletes the custom field for the specified brand.
        /// </summary>
        /// <param name="customFieldId">The custom field id.</param>
        /// <returns>Return the custom field message.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        ApiResponse<CustomFieldMessage> DeleteCustomFieldWithHttpInfo(string customFieldId);

        /// <summary>
        /// Deletes the custom field for the specified brand.
        /// </summary>
        /// <param name="customFieldId">The custom field id.</param>
        /// <returns>Return the custom field message.</returns>
        Task<CustomFieldMessage> DeleteCustomFieldAsync(string customFieldId);

        /// <summary>
        /// Deletes the custom field for the specified brand.
        /// </summary>
        /// <param name="customFieldId">The custom field id.</param>
        /// <returns>Return the custom field message.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        Task<ApiResponse<CustomFieldMessage>> DeleteCustomFieldAsyncWithHttpInfo(string customFieldId);

        /// <summary>
        /// Gets the collections of custom fields for the specified brand.
        /// </summary>
        /// <param name="brandId">The brand Id.</param>
        /// <returns>Returns the collection of custom fields.</returns>
        CustomFieldCollection GetBrandBasedCustomFields(string brandId);

        /// <summary>
        /// Gets the collections of custom fields for the specified brand.
        /// </summary>
        /// <param name="brandId">The brand Id.</param>
        /// <returns>Returns the collection of custom fields.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        ApiResponse<CustomFieldCollection> GetBrandBasedCustomFieldsWithHttpInfo(string brandId);

        /// <summary>
        /// Gets the collections of custom fields for the specified brand.
        /// </summary>
        /// <param name="brandId">The brand Id.</param>
        /// <returns>Returns the collection of custom fields.</returns>
        Task<CustomFieldCollection> GetBrandBasedCustomFieldsAsync(string brandId);

        /// <summary>
        /// Gets the collections of custom fields for the specified brand.
        /// </summary>
        /// <param name="brandId">The brand Id.</param>
        /// <returns>Returns the collection of custom fields.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        Task<ApiResponse<CustomFieldCollection>> GetBrandBasedCustomFieldsAsyncWithHttpInfo(string brandId);

        /// <summary>
        /// Generates a URL to embed manipulation of custom field process into your application.
        /// </summary>
        /// <param name="embeddedCustomFieldDetails">The embedded custom field details.</param>
        /// <returns>Returns the embedded custom field url.</returns>
        EmbeddedCustomFieldCreated CreateEmbeddedCustomFieldUrl(EmbeddedCustomFieldDetails embeddedCustomFieldDetails);

        /// <summary>
        /// Generates a URL to embed manipulation of custom field process into your application.
        /// </summary>
        /// <param name="embeddedCustomFieldDetails">The embedded custom field details.</param>
        /// <returns>Returns the embedded custom field url.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        ApiResponse<EmbeddedCustomFieldCreated> CreateEmbeddedCustomFieldUrlWithHttpInfo(EmbeddedCustomFieldDetails embeddedCustomFieldDetails);

        /// <summary>
        /// Generates a URL to embed manipulation of custom field process into your application.
        /// </summary>
        /// <param name="embeddedCustomFieldDetails">The embedded custom field details.</param>
        /// <returns>Returns the embedded custom field url.</returns>
        Task<EmbeddedCustomFieldCreated> CreateEmbeddedCustomFieldUrlAsync(EmbeddedCustomFieldDetails embeddedCustomFieldDetails);

        /// <summary>
        /// Generates a URL to embed manipulation of custom field process into your application.
        /// </summary>
        /// <param name="embeddedCustomFieldDetails">The embedded custom field details.</param>
        /// <returns>Returns the embedded custom field url.</returns>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        Task<ApiResponse<EmbeddedCustomFieldCreated>> CreateEmbeddedCustomFieldUrlAsyncWithHttpInfo(EmbeddedCustomFieldDetails embeddedCustomFieldDetails);
    }
}
