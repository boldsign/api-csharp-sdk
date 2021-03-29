namespace BoldSign.Examples
{
    using BoldSign.Api;
    using BoldSign.Client;
    using System.Threading.Tasks;

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
            await documentExamples.CreateDocument().ConfigureAwait(false);

        }
    }
}
