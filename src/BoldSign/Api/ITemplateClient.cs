namespace BoldSign.Api
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using BoldSign.Api.Model;
    using BoldSign.Model;

    /// <summary>
    ///    Represents a collection of functions to interact with the API endpoints. The functions perform actions such as sending document sign request from template, deleting a template, listing the templates and so on.
    /// </summary>
    public interface ITemplateClient : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Deletes a template with the given template ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template id.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <returns></returns>
        void DeleteTemplate(string templateId, string onBehalfOf = default);

        /// <summary>
        ///     Deletes a template with the given template ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template id.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> DeleteTemplateWithHttpInfo(string templateId, string onBehalfOf = default);

        /// <summary>
        ///     List all the templates created.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="templateType">Gets or sets the templateType. (optional, default to all).</param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of emails.</param>
        /// <param name="createdBy">Gets or sets the created by.</param>
        /// <param name="templateLabels">Gets or sets the template labels.</param>
        /// <param name="startDate">Gets or sets the start date.</param>
        /// <param name="endDate">Gets or sets the end date.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <returns>TemplateRecords</returns>
        TemplateRecords ListTemplates(int page, int? pageSize = default, string searchKey = default, TemplateType? templateType = default, List<string> onBehalfOf = default, List<string> createdBy = default, List<string> templateLabels = default, DateTime? startDate = default, DateTime? endDate = default, List<string> brandIds = default);

        /// <summary>
        ///     List all the templates created.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="templateType">Gets or sets the templateType. (optional, default to all).</param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of emails.</param>
        /// <param name="createdBy">Gets or sets the created by.</param>
        /// <param name="templateLabels">Gets or sets the template labels.</param>
        /// <param name="startDate">Gets or sets the start date.</param>
        /// <param name="endDate">Gets or sets the end date.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <returns>ApiResponse of TemplateRecords</returns>
        ApiResponse<TemplateRecords> ListTemplatesWithHttpInfo(int page, int? pageSize = default, string searchKey = default, TemplateType? templateType = default, List<string> onBehalfOf = default, List<string> createdBy = default, List<string> templateLabels = default, DateTime? startDate = default, DateTime? endDate = default, List<string> brandIds = default);

        /// <summary>
        ///     Send a document for signature using a Template.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendForSignFromTemplate">It contains page,page size and status details. (optional)</param>
        /// <returns>DocumentCreated</returns>
        DocumentCreated SendUsingTemplate(SendForSignFromTemplate sendForSignFromTemplate = default);

        /// <summary>
        ///     Send a document for signature using a Template.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendForSignFromTemplate">It contains page,page size and status details. (optional)</param>
        /// <returns>ApiResponse of DocumentCreated</returns>
        ApiResponse<DocumentCreated> SendUsingTemplateWithHttpInfo(SendForSignFromTemplate sendForSignFromTemplate = default);

        /// <summary>
        ///  Generates a edit embed URL using a template id which embeds template edit process into your application.
        /// </summary>
        /// <param name="embedTemplateEdit">The embed template edit request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (EmbeddedTemplateEdited).</returns>
        EmbeddedTemplateEdited GetEmbeddedTemplateEditUrl(EmbeddedTemplateEditRequest embedTemplateEdit);

        /// <summary>
        ///  Generates a edit embed URL using a template id which embeds template edit process into your application.
        /// </summary>
        /// <param name="embeddedTemplateEditRequest">The embedded template edit request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (EmbeddedTemplateEdited).</returns>
        Task<EmbeddedTemplateEdited> GetEmbeddedTemplateEditUrlAsync(EmbeddedTemplateEditRequest embeddedTemplateEditRequest);

        /// <summary>
        ///  Generates a edit embed URL using a template id which embeds template edit process into your application.
        /// </summary>
        /// <param name="embedTemplateEdit">The embed template edit request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (EmbeddedTemplateEdited).</returns>
        ApiResponse<EmbeddedTemplateEdited> GetEmbeddedTemplateEditUrlWithHttpInfo(EmbeddedTemplateEditRequest embedTemplateEdit);

        /// <summary>
        ///  Generates a edit embed URL using a template id which embeds template edit process into your application.
        /// </summary>
        /// <param name="embeddedTemplateEditRequest">The embedded template edit request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (EmbeddedTemplateEdited).</returns>
        Task<ApiResponse<EmbeddedTemplateEdited>> GetEmbeddedTemplateEditUrlWithHttpInfoAsync(EmbeddedTemplateEditRequest embeddedTemplateEditRequest);

        /// <summary>
        ///     Download the template for given template ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="templateId">Template Id.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <returns>System.IO.Stream.</returns>
        Stream DownloadTemplate(string templateId, string onBehalfOf = default);

        /// <summary>
        ///    Download the template for given template ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="templateId">Template Id.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <returns>ApiResponse of System.IO.Stream.</returns>
        ApiResponse<Stream> DownloadTemplateWithHttpInfo(string templateId, string onBehalfOf = default);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Deletes a template with the given template ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template id.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <returns>Task of void</returns>
        Task DeleteTemplateAsync(string templateId, string onBehalfOf = default);

        /// <summary>
        ///     Deletes a template with the given template ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template id.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteTemplateAsyncWithHttpInfo(string templateId, string onBehalfOf = default);

        /// <summary>
        ///     List all the templates created.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="templateType">Gets or sets the templateType. (optional, default to all).</param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of emails.</param>
        /// <param name="createdBy">Gets or sets the created by.</param>
        /// <param name="templateLabels">Gets or sets the template labels.</param>
        /// <param name="startDate">Gets or sets the start date.</param>
        /// <param name="endDate">Gets or sets the end date.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <returns>Task of TemplateRecords</returns>
        Task<TemplateRecords> ListTemplatesAsync(int page, int? pageSize = default, string searchKey = default, TemplateType? templateType = default, List<string> onBehalfOf = default, List<string> createdBy = default, List<string> templateLabels = default,  DateTime? startDate = default, DateTime? endDate = default, List<string> brandIds = default);

        /// <summary>
        ///    List all the templates created.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="templateType">Gets or sets the templateType. (optional, default to all).</param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of emails.</param>
        /// <param name="createdBy">Gets or sets the created by.</param>
        /// <param name="templateLabels">Gets or sets the template labels.</param>
        /// <param name="startDate">Gets or sets the start date.</param>
        /// <param name="endDate">Gets or sets the end date.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <returns>Task of ApiResponse (TemplateRecords)</returns>
        Task<ApiResponse<TemplateRecords>> ListTemplatesAsyncWithHttpInfo(int page, int? pageSize = default, string searchKey = default, TemplateType? templateType = default, List<string> onBehalfOf = default, List<string> createdBy = default, List<string> templateLabels = default, DateTime? startDate = default, DateTime? endDate = default, List<string> brandIds = default);

        /// <summary>
        ///     Send a document for signature using a Template.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendForSignFromTemplate">It contains page,page size and status details. (optional)</param>
        /// <returns>Task of DocumentCreated</returns>
        Task<DocumentCreated> SendUsingTemplateAsync(SendForSignFromTemplate sendForSignFromTemplate = default);

        /// <summary>
        ///     Send a document for signature using a Template.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendForSignFromTemplate">It contains page,page size and status details. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentCreated)</returns>
        Task<ApiResponse<DocumentCreated>> SendUsingTemplateAsyncWithHttpInfo(SendForSignFromTemplate sendForSignFromTemplate = default);

        /// <summary>
        ///     Embedded send a document for signature using a template.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="send">It contains page,page size and status details.</param>
        /// <returns>An ApiResponse (DocumentCreated).</returns>
        EmbeddedSendCreated CreateEmbeddedRequestUrl(EmbeddedTemplateRequest send = default);

        /// <summary>
        ///     Embedded send a document for signature using a template.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="send">It contains page,page size and status details.</param>
        /// <returns>An ApiResponse (DocumentCreated).</returns>
        ApiResponse<EmbeddedSendCreated> CreateEmbeddedRequestUrlWithHttpInfo(EmbeddedTemplateRequest send = default);

        /// <summary>
        ///     Embedded send a document for signature using a template.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="send">It contains page,page size and status details.</param>
        /// <returns>Task of ApiResponse (DocumentCreated).</returns>
        Task<EmbeddedSendCreated> CreateEmbeddedRequestUrlAsync(EmbeddedTemplateRequest send = default);

        /// <summary>
        ///     Generates a send URL using a template which embeds document sending process into your application.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="send">It contains page,page size and status details.</param>
        /// <returns>Task of ApiResponse (DocumentCreated).</returns>
        Task<ApiResponse<EmbeddedSendCreated>> CreateEmbeddedRequestUrlAsyncWithHttpInfo(EmbeddedTemplateRequest send = default);

        /// <summary>
        ///     Embedded send document using multiple templates.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="mergeAndSend">It contains template id's, signer details, cc details, files, etc.</param>
        /// <returns>An ApiResponse (EmbeddedSendCreated).</returns>
        EmbeddedSendCreated MergeCreateEmbeddedRequestUrl(EmbeddedMergeTemplateRequest mergeAndSend = default);

        /// <summary>
        ///     Embedded send document using multiple templates.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="mergeAndSend">It contains template id's, signer details, cc details, files, etc.</param>
        /// <returns>An ApiResponse (EmbeddedSendCreated).</returns>
        ApiResponse<EmbeddedSendCreated> MergeCreateEmbeddedRequestUrlWithHttpInfo(EmbeddedMergeTemplateRequest mergeAndSend = default);

        /// <summary>
        ///     Embedded send document using multiple templates.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="mergeAndSend">It contains template id's, signer details, cc details, files, etc.</param>
        /// <returns>Task of ApiResponse (EmbeddedSendCreated).</returns>
        Task<EmbeddedSendCreated> MergeCreateEmbeddedRequestUrlAsync(EmbeddedMergeTemplateRequest mergeAndSend = default);

        /// <summary>
        ///     Embedded send document using multiple templates.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="mergeAndSend">It contains template id's, signer details, cc details, files, etc.</param>
        /// <returns>Task of ApiResponse (EmbeddedSendCreated).</returns>
        Task<ApiResponse<EmbeddedSendCreated>> MergeCreateEmbeddedRequestUrlAsyncWithHttpInfo(EmbeddedMergeTemplateRequest mergeAndSend = default);

        /// <summary>
        /// Creates a template.
        /// </summary>
        /// <param name="createTemplate">The create template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Template Created.</returns>
        TemplateCreated CreateTemplate(CreateTemplateRequest createTemplate);

        /// <summary>
        ///  Creates a template.
        /// </summary>
        /// <param name="createTemplate">The create template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Template created.</returns>
        Task<TemplateCreated> CreateTemplateAsync(CreateTemplateRequest createTemplate);

        /// <summary>
        ///  Creates a template.
        /// </summary>
        /// <param name="createTemplate">The create template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>ApiResponse of Template created.</returns>
        ApiResponse<TemplateCreated> CreateTemplateWithHttpInfo(CreateTemplateRequest createTemplate);

        /// <summary>
        /// Creates a template.
        /// </summary>
        /// <param name="createTemplate">The create template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>ApiResponse of Template Created.</returns>
        Task<ApiResponse<TemplateCreated>> CreateTemplateWithHttpInfoAsync(CreateTemplateRequest createTemplate);

        /// <summary>
        ///  Generates a create URL using a template which embeds template create process into your application.
        /// </summary>
        /// <param name="createTemplate">The create template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (EmbeddedTemplateCreated).</returns>
        EmbeddedTemplateCreated CreateEmbeddedTemplateUrl(CreateEmbeddedTemplateRequest createTemplate);

        /// <summary>
        ///  Generates a create URL using a template which embeds template create process into your application.
        /// </summary>
        /// <param name="createRequest">The create template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (EmbeddedTemplateCreated).</returns>
        Task<EmbeddedTemplateCreated> CreateEmbeddedTemplateUrlAsync(CreateEmbeddedTemplateRequest createRequest);

        /// <summary>
        ///  Generates a create URL using a template which embeds template create process into your application.
        /// </summary>
        /// <param name="createTemplate">The create template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (EmbeddedTemplateCreated).</returns>
        ApiResponse<EmbeddedTemplateCreated> CreateEmbeddedTemplateUrlWithHttpInfo(CreateEmbeddedTemplateRequest createTemplate);

        /// <summary>
        ///  Generates a create URL using a template which embeds template create process into your application.
        /// </summary>
        /// <param name="createRequest">The create template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (EmbeddedTemplateCreated).</returns>
        Task<ApiResponse<EmbeddedTemplateCreated>> CreateEmbeddedTemplateUrlWithHttpInfoAsync(CreateEmbeddedTemplateRequest createRequest);

        /// <summary>
        ///    Download the template for given template ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="templateId">Template Id.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <returns>Task of System.IO.Stream.</returns>
        Task<Stream> DownloadTemplateAsync(string templateId, string onBehalfOf = default);

        /// <summary>
        ///     Download the template for given template ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="templateId">Template Id.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream).</returns>
        Task<ApiResponse<Stream>> DownloadTemplateAsyncWithHttpInfo(string templateId, string onBehalfOf = default);

        /// <summary>
        ///     Get summary of the template for the given template ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="templateId">Template Id.</param>
        /// <returns>TemplateProperties.</returns>
        TemplateProperties GetProperties(string templateId);

        /// <summary>
        ///     Get summary of the template for the given template ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="templateId">Template Id.</param>
        /// <returns>ApiResponse of TemplateProperties.</returns>
        ApiResponse<TemplateProperties> GetPropertiesWithHttpInfo(string templateId);

        /// <summary>
        ///     Get summary of the template for the given template ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="templateId">Template Id.</param>
        /// <returns>Task of TemplateProperties.</returns>
        Task<TemplateProperties> GetPropertiesAsync(string templateId);

        /// <summary>
        ///    Get summary of the template for the given template ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="templateId">Template Id.</param>
        /// <returns>Task of ApiResponse (TemplateProperties).</returns>
        Task<ApiResponse<TemplateProperties>> GetPropertiesAsyncWithHttpInfo(string templateId);

        /// <summary>
        /// Edit and update a template.
        /// </summary>
        /// <param name="editTemplate">The edit template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        void EditTemplate(EditTemplateRequest editTemplate);

        /// <summary>
        /// Edit and update a template.
        /// </summary>
        /// <param name="editTemplate">The edit template request.</param>
        /// <returns>A Task.</returns>
        ApiResponse<object> EditTemplateWithHttpInfo(EditTemplateRequest editTemplate);

        /// <summary>
        /// Edit and update a template.
        /// </summary>
        /// <param name="editTemplate">The edit template request.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>A Task.</returns>
        Task EditTemplateAsync(EditTemplateRequest editTemplate);

        /// <summary>
        /// Edit and update a template.
        /// </summary>
        /// <param name="editTemplate">The edit template request.</param>
        /// <returns>A Task.</returns>
        Task<ApiResponse<object>> EditTemplateWithHttpInfoAsync(EditTemplateRequest editTemplate);

        #endregion Asynchronous Operations
    }
}
