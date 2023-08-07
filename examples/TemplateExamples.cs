namespace BoldSign.Examples
{
    using BoldSign.Api;
    using BoldSign.Api.Model;
    using BoldSign.Model;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    /// <summary>
    ///     The template examples.
    /// </summary>
    public class TemplateExamples
    {
        private readonly TemplateClient templateApi;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TemplateExamples" /> class.
        /// </summary>
        /// <param name="templateApi">The template api.</param>
        public TemplateExamples(TemplateClient templateApi) => this.templateApi = templateApi;

        /// <summary>
        ///     Lists the templates.
        /// </summary>
        /// <returns>A TemplateRecords.</returns>
        public TemplateRecords ListTemplates()
        {
            var templates = this.templateApi.ListTemplates(page: 1, pageSize: 20);

            return templates;
        }

        /// <summary>
        ///     Deletes the template.
        /// </summary>
        public void DeleteTemplate()
        {
            // This is an example document id, add your own document id upon usage.
            var templateId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            this.templateApi.DeleteTemplate(templateId);
        }

        /// <summary>
        ///     Creates the document using template without any customization.
        /// </summary>
        /// <returns>A DocumentCreated.</returns>
        public DocumentCreated CreateDocumentUsingTemplate()
        {
            // This is an example document id, add your own document id upon usage.
            var templateId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            var templateDetails = new SendForSignFromTemplate(
                templateId: templateId,
                title: "Document from Template",
                message: "This document description");

            var documentCreated = this.templateApi.SendUsingTemplate(templateDetails);

            return documentCreated;
        }

        /// <summary>
        ///     <para>Creates the document using template with customization.</para>
        ///     <para>We can only Customize/Edit predefined roles, we cannot add or delete roles from the template already created.</para>
        /// </summary>
        /// <returns>A DocumentCreated.</returns>
        public DocumentCreated CreateDocumentWithCustomRoles()
        {
            // This is an example document id, add your own document id upon usage.
            var templateId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            var roles = new List<Roles>
            {
                new Roles
                {
                    RoleIndex = 1,
                    SignerEmail = "signer1@email.com",
                    SignerName = "Signer Name",
                },
            };

            var templateDetails = new SendForSignFromTemplate(
                templateId: templateId,
                title: "Document from Template",
                message: "This document description",
                roles: roles,
                roleRemovalIndices: new []{2,3});

            var documentCreated = this.templateApi.SendUsingTemplate(templateDetails);

            return documentCreated;
        }

        /// <summary>
        ///     Send embedded document using template without any customization.
        /// </summary>
        /// <returns>A DocumentCreated.</returns>
        public async Task<EmbeddedSendCreated> CreateEmbeddedDocumentUsingTemplate()
        {
            // This is an example document id, add your own template id created from the web app upon usage.
            var templateId = "0992eb79-ea24-4e95-887a-10aa82b30957";

            var templateRequest = new EmbeddedTemplateRequest(
                templateId: templateId,
                title: "Document from Template",
                message: "This document description")
            {
                // customize page options
                SendViewOption = PageViewOption.PreparePage,
                ShowToolbar = true,
                ShowNavigationButtons = false,
                ShowSaveButton = false,
                ShowPreviewButton = true,
                ShowSendButton = false,
            };

            var documentCreated = await this.templateApi.CreateEmbeddedRequestUrlAsync(templateRequest);

            // url to send the document from your web application
            var sendUrl = documentCreated.SendUrl;

            return documentCreated;
        }

        /// <summary>
        ///     Downloads the template.
        /// </summary>
        /// <returns>A Stream.</returns>
        public Stream DownloadTemplate()
        {
            // This is an example template id, add your own template id upon usage.
            var templateId = "da9cc375-5bce-4ce2-b224-33792e3a3282";

            var templateStream = this.templateApi.DownloadTemplate(templateId);

            return templateStream;
        }

        /// <summary>
        ///     Gets the template properties.
        /// </summary>
        /// <returns>A TemplateProperties.</returns>
        public TemplateProperties GetProperties()
        {
            // This is an example template id, add your own template id upon usage.
            var templateId = "077a0ef6-9673-4806-88bb-d2e552558ca0";

            var templateProperties = this.templateApi.GetProperties(templateId);

            return templateProperties;
        }
        
        /// <summary>
        ///  Generates a edit URL to embeds template edit process into your application.
        /// </summary>
        /// <returns>A Embedded Template Edited.</returns>
        public async Task<EmbeddedTemplateEdited> GetEmbeddedTemplateEditUrl()
        {
            // This is an example, add your own template id created from the embedded request.
            var templateId = "3ecbb6ba-80c6-4107-a47e-d00e2318a4ca";

            var embeddedTemplateEditRequest = new EmbeddedTemplateEditRequest()
            {
                TemplateId = templateId,
                // customize page options
                ViewOption = PageViewOption.FillingPage,
                ShowToolbar = true,
                ShowNavigationButtons = true,
                ShowSaveButton = true,
                ShowPreviewButton = true,
                ShowCreateButton = true,
            };

            var embeddedTemplateEdited = await this.templateApi.GetEmbeddedTemplateEditUrlAsync(embeddedTemplateEditRequest).ConfigureAwait(false);

            return embeddedTemplateEdited;
        }
        
        /// <summary>
        ///     Creates the template.
        /// </summary>
        public async Task<TemplateCreated> CreateTemplate()
        {
            var formFields = new List<FormField>
            {
                new FormField(
                    id: "Sign",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30)),
            };

            var templateDetails = new CreateTemplateRequest
            {
                Title = "Template created from API SDK",
                Description = "The is a template created to get a quick contract sign.",
                EnableSigningOrder = true,
                Roles = new List<TemplateRole>
                {
                    new TemplateRole(
                        index: 1,
                        name: "RoleName",
                        defaultSignerEmail: "signer1@email.com",
                        defaultSignerName: "signer1",
                        signerOrder: 1,
                        signerType: SignerType.Signer,
                        formFields: formFields),
                },
                DocumentInfo = new List<DocumentInfo>
                {
                    new DocumentInfo(
                        title: "Sent using template created from API SDK",
                        language: Languages.English,
                        description: "This is document message sent from API SDK"),
                }
            };

            // document read from local as byte array
            var fileBytes = await File.ReadAllBytesAsync("doc-1.pdf");

            // document read from local as stream
            await using var fs = File.OpenRead("doc-2.pdf");

            templateDetails.Files = new List<IDocumentFile>
            {
                new DocumentFilePath
                {
                    ContentType = "application/pdf",

                    // directly provide file path
                    FilePath = "doc-1.pdf",
                },
                new DocumentFileBytes
                {
                    ContentType = "application/pdf",
                    FileData = fileBytes,
                    FileName = "doc-1.pdf",
                },
                new DocumentFileStream
                {
                    ContentType = "application/pdf",
                    FileData = fs,
                    FileName = "doc-2.pdf",
                },
            };

            var templateCreated = await this.templateApi.CreateTemplateAsync(templateDetails);

            return templateCreated;
        }
        
        /// <summary>
        ///     Embedded create the template and generates a URL to embedded that template into iframe.
        /// </summary>
        public async Task EmbeddedCreateTemplate()
        {
            var formFields = new List<FormField>
            {
                new FormField(
                    id: "Sign",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30)),
            };

            var templateRequest = new CreateEmbeddedTemplateRequest
            {
                Title = "Template created from API SDK",
                Description = "The is a template created to get a quick contract sign.",
                DocumentTitle = "Sent using template created from API SDK",
                DocumentMessage = "This is document message sent from API SDK",
                EnableSigningOrder = true,
                Roles = new List<TemplateRole>
                {
                    new TemplateRole(
                        index: 1,
                        name: "Engineer",
                        defaultSignerEmail: "signer1@email.com",
                        defaultSignerName: "signer1",
                        signerOrder: 1,
                        signerType: SignerType.Signer,
                        formFields: formFields),
                },
                Files = new List<IDocumentFile>
                {
                    new DocumentFilePath
                    {
                        ContentType = "application/pdf",

                        // directly provide file path
                        FilePath = "doc-1.pdf",
                    },
                },

                // customize page options
                ViewOption = PageViewOption.PreparePage,
                ShowToolbar = true,
                ShowNavigationButtons = true,
                ShowSaveButton = true,
                ShowPreviewButton = false,
                ShowSendButton = true,
            };

            var templateCreated = await this.templateApi.CreateEmbeddedTemplateUrlAsync(templateRequest);

            // url to send the document from your web application
            var templateCreateUrl = templateCreated.CreateUrl;
        }
    }
}
