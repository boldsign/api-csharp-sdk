// <copyright file="IContactClient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BoldSign.Api.Model;
    using BoldSign.Model;

    /// <summary>
    /// Contact Client.
    /// </summary>
    public interface IContactClient : IApiAccessor
    {
        /// <summary>
        /// Gets the contact list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="searchKey">The search key.</param>
        /// <param name="contactType">contactType.</param>
        /// <returns>A Task.</returns>
        ContactsList ListContacts(int page, int? pageSize = default, string searchKey = default,
            ContactType? contactType = ContactType.AllContacts);

        /// <summary>
        /// Gets the contact list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="searchKey">The search key.</param>
        /// <param name="contactType">contactType.</param>
        /// <returns>A Task.</returns>
        ApiResponse<ContactsList> ListContactsWithHttpInfo(int page, int? pageSize = default,
            string searchKey = default, ContactType? contactType = ContactType.AllContacts);

        /// <summary>
        /// Gets the contact list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="searchKey">The search key.</param>
        /// <param name="contactType">contactType.</param>
        /// <returns>A Task.</returns>
        Task<ContactsList> ListContactsAsync(int page, int? pageSize = default, string searchKey = default,
            ContactType? contactType = ContactType.AllContacts);

        /// <summary>
        /// Gets the contact list.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="searchKey">The search key.</param>
        /// <param name="contactType">contactType.</param>
        /// <returns>A Task.</returns>
        Task<ApiResponse<ContactsList>> ListContactsAsyncWithHttpInfo(int page, int? pageSize = default,
            string searchKey = default, ContactType? contactType = ContactType.AllContacts);

        /// <summary>
        ///     Delete the brand when a particular brand’s ID is given as input.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="id">Contact Id.</param>
        void DeleteContact(string id);

        /// <summary>
        ///    Delete the brand when a particular brand’s ID is given as input.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="id">Contact Id.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> DeleteContactWithHttpInfo(string id);

        /// <summary>
        ///    Delete the brand when a particular brand’s ID is given as input.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="id">Contact Id.</param>
        /// <returns>Task of void.</returns>
        Task DeleteContactAsync(string id);

        /// <summary>
        ///     Delete the brand.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="id">Contact Id.</param>
        /// <returns>Task of ApiResponse.</returns>
        Task<ApiResponse<object>> DeleteContactAsyncWithHttpInfo(string id);

        /// <summary>
        /// Create Contact details.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="contactsDetails">Contact details.</param>
        /// <returns>CreatedContact.</returns>
        CreatedContact CreateContact(List<ContactDetails> contactsDetails);

        /// <summary>
        /// Creates a new contact.
        /// </summary>
        /// <param name="contactsDetailsList">The contactsDetailsList.</param>
        /// <returns>A Task.</returns>
        ApiResponse<CreatedContact> CreateContactWithHttpInfo(List<ContactDetails> contactsDetailsList = default);

        /// <summary>
        /// Creates a new contact.
        /// </summary>
        /// <param name="contactDetailsList">The contactDetailsList.</param>
        /// <returns>A Task.</returns>
        Task<CreatedContact> CreateContactAsync(List<ContactDetails> contactDetailsList = default);

        /// <summary>
        /// Gets create the contact.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="contactsDetailsList">The contactDetailsList.</param>
        /// <returns>A Task of Response.</returns>
        Task<ApiResponse<CreatedContact>> CreateContactAsyncWithHttpInfo(List<ContactDetails> contactsDetailsList = default);

        /// <summary>
        /// Creates a new contact.
        /// </summary>
        /// <param name="id">The Contact ID.</param>
        /// <param name="updateContact">The Update Contact.</param>
        void UpdateContact(string id, ContactDetails updateContact);

        /// <summary>
        /// Creates a new contact.
        /// </summary>
        /// <param name="id">The Contact ID.</param>
        /// <param name="updateContact">The Update Contact.</param>
        /// <returns>A Task.</returns>
        ApiResponse<object> UpdateContactWithHttpInfo(string id, ContactDetails updateContact);

        /// <summary>
        /// Creates a new contact.
        /// </summary>
        /// <param name="id">The Contact ID.</param>
        /// <param name="updateContact">The Update Contact.</param>
        /// <returns>A Task.</returns>
        Task UpdateContactAsync(string id, ContactDetails updateContact);

        /// <summary>
        /// Creates a new contact.
        /// </summary>
        /// <param name="id">The Contact ID.</param>
        /// <param name="updateContact">The Update Contact.</param>
        /// <returns>A Task.</returns>
        Task<ApiResponse<object>> UpdateContactAsyncWithHttpInfo(string id, ContactDetails updateContact);

        /// <summary>
        /// Gets the contact.
        /// </summary>
        /// <param name="id">The Contact ID.</param>
        /// <returns>A Contact Details.</returns>
        ContactsDetails GetContact(string id);

        /// <summary>
        /// Gets the contact.
        /// </summary>
        /// <param name="id">The Contact ID.</param>
        /// <returns>A Task.</returns>
        ApiResponse<ContactsDetails> GetContactWithHttpInfo(string id);

        /// <summary>
        /// Gets the contact.
        /// </summary>
        /// <param name="id">The Contact ID.</param>
        /// <returns>A Task.</returns>
        Task<ContactsDetails> GetContactAsync(string id);

        /// <summary>
        /// Gets the contact.
        /// </summary>
        /// <param name="id">The Contact ID.</param>
        /// <returns>A Task.</returns>
        Task<ApiResponse<ContactsDetails>> GetContactAsyncWithHttpInfo(string id);
    }
}
