using BoldSign.Api.Model;

namespace BoldSign.Examples
{
    using BoldSign.Api;
    using BoldSign.Model;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Linq;

    /// <summary>
    ///     The document examples.
    /// </summary>
    public class DocumentExamples
    {
        private readonly DocumentClient DocumentClient;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DocumentExamples" /> class.
        /// </summary>
        /// <param name="DocumentClient">The document api.</param>
        public DocumentExamples(DocumentClient DocumentClient) => this.DocumentClient = DocumentClient;

        /// <summary>
        ///     Lists the documents.
        /// </summary>
        public DocumentRecords ListDocuments()
        {
            var documents = this.DocumentClient.ListDocuments(page: 1, pageSize: 20);

            return documents;
        }

        /// <summary>
        ///     Lists the team documents.
        /// </summary>
        public TeamDocumentRecords ListTeamDocuments()
        {
            var documents = this.DocumentClient.ListTeamDocuments(page: 1, pageSize: 20);

            return documents;
        }

        /// <summary>
        ///     Lists the behalf documents.
        /// </summary>
        public BehalfDocumentRecords ListBehalfDocuments()
        {
            var tags = new List<string> { "tag" };
            var recipients = new List<string> { "recipient1@email.com", "recipient2@email.com" };
            var documents = this.DocumentClient.ListBehalfDocuments(
                page: 1,
                pageSize: 20,
                labels: tags,
                signers: recipients);

            return documents;
        }

        /// <summary>
        ///     Lists the document by senders.
        /// </summary>
        public DocumentRecords ListDocumentBySenders()
        {
            var senders = new List<string> { "sender1@email.com", "sender2@email.com" };

            var documents = this.DocumentClient.ListDocuments(page: 1, pageSize: 20, sentBy: senders);

            return documents;
        }

        /// <summary>
        ///     Searches the documents.
        /// </summary>
        public DocumentRecords SearchDocuments()
        {
            var documents = this.DocumentClient.ListDocuments(page: 1, pageSize: 20, searchKey: "NDA");

            return documents;
        }

        /// <summary>
        ///     Lists the documents by status.
        /// </summary>
        public DocumentRecords ListDocumentsByStatus()
        {
            var status = new List<Status> { Status.Declined, Status.Completed };

            var documents = this.DocumentClient.ListDocuments(page: 1, pageSize: 20, status: status);

            return documents;
        }

        /// <summary>
        ///     Lists the documents with date rage.
        /// </summary>
        public DocumentRecords ListDocumentsWithDateRage()
        {
            var startDate = DateTime.UtcNow.Subtract(TimeSpan.FromDays(5));

            var documents = this.DocumentClient.ListDocuments(page: 1, pageSize: 20, startDate: startDate, endDate: DateTime.UtcNow);

            return documents;
        }

        /// <summary>
        ///    Add emailOTP authentication.
        /// </summary>
        public void AddAuthenticationEmailOTP()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            this.DocumentClient.AddAuthentication(documentId, "signer1@email.com", AuthenticationType.EmailOTP);
        }

        /// <summary>
        ///    Add AccessCode authentication.
        /// </summary>
        public void AddAuthenticationAccessCode()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            this.DocumentClient.AddAuthentication(documentId, "signer1@email.com", AuthenticationType.AccessCode, 1, "123456");
        }

        /// <summary>
        ///    Add emailOTP authentication(When Document signing order enabled).
        /// </summary>
        public void AddAuthenticationEmailOTPWithOrder()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            this.DocumentClient.AddAuthentication(documentId, "signer1@email.com", AuthenticationType.EmailOTP, 2);
        }

        /// <summary>
        ///    Add AccessCode authentication(When Document signing order enabled).
        /// </summary>
        public void AddAuthenticationAccessCodeWithOrder()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            // targeting 2nd order signer of the document
            this.DocumentClient.AddAuthentication(documentId, "signer1@email.com", AuthenticationType.AccessCode, 2, "123456");
        }

        /// <summary>
        ///     Gets the document properties.
        /// </summary>
        /// <returns>A DocumentProperties.</returns>
        public DocumentProperties GetDocumentProperties()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            var documentProperties = this.DocumentClient.GetProperties(documentId);

            return documentProperties;
        }

        /// <summary>
        ///     Downloads the document.
        /// </summary>
        /// <returns>A Stream.</returns>
        public Stream DownloadDocument()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            var documentStream = this.DocumentClient.DownloadDocument(documentId);

            return documentStream;
        }

        /// <summary>
        ///     Downloads the Attachment.
        /// </summary>
        /// <returns>A Stream.</returns>
        public Stream DownloadAttachment()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "87e96d94-2a50-4a6b-aff1-449283d395d3";
            var attachmentId = "attachment_6rn98";
            var documentStream = this.DocumentClient.DownloadAttachment(documentId, attachmentId);

            return documentStream;
        }

        /// <summary>
        ///     Downloads the document.
        /// </summary>
        /// <returns>A Stream.</returns>
        public Stream DownloadDocumentAuditLog()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            var documentStream = this.DocumentClient.DownloadAuditLog(documentId);

            return documentStream;
        }

        /// <summary>
        ///     Revokes the document.
        /// </summary>
        public void RevokeDocument()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            this.DocumentClient.RevokeDocument(documentId, "This is document revoke message");
        }

        /// <summary>
        ///     Deletes the document.
        /// </summary>
        public void DeleteDocument()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            this.DocumentClient.DeleteDocument(documentId);
        }

        /// <summary>
        ///Add the Tag.
        /// </summary>
        public void AddTags()
        {
            // This is an example document id, add your own document id upon usage.
            DocumentTags addTags = new DocumentTags()
            {
                DocumentId = "0ab99f4e-6d03-415e-b7bb-0d4b7c083e17",
                Tags = new List<string>
                {
                   "test",
                   "test1"
                }

            };
            this.DocumentClient.AddTag(addTags);

        }

        /// <summary>
        ///Delete the Tag.
        /// </summary>
        public void DeleteTags()
        {
            // This is an example document id, add your own document id upon usage.
            DocumentTags deletetags = new DocumentTags()
            {
                DocumentId = "0ab99f4e-6d03-415e-b7bb-0d4b7c083e17",
                Tags = new List<string>
                {
                    "test",
                   "test1"
                },

            };
            this.DocumentClient.DeleteTag(deletetags);
        }
        /// <summary>
        ///     Sends the reminder.
        /// </summary>
        public void SendReminder()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";
            var receiverEmails = new List<string> { "signer1@email.com" };
            var reminderMessage = new ReminderMessage("Please sign this document");

            this.DocumentClient.RemindDocument(documentId, receiverEmails, reminderMessage);
        }

        /// <summary>
        ///     Changes the access code.
        /// </summary>
        public void ChangeAccessCode()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            this.DocumentClient.ChangeAccessCode(documentId, "signer1@email.com", "newAccessCodeHere");
        }

        /// <summary>
        /// Extends the expiration date of the document.
        /// </summary>
        public void ExtendExpiry()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "052181ef-0817-41f6-9e75-6310b796d7fd";
            var newExpiryValue = "2022-10-15";
            this.DocumentClient.ExtendExpiry(documentId, newExpiryValue);
        }

        /// <summary>
        ///     chnages the recipient details.
        /// </summary>
        public void ChangeRecipient()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "1ace7c82-6770-4d03-b514-b593e20c4550";

            this.DocumentClient.ChangeRecipient(documentId, "signer1@gmail.com", "wrong email", "signer2", "signer2@email.com");
        }

        /// <summary>
        ///     Changes the access code (When Document signing order enabled).
        /// </summary>
        public void ChangeAccessCodeWithOrder()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            // targeting 2nd order signer of the document
            this.DocumentClient.ChangeAccessCode(documentId, "signer1@email.com", "newAccessCodeHere", 2);
        }

        /// <summary>
        ///     Gets the embedded sign link.
        /// </summary>
        public EmbeddedSigningLink GetEmbeddedSignLink()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            var embeddedSigningLink = this.DocumentClient.GetEmbeddedSignLink(
                documentId: documentId,
                signerEmail: "signer1@email.com",
                signLinkValidTill: DateTime.UtcNow.AddDays(1),
                redirectUrl: "https://myapp.com/sign/redirect");

            return embeddedSigningLink;
        }

        /// <summary>
        ///     Creates the document.
        /// </summary>
        public async Task<DocumentCreated> CreateDocument()
        {
            List<FormField> formFeilds = new List<FormField>();
            formFeilds.Add(new FormField(
                        name: "Sign",
                        type: FieldType.CheckBox,
                        pageNumber: 1,
                        isRequired: true,
                        bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30)));

            var documentDetails = new SendForSign
            {
                Title = "Sent from API SDK",
                Message = "This is document message sent from API SDK",
                EnableSigningOrder = true,
                Signers = new List<DocumentSigner>
                {
                    new DocumentSigner(
                        signerName: "Signer Name 1",
                        signerType: SignerType.Signer,
                        signerEmail: "ranjitha.vazhivittan+1@syncfusion.com",
                        signerOrder: 1,
                        authenticationCode: "123",
                        privateMessage: "This is private message for signer",
                        formFields: formFeilds,
                        locale: Locales.EN)
                },
            };

            // document read from local as byte array
            var fileBytes = File.ReadAllBytes("doc-1.pdf");

            // document read from local as stream
            using var fs = File.OpenRead("doc-2.pdf");

            documentDetails.Files = new List<IDocumentFile>
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

            var documentCreated = this.DocumentClient.SendDocument(documentDetails);

            return documentCreated;
        }

        /// <summary>
        ///     Creates the document with Formula field.
        /// </summary>
        public DocumentCreated CreateDocumentWithFormulaField()
        {
            TextBoxField textBox = new TextBoxField(
                id: "textbox1",
                validationType: Model.ValidationType.NumbersOnly,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 50, width: 100, height: 30)
            );
            DateSignedField dateField1 = new DateSignedField (
                id: "datepicker1",
                dateFormat: "MM/dd/yyyy",
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 100, width: 100, height: 30)
            );
            DateSignedField dateField2 = new DateSignedField (
                id: "datepicker2",
                dateFormat: "MM/dd/yyyy",
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 150, width: 100, height: 30)
            );
            FormField formulaField1 = new FormField(
                id: "Formula1",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 200, width: 200, height: 30)
            );
            FormField formulaField2 = new FormField(
                id: "Formula2",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 250, width: 200, height: 30)
            );
            FormField formulaField3 = new FormField(
                id: "Formula3",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 300, width: 200, height: 30)
            );
            FormField formulaField4 = new FormField(
                id: "Formula4",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 350, width: 200, height: 30)
            );
            FormField formulaField5 = new FormField(
                id: "Formula5",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 400, width: 200, height: 30)
            );
            FormField formulaField6 = new FormField(
                id: "Formula6",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 450, width: 200, height: 30)
            );
            FormField formulaField7 = new FormField(
                id: "Formula7",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 500, width: 200, height: 30)
            );
            FormField formulaField8 = new FormField(
                id: "Formula8",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 550, width: 200, height: 30)
            );
            FormField formulaField9 = new FormField(
                id: "Formula9",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 600, width: 200, height: 30)
            );
            FormField formulaField10 = new FormField(
                id: "Formula10",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 650, width: 200, height: 30)
            );
            FormField formulaField11 = new FormField(
                id: "Formula11",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 700, width: 200, height: 30)
            );
            FormField formulaField12 = new FormField(
                id: "Formula12",
                type: FieldType.Formula,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 750, width: 200, height: 30)
            );
            formulaField1.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "[textbox1] + 1",
                DecimalPrecision = 1
            };
            formulaField2.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "If([textbox1]>1,1,2)",
                DecimalPrecision = 1
            };
            formulaField3.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "Floor([textbox1]/2)",
                DecimalPrecision = 1
            };
            formulaField4.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "Ceil([textbox1]/2)",
                DecimalPrecision = 1
            };
            formulaField5.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "DateDiff([datepicker1],[datepicker2])",
                DecimalPrecision = 1
            };
            formulaField6.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "AddDays([datepicker1],1)",
                DecimalPrecision = 1
            };
            formulaField7.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "AddMonths([datepicker1],1)",
                DecimalPrecision = 1
            };
            formulaField8.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "AddYears([datepicker1],1)",
                DecimalPrecision = 1
            };
            formulaField9.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "Day([datepicker2])",
                DecimalPrecision = 1
            };
            formulaField10.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "Days([datepicker2])",
                DecimalPrecision = 1
            };
            formulaField11.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "Month([datepicker2])",
                DecimalPrecision = 1
            };
            formulaField12.FormulaFieldSettings = new FormulaFieldSettings {
                FormulaExpression = "Year([datepicker2])",
                DecimalPrecision = 1
            };
            List<FormField> formFields = new List<FormField>
            {
                textBox, dateField1, dateField2, formulaField1, formulaField2, formulaField3, formulaField4, formulaField5, formulaField6, formulaField7, formulaField8, formulaField9, formulaField10, formulaField11, formulaField12
            };
            var documentDetails = new SendForSign
            {
                Title = "Sent from API SDK",
                Message = "This is document message sent from API SDK",
                EnableSigningOrder = true,
                Signers = new List<DocumentSigner>
                {
                    new DocumentSigner(
                        signerName: "Signer Name 1",
                        signerEmail: "signer1@email.com",
                        signerOrder: 1,
                        authenticationCode: "123",
                        signerType: SignerType.Signer,
                        privateMessage: "This is private message for signer",
                        formFields: formFields,
                        locale: Locales.EN),
                },
                MetaData = new Dictionary<string, string>
                {
                    {"DocumentType","NDA"},{"DocumentCategory","Legal"}
                },
            };


            // document read from local as byte array
            var fileBytes = File.ReadAllBytes("doc-1.pdf");

            // document read from local as stream
            using var fs = File.OpenRead("doc-2.pdf");

            documentDetails.Files = new List<IDocumentFile>
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

            var documentCreated = this.DocumentClient.SendDocument(documentDetails);

            return documentCreated;
        }

        /// <summary>
        ///     Creates the document with Radio button.
        /// </summary>
        public async Task<DocumentCreated> CreateDocumentWithRadioButtonField()
        {
            var radioButtonFields = new List<RadioButtonField>
            {
                new RadioButtonField(
                    id: "Tamil_Language",
                    pageNumber: 1,
                    isRequired: true,
                    label: "Tamil",
                    groupName: "Language",
                    bounds: new Rectangle(x: 50, y: 200, width: 20, height: 20)),
                new RadioButtonField(
                    id: "Maths_Language",
                    pageNumber: 1,
                    isRequired: true,
                    label: "Maths",
                    groupName: "Language",
                    bounds: new Rectangle(x: 150, y: 200, width: 20, height: 20)),
            };

            var documentDetails = new SendForSign
            {
                Title = "Sent from API SDK",
                Message = "This is document message sent from API SDK",
                EnableSigningOrder = true,
                Signers = new List<DocumentSigner>
                {
                    new DocumentSigner(
                        signerName: "Signer Name 1",
                        signerEmail: "signer1@email.com",
                        signerOrder: 1,
                        authenticationCode: "123",
                        signerType: SignerType.Signer,
                        privateMessage: "This is private message for signer",
                        formFields: radioButtonFields.Cast<FormField>().ToList(),
                        locale: Locales.EN),
                },
            };


            // document read from local as byte array
            var fileBytes = File.ReadAllBytes("doc-1.pdf");

            // document read from local as stream
            using var fs = File.OpenRead("doc-2.pdf");

            documentDetails.Files = new List<IDocumentFile>
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

            var documentCreated = this.DocumentClient.SendDocument(documentDetails);

            return documentCreated;
        }

        /// <summary>
        ///     Creates the document with scheduled send date.
        /// </summary>
        public DocumentCreated CreateDocumentWithScheduledSendDate()
        {
            List<FormField> formFields = new List<FormField>
            {
                new FormField(
                    id: "Sign",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30)),
            };

            // This is an example scheduled send date, add your own scheduled send date and convert to epoch time.
            DateTime scheduledSendDate = DateTime.UtcNow.AddDays(1);
            long scheduledSendTime = (long)(scheduledSendDate - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

            var documentDetails = new SendForSign
            {
                Title = "Sent from API SDK",
                Message = "This is document message sent from API SDK",
                Signers = new List<DocumentSigner>
                {
                    new DocumentSigner(
                        signerName: "Signer Name 1",
                        signerEmail: "signer1@email.com",
                        signerType: SignerType.Signer,
                        formFields: formFields,
                        locale: Locales.EN),
                },
                ScheduledSendTime = scheduledSendTime,
            };


            // document read from local as byte array
            var fileBytes = File.ReadAllBytes("doc-1.pdf");

            // document read from local as stream
            using var fs = File.OpenRead("doc-2.pdf");

            documentDetails.Files = new List<IDocumentFile>
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

            var documentCreated = this.DocumentClient.SendDocument(documentDetails);

            return documentCreated;
        }

        /// <summary>
        ///  Creates the document with File urls.
        /// </summary>
        public async Task<DocumentCreated> CreateDocumentWithFileUrl()
        {
            List<FormField> formFields = new List<FormField>
            {
                new FormField(
                    name: "Sign",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30)),
            };

            var documentDetails = new SendForSign
            {
                Title = "Sent from API SDK",
                Message = "This is document message sent from API SDK",
                EnableSigningOrder = true,
                Signers = new List<DocumentSigner>
                {
                    new DocumentSigner(
                        signerName: "Signer Name 1",
                        signerType: SignerType.Signer,
                        signerEmail: "signer1@email.com",
                        signerOrder: 1,
                        authenticationCode: "123",
                        privateMessage: "This is private message for signer",
                        formFields:formFields,
                        locale: Locales.EN),
                },
            };

            documentDetails.FileUrls = new List<Uri>()
            {
                new Uri("https://example.com/EBrochure.pdf"),
                new Uri("https://example.com/Brouchure2021.pdf")
            };
            var documentCreated = this.DocumentClient.SendDocument(documentDetails);

            return documentCreated;
        }

        ///  Creates the document with resize option provided form fields.
        /// </summary>
        public DocumentCreated CreateDocumentWithResizeOption()
        {
            FormField formField1 = new FormField(
                id: "Textbox1",
                type: FieldType.TextBox,
                pageNumber: 1,
                bounds: new Rectangle(x: 50, y: 50, width: 80, height: 17)
            );

            formField1.ResizeOption = ResizeOptions.GrowBoth;
            formField1.IsRequired = true;

            List<FormField> formFields = new List<FormField> {formField1};
            var documentDetails = new SendForSign
            {
                Title = "Sent from API SDK",
                Message = "This is document message sent from API SDK",
                EnableSigningOrder = true,
                Signers = new List<DocumentSigner>
                {
                    new DocumentSigner(
                        signerName: "Signer Name 1",
                        signerEmail: "signer1@email.com",
                        signerOrder: 1,
                        authenticationCode: "123",
                        signerType: SignerType.Signer,
                        privateMessage: "This is private message for signer",
                        formFields:formFields,
                        locale: Locales.EN),
                },
            };

            documentDetails.FileUrls = new List<Uri>()
            {
                new Uri("https://example.com/sample.pdf")
            };
            var documentCreated = this.DocumentClient.SendDocument(documentDetails);

            return documentCreated;
        }

        /// <summary>
        ///     Embedded sends the document and generates a URL to embedded that document into iframe.
        /// </summary>
        public async Task EmbeddedSendDocument()
        {
            List<FormField> formFields = new List<FormField>
            {
                new FormField(
                    name: "Sign",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30)),
            };

            var documentRequest = new EmbeddedDocumentRequest
            {
                Title = "Sent from API SDK",
                Message = "This is document message sent from API SDK",
                EnableSigningOrder = true,
                Signers = new List<DocumentSigner>
                {
                    new DocumentSigner(
                        signerName: "Signer Name 1",
                        signerType: SignerType.Signer,
                        signerEmail: "signer1@email.com",
                        signerOrder: 1,
                        authenticationCode: "123",
                        privateMessage: "This is private message for signer",
                        formFields: formFields,
                        locale: Locales.EN),
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
                SendViewOption = PageViewOption.PreparePage,
                ShowToolbar = true,
                ShowNavigationButtons = true,
                ShowSaveButton = true,
                ShowPreviewButton = false,
                ShowSendButton = true,
            };

            var documentCreated = await this.DocumentClient.CreateEmbeddedRequestUrlAsync(documentRequest);

            // url to send the document from your web application
            var documentSendUrl = documentCreated.SendUrl;
        }
        /// <summary>
        ///     Removes the access code.
        /// </summary>
        public void RemoveAuthentication()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "949ebf20-45a8-4a3e-91a9-68e9540e0020";

            this.DocumentClient.RemoveAuthentication(documentId, "signer1@email.com", 1);
        }

        /// <summary>
        ///     Embedded sends the document with allow scheduled send.
        /// </summary>
        public async Task EmbeddedSendDocumentWithAllowScheduledSend()
        {
            List<FormField> formFields = new List<FormField>
            {
                new FormField(
                    name: "Sign",
                    type: FieldType.Signature,
                    pageNumber: 1,
                    isRequired: true,
                    bounds: new Rectangle(x: 50, y: 50, width: 200, height: 30)),
            };

            var documentRequest = new EmbeddedDocumentRequest
            {
                Title = "Sent from API SDK",
                Message = "This is document message sent from API SDK",
                Signers = new List<DocumentSigner>
                {
                    new DocumentSigner(
                        signerName: "Signer Name 1",
                        signerEmail: "signer1@email.com",
                        signerType: SignerType.Signer,
                        formFields: formFields,
                        locale: Locales.EN),
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
                AllowScheduledSend = true,

                // customize page options
                SendViewOption = PageViewOption.PreparePage,
                ShowToolbar = true,
                ShowNavigationButtons = true,
                ShowSaveButton = true,
                ShowPreviewButton = false,
                ShowSendButton = true,
            };

            var documentCreated = await this.DocumentClient.CreateEmbeddedRequestUrlAsync(documentRequest);

            // url to send the document from your web application
            var documentSendUrl = documentCreated.SendUrl;
        }

        /// <summary>
        /// pre fill form field.
        /// </summary>
        public async Task PrefillFieldsAsync()
        {
            // This is an example document id, add your own document id upon usage.
            var documentId = "702d9699-3f01-4a46-ac70-c0545cff73b7";
            var prefillFieldRequest = new PrefillFieldRequest(documentId)
            {
                Fields = new List<PrefillField>()
                {
                    new PrefillField()
                    {
                        Id = "checkbox_v4tuQ",
                        Value = "off"
                    }
                },
            };

            await this.DocumentClient.PrefillFieldsAsync(prefillFieldRequest);
        }

    }
}
