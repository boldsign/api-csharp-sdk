namespace BoldSign.Examples
{
    using BoldSign.Api;
    using BoldSign.Model;

    /// <summary>
    /// The sender identity examples.
    /// </summary>
    public class SenderIdentityExamples
    {
        private readonly SenderIdentityClient senderIdentityClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SenderIdentityExamples" /> class.
        /// </summary>
        /// <param name="SenderIdentityClient">The sender identity api.</param>
        public SenderIdentityExamples(SenderIdentityClient senderIdentityClient) => this.senderIdentityClient = senderIdentityClient;

        /// <summary>
        /// Gets or sets the create sender identity details.
        /// Gets or sets the emailId (Required).
        /// Gets or sets the name  (Required).
        /// </summary>
        public SenderIdentityCreated CreateSenderIdentity()
        {
            NotificationSettings notificationSettings = new NotificationSettings();
            notificationSettings.AuthenticationFailed = true;
            notificationSettings.Completed = true;
            notificationSettings.Sent = true;
            var request = new SenderIdentityRequest("Sender Identity", "identity@email.com", notificationSettings);
            var senderIdentityCreated = this.senderIdentityClient.CreateSenderIdentity(request);
            return senderIdentityCreated;
        }

        /// <summary>
        /// Updates sender identity name.
        /// This is an example sender identity name, add your own sender identity name upon usage.
        /// This is an example sender identity email, add your own identity email upon usage.
        /// </summary>
        public void UpdateSenderIdentity()
        {
            NotificationSettings notificationSettings = new NotificationSettings();
            notificationSettings.Completed = false;
            notificationSettings.Sent = false;
            var request = new SenderIdentityRequest("Edit Sender Identity", "identity@email.com", notificationSettings);
            this.senderIdentityClient.UpdateSenderIdentity(request);
        }

        /// <summary>
        /// Resend sender identity invite.
        /// </summary>
        public void ResendSenderIdentityInvitation()
        {
            var email = "identity@email.com";
            this.senderIdentityClient.ResendInvitation(email);
        }

        /// <summary>
        /// Rerequests the sender identity.
        /// </summary>
        public void RerequestSenderIdentity()
        {
            var email = "identity@email.com";
            this.senderIdentityClient.RerequestSenderIdentity(email);
        }

        /// <summary>
        /// Delete sender identity.
        /// </summary>
        public void DeleteSenderIdentity()
        {
            var email = "identity@email.com";
            this.senderIdentityClient.DeleteSenderIdentity(email);
        }

        /// <summary>
        /// Lists the sender identities.
        /// </summary>
        public SenderIdentityList ListSenderIdentity()
        {
            var senderIdentities = this.senderIdentityClient.ListSenderIdentities(page: 1, pageSize: 20);
            return senderIdentities;
        }
    }
}
