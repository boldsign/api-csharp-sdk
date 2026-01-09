// <copyright file="GroupContactExamples.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Examples
{
    using System.Collections.Generic;
    using BoldSign.Api;
    using BoldSign.Model;
    using System.Threading.Tasks;
    using BoldSign.Api.Model;

    /// <summary>
    /// The group contact examples.
    /// </summary>
    public class GroupContactExamples
    {
        private readonly GroupContactClient groupContactClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupContactExamples" /> class.
        /// </summary>
        /// <param name="groupContactClient">The group contact API client.</param>
        public GroupContactExamples(GroupContactClient groupContactClient)
        {
            this.groupContactClient = groupContactClient;
        }

        /// <summary>
        /// Get group contact list.
        /// </summary>
        public GroupContactsList GetGroupContactList()
        {
            var response = this.groupContactClient.ListGroupContacts(1, 10, "", ContactType.AllContacts, new List<string> { "TestDirectories" });
            return response;
        }

        /// <summary>
        /// Delete a group contact.
        /// </summary>
        public void DeleteGroupContact()
        {
            var groupId = "a6e8ba92-baab-45f5-92a9-c6458e732e67";
            this.groupContactClient.DeleteGroupContact(groupId);
        }

        /// <summary>
        /// Create a new group contact.
        /// </summary>
        /// <returns>The created group contact response.</returns>
        public CreateGroupContactResponse CreateGroupContact()
        {
            var groupContact = new GroupContactDetails ()
            {

                GroupName = "Testsdk",
                Directories = new List<string> { "TestDirectories1", "TestDirectories2" },
                Contacts = new List<Contacts>
                {
                    new Contacts
                    {
                        Name = "test 01",
                        Email = "test01@gmail.com"
                    },
                    new Contacts
                    {
                        Name = "test 02",
                        Email = "test02@gmail.com"
                    }
                }
            };
            var response = this.groupContactClient.CreateGroupContact(groupContact);
            return response;
        }

        /// <summary>
        /// Update a group contact.
        /// </summary>
        public void UpdateGroupContact()
        {
            string groupId = "ed3e52f3-5561-455d-a801-cede5d9df3cb";
            var groupContact = new GroupContact()
            {
                GroupName = "Updated Test Group",
                Contacts = new List<Contacts>
                {
                    new Contacts
                    {
                        Name = "test 03",
                        Email = "test03@gmail.com"
                    },
                    new Contacts
                    {
                        Name = "test 04",
                        Email = "test04@gmail.com"
                    }
                },
                Directories = new List<string> { "TestDirectories03", "TestDirectories04" }
            };
            this.groupContactClient.UpdateGroupContact(groupId, groupContact);
        }

        /// <summary>
        /// Get details of a specific group contact.
        /// </summary>
        /// <returns>The group contact details.</returns>
        public GetGroupContactDetails GetGroupContact()
        {
            string groupId = "928e6d45-2898-48f8-9bd3-68a589ef8083";
            var response = this.groupContactClient.GetGroupContact(groupId);
            return response;
        }
    }
}