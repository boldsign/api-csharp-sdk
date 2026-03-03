// <copyright file="IGroupContactClient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BoldSign.Api.Model;
    using BoldSign.Model;

    /// <summary>
    /// Interface for GroupContactClient.
    /// </summary>
    public interface IGroupContactClient
    {
        /// <summary>
        /// Creates a new group contact.
        /// </summary>
        /// <param name="groupContact">The group contact details.</param>
        /// <returns>A Task of CreateGroupContactResponse.</returns>
        CreateGroupContactResponse CreateGroupContact(GroupContactDetails groupContact = default);

        /// <summary>
        /// Creates a new group contact.
        /// </summary>
        /// <param name="groupContact">The group contact details.</param>
        /// <returns>A Task of CreateGroupContactResponse.</returns>
        ApiResponse<CreateGroupContactResponse> CreateGroupContactWithHttpInfo(GroupContactDetails groupContact);

        /// <summary>
        /// Creates a new group contact.
        /// </summary>
        /// <param name="groupContact">The group contact details.</param>
        /// <returns>A Task of CreateGroupContactResponse.</returns>
        Task<CreateGroupContactResponse> CreateGroupContactAsync(GroupContactDetails groupContact);

        /// <summary>
        /// Creates a new group contact.
        /// </summary>
        /// <param name="groupContact">The group contact details.</param>
        /// <returns>A Task of CreateGroupContactResponse.</returns>
        Task<ApiResponse<CreateGroupContactResponse>> CreateGroupContactAsyncWithHttpInfo(GroupContactDetails groupContact);

        /// <summary>
        /// Gets a list of group contacts.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="searchKey">The search key.</param>
        /// <param name="contactType">contact type.</param>
        /// <param name="directories">The directories.</param>
        /// <returns>A Task of GroupContactsList.</returns>
        Task<GroupContactsList> ListGroupContactsAsync(int page, int? pageSize = default, string searchKey = default, ContactType? contactType = ContactType.AllContacts, List<string> directories = null);

        /// <summary>
        /// Gets a list of group contacts.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="searchKey">The search key.</param>
        /// <param name="contactType">contact type.</param>
        /// <param name="directories">The directories.</param>
        /// <returns>A Task of GroupContactsList.</returns>
        Task<ApiResponse<GroupContactsList>> ListGroupContactsAsyncWithHttpInfo(int page, int? pageSize = default, string searchKey = default, ContactType? contactType = ContactType.AllContacts, List<string> directories = null);

        /// <summary>
        /// Gets a list of group contacts.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="searchKey">The search key.</param>
        /// <param name="contactType">contact type.</param>
        /// <param name="directories">The directories.</param>
        /// <returns>A Task of GroupContactsList.</returns>
        GroupContactsList ListGroupContacts(int page, int? pageSize = default, string searchKey = default, ContactType? contactType = ContactType.AllContacts, List<string> directories = null);

        /// <summary>
        /// Gets a list of group contacts.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="searchKey">The search key.</param>
        /// <param name="contactType">contact type.</param>
        /// <param name="directories">The directories.</param>
        /// <returns>A Task of GroupContactsList.</returns>
        ApiResponse<GroupContactsList> ListGroupContactsWithHttpInfo(int page, int? pageSize = default, string searchKey = default, ContactType? contactType = ContactType.AllContacts, List<string> directories = null);

        /// <summary>
        /// Gets details of a specific group contact.
        /// </summary>
        /// <param name="groupId">The ID of the group contact.</param>
        /// <returns>A Task of GetGroupContactDetails.</returns>
        GetGroupContactDetails GetGroupContact(string groupId);

        /// <summary>
        /// Gets details of a specific group contact.
        /// </summary>
        /// <param name="groupId">The ID of the group contact.</param>
        /// <returns>A Task of GetGroupContactDetails.</returns>
        ApiResponse<GetGroupContactDetails> GetGroupContactWithHttpInfo(string groupId);

        /// <summary>
        /// Gets details of a specific group contact.
        /// </summary>
        /// <param name="groupId">The ID of the group contact.</param>
        /// <returns>A Task of GetGroupContactDetails.</returns>
        Task<GetGroupContactDetails> GetGroupContactAsync(string groupId);

        /// <summary>
        /// Gets details of a specific group contact.
        /// </summary>
        /// <param name="groupId">The ID of the group contact.</param>
        /// <returns>A Task of GetGroupContactDetails.</returns>
        Task<ApiResponse<GetGroupContactDetails>> GetGroupContactAsyncWithHttpInfo(string groupId);

        /// <summary>
        /// Update group contact.
        /// </summary>
        /// <param name="groupId">group id.</param>
        /// <param name="updateGroupContact">update group contact.</param>
        void UpdateGroupContact(string groupId, GroupContact updateGroupContact);

        /// <summary>
        /// Update group contact.
        /// </summary>
        /// <param name="groupId">group id.</param>
        /// <param name="updateGroupContact">update group contact.</param>
        /// <returns>A Task.</returns>
        ApiResponse<object> UpdateGroupContactWithHttpInfo(string groupId, GroupContact updateGroupContact);

        /// <summary>
        /// Update group contact.
        /// </summary>
        /// <param name="groupId">group id.</param>
        /// <param name="updateGroupContact">update group contact.</param>
        /// /// <returns>A Task.</returns>
        Task UpdateGroupContactAsync(string groupId, GroupContact updateGroupContact);

        /// <summary>
        /// Update group contact.
        /// </summary>
        /// <param name="groupId">group id.</param>
        /// <param name="updateGroupContact">update group contact.</param>
        /// /// <returns>A Task.</returns>
        Task<ApiResponse<object>> UpdateGroupContactAsyncWithHttpInfo(string groupId, GroupContact updateGroupContact);

        /// <summary>
        /// Deletes a group contact.
        /// </summary>
        /// <param name="groupId">The ID of the group contact to delete.</param>
        void DeleteGroupContact(string groupId);

        /// <summary>
        /// Deletes a group contact.
        /// </summary>
        /// <param name="groupId">The ID of the group contact to delete.</param>
        /// <returns>A Task of void.</returns>
        ApiResponse<object> DeleteGroupContactWithHttpInfo(string groupId);

        /// <summary>
        /// Deletes a group contact.
        /// </summary>
        /// <param name="groupId">The ID of the group contact to delete.</param>
        /// <returns>A Task of void.</returns>
        Task DeleteGroupContactAsync(string groupId);

        /// <summary>
        /// Deletes a group contact.
        /// </summary>
        /// <param name="groupId">The ID of the group contact to delete.</param>
        /// <returns>A Task of void.</returns>
        Task<ApiResponse<object>> DeleteGroupContactAsyncWithHttpInfo(string groupId);
    }
}
