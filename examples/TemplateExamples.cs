namespace BoldSign.Examples
{
    using BoldSign.Api;
    using BoldSign.Api.Model;
    using BoldSign.Model;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using System.Linq;

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
        /// Edits a template.
        /// </summary>
        /// <returns>A task.</returns>
        public async  Task EditTemplate()
        {
            // This is an example template  id, add your own template id upon usage.
            var templateId = "cc8e9326-c0a9-4caf-808f-17d9499d1abc";
            var formFields = new List<FormField>
            {
                new FormField(
                    id: "Sign",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30)),
            };
            var editTemplateRequest = new EditTemplateRequest(templateId)
            {
                DocumentTitle = "new title",
                Roles = new List<TemplateRole>
                {
                    new TemplateRole(
                        1,
                        name: "RoleName",
                        defaultSignerEmail: "signer1@email.com",
                        defaultSignerName: "signer1",
                        signerOrder: 1,
                        signerType: SignerType.Signer,
                        formFields: formFields,
                        locale: Locales.EN),
                },
                EnableSigningOrder = true,
           

            };

            await this.templateApi.EditTemplateAsync(editTemplateRequest).ConfigureAwait(false);
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

            var formFields = new List<FormField>
            {
                new FormField(
                    id: "Sign",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30)),
            };

            var roles = new List<Roles>
            {
                new Roles(
                    roleSignerIndex: 1,
                    roleSignerEmailAddress: "signer1@email.com",
                    roleSignerName: "signer1",
                    signerOrder: 1,
                    signerType: SignerType.Signer,
                    formFields: formFields,
                    locale: Locales.EN)
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
        /// Add the template tag.
        /// </summary>
        public void AddTemplateTags()
        {
            TemplateTag addTags = new TemplateTag()
            {
                TemplateId = "6c386439-7f23-405a-98a3-a1bf3451a1ab",
                TemplateLabels = new List<string>
                {
                    "test",
                    "test1"
                },
                DocumentLabels = new List<string>
                {
                    "test2",
                    "test3"
                }
            };

            this.templateApi.AddTag(addTags);
        }
        
        /// <summary>
        /// Delete the template properties.
        /// </summary>
        public void DeleteTags()
        {
            TemplateTag addTags = new TemplateTag()
            {
                TemplateId = "6c386439-7f23-405a-98a3-a1bf3451a1ab",
                TemplateLabels = new List<string>
                {
                    "test",
                    "test1"
                },
                DocumentLabels = new List<string>
                {
                    "test2",
                    "test3"
                }
            };

            this.templateApi.DeleteTag(addTags);
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
                AutoDetectFields = true,
                Roles = new List<TemplateRole>
                {
                    new TemplateRole(
                        1,
                        name: "RoleName",
                        defaultSignerEmail: "signer1@email.com",
                        defaultSignerName: "signer1",
                        signerOrder: 1,
                        signerType: SignerType.Signer,
                        formFields: formFields,
                        locale: Locales.EN)
                },
                DocumentInfo = new List<DocumentInfo>
                {
                    new DocumentInfo(
                        documentTitle: "Sent using template created from API SDK",
                        documentDescription: "This is document message sent from API SDK",
                        locale: Locales.EN),
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
        ///     Creates the template.
        /// </summary>
        public async Task<TemplateCreated> CreateTemplateWithRadioButtonField()
        {
            var radioButtonFields = new List<RadioButtonField>
            {
                new RadioButtonField(
                    id: "Tamil_Language",
                    pageNumber: 1,
                    isRequired: true,
                    label: "Tamil",
                    groupName: "Language",
                    bounds: new Rectangle(x: 50, y: 100, width: 20, height: 20)),
                new RadioButtonField(
                    id: "Maths_Language",
                    pageNumber: 1,
                    isRequired: true,
                    label: "Maths",
                    groupName: "Language",
                    bounds: new Rectangle(x: 150, y: 200, width: 20, height: 20)),
            };

            var templateDetails = new CreateTemplateRequest
            {
                Title = "Template created from API SDK",
                Description = "The is a template created to get a quick contract sign.",
                EnableSigningOrder = true,
                AutoDetectFields = true,
                Roles = new List<TemplateRole>
                {
                    new TemplateRole(
                        roleIndex: 1,
                        name: "RoleName",
                        defaultSignerEmail: "signer1@email.com",
                        defaultSignerName: "signer1",
                        signerOrder: 1,
                        signerType: SignerType.Signer,
                        formFields: radioButtonFields.Cast<FormField>().ToList(),
                        locale: Locales.EN)
                },
                DocumentInfo = new List<DocumentInfo>
                {
                    new DocumentInfo(
                        documentTitle: "Sent using template created from API SDK",
                        locale: Locales.EN,
                        documentDescription: "This is document message sent from API SDK"),
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
                DocumentMessage = "This is document message sent from API SDK",
                EnableSigningOrder = true,
                AutoDetectFields = true,
                Roles = new List<TemplateRole>
                {
                    new TemplateRole(
                        1,
                        name: "Engineer",
                        defaultSignerEmail: "signer1@email.com",
                        defaultSignerName: "signer1",
                        signerOrder: 1,
                        signerType: SignerType.Signer,
                        formFields: formFields,
                        locale: Locales.EN),
                },
                DocumentInfo = new List<DocumentInfo>
                {
                    new DocumentInfo(
                        documentTitle: "Sent using template created from API SDK",
                        locale:Locales.EN,
                        documentDescription: "This is document message sent from API SDK"),
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
        
        /// <summary>
        /// <para>Creates the document using merge the templates.</para>
        /// </summary>
        /// <returns>A DocumentCreated.</returns>
        public DocumentCreated MergeAndSend()
        {
            // This is list of example template ids, add your own template ids created from the web app upon usage.
            string[] templateIds = { "templateId1", "templateId2", "moreTemplateIds..." };

            var formFields = new List<FormField>
            {
                new FormField(
                    id: "Sign1",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30))

            };
            var formFields2 = new List<FormField>
            {
                new FormField(
                    id: "Sign2",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 150, y: 150, width: 200, height: 30)),
            };
            var formFields3 = new List<FormField>
            {
                new FormField(
                    id: "Sign3",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 250, y: 250, width: 200, height: 30)),
            };


            var roles = new List<Roles>
            {
                new Roles(
                    roleSignerIndex: 1,
                    roleSignerEmailAddress: "sign1@gmail.com",
                    roleSignerName: "sign1",
                    signerOrder: 1,
                    signerType: SignerType.Signer,
                    formFields: formFields,
                    locale: Locales.EN),
                new Roles(
                    roleSignerIndex: 2,
                    roleSignerEmailAddress: "sign2@gmail.com",
                    roleSignerName: "sign2",
                    signerOrder: 1,
                    signerType: SignerType.Signer,
                    formFields: formFields2,
                    locale: Locales.EN),
                new Roles(
                    roleSignerIndex: 3,
                    roleSignerEmailAddress: "sign3@gmail.com",
                    roleSignerName: "sign3",
                    signerOrder: 1,
                    signerType: SignerType.Signer,
                    formFields: formFields3,
                    locale: Locales.EN)
            };

            var templateDetails = new MergeAndSendForSign(
                templateIds: templateIds,
                title: "Create Document from Merged Templates",
                message: "This is the document description",
                roles: roles);

            var documentCreated = this.templateApi.MergeAndSend(templateDetails);

            return documentCreated;
        }
        
        /// <summary>
        ///     Remove the fields via send document using template.
        /// </summary>
        /// <returns>A DocumentCreated.</returns>
        public DocumentCreated RemoveFieldsViaTemplateSend()
        {
            // This is an example document id, add your own template id created from the web app upon usage.
            var templateId = "43707a56-e2e1-4bde-9ce1-1b2958fcc015";

            var templateDetails = new SendForSignFromTemplate(
                templateId: templateId,
                title: "Document from Template",
                message: "This document description",
                roles:new List<Roles>()
                {
                    new Roles()
                    {
                        RoleIndex = 1,
                        SignerName = "signer",
                        SignerEmail = "signer@123.com",
                        SignerOrder = 1,
                        SignerRole = "signer",
                        SignerType = SignerType.Signer,
                    }
                });
            var removefields = new List<string>();
            removefields.Add("TextBox1");
            templateDetails.RemoveFormFields = removefields;
            var documentCreated = this.templateApi.SendUsingTemplate(templateDetails);

            return documentCreated;
        }
    }
}
