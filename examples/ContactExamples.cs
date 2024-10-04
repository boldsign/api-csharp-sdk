namespace BoldSign.Examples
{
    using System.Collections.Generic;
    using BoldSign.Api;
    using BoldSign.Api.Model;
    using BoldSign.Model;
    using System.Threading.Tasks;

    /// <summary>
    ///     The create user examples.
    /// </summary>
    public class ContactExamples
    {
        private readonly ContactClient ContactClient;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContactExamples" /> class.
        /// </summary>
        /// <param name="ContactClient">The create user api.</param>
        public ContactExamples(ContactClient ContactClient)
        {
            this.ContactClient = ContactClient;
        }

        ///<summary>
        /// Get contact list
        /// </summary>
        public ContactsList ContactList()
        {
            var response = this.ContactClient.ListContacts(1, 10, "", ContactType.AllContacts);
            return response;
        }

        /// <summary>
        /// Delete Contact details
        /// </summary>
        public void DeleteContact()
        {
            // This is an example contact id, add your own brand id upon usage.
            var id = "contact-Id";
            this.ContactClient.DeleteContact(id);
        }

        /// <summary>
        /// Create Contact details
        /// </summary>
        public CreatedContact CreateContact()
        {
            var contactsDetailsList = new List<ContactDetails>();
            ContactDetails contactsDetails = new ContactDetails()
            {
                Email = "test1711@gmail.com",
                Name = "API-SDK_Test",
                PhoneNumber = new PhoneNumber()
                {
                    CountryCode = "91",
                    Number = "6547456721"
                },
                CompanyName = "1711",
                JobTitle = "Test"
            };

            contactsDetailsList.Add(contactsDetails);
            var response = this.ContactClient.CreateContact(contactsDetailsList);
            return response;
        }

        /// <summary>
        /// Update Contact details
        /// </summary>
        public void UpdateContact()
        {
            string id = "6797a07d-26d7-41fa-b3a8-c8f72378a7a6c_gEkPI";
            var updateContact = new ContactDetails()
            {
                Email = "test1711@gmail.com",
                Name = "Test_Engineer",
                PhoneNumber = new PhoneNumber()
                {
                    CountryCode = "91",
                    Number = "9182736450"
                },
                CompanyName = "1711_1802",
                JobTitle = "Test"
            };

            this.ContactClient.UpdateContact(id, updateContact);
        }

        public ContactsDetails GetContact()
        {
            string id = "6797a07d-26d7-41fa-b3a8-c8f72378a7a6c_KRMh4";
            var response = this.ContactClient.GetContact(id);
            return response;
        }
    }
}