namespace BoldSign.Examples
{
    using System.IO;
    using System.Threading.Tasks;
    using BoldSign.Api;
    using BoldSign.Model.IdVerification;

    public class IdVerificationExamples
    {
        private readonly IdVerificationClient IdVerificationClient;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DocumentExamples" /> class.
        /// </summary>
        /// <param name="IdVerificationClient">The id verification api.</param>
        public IdVerificationExamples(IdVerificationClient IdVerificationClient) => this.IdVerificationClient = IdVerificationClient;

        /// <summary>
        /// Retrieve the ID verification report for the specified document signer.
        /// </summary>
        /// <returns>A Id Verification Report.</returns>
        public async Task<IdReport> GetReportAsync()
        {
            var documentId = "1713c429-9fd7-4906-9e72-28ad84a4c5ae";

            var verificationReportRequest = new VerificationReportRequest()
            {
                EmailId = "signer1@email.com",
            };

            var idReport = await this.IdVerificationClient.GetReportAsync(documentId, verificationReportRequest).ConfigureAwait(false);

            return idReport;
        }

        /// <summary>
        /// Retrieve the uploaded ID verification document or selfie image for the specified document signer using the file ID.
        /// </summary>
        /// <returns>A Id Verification Image in File Stream.</returns>
        public async Task<Stream> GetImageAsync()
        {
            var documentId = "1713c429-9fd7-4906-9e72-28ad84a4c5ae";

            var verificationImageRequest = new VerificationImageRequest()
            {
                EmailId = "signer1@email.com",
                FileId = "686a2352-aa04-4b9a-a299-593451ed3f7a",
            };

            var imageStream = await this.IdVerificationClient.GetImageAsync(documentId, verificationImageRequest).ConfigureAwait(false);

            return imageStream;
        }

        /// <summary>
        /// Generate a URL that embeds manual ID verification for the specified document signer into your application.
        /// </summary>
        /// <returns>Embedded Verification Url.</returns>
        public async Task<EmbeddedVerificationCreated> CreateEmbeddedVerificationUrlAsync()
        {
            var documentId = "b584565c-ba75-4f92-9ef8-4df6dcbe8006";

            var embeddedVerificationRequest = new EmbeddedVerificationRequest()
            {
                EmailId = "signer1@email.com",
            };

            var embeddedVerificationCreated = await this.IdVerificationClient.CreateEmbeddedVerificationUrlAsync(documentId, embeddedVerificationRequest).ConfigureAwait(false);

            var embeddedVerificationUrl = embeddedVerificationCreated.Url;

            return embeddedVerificationCreated;
        }
    }
}