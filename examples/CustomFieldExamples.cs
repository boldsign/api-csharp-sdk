using BoldSign.Api;
using BoldSign.Model;
using System;

namespace BoldSign.Examples
{
    /// <summary>
    /// The Custom Field Examples.
    /// </summary>
    public class CustomFieldExamples
    {
        private readonly ICustomFieldClient CustomFieldClient;
        
        public CustomFieldExamples(ICustomFieldClient customFieldClient) => this.CustomFieldClient = customFieldClient;

        /// <summary>
        /// Creates a custom field for the specified brand.
        /// </summary>
        public void CreateCustomField()
        {
            var brandCustomFieldDetails = new BrandCustomFieldDetails()
            {
                FieldName = "Field Name",
                FieldDescription = "Description",
                FieldOrder = 1,
                BrandId = "Brand Id",
                FormField = new CustomFormField(
                    type: FieldType.Signature,
                    isRequired: true),
            };

            this.CustomFieldClient.CreateCustomField(brandCustomFieldDetails);
        }
        
        /// <summary>
        /// Edits a custom field for the specified brand.
        /// </summary>
        public void EditCustomField()
        {
            var brandCustomFieldDetails = new BrandCustomFieldDetails()
            {
                FieldName = "Field Name",
                FieldDescription = "Description",
                FieldOrder = 1,
                BrandId = "Brand Id",
                FormField = new CustomFormField(
                    type: FieldType.Signature,
                    isRequired: true),
            };
            
            var customFieldId = "custom field id";

            this.CustomFieldClient.EditCustomField(customFieldId, brandCustomFieldDetails);
        }
        
        /// <summary>
        /// Deletes a custom field for the specified brand.
        /// </summary>
        public void DeleteCustomField()
        {
            var customFieldId = "custom field id";

            this.CustomFieldClient.DeleteCustomField(customFieldId);
        }

        /// <summary>
        /// Gets the all custom field for the specified brand.
        /// </summary>
        public void GetCustomField()
        {
            var brandId = "Brand Id";

            this.CustomFieldClient.GetBrandBasedCustomFields(brandId);
        }

        /// <summary>
        /// Generates a URL to embed manipulation of custom field process.
        /// </summary>
        public void CreateEmbeddedCustomFieldUrl()
        {
            var embeddedCustomFieldDetails = new EmbeddedCustomFieldDetails()
            {
                BrandId = "Brand Id",
                LinkValidTill = DateTime.UtcNow.AddDays(1),
            };

            this.CustomFieldClient.CreateEmbeddedCustomFieldUrl(embeddedCustomFieldDetails);
        }
    }
}