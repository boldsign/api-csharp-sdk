namespace BoldSign.Examples
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BoldSign.Api;
    using BoldSign.Model;
    using BoldSign.Api.Model;

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
            // This is an example user id, add your own user id upon usage.
            var ids = new List<string>
            {
              "your-user-id-1",
              "your-user-id-2"
            };

            var users = this.UserClient.ListUsers(page: 1, pageSize: 20, userId: ids);

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
        
        /// <summary>
        /// Updates user role.
        /// This is an example user id, add your own user id upon usage.
        /// This is an example user role, add your own user role upon usage.
        /// </summary>
        public async Task UpdateUserMetaData()
        {
            UpdateUserMetaData updateUsers = new UpdateUserMetaData
            (
                userId: "73236919-c6bf-490a-b332-db6e565f7fd3",
                metaData: new Dictionary<string, string>()
                {
                    { "role", "role" },
                    { "company", "syncfusion" },
                }
            );

            await UserClient.UpdateUsersMetaDataAsync(updateUsers).ConfigureAwait(false);
        }

        /// <summary>
        /// Changes a user's team.
        /// </summary>
        public void ChangeTeam()
        {
            var userId = "66b2cab9-b20c-4aff-a600-adecab6fc2b4";
            var changeTeamRequest = new ChangeTeam()
            {
                ToTeamId = "ea2cd866-ce19-458d-8835-7f1a65b470f2",
                TransferDocumentsToUserId = "99bccbe3-6599-44a0-b6b1-999e627de892",
            };
            this.UserClient.ChangeTeamAsync(userId, changeTeamRequest);
        }
    }
}