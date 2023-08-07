// <copyright file="ISenderIdentityClient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BoldSign.Model;

    /// <summary>
    /// Represents a function to interact with the API endpoints. The function perform action such as invite the sender identity and so on.
    /// </summary>
    public interface ISenderIdentityClient : IApiAccessor
    {
        /// <summary>
        ///  Creates the sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createSenderIdentityRequest">The create sender identity details.</param>
        /// <returns>Create sender identity response.</returns>
        SenderIdentityCreated CreateSenderIdentity(SenderIdentityRequest createSenderIdentityRequest = default);

        /// <summary>
        /// Creates the sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createSenderIdentityRequest">The create sender identity details.</param>
        /// <returns>ApiResponse of object create sender identity response.</returns>
        ApiResponse<SenderIdentityCreated> CreateSenderIdentityWithHttpInfo(SenderIdentityRequest createSenderIdentityRequest = default);

        /// <summary>
        ///  Creates the sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createSenderIdentityRequest">The create sender identity details.</param>
        /// <returns>Task.</returns>
        Task<SenderIdentityCreated> CreateSenderIdentityAsync(SenderIdentityRequest createSenderIdentityRequest = default);

        /// <summary>
        /// Creates the sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createSenderIdentityRequest">The create sender identity details.</param>
        /// <returns>ApiResponse of object create sender identity response.</returns>
        Task<ApiResponse<SenderIdentityCreated>> CreateSenderIdentityAsyncWithHttpInfo(SenderIdentityRequest createSenderIdentityRequest = default);

        /// <summary>
        /// Updates sender identity name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="editSenderIdentityRequest">Edit sender identity request.</param>
        void UpdateSenderIdentity(SenderIdentityRequest editSenderIdentityRequest);

        /// <summary>
        /// Updates sender identity name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="editSenderIdentityRequest">Edit sender identity request.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> UpdateSenderIdentityWithHttpInfo(SenderIdentityRequest editSenderIdentityRequest);

        /// <summary>
        /// Updates sender identity name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="editSenderIdentityRequest">Edit sender identity request.</param>
        /// <returns>Edit sender identity response.</returns>
        Task UpdateSenderIdentityAsync(SenderIdentityRequest editSenderIdentityRequest);

        /// <summary>
        /// Updates sender identity name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="editSenderIdentityRequest">Edit sender identity request.</param>
        /// <returns>ApiResponse of object update sender identity response.</returns>
        Task<ApiResponse<object>> UpdateSenderIdentityAsyncWithHttpInfo(SenderIdentityRequest editSenderIdentityRequest);

        /// <summary>
        /// Resend sender identity invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The sender identity email.</param>
        void ResendInvitation(string email);

        /// <summary>
        /// Resend sender identity invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The sender identity email.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> ResendInvitationWithHttpInfo(string email);

        /// <summary>
        /// Resend sender identity invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The sender identity email.</param>
        /// <returns>ResendInvite.</returns>
        Task ResendInvitationAsync(string email);

        /// <summary>
        /// Resend sender identity invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The sender identity email.</param>
        /// <returns>ApiResponse of Object(ResendInvite).</returns>
        Task<ApiResponse<object>> ResendInvitationAsyncWithHttpInfo(string email);

        /// <summary>
        /// Rerequests the sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The sender identity email.</param>
        void RerequestSenderIdentity(string email);

        /// <summary>
        /// Rerequests the sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The sender identity email.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> RerequestSenderIdentityWithHttpInfo(string email);

        /// <summary>
        /// Rerequests the sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The sender identity email.</param>
        /// <returns>Rerequest response.</returns>
        Task RerequestSenderIdentityAsync(string email);

        /// <summary>
        /// Rerequests the sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The sender identity email.</param>
        /// <returns>ApiResponse of Object(Rerequest).</returns>
        Task<ApiResponse<object>> RerequestSenderIdentityAsyncWithHttpInfo(string email);

        /// <summary>
        /// Delete sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The sender identity email.</param>
        void DeleteSenderIdentity(string email);

        /// <summary>
        /// Delete sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The email address.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> DeleteSenderIdentityWithHttpInfo(string email);

        /// <summary>
        /// Delete sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The email address.</param>
        /// <returns>CancelInvite.</returns>
        Task DeleteSenderIdentityAsync(string email);

        /// <summary>
        /// Delete sender identity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="email">The email address.</param>
        /// <returns>ApiResponse of Object(CancelInvite).</returns>
        Task<ApiResponse<object>> DeleteSenderIdentityAsyncWithHttpInfo(string email);

        /// <summary>
        /// Gets the sender identity list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="search">The search key.</param>
        /// <returns>A Task.</returns>
        SenderIdentityList ListSenderIdentities(int page, int? pageSize = default, string search = default);

        /// <summary>
        /// Gets the sender identity list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="search">The search key.</param>
        /// <returns>A Task.</returns>
        ApiResponse<SenderIdentityList> ListSenderIdentitiesWithHttpInfo(int page, int? pageSize = default, string search = default);

        /// <summary>
        /// Gets the sender identity list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="search">The search key.</param>
        /// <returns>A Task.</returns>
        Task<SenderIdentityList> ListSenderIdentitiesAsync(int page, int? pageSize = default, string search = default);

        /// <summary>
        /// Gets the sender identity list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="search">The search key.</param>
        /// <returns>A Task.</returns>
        Task<ApiResponse<SenderIdentityList>> ListSenderIdentitiesAsyncWithHttpInfo(int page, int? pageSize = default, string search = default);
    }
}
