namespace BoldSign.Examples
{
    using System.Collections.Generic;
    using BoldSign.Api;
    using BoldSign.Api.Model;
    using BoldSign.Model;

    /// <summary>
    ///     The create user examples.
    /// </summary>
    public class UserExamples
    {
        private readonly UserClient UserClient;

        /// <summary>
        ///     Initializes a new instance of the <see cref="UserExamples" /> class.
        /// </summary>
        /// <param name="UserClient">The create user api.</param>
        public UserExamples(UserClient UserClient) => this.UserClient = UserClient;

        /// <summary>
        ///     Gets or sets the create user details.
        ///     Gets or sets the emailId (Required).
        ///     Gets or sets the teamId  (Optional).
        ///     Gets or sets the userRole(Optional).
        /// </summary>
        public CreateUserResponse CreateUser()
        {
            var users = new List<CreateUserRequest>
            {
                new CreateUserRequest(
                        emailId:"signer1@boldsign.dev"
                        ),
                new CreateUserRequest(
                        emailId:"signer2@boldsign.dev",
                        teamId:"your-team-Id",
                        userRole:UserRoleType.Admin
                        ),
            };
            var CreateUserResponse = this.UserClient.CreateUser(users);
            return CreateUserResponse;
        }

        /// <summary>
        /// Updates user role.
        /// This is an example user id, add your own user id upon usage.
        /// This is an example user role, add your own user role upon usage.
        /// </summary>
        public void UpdateUser()
        {
            var updateUsers = new UpdateUser
                (
                    userId: "your-user-Id",
                    userRole: UserRoleType.TeamAdmin
                );

            this.UserClient.UpdateUser(updateUsers);
        }

        /// <summary>
        /// Updates user metadata.
        /// This is an example user name, add your own user name upon usage.
        /// This is an example user email, add your own identity email upon usage.
        /// This is an example user metadata, add your own user metadata upon usage.
        /// </summary>
        public void UpdateUserWithMetadata()
        {
            var updateUserMetaData = new UpdateUserMetaData
               (
                   userId: "user-id",
                   metaData: new Dictionary<string, string>
                    {
                        { "accountPlan", "Paid" },
                        { "role", "Admin" },
                    }
               );

            this.UserClient.UpdateUsersMetaData(updateUserMetaData);
        }

        /// <summary>
        /// Resend user Invite.
        /// </summary>
        /// <returns>Resend User Invite response.</returns>
        public void ResendUserInvitation()
        {
            // This is an example user id, add your own user id upon usage.
            var userId = "your-user-id";

            this.UserClient.ResendInvitation(userId);
        }

        /// <summary>
        /// Cancel user Invite.
        /// </summary>
        /// <returns>Cancel User Invite response.</returns>
        public void CancelUserInvitation()
        {
            // This is an example user id, add your own user id upon usage.
            var userId = "your-user-id";

            this.UserClient.CancelInvitation(userId);
        }

        /// <summary>
        /// Lists the users.
        /// </summary>
        public UserRecords ListUsers()
        {
            var users = this.UserClient.ListUsers(page: 1, pageSize: 20);

            return users;
        }

        /// <summary>
        /// Gets the user properties.
        /// </summary>
        /// <returns>A UserProperties.</returns>
        public UserProperties GetUserDetails()
        {
            // This is an example document id, add your own document id upon usage.
            var userId = "47a0403c-abda-49ee-ac3c-968e80a9d700";

            var userDeatils = this.UserClient.GetUserDetails(userId);

            return userDeatils;
        }
    }
}