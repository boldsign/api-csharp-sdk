namespace BoldSign.Examples
{
    using System;
    using BoldSign.Api;
    using BoldSign.Model;
    using System.Collections.Generic;
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
            // This is an example document id, add your own template id created from the web app upon usage.
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
            // This is an example document id, add your own template id created from the web app upon usage.
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
                roles: roles);

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
    }
}
