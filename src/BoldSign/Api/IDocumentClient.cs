namespace BoldSign.Api
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using BoldSign.Client;
    using BoldSign.Model;

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentClient : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Changes the access code for the given document signer.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets the document id.</param>
        /// <param name="emailId">Gets or sets the signer email.</param>
        /// <param name="newAccessCode">The new access code.</param>
        /// <param name="signerOrder">
        ///     Gets or sets the signer&#39;s order.  When signer order is enabled for a document, this order is
        ///     used to target that particular order with given signer email. (optional)
        /// </param>
        /// <returns></returns>
        void ChangeAccessCode(string documentId, string emailId, string newAccessCode, int? signerOrder = default);

        /// <summary>
        ///     Changes the access code for the given document signer.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets the document id.</param>
        /// <param name="emailId">Gets or sets the signer email.</param>
        /// <param name="newAccessCode">The new access code.</param>
        /// <param name="zOrder">
        ///     Gets or sets the signer&#39;s order.  When signer order is enabled for a document, this order is
        ///     used to target that particular order with given signer email. (optional)
        /// </param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ChangeAccessCodeWithHttpInfo(string documentId, string emailId, string newAccessCode, int? zOrder = default);

        /// <summary>
        ///     Delete the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns></returns>
        void DeleteDocument(string documentId);

        /// <summary>
        ///     Delete the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> DeleteDocumentWithHttpInfo(string documentId);

        /// <summary>
        ///     Download the audit trail document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>System.IO.Stream</returns>
        Stream DownloadAuditLog(string documentId);

        /// <summary>
        ///     Download the audit trail document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<Stream> DownloadAuditLogWithHttpInfo(string documentId);

        /// <summary>
        ///     Download the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>System.IO.Stream</returns>
        Stream DownloadDocument(string documentId);

        /// <summary>
        ///     Download the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<Stream> DownloadDocumentWithHttpInfo(string documentId);

        /// <summary>
        ///     Get sign link for Embedded Sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="signerEmail">Gets or sets signer email.</param>
        /// <param name="signLinkValidTill">Gets or sets sign link expiration date (Valid Till). (optional)</param>
        /// <param name="redirectUrl">Gets or sets Redirect URL. (optional)</param>
        /// <returns>EmbeddedSigningLink</returns>
        EmbeddedSigningLink GetEmbeddedSignLink(string documentId, string signerEmail, DateTime? signLinkValidTill = default, string redirectUrl = default);

        /// <summary>
        ///     Get sign link for Embedded Sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="signerEmail">Gets or sets signer email.</param>
        /// <param name="signLinkValidTill">Gets or sets sign link expiration date (Valid Till). (optional)</param>
        /// <param name="redirectUrl">Gets or sets Redirect URL. (optional)</param>
        /// <returns>ApiResponse of EmbeddedSigningLink</returns>
        ApiResponse<EmbeddedSigningLink> GetEmbeddedSignLinkWithHttpInfo(string documentId, string signerEmail, DateTime? signLinkValidTill = default, string redirectUrl = default);

        /// <summary>
        ///     Get summary of the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>DocumentProperties</returns>
        DocumentProperties GetProperties(string documentId);

        /// <summary>
        ///     Get summary of the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>ApiResponse of DocumentProperties</returns>
        ApiResponse<DocumentProperties> GetPropertiesWithHttpInfo(string documentId);

        /// <summary>
        ///     List user documents.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="sentBy">Gets or sets the documentId. (optional)</param>
        /// <param name="recipients">Gets or sets the recipients. (optional)</param>
        /// <param name="startDate">Gets or sets the start date. (optional)</param>
        /// <param name="status">Gets or sets the status. (optional)</param>
        /// <param name="endDate">Gets or sets the endDate. (optional)</param>
        /// <param name="searchKey">Gets or sets the searchKey. (optional)</param>
        /// <returns>DocumentRecords</returns>
        DocumentRecords ListDocuments(int page, int? pageSize = default, List<string> sentBy = default, List<string> recipients = default, DateTime? startDate = default, List<Status> status = default, DateTime? endDate = default, string searchKey = default);

        /// <summary>
        ///     List user documents.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="sentBy">Gets or sets the documentId. (optional)</param>
        /// <param name="recipients">Gets or sets the recipients. (optional)</param>
        /// <param name="startDate">Gets or sets the start date. (optional)</param>
        /// <param name="status">Gets or sets the status. (optional)</param>
        /// <param name="endDate">Gets or sets the endDate. (optional)</param>
        /// <param name="searchKey">Gets or sets the searchKey. (optional)</param>
        /// <returns>ApiResponse of DocumentRecords</returns>
        ApiResponse<DocumentRecords> ListDocumentsWithHttpInfo(int page, int? pageSize = default, List<string> sentBy = default, List<string> recipients = default, DateTime? startDate = default, List<Status> status = default, DateTime? endDate = default, string searchKey = default);

        /// <summary>
        ///     Send reminder to pending signers.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="receiverEmails">Signer emails.</param>
        /// <param name="reminderMessage">Reminder Message for signers. (optional)</param>
        /// <returns></returns>
        void RemindDocument(string documentId, List<string> receiverEmails, ReminderMessage reminderMessage = default);

        /// <summary>
        ///     Send reminder to pending signers.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="receiverEmails">Signer emails.</param>
        /// <param name="reminderMessage">Reminder Message for signers. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> RemindDocumentWithHttpInfo(string documentId, List<string> receiverEmails, ReminderMessage reminderMessage = default);

        /// <summary>
        ///     Revoke the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="revokeMessage">RevokeDetails.</param>
        /// <returns></returns>
        void RevokeDocument(string documentId, string revokeMessage);

        /// <summary>
        ///     Revoke the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="revokeMessage">RevokeDetails.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> RevokeDocumentWithHttpInfo(string documentId, string revokeMessage);

        /// <summary>
        ///     Sends the document for sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>DocumentCreated</returns>
        DocumentCreated SendDocument(SendForSign signRequestDetails);

        /// <summary>
        ///     Sends the document for sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DocumentCreated</returns>
        ApiResponse<DocumentCreated> SendDocumentWithHttpInfo(SendForSign signRequestDetails);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Changes the access code for the given document signer.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets the document id.</param>
        /// <param name="emailId">Gets or sets the signer email.</param>
        /// <param name="newAccessCode">The new access code.</param>
        /// <param name="signerOrder">
        ///     Gets or sets the signer&#39;s order.  When signer order is enabled for a document, this order is
        ///     used to target that particular order with given signer email. (optional)
        /// </param>
        /// <returns>Task of void</returns>
        Task ChangeAccessCodeAsync(string documentId, string emailId, string newAccessCode, int? signerOrder = default);

        /// <summary>
        ///     Changes the access code for the given document signer.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets the document id.</param>
        /// <param name="emailId">Gets or sets the signer email.</param>
        /// <param name="newAccessCode">The new access code.</param>
        /// <param name="signerOrder">
        ///     Gets or sets the signer&#39;s order.  When signer order is enabled for a document, this order is
        ///     used to target that particular order with given signer email. (optional)
        /// </param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> ChangeAccessCodeAsyncWithHttpInfo(string documentId, string emailId, string newAccessCode, int? signerOrder = default);

        /// <summary>
        ///     Delete the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of void</returns>
        Task DeleteDocumentAsync(string documentId);

        /// <summary>
        ///     Delete the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteDocumentAsyncWithHttpInfo(string documentId);

        /// <summary>
        ///     Download the audit trail document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<Stream> DownloadAuditLogAsync(string documentId);

        /// <summary>
        ///     Download the audit trail document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        Task<ApiResponse<Stream>> DownloadAuditLogAsyncWithHttpInfo(string documentId);

        /// <summary>
        ///     Download the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<Stream> DownloadDocumentAsync(string documentId);

        /// <summary>
        ///     Download the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        Task<ApiResponse<Stream>> DownloadDocumentAsyncWithHttpInfo(string documentId);

        /// <summary>
        ///     Get sign link for Embedded Sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="signerEmail">Gets or sets signer email.</param>
        /// <param name="signLinkValidTill">Gets or sets sign link expiration date (Valid Till). (optional)</param>
        /// <param name="redirectUrl">Gets or sets Redirect URL. (optional)</param>
        /// <returns>Task of EmbeddedSigningLink</returns>
        Task<EmbeddedSigningLink> GetEmbeddedSignLinkAsync(string documentId, string signerEmail, DateTime? signLinkValidTill = default, string redirectUrl = default);

        /// <summary>
        ///     Get sign link for Embedded Sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="signerEmail">Gets or sets signer email.</param>
        /// <param name="signLinkValidTill">Gets or sets sign link expiration date (Valid Till). (optional)</param>
        /// <param name="redirectUrl">Gets or sets Redirect URL. (optional)</param>
        /// <returns>Task of ApiResponse (EmbeddedSigningLink)</returns>
        Task<ApiResponse<EmbeddedSigningLink>> GetEmbeddedSignLinkAsyncWithHttpInfo(string documentId, string signerEmail, DateTime? signLinkValidTill = default, string redirectUrl = default);

        /// <summary>
        ///     Get summary of the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of DocumentProperties</returns>
        Task<DocumentProperties> GetPropertiesAsync(string documentId);

        /// <summary>
        ///     Get summary of the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of ApiResponse (DocumentProperties)</returns>
        Task<ApiResponse<DocumentProperties>> GetPropertiesAsyncWithHttpInfo(string documentId);

        /// <summary>
        ///     List user documents.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="sentBy">Gets or sets the documentId. (optional)</param>
        /// <param name="recipients">Gets or sets the recipients. (optional)</param>
        /// <param name="startDate">Gets or sets the start date. (optional)</param>
        /// <param name="status">Gets or sets the status. (optional)</param>
        /// <param name="endDate">Gets or sets the endDate. (optional)</param>
        /// <param name="searchKey">Gets or sets the searchKey. (optional)</param>
        /// <returns>Task of DocumentRecords</returns>
        Task<DocumentRecords> ListDocumentsAsync(int page, int? pageSize = default, List<string> sentBy = default, List<string> recipients = default, DateTime? startDate = default, List<Status> status = default, DateTime? endDate = default, string searchKey = default);

        /// <summary>
        ///     List user documents.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="sentBy">Gets or sets the documentId. (optional)</param>
        /// <param name="recipients">Gets or sets the recipients. (optional)</param>
        /// <param name="startDate">Gets or sets the start date. (optional)</param>
        /// <param name="status">Gets or sets the status. (optional)</param>
        /// <param name="endDate">Gets or sets the endDate. (optional)</param>
        /// <param name="searchKey">Gets or sets the searchKey. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentRecords)</returns>
        Task<ApiResponse<DocumentRecords>> ListDocumentsAsyncWithHttpInfo(int page, int? pageSize = default, List<string> sentBy = default, List<string> recipients = default, DateTime? startDate = default, List<Status> status = default, DateTime? endDate = default, string searchKey = default);

        /// <summary>
        ///     Send reminder to pending signers.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="receiverEmails">Signer emails.</param>
        /// <param name="reminderMessage">Reminder Message for signers. (optional)</param>
        /// <returns>Task of void</returns>
        Task RemindDocumentAsync(string documentId, List<string> receiverEmails, ReminderMessage reminderMessage = default);

        /// <summary>
        ///     Send reminder to pending signers.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="receiverEmails">Signer emails.</param>
        /// <param name="reminderMessage">Reminder Message for signers. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> RemindDocumentAsyncWithHttpInfo(string documentId, List<string> receiverEmails, ReminderMessage reminderMessage = default);

        /// <summary>
        ///     Revoke the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="revokeMessage">RevokeDetails.</param>
        /// <returns>Task of void</returns>
        Task RevokeDocumentAsync(string documentId, string revokeMessage);

        /// <summary>
        ///     Revoke the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="revokeMessage">RevokeDetails.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> RevokeDocumentAsyncWithHttpInfo(string documentId, string revokeMessage);

        /// <summary>
        ///     Sends the document for sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DocumentCreated</returns>
        Task<DocumentCreated> SendDocumentAsync(SendForSign signRequestDetails);

        /// <summary>
        ///     Sends the document for sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DocumentCreated)</returns>
        Task<ApiResponse<DocumentCreated>> SendDocumentAsyncWithHttpInfo(SendForSign signRequestDetails);

        #endregion Asynchronous Operations
    }
}
