namespace BoldSign.Examples
{
    using BoldSign.Api;
    using System.Threading.Tasks;
    using BoldSign.Model.Webhook;

    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var configuration = new Configuration();

            // set your OAuth2 Access Token for authentication.
            configuration.SetBearerToken("your-oauth2-token");

            var apiClient = new ApiClient(configuration);

            var documentExamples = new DocumentExamples(new DocumentClient(apiClient));
            var templateExamples = new TemplateExamples(new TemplateClient(apiClient));
            var userExamples = new UserExamples(new UserClient(apiClient));
            var brandingExamples = new BrandingExamples(new BrandingClient(apiClient));
            var senderIdentityExamples = new SenderIdentityExamples(new SenderIdentityClient(apiClient));
            await documentExamples.CreateDocument().ConfigureAwait(false);

            // webhook event helpers
            var jsonPayload = "{}";
            var webhookEvent = WebhookUtility.ParseEvent(jsonPayload);

            switch (webhookEvent.Event.EventType)
            {
                // if its a document event, cast as DocumentEvent
                case WebHookEventType.Declined:
                    var documentEvent = webhookEvent.Data as DocumentEvent;

                    break;

                // if its a sender identity event, cast as SenderIdentityEvent
                case WebHookEventType.SenderIdentityUpdated:
                    var senderIdentityEvent = webhookEvent.Data as SenderIdentityEvent;

                    break;
            }
        }
    }
}
