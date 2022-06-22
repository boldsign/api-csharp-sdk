// <copyright file="IUserClient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BoldSign.Model;

    /// <summary>
    ///    Represents a function to interact with the API endpoints. The function perform action such as invite the user and so on.
    /// </summary>
    public interface IUserClient : IApiAccessor
    {
        /// <summary>
        ///  Create the user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createUserRequest">The create user details.</param>
        /// <returns>CreateUserResponse.</returns>
        CreateUserResponse CreateUser(List<CreateUserRequest> createUserRequest = default);

        /// <summary>
        ///     Gets Create the user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createUserRequest">The create user details.</param>
        /// <returns>ApiResponse of Object(CreateUserResponse).</returns>
        ApiResponse<CreateUserResponse> CreateUserWithHttpInfo(List<CreateUserRequest> createUserRequest = default);

        /// <summary>
        ///  Create the user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createUserRequest">The create user details.</param>
        /// <returns>Task.</returns>
        Task<CreateUserResponse> CreateUserAsync(List<CreateUserRequest> createUserRequest = default);

        /// <summary>
        ///     Gets Create the user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createUserRequest">The create user details.</param>
        /// <returns>ApiResponse of Object(CreateUserResponse).</returns>
        Task<ApiResponse<CreateUserResponse>> CreateUserAsyncWithHttpInfo(List<CreateUserRequest> createUserRequest = default);

        /// <summary>
        /// Updates user role.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="updateUserQuery">update User Query.</param>
        void UpdateUser(UpdateUser updateUserQuery);

        /// <summary>
        /// Updates user role.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="updateUserQuery">update User Query.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> UpdateUserWithHttpInfo(UpdateUser updateUserQuery);

        /// <summary>
        /// Updates user role.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="updateUserQuery">updateUserQuery.</param>
        /// <returns>UpdateUserRole.</returns>
        Task UpdateUserAsync(UpdateUser updateUserQuery);

        /// <summary>
        /// Updates user role.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="updateUserQuery">updateUserQuery.</param>
        /// <returns>ApiResponse of Object(UpdateUserRole).</returns>
        Task<ApiResponse<object>> UpdateUserAsyncWithHttpInfo(UpdateUser updateUserQuery);

        /// <summary>
        /// Resend Invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">userId.</param>
        void ResendInvitation(string userId);

        /// <summary>
        /// Resend Invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">userId.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> ResendInvitationWithHttpInfo(string userId);

        /// <summary>
        /// Resend Invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">userId.</param>
        /// <returns>ResendInvite.</returns>
        Task ResendInvitationAsync(string userId);

        /// <summary>
        /// Resend Invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">userId.</param>
        /// <returns>ApiResponse of Object(ResendInvite).</returns>
        Task<ApiResponse<object>> ResendInvitationAsyncWithHttpInfo(string userId);

        /// <summary>
        /// Cancel Invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">userId.</param>
        void CancelInvitation(string userId);

        /// <summary>
        /// Cancel Invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">userId.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> CancelInvitationWithHttpInfo(string userId);

        /// <summary>
        /// Cancel Invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">userId.</param>
        /// <returns>CancelInvite.</returns>
        Task CancelInvitationAsync(string userId);

        /// <summary>
        /// Cancel Invitation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">userId.</param>
        /// <returns>ApiResponse of Object(CancelInvite).</returns>
        Task<ApiResponse<object>> CancelInvitationAsyncWithHttpInfo(string userId);

        /// <summary>
        /// Get summary of the user details for the given user ID.
        /// </summary>
        /// <param name="userId">The User Id.</param>
        /// <returns>A Task.</returns>
        UserProperties GetUserDetails(string userId);

        /// <summary>
        /// Get summary of the user details for the given user ID.
        /// </summary>
        /// <param name="userId">The User Id.</param>
        /// <returns>A Task.</returns>
        ApiResponse<UserProperties> GetUserDetailsWithHttpInfo(string userId);

        /// <summary>
        /// Get summary of the user details for the given user ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">User Id.</param>
        /// <returns>UserProperties.</returns>
        Task<UserProperties> GetUserDetailsAsync(string userId);

        /// <summary>
        /// Get summary of the user details for the given user ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="userId">User Id.</param>
        /// <returns>ApiResponse of UserProperties.</returns>
        Task<ApiResponse<UserProperties>> GetUserDetailsAsyncWithHttpInfo(string userId);

        /// <summary>
        /// Gets the user list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="search">The search key.</param>
        /// <returns>A Task.</returns>
        UserRecords ListUsers(int page, int? pageSize = default, string search = default);

        /// <summary>
        /// Gets the user list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="search">The search key.</param>
        /// <returns>A Task.</returns>
        ApiResponse<UserRecords> ListUsersWithHttpInfo(int page, int? pageSize = default, string search = default);

        /// <summary>
        /// Gets the user list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="search">The search key.</param>
        /// <returns>A Task.</returns>
        Task<UserRecords> ListUsersAsync(int page, int? pageSize = default, string search = default);

        /// <summary>
        /// Gets the user list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="search">The search key.</param>
        /// <returns>A Task.</returns>
        Task<ApiResponse<UserRecords>> ListUsersAsyncWithHttpInfo(int page, int? pageSize = default, string search = default);
    }
}