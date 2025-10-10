
namespace BoldSign.Api
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using BoldSign.Api.Model;
    using BoldSign.Model;

    /// <summary>
    ///  Represents a collection of functions to interact with the API endpoints. The functions perform actions such as sending document to sign, getting document list, deleting a document, downloading audit log, downloading a document, changing access code of the desired signer and so on.
    /// </summary>
    public interface IDocumentClient : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Change recipient details of a document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">The document id.</param>
        /// <param name="oldSignerEmail">The signer email.</param>
        /// <param name="reason">The reason for changing recipient details.</param>
        /// <param name="newSignerName">The new name of the recipient.</param>
        /// <param name="newSignerEmail">The new  email address of recipient.</param>
        /// <param name="signerOrder"> The signer order.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The signer phone number.</param>
        /// <param name="oldPhoneNumber">The Old Signer Phone Number.</param>
        void ChangeRecipient(string documentId, string oldSignerEmail = null, string reason = null, string newSignerName = null, string newSignerEmail = null, int? signerOrder = null, string onBehalfOf = null, PhoneNumber phoneNumber = null, PhoneNumber oldPhoneNumber = null);

        /// <summary>
        /// Change recipient details of a document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">The document id.</param>
        /// <param name="oldSignerEmail">The signer email.</param>
        /// <param name="reason">The reason for changing recipient details.</param>
        /// <param name="newSignerName">The new name of the recipient.</param>
        /// <param name="newSignerEmail">The new email address of recipient.</param>
        /// <param name="signerOrder"> The signer order.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The signer phone number.</param>
        /// <param name="oldPhoneNumber">The Old Signer phone number.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> ChangeRecipientWithHttpInfo(string documentId, string oldSignerEmail = null, string reason = null, string newSignerName = null, string newSignerEmail = null, int? signerOrder = null, string onBehalfOf = null, PhoneNumber phoneNumber = null, PhoneNumber oldPhoneNumber = null);

        /// <summary>
        ///     Changes the access code for the desired document signer by verifying the email ID of the signer.
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
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns></returns>
        void ChangeAccessCode(string documentId, string emailId = default, string newAccessCode = default, int? signerOrder = default, string onBehalfOf = default, PhoneNumber phoneNumber = default);

        /// <summary>
        ///     Changes the access code for the desired document signer by verifying the email ID of the signer.
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
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ChangeAccessCodeWithHttpInfo(string documentId, string emailId = default, string newAccessCode = default, int? zOrder = default, string onBehalfOf = default,  PhoneNumber phoneNumber = default);

        /// <summary>
        /// Add tag.
        /// </summary>
        /// <param name="addTags">Add Tags.</param>
        /// <returns></returns>
        void AddTag(DocumentTags addTags);

        /// <summary>
        /// Add tag with Http info.
        /// </summary>
        /// <param name="addTags">ets or sets the add tags.</param>
        /// <returns></returns>
        ApiResponse<object> AddTagWithHttpInfo(DocumentTags addTags);

        /// <summary>
        /// Add tag async.
        /// </summary>
        /// <param name="addTags">Gets or sets the add tags.</param>
        /// <returns></returns>
        Task AddTagAsync(DocumentTags addTags);

        /// <summary>
        /// Add tag async with Http info.
        /// </summary>
        /// <param name="addTags">Gets or sets the add tags.</param>
        /// <returns></returns>
        Task<ApiResponse<object>> AddTagAsyncWithHttpInfo(DocumentTags addTags);

        /// <summary>
        /// Delete tag.
        /// </summary>
        /// <param name="deleteTags">Gets or sets the delete tags.</param>
        void DeleteTag(DocumentTags deleteTags);

        /// <summary>
        /// Delete with Http info.
        /// </summary>
        /// <param name="deleteTags">Gets or sets the delete tags.</param>
        /// <returns></returns>
        ApiResponse<object> DeleteTagWithHttpInfo(DocumentTags deleteTags);

        /// <summary>
        /// Delete tag async.
        /// </summary>
        /// <param name="deleteTags">Gets or sets the delete tags.</param>
        /// <returns></returns>
        Task DeleteTagAsync(DocumentTags deleteTags);

        /// <summary>
        /// Delete tag async with Http info.
        /// </summary>
        /// <param name="deleteTags">Gets or sets the delete tags.</param>
        /// <returns></returns>
        Task<ApiResponse<object>> DeleteTagAsyncWithHttpInfo(DocumentTags deleteTags);

        /// <summary>
        /// List team documents.
        /// </summary>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size.</param>
        /// <param name="startDate">Gets or sets the start date.</param>
        /// <param name="status">Gets or sets the status.</param>
        /// <param name="teamId">Gets or sets the team id.</param>
        /// <param name="userId">Gets or sets the user id.</param>
        /// <param name="endDate">Gets or sets the end date.</param>
        /// <param name="searchKey">Gets or sets the search key.</param>
        /// <param name="labels">Gets or sets the labels.</param>
        /// <param name="transmitType">Gets or sets the transmit type.</param>
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <param name="dateFilterType">dateFilterType.</param>
        /// <returns></returns>
        TeamDocumentRecords ListTeamDocuments(int page = 1, int? pageSize = default, DateTime? startDate = default,
            List<Status> status = default, List<string> teamId = default, List<string> userId = default,
            DateTime? endDate = default, string searchKey = default, List<string> labels = default,
            TransmitType? transmitType = default, long? nextCursor = default, List<string> brandIds = default, DateFilterType? dateFilterType = default);

        /// <summary>
        /// List team documents with Http info.
        /// </summary>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size.</param>
        /// <param name="startDate">Gets or sets the start date.</param>
        /// <param name="status">Gets or sets the status.</param>
        /// <param name="teamId">Gets or sets the team id.</param>
        /// <param name="userId">Gets or sets the user id.</param>
        /// <param name="endDate">Gets or sets the end date.</param>
        /// <param name="searchKey">Gets or sets the search key.</param>
        /// <param name="labels">Gets or sets the labels.</param>
        /// <param name="transmitType">Gets or sets the transmit type.</param>
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <param name="dateFilterType">dateFilterType.</param>
        /// <returns></returns>
        ApiResponse<TeamDocumentRecords> ListTeamDocumentsWithHttpInfo(int page = 1, int? pageSize = default,
            DateTime? startDate = default, List<Status> status = default, List<string> teamId = default,
            List<string> userId = default, DateTime? endDate = default, string searchKey = default,
            List<string> labels = default, TransmitType? transmitType = default, long? nextCursor = default, List<string> brandIds = default, DateFilterType? dateFilterType = default);

        /// <summary>
        /// List team documents async.
        /// </summary>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size.</param>
        /// <param name="startDate">Gets or sets the start date.</param>
        /// <param name="status">Gets or sets the status.</param>
        /// <param name="teamId">Gets or sets the team id.</param>
        /// <param name="userId">Gets or sets the user id.</param>
        /// <param name="endDate">Gets or sets the end date.</param>
        /// <param name="searchKey">Gets or sets the search key.</param>
        /// <param name="labels">Gets or sets the labels.</param>
        /// <param name="transmitType">Gets or sets the transmit type.</param>
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <param name="dateFilterType">dateFilterType.</param>
        /// <returns></returns>
        Task<TeamDocumentRecords> ListTeamDocumentsAsync(int page = 1, int? pageSize = default,
            DateTime? startDate = default, List<Status> status = default, List<string> teamId = default,
            List<string> userId = default, DateTime? endDate = default, string searchKey = default,
            List<string> labels = default, TransmitType? transmitType = default, long? nextCursor = default,  List<string> brandIds = default, DateFilterType? dateFilterType = default);

        /// <summary>
        /// List team documents async with Http info.
        /// </summary>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size.</param>
        /// <param name="startDate">Gets or sets the start date.</param>
        /// <param name="status">Gets or sets the status.</param>
        /// <param name="teamId">Gets or sets the team id.</param>
        /// <param name="userId">Gets or sets the user id.</param>
        /// <param name="endDate">Gets or sets the end date.</param>
        /// <param name="searchKey">Gets or sets the search key.</param>
        /// <param name="labels">Gets or sets the labels.</param>
        /// <param name="transmitType">Gets or sets the transmit type.</param>
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <param name="dateFilterType">dateFilterType.</param>
        /// <returns></returns>
        Task<ApiResponse<TeamDocumentRecords>> ListTeamDocumentsAsyncWithHttpInfo(int page = 1, int? pageSize = default,
            DateTime? startDate = default, List<Status> status = default, List<string> teamId = default,
            List<string> userId = default, DateTime? endDate = default, string searchKey = default,
            List<string> labels = default, TransmitType? transmitType = default, long? nextCursor = default,  List<string> brandIds = default, DateFilterType? dateFilterType = default);

        /// <summary>
        ///     Delete the document when a particular document’s ID is given as input.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="deletePermanently">
        /// if true, the document will be deleted permanently.
        /// if false, the document will be moved to the trash.
        /// </param>
        /// <returns></returns>
        void DeleteDocument(string documentId,  bool deletePermanently = false);

        /// <summary>
        ///     Delete the document when a particular document’s ID is given as input.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="deletePermanently">
        /// if true, the document will be deleted permanently.
        /// if false, the document will be moved to the trash.
        /// </param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> DeleteDocumentWithHttpInfo(string documentId,  bool deletePermanently = false);

        /// <summary>
        ///     Download the audit trail document for a particular document with given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of email.</param>
        /// <returns>System.IO.Stream</returns>
        Stream DownloadAuditLog(string documentId, string onBehalfOf = default);

        /// <summary>
        ///     Download the audit trail document for a particular document with given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of email.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<Stream> DownloadAuditLogWithHttpInfo(string documentId, string onBehalfOf = default);

        /// <summary>
        ///     Download the document for given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>System.IO.Stream</returns>
        Stream DownloadDocument(string documentId, string onBehalfOf = default);

        /// <summary>
        ///    Download the document for given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<Stream> DownloadDocumentWithHttpInfo(string documentId, string onBehalfOf = default);

        /// <summary>
        ///    Download the attachment for given document ID and attachment ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="attachmentId">attachmentId.</param>
        /// <param name="onBehalfOf">OnBehalfOf Email.</param>
        /// <returns>System.IO.Stream.</returns>
        Stream DownloadAttachment(string documentId, string attachmentId, string onBehalfOf = null);

        /// <summary>
        ///   Download the attachment for given document ID and attachment ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="attachmentId">attachmentId.</param>
        /// <param name="onBehalfOf">OnBehalfOf Email.</param>
        /// <returns>ApiResponse of System.IO.Stream.</returns>
        ApiResponse<Stream> DownloadAttachmenttWithHttpInfo(string documentId, string attachmentId, string onBehalfOf = null);

        /// <summary>
        ///    Get sign link in a mail for Embedded Sign to given Email ID. The link has expiry time. This method can also be used to send a redirect URL.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="signerEmail">Gets or sets signer email. (optional)</param>
        /// <param name="signLinkValidTill">Gets or sets sign link expiration date (Valid Till). (optional)</param>
        /// <param name="redirectUrl">Gets or sets Redirect URL. (optional)</param>
        /// <param name="countryCode">Gets or sets Country Code. (optional)</param>
        /// <param name="phoneNumber">Gets or sets Phone Number. (optional)</param>
        /// <returns>EmbeddedSigningLink</returns>
        EmbeddedSigningLink GetEmbeddedSignLink(string documentId, string signerEmail = default, DateTime? signLinkValidTill = default, string redirectUrl = default, string countryCode = default, string phoneNumber = default);

        /// <summary>
        ///    Get sign link in a mail for Embedded Sign to given Email ID. The link has expiry time. This method can also be used to send a redirect URL.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="signerEmail">Gets or sets signer email. (optional)</param>
        /// <param name="signLinkValidTill">Gets or sets sign link expiration date (Valid Till). (optional)</param>
        /// <param name="redirectUrl">Gets or sets Redirect URL. (optional)</param>
        /// <param name="countryCode">Gets or sets Country Code. (optional)</param>
        /// <param name="phoneNumber">Gets or sets Phone Number. (optional)</param>
        /// <returns>ApiResponse of EmbeddedSigningLink</returns>
        ApiResponse<EmbeddedSigningLink> GetEmbeddedSignLinkWithHttpInfo(string documentId, string signerEmail = default, DateTime? signLinkValidTill = default, string redirectUrl = default, string countryCode = default, string phoneNumber = default);

        /// <summary>
        ///     Get summary of the document for the given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>DocumentProperties</returns>
        DocumentProperties GetProperties(string documentId);

        /// <summary>
        ///     Get summary of the document for the given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>ApiResponse of DocumentProperties</returns>
        ApiResponse<DocumentProperties> GetPropertiesWithHttpInfo(string documentId);

        /// <summary>
        ///     List all user documents which can be filtered by date, time, sender, status, and so on.
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
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <param name="dateFilterType">dateFilterType.</param>
        /// <returns>DocumentRecords</returns>
        DocumentRecords ListDocuments(int page = 1, int? pageSize = default, List<string> sentBy = default, List<string> recipients = default, DateTime? startDate = default, List<Status> status = default, DateTime? endDate = default, string searchKey = default, List<string> labels = default, TransmitType? transmitType = default, long? nextCursor = default, List<string> brandIds = default, DateFilterType? dateFilterType = default);

        /// <summary>
        ///    List all user documents which can be filtered by date, time, sender, status, and so on.
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
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <param name="dateFilterType">dateFilterType.</param>
        /// <returns>ApiResponse of DocumentRecords</returns>
        ApiResponse<DocumentRecords> ListDocumentsWithHttpInfo(int page = 1, int? pageSize = default, List<string> sentBy = default, List<string> recipients = default, DateTime? startDate = default, List<Status> status = default, DateTime? endDate = default, string searchKey = default, List<string> labels = default, TransmitType? transmitType = default, long? nextCursor = default,  List<string> brandIds = default, DateFilterType? dateFilterType = default);

        /// <summary>
        ///     List of behalf documents which can be filtered by status, page size and so on.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="page">Gets or sets the page index specified in get document list request.</param>
        /// <param name="pageSize">Gets or sets the page size specified in get document list request. (optional, default to 10).</param>
        /// <param name="emailAddress">Gets or sets the sender identity's email used to filter the documents returned in the API. The API will return documents that were sent on behalf of the specified email address. (optional).</param>
        /// <param name="status">Gets or sets the status used to filter documents based on their current status, including In-progress, Completed, Declined, Expired, and Revoked. (optional).</param>
        /// <param name="searchKey">Gets or sets the search key used to filter the documents returned in the API. The API will return documents that contain the search key in the document title, document ID, sender or signer(s) name, etc. (optional).</param>
        /// <param name="pageType">Gets or sets the page type used to differentiate between documents sent on the user's behalf and documents sent by the user on behalf of others. The API will return documents based on the specified value. (optional).</param>
        /// <param name="startDate">Gets or sets the start date used to filter the documents returned in the API. The API will return documents that were created on or after this date (optional).</param>
        /// <param name="endDate">Gets or sets the endDate used to filter the documents returned in the API. The API will return documents that were created on or before this date. (optional).</param>
        /// <param name="signers">Gets or sets the list of signer email addresses used to filter the documents returned in the API. The API will return documents where the signer's email address matches one of the email addresses provided in this list. (optional).</param>
        /// <param name="labels">Gets or sets the list of labels or tags used to filter the documents returned in the API. The API will return documents that have been tagged with one or more of the labels provided in this list. (optional).</param>
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">The list of brand IDs to filter associated with the behalf documents.</param>
        /// <returns>BehalfDocumentRecords.</returns>
        BehalfDocumentRecords ListBehalfDocuments(
            int page = 1,
            int? pageSize = default,
            List<string> emailAddress = default,
            List<Status> status = default,
            string searchKey = default,
            PageType? pageType = default,
            DateTime? startDate = default,
            DateTime? endDate = default,
            List<string> signers = default,
            List<string> labels = default,
            long? nextCursor = default,
            List<string> brandIds = default);
        /// <summary>
        ///     List of behalf documents which can be filtered by status, page size and so on.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="page">Gets or sets the page index specified in get document list request.</param>
        /// <param name="pageSize">Gets or sets the page size specified in get document list request. (optional, default to 10).</param>
        /// <param name="emailAddress">Gets or sets the sender identity's email used to filter the documents returned in the API. The API will return documents that were sent on behalf of the specified email address. (optional).</param>
        /// <param name="status">Gets or sets the status used to filter documents based on their current status, including In-progress, Completed, Declined, Expired, and Revoked. (optional).</param>
        /// <param name="searchKey">Gets or sets the search key used to filter the documents returned in the API. The API will return documents that contain the search key in the document title, document ID, sender or signer(s) name, etc. (optional).</param>
        /// <param name="pageType">Gets or sets the page type used to differentiate between documents sent on the user's behalf and documents sent by the user on behalf of others. The API will return documents based on the specified value. (optional).</param>
        /// <param name="startDate">Gets or sets the start date used to filter the documents returned in the API. The API will return documents that were created on or after this date (optional).</param>
        /// <param name="endDate">Gets or sets the endDate used to filter the documents returned in the API. The API will return documents that were created on or before this date. (optional).</param>
        /// <param name="signers">Gets or sets the list of signer email addresses used to filter the documents returned in the API. The API will return documents where the signer's email address matches one of the email addresses provided in this list. (optional).</param>
        /// <param name="labels">Gets or sets the list of labels or tags used to filter the documents returned in the API. The API will return documents that have been tagged with one or more of the labels provided in this list. (optional).</param>
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">The list of brand IDs to filter associated with the behalf documents.</param>
        /// <returns>ApiResponse of BehalfDocumentRecords.</returns>
        ApiResponse<BehalfDocumentRecords> ListBehalfDocumentsWithHttpInfo(
            int page = 1,
            int? pageSize = default,
            List<string> emailAddress = default,
            List<Status> status = default,
            string searchKey = default,
            PageType? pageType = default,
            DateTime? startDate = default,
            DateTime? endDate = default,
            List<string> signers = default,
            List<string> labels = default,
            long? nextCursor = default,
            List<string> brandIds = default);

        /// <summary>
        ///    Send a reminder message to pending signers for a particular document to their respective email IDs.
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
        ///     Send a reminder message to pending signers for a particular document to their respective email IDs.
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
        ///    Revoke the document with the given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="revokeMessage">RevokeDetails.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns></returns>
        void RevokeDocument(string documentId, string revokeMessage, string onBehalfOf = default);

        /// <summary>
        ///     Revoke the document with the given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="revokeMessage">RevokeDetails.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> RevokeDocumentWithHttpInfo(string documentId, string revokeMessage, string onBehalfOf = default);

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

        /// <summary>
        /// Sends the draft document from API for sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>DocumentCreated</returns>
        DocumentCreated SendDocumentFromDraft(string  documentId);

        /// <summary>
        /// Sends the draft document from API for sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DocumentCreated</returns>
        ApiResponse<DocumentCreated> SendDocumentFromDraftWithHttpInfo(string  documentId);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///      Changes the access code for the desired document signer by verifying the email ID of the signer.
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
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns>Task of void</returns>
        Task ChangeAccessCodeAsync(string documentId, string emailId = default, string newAccessCode = default, int? signerOrder = default, string onBehalfOf = default, PhoneNumber phoneNumber = default);

        /// <summary>
        ///     Changes the access code for the desired document signer by verifying the email ID of the signer.
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
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> ChangeAccessCodeAsyncWithHttpInfo(string documentId, string emailId = default, string newAccessCode = default, int? signerOrder = default, string onBehalfOf = default, PhoneNumber phoneNumber = default);

        /// <summary>
        ///     Delete the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="deletePermanently">
        /// if true, the document will be deleted permanently.
        /// if false, the document will be moved to the trash.
        /// </param>
        /// <returns>Task of void</returns>
        Task DeleteDocumentAsync(string documentId,  bool deletePermanently = false);

        /// <summary>
        ///     Delete the document.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="deletePermanently">
        /// if true, the document will be deleted permanently.
        /// if false, the document will be moved to the trash.
        /// </param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteDocumentAsyncWithHttpInfo(string documentId,  bool deletePermanently = false);

        /// <summary>
        ///    Download the audit trail document for a particular document with given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of email.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<Stream> DownloadAuditLogAsync(string documentId, string onBehalfOf = default);

        /// <summary>
        ///     Download the audit trail document for a particular document with given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of email.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        Task<ApiResponse<Stream>> DownloadAuditLogAsyncWithHttpInfo(string documentId, string onBehalfOf = default);

        /// <summary>
        ///    Download the document for given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<Stream> DownloadDocumentAsync(string documentId, string onBehalfOf = default);

        /// <summary>
        ///     Download the document for given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        Task<ApiResponse<Stream>> DownloadDocumentAsyncWithHttpInfo(string documentId, string onBehalfOf = default);

        /// <summary>
        ///     Download the attachment for given document ID and attachment ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="attachmentId">Attachment Id.</param>
        /// <param name="onBehalfOf">OnBehalfOf Email.</param>
        /// <returns>Task of System.IO.Stream.</returns>
        Task<Stream> DownloadAttachmentAsync(string documentId, string attachmentId, string onBehalfOf = null);

        /// <summary>
        ///     Download the attachment for given document ID and attachment ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="attachmentId">Attachment Id.</param>
        /// <param name="onBehalfOf">OnBehalfOf Email.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream).</returns>
        Task<ApiResponse<Stream>> DownloadAttachmentAsyncWithHttpInfo(string documentId, string attachmentId, string onBehalfOf = null);

        /// <summary>
        ///     Get sign link in a mail for Embedded Sign to given Email ID. The link has expiry time. This method can also be used to send a redirect URL.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="signerEmail">Gets or sets signer email. (optional)</param>
        /// <param name="signLinkValidTill">Gets or sets sign link expiration date (Valid Till). (optional)</param>
        /// <param name="redirectUrl">Gets or sets Redirect URL. (optional)</param>
        /// <param name="countryCode">Gets or sets Country Code. (optional)</param>
        /// <param name="phoneNumber">Gets or sets Phone Number. (optional)</param>
        /// <returns>Task of EmbeddedSigningLink</returns>
        Task<EmbeddedSigningLink> GetEmbeddedSignLinkAsync(string documentId, string signerEmail = default, DateTime? signLinkValidTill = default, string redirectUrl = default, string countryCode = default, string phoneNumber = default);

        /// <summary>
        ///     Get sign link in a mail for Embedded Sign to given Email ID. The link has expiry time. This method can also be used to send a redirect URL.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets Document Id.</param>
        /// <param name="signerEmail">Gets or sets signer email. (optional)</param>
        /// <param name="signLinkValidTill">Gets or sets sign link expiration date (Valid Till). (optional)</param>
        /// <param name="redirectUrl">Gets or sets Redirect URL. (optional)</param>
        /// <param name="countryCode">Gets or sets Country Code. (optional)</param>
        /// <param name="phoneNumber">Gets or sets Phone Number. (optional)</param>
        /// <returns>Task of ApiResponse (EmbeddedSigningLink)</returns>
        Task<ApiResponse<EmbeddedSigningLink>> GetEmbeddedSignLinkAsyncWithHttpInfo(string documentId, string signerEmail = default, DateTime? signLinkValidTill = default, string redirectUrl = default, string countryCode = default, string phoneNumber = default);

        /// <summary>
        ///     Get summary of the document for the given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of DocumentProperties</returns>
        Task<DocumentProperties> GetPropertiesAsync(string documentId);

        /// <summary>
        ///    Get summary of the document for the given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <returns>Task of ApiResponse (DocumentProperties)</returns>
        Task<ApiResponse<DocumentProperties>> GetPropertiesAsyncWithHttpInfo(string documentId);

        /// <summary>
        ///     List all user documents which can be filtered by date, time, sender, status, and so on.
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
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <param name="dateFilterType">dateFilterType.</param>
        /// <returns>Task of DocumentRecords</returns>
        Task<DocumentRecords> ListDocumentsAsync(int page = 1, int? pageSize = default, List<string> sentBy = default, List<string> recipients = default, DateTime? startDate = default, List<Status> status = default, DateTime? endDate = default, string searchKey = default, List<string> labels = default, TransmitType? transmitType = default, long? nextCursor = default, List<string> brandIds = default, DateFilterType? dateFilterType = default);

        /// <summary>
        ///    List all user documents which can be filtered by date, time, sender, status, and so on.
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
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">Gets or sets the brandIds.</param>
        /// <param name="dateFilterType">dateFilterType.</param>
        /// <returns>Task of ApiResponse (DocumentRecords)</returns>
        Task<ApiResponse<DocumentRecords>> ListDocumentsAsyncWithHttpInfo(int page = 1, int? pageSize = default, List<string> sentBy = default, List<string> recipients = default, DateTime? startDate = default, List<Status> status = default, DateTime? endDate = default, string searchKey = default, List<string> labels = default, TransmitType? transmitType = default, long? nextCursor = default, List<string> brandIds = default, DateFilterType? dateFilterType = default);

        /// <summary>
        ///     List of behalf documents which can be filtered by status, page size and so on.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="page">Gets or sets the page index specified in get document list request.</param>
        /// <param name="pageSize">Gets or sets the page size specified in get document list request. (optional, default to 10).</param>
        /// <param name="emailAddress">Gets or sets the sender identity's email used to filter the documents returned in the API. The API will return documents that were sent on behalf of the specified email address. (optional).</param>
        /// <param name="status">Gets or sets the status used to filter documents based on their current status, including In-progress, Completed, Declined, Expired, and Revoked. (optional).</param>
        /// <param name="searchKey">Gets or sets the search key used to filter the documents returned in the API. The API will return documents that contain the search key in the document title, document ID, sender or signer(s) name, etc. (optional).</param>
        /// <param name="pageType">Gets or sets the page type used to differentiate between documents sent on the user's behalf and documents sent by the user on behalf of others. The API will return documents based on the specified value. (optional).</param>
        /// <param name="startDate">Gets or sets the start date used to filter the documents returned in the API. The API will return documents that were created on or after this date (optional).</param>
        /// <param name="endDate">Gets or sets the endDate used to filter the documents returned in the API. The API will return documents that were created on or before this date. (optional).</param>
        /// <param name="signers">Gets or sets the list of signer email addresses used to filter the documents returned in the API. The API will return documents where the signer's email address matches one of the email addresses provided in this list. (optional).</param>
        /// <param name="labels">Gets or sets the list of labels or tags used to filter the documents returned in the API. The API will return documents that have been tagged with one or more of the labels provided in this list. (optional).</param>
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">The list of brand IDs to filter associated with the behalf documents.</param>
        /// <returns>Task of BehalfDocumentRecords.</returns>
        Task<BehalfDocumentRecords> ListBehalfDocumentsAsync(
            int page = 1,
            int? pageSize = default,
            List<string> emailAddress = default,
            List<Status> status = default,
            string searchKey = default,
            PageType? pageType = default,
            DateTime? startDate = default,
            DateTime? endDate = default,
            List<string> signers = default,
            List<string> labels = default,
            long? nextCursor = default,
            List<string> brandIds = default);

        /// <summary>
        ///    List of behalf documents which can be filtered by status, page size and so on.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="page">Gets or sets the page index specified in get document list request.</param>
        /// <param name="pageSize">Gets or sets the page size specified in get document list request. (optional, default to 10).</param>
        /// <param name="emailAddress">Gets or sets the sender identity's email used to filter the documents returned in the API. The API will return documents that were sent on behalf of the specified email address. (optional).</param>
        /// <param name="status">Gets or sets the status used to filter documents based on their current status, including In-progress, Completed, Declined, Expired, and Revoked. (optional).</param>
        /// <param name="searchKey">Gets or sets the search key used to filter the documents returned in the API. The API will return documents that contain the search key in the document title, document ID, sender or signer(s) name, etc. (optional).</param>
        /// <param name="pageType">Gets or sets the page type used to differentiate between documents sent on the user's behalf and documents sent by the user on behalf of others. The API will return documents based on the specified value. (optional).</param>
        /// <param name="startDate">Gets or sets the start date used to filter the documents returned in the API. The API will return documents that were created on or after this date (optional).</param>
        /// <param name="endDate">Gets or sets the endDate used to filter the documents returned in the API. The API will return documents that were created on or before this date. (optional).</param>
        /// <param name="signers">Gets or sets the list of signer email addresses used to filter the documents returned in the API. The API will return documents where the signer's email address matches one of the email addresses provided in this list. (optional).</param>
        /// <param name="labels">Gets or sets the list of labels or tags used to filter the documents returned in the API. The API will return documents that have been tagged with one or more of the labels provided in this list. (optional).</param>
        /// <param name="nextCursor">Gets or sets the nextCursor.</param>
        /// <param name="brandIds">The list of brand IDs to filter associated with the behalf documents.</param>
        /// <returns>Task of ApiResponse (BehalfDocumentRecords).</returns>
        Task<ApiResponse<BehalfDocumentRecords>> ListBehalfDocumentsAsyncWithHttpInfo(
            int page = 1,
            int? pageSize = default,
            List<string> emailAddress = default,
            List<Status> status = default,
            string searchKey = default,
            PageType? pageType = default,
            DateTime? startDate = default,
            DateTime? endDate = default,
            List<string> signers = default,
            List<string> labels = default,
            long? nextCursor = default,
            List<string> brandIds = default);

        /// <summary>
        ///    Send a reminder message to pending signers for a particular document to their respective email IDs.
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
        ///     Send a reminder message to pending signers for a particular document to their respective email IDs.
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
        /// Add Authentication to user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">DocumentId.</param>
        /// <param name="emailId">EmailID.</param>
        /// <param name="authenticationType">AuthenticationType.</param>
        /// <param name="signerOrder">SignerOrder.</param>
        /// <param name="newAccessCode">NewAccesscode.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="identityVerificationSettings">The identity verification settings.</param>
        /// <param name="authenticationRetryCount">The authentication retry count.</param>
        /// <param name="authenticationSettings">The authentication settings.</param>
        void AddAuthentication(
            string documentId,
            string emailId = default,
            AuthenticationType authenticationType = default,
            int? signerOrder = default,
            string newAccessCode = "",
            string onBehalfOf = default,
            PhoneNumber phoneNumber = default,
            IdentityVerificationSettings identityVerificationSettings = default,
            int? authenticationRetryCount = default,
            AuthenticationSettings authenticationSettings = default);

        /// <summary>
        /// Add Authentication to user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">DocumentId.</param>
        /// <param name="emailId">EmailID.</param>
        /// <param name="authenticationType">AuthenticationType.</param>
        /// <param name="signerOrder">SignerOrder.</param>
        /// <param name="newAccessCode">NewAccesscode.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="identityVerificationSettings">The identity verification settings.</param>
        /// <param name="authenticationRetryCount">The authentication retry count.</param>
        /// <param name="authenticationSettings">The authentication settings.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> AddAuthenticationWithHttpInfo(
            string documentId,
            string emailId = default,
            AuthenticationType authenticationType = default,
            int? signerOrder = default,
            string newAccessCode = "",
            string onBehalfOf = default,
            PhoneNumber phoneNumber = default,
            IdentityVerificationSettings identityVerificationSettings = default,
            int? authenticationRetryCount = default,
            AuthenticationSettings authenticationSettings = default);

        /// <summary>
        /// Add Authentication to user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">DocumentId.</param>
        /// <param name="emailId">EmailID.</param>
        /// <param name="authenticationType">AuthenticationType.</param>
        /// <param name="signerOrder">SignerOrder.</param>
        /// <param name="newAccessCode">NewAccesscode.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="identityVerificationSettings">The identity verification settings.</param>
        /// <param name="authenticationRetryCount">The authentication retry count.</param>
        /// <param name="authenticationSettings">The authentication settings.</param>
        /// <returns>AddAuthentication.</returns>
        Task AddAuthenticationAsync(
            string documentId,
            string emailId = default,
            AuthenticationType authenticationType = default,
            int? signerOrder = default,
            string newAccessCode = "",
            string onBehalfOf = default,
            PhoneNumber phoneNumber = default,
            IdentityVerificationSettings identityVerificationSettings = default,
            int? authenticationRetryCount = default,
            AuthenticationSettings authenticationSettings = default);

        /// <summary>
        /// Add Authentication to user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">DocumentId.</param>
        /// <param name="emailId">EmailID.</param>
        /// <param name="authenticationType">AuthenticationType.</param>
        /// <param name="signerOrder">SignerOrder.</param>
        /// <param name="newAccessCode">NewAccesscode.</param>
        /// <param name="onBehalfOf">The on behalf of email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="identityVerificationSettings">The identity verification settings.</param>
        /// <param name="authenticationRetryCount">The authentication retry count.</param>
        /// <param name="authenticationSettings">The authentication settings.</param>
        /// <returns>ApiResponse of Object(AddAuthentication).</returns>
        Task<ApiResponse<object>> AddAuthenticationAsyncWithHttpInfo(
            string documentId,
            string emailId = default,
            AuthenticationType authenticationType = default,
            int? signerOrder = default,
            string newAccessCode = "",
            string onBehalfOf = default,
            PhoneNumber phoneNumber = default,
            IdentityVerificationSettings identityVerificationSettings = default,
            int? authenticationRetryCount = default,
            AuthenticationSettings authenticationSettings = default);

        /// <summary>
        ///     Revoke the document with the given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="revokeMessage">RevokeDetails.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>Task of void</returns>
        Task RevokeDocumentAsync(string documentId, string revokeMessage, string onBehalfOf = default);

        /// <summary>
        ///     Revoke the document with the given document ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document Id.</param>
        /// <param name="revokeMessage">RevokeDetails.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> RevokeDocumentAsyncWithHttpInfo(string documentId, string revokeMessage, string onBehalfOf = default);

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

        /// <summary>
        ///     Embedded sends the document and generates a URL to embedded that document into iframe.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="sendRequest">The signRequestDetails.</param>
        /// <returns>EmbeddedSendCreated.</returns>
        EmbeddedSendCreated CreateEmbeddedRequestUrl(EmbeddedDocumentRequest sendRequest);

        /// <summary>
        ///     Embedded sends the document and generates a URL to embedded that document into iframe.
        /// </summary>
        /// <param name="sendRequest">The signRequestDetails.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>ApiResponse of EmbeddedSendCreated.</returns>
        ApiResponse<EmbeddedSendCreated> CreateEmbeddedRequestUrlWithHttpInfo(EmbeddedDocumentRequest sendRequest);

        /// <summary>
        ///     Generates a send URL which embeds document sending process into your application.
        /// </summary>
        /// <param name="sendRequest">The signRequestDetails.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of EmbeddedSendCreated.</returns>
        Task<EmbeddedSendCreated> CreateEmbeddedRequestUrlAsync(EmbeddedDocumentRequest sendRequest);

        /// <summary>
        ///     Embedded sends the document and generates a URL to embedded that document into iframe.
        /// </summary>
        /// <param name="sendRequest">The signRequestDetails.</param>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of ApiResponse (EmbeddedSendCreated).</returns>
        Task<ApiResponse<EmbeddedSendCreated>> CreateEmbeddedRequestUrlAsyncWithHttpInfo(EmbeddedDocumentRequest sendRequest);

        /// <summary>
        ///     Remove Authentication to user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">DocumentId.</param>
        /// <param name="emailId">EmailID.</param>
        /// <param name="signerOrder">SignerOrder.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        void RemoveAuthentication(string documentId, string emailId = default, int? signerOrder = default, string onBehalfOf = default, PhoneNumber phoneNumber = default);

        /// <summary>
        ///     Remove Authentication to user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets the document id.</param>
        /// <param name="emailId">Gets or sets the signer email.</param>
        /// <param name="zOrder">
        ///     Gets or sets the signer&#39;s order.  When signer order is enabled for a document, this order is
        ///     used to target that particular order with given signer email. (optional)
        /// </param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> RemoveAuthenticationWithHttpInfo(string documentId, string emailId = default, int? signerOrder = default, string onBehalfOf = default, PhoneNumber phoneNumber = default);

        /// <summary>
        ///     Remove Authentication to user.
        ///</summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets the document id.</param>
        /// <param name="emailId">Gets or sets the signer email.</param>
        /// <param name="signerOrder">
        ///     Gets or sets the signer&#39;s order.  When signer order is enabled for a document, this order is
        ///     used to target that particular order with given signer email. (optional)
        /// </param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>Task of void</returns>
        Task RemoveAuthenticationAsync(string documentId, string emailId = default, int? signerOrder = default, string onBehalfOf = default, PhoneNumber phoneNumber = default);

        /// <summary>
        ///      Remove Authentication to user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Gets or sets the document id.</param>
        /// <param name="emailId">Gets or sets the signer email.</param>
        /// <param name="signerOrder">
        ///     Gets or sets the signer&#39;s order.  When signer order is enabled for a document, this order is
        ///     used to target that particular order with given signer email. (optional)
        /// </param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> RemoveAuthenticationAsyncWithHttpInfo(string documentId, string emailId = default, int? signerOrder = default, string onBehalfOf = default, PhoneNumber phoneNumber = default);

        /// <summary>
        /// Extends the expiration date of the document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">The Document ID.</param>
        /// <param name="newExpiryValue">
        /// The new expiry value should be specified in yyyy-MM-dd format for days type, ISO date time format for specific date time and integer for hours type.
        /// </param>
        /// <param name="warnPrior">
        /// If null, the existing configuration will be used.
        /// If true, one day before the expiration date, a warning email will be sent.
        /// If false, a warning email will not be sent one day before the expiration date.
        /// </param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        void ExtendExpiry(string documentId, string newExpiryValue, bool? warnPrior = null, string onBehalfOf = null);

        /// <summary>
        /// Extends the expiration date of the document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">The Document ID.</param>
        /// <param name="newExpiryValue">
        /// The new expiry value should be specified in yyyy-MM-dd format for days type, ISO date time format for specific date time and integer for hours type.
        /// </param>
        /// <param name="warnPrior">
        /// If null, the existing configuration will be used.
        /// If true, one day before the expiration date, a warning email will be sent.
        /// If false, a warning email will not be sent one day before the expiration date.
        /// </param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> ExtendExpiryWithHttpinfo(string documentId, string newExpiryValue, bool? warnPrior = null, string onBehalfOf = null);

        /// <summary>
        /// Extends the expiration date of the document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">The Document ID.</param>
        /// <param name="newExpiryValue">
        /// The new expiry value should be specified in yyyy-MM-dd format for days type, ISO date time format for specific date time and integer for hours type.
        /// </param>
        /// <param name="warnPrior">
        /// If null, the existing configuration will be used.
        /// If true, one day before the expiration date, a warning email will be sent.
        /// If false, a warning email will not be sent one day before the expiration date.
        /// </param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns><see cref="Task"/> representing the asynchronous operation.</returns>
        Task ExtendExpiryAsync(string documentId, string newExpiryValue, bool? warnPrior = null, string onBehalfOf = null);

        /// <summary>
        /// Extends the expiration date of the document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">The Document ID.</param>
        /// <param name="newExpiryValue">
        /// The new expiry value should be specified in yyyy-MM-dd format for days type, ISO date time format for specific date time and integer for hours type.
        /// </param>
        /// <param name="warnPrior">
        /// If null, the existing configuration will be used.
        /// If true, one day before the expiration date, a warning email will be sent.
        /// If false, a warning email will not be sent one day before the expiration date.
        /// </param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <returns>Task of ApiResponse.</returns>
        Task<ApiResponse<object>> ExtendExpiryAsyncWithHttpInfo(string documentId, string newExpiryValue, bool? warnPrior = null, string onBehalfOf = null);

        /// <summary>
        /// Change recipient details of a document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">The document id.</param>
        /// <param name="oldSignerEmail">The signer email.</param>
        /// <param name="reason">The reason for changing recipient details.</param>
        /// <param name="newSignerName">The new name of the recipient .</param>
        /// <param name="newSignerEmail">The new email address  of recipient .</param>
        /// <param name="signerOrder"> The signer order.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The signer phone number.</param>
        /// <param name="oldPhoneNumber">The Old Signer Phone number.</param>
        /// <returns>A <see cref="Task"/>  representing the asynchronous operation.</returns>
        Task ChangeRecipientasync(string documentId, string oldSignerEmail = null, string reason = null, string newSignerName = null, string newSignerEmail = null, int? signerOrder = null, string onBehalfOf = null, PhoneNumber phoneNumber = null, PhoneNumber oldPhoneNumber = null);

        /// <summary>
        /// Change recipient details of a document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="documentId">The document id.</param>
        /// <param name="oldSignerEmail">The signer email.</param>
        /// <param name="reason">The reason for changing recipient details.</param>
        /// <param name="newSignerName">The new name of the recipient .</param>
        /// <param name="newSignerEmail">The new email address of recipient .</param>
        /// <param name="signerOrder"> The signer order.</param>
        /// <param name="onBehalfOf">The on behalfof email.</param>
        /// <param name="phoneNumber">The signer phone number.</param>
        /// <param name="oldPhoneNumber">The Old Signer Phone number.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        Task<ApiResponse<object>> ChangeRecipientasyncWithHttpInfo(string documentId, string oldSignerEmail = null, string reason = null, string newSignerName = null, string newSignerEmail = null, int? signerOrder = null, string onBehalfOf = null, PhoneNumber phoneNumber = null, PhoneNumber oldPhoneNumber = null);

        /// <summary>
        /// Sends the draft document from API for sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DocumentCreated</returns>
        Task<DocumentCreated> SendDocumentFromDraftAsync(string  documentId);

        /// <summary>
        /// Sends the draft document from API for sign.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DocumentCreated)</returns>
        Task<ApiResponse<DocumentCreated>> SendDocumentFromDraftAsyncWithHttpInfo(string  documentId);

        #endregion Asynchronous Operations
    }
}
