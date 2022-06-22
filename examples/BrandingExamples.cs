using BoldSign.Api;
using BoldSign.Model;

namespace BoldSign.Examples
{
    /// <summary>
    /// The branding examples.
    /// </summary>
    public class BrandingExamples
    {
        private readonly BrandingClient BrandingClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandingExamples" /> class.
        /// </summary>
        /// <param name="BrandingClient">The brand api.</param>
        public BrandingExamples(BrandingClient BrandingClient) => this.BrandingClient = BrandingClient;

        /// <summary>
        /// Deletes the brand.
        /// </summary>
        public void DeleteBrand()
        {
            // This is an example brand id, add your own brand id upon usage.
            var brandId = "Your brand-id";
            this.BrandingClient.DeleteBrand(brandId);
        }

        /// <summary>
        /// Reset the default brand.
        /// </summary>
        public void ResetDefaultBrand()
        {
            // This is an example brand id, add your own brand id upon usage.
            var brandId = "Your brand-id";
            this.BrandingClient.ResetDefaultBrand(brandId);
        }

        /// <summary>
        /// Create the brand.
        /// </summary>
        public BrandingData CreateBrand()
        {
            var createBrandData = new BrandSettings()
            {
                // This is an example brand settings data to create, add your own brand settings upon usage.
                BrandName = "Brand from SDK",
                BrandLogo = new DocumentFileBytes
                {
                    ContentType = "image/jpg",
                    FileName = "assets/sample.jpg",
                },
                CombineAuditTrail = false,
                IsDefault = false,
                CanHideTagLine = false,
                DisclaimerDescription = "Consumer disclosure regarding conducting business electronically, receiving electronic notices, disclosures and other documents and to electronically sign documents.",
                DisclaimerTitle = "Classic Company Policy",
                EmailDisplayName = "{SenderName} via Your company name",
                BackgroundColor = "#EEF4F8",
                ButtonColor = "#00BDD4",
                ButtonTextColor = "#FFFFFF",
                RedirectUrl = "https://app.boldsign.com/dashboard",
            };
            var result = this.BrandingClient.CreateBrand(createBrandData);
            return result;
        }

        /// <summary>
        /// Edit the brand.
        /// </summary>
        public BrandingData EditBrand()
        {
            string brandId = "Your brand-id";

            var editBrandData = new BrandSettings()
            {
                // This is an example brand settings data to edit, add your own brand settings upon usage.
                BrandName = "Brand edit from SDK",
                BrandLogo = new DocumentFileBytes
                {
                    ContentType = "image/jpg",
                    FileName = "assets/sample.jpg",
                },
                CombineAuditTrail = false,
                IsDefault = false,
                CanHideTagLine = false,
                DisclaimerDescription = "Consumer disclosure regarding conducting business electronically, receiving electronic notices, disclosures and other documents and to electronically sign documents.",
                DisclaimerTitle = "Classic Company Policy",
                EmailDisplayName = "{SenderName} via Your company name",
                BackgroundColor = "#EEF4F8",
                ButtonColor = "#00BDD4",
                ButtonTextColor = "#FFFFFF",
                RedirectUrl = "https://app.boldsign.com/dashboard",
            };
            var result = this.BrandingClient.EditBrand(brandId, editBrandData);
            return result;
        }

        /// <summary>
        /// list the brand.
        /// </summary>
        public BrandingRecords ListBrand()
        {
            var brandRecords = this.BrandingClient.ListBrand();
            return brandRecords;
        }
    }
}