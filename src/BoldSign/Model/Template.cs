/*
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///     Template Document DTO.
    /// </summary>
    [DataContract]
    public class Template
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        /// <param name="documentId"> Gets or sets documentId..</param>
        /// <param name="senderDetail">senderDetail.</param>
        /// <param name="ccDetails"> Gets or sets the CC details..</param>
        /// <param name="createdDate"> Gets or sets the createdDate..</param>
        /// <param name="activityDate"> Gets or sets the activityDate..</param>
        /// <param name="activityBy"> Gets or sets the activityBy..</param>
        /// <param name="messageTitle"> Gets or sets the messageTitle..</param>
        /// <param name="status">status.</param>
        /// <param name="signerDetails"> Gets or sets the signerDetails..</param>
        /// <param name="enableSigningOrder"> Gets or sets a value indicating whether the SigningOrder is enabled..</param>
        /// <param name="templateName"> Gets or sets the templateName..</param>
        /// <param name="templateDescription"> Gets or sets the templateDescription..</param>
        /// <param name="accessType">accessType.</param>
        /// <param name="accessTid">
        ///     &lt;br&gt; Gets or sets the shared Team ID.  &lt;br&gt;The value represents the Team ID of the
        ///     template shared to..
        /// </param>
        /// <param name="isTemplate"> Gets or sets a value indicating whether get or Set the isTemplate. (default to false).</param>
        /// <param name="behalfOf">Gets or sets the behalf of details..</param>
        /// <param name="templateLabels">Gets or sets the template labels.</param>
        /// <param name="labels">Gets or sets the labels.</param>
        /// <param name="brandId">Gets or sets the brandId.</param>
        public Template(string documentId = default, TemplateSenderDetails senderDetail = default, List<TemplateCC> ccDetails = default, long createdDate = default, long? activityDate = default, string activityBy = default, string messageTitle = default, DocumentStatus? status = default, List<TemplateSignerDetails> signerDetails = default, bool enableSigningOrder = default, string templateName = default, string templateDescription = default, TemplateAccessType? accessType = default, string accessTid = default, bool isTemplate = false, BehalfOf behalfOf = default, List<string> templateLabels = default, List<string> labels = default, string brandId = default)
        {
            this.DocumentId = documentId;
            this.CcDetails = ccDetails;
            this.ActivityDate = activityDate;
            this.ActivityBy = activityBy;
            this.MessageTitle = messageTitle;
            this.SignerDetails = signerDetails;
            this.TemplateName = templateName;
            this.TemplateDescription = templateDescription;
            this.AccessTid = accessTid;
            this.DocumentId = documentId;
            this.SenderDetail = senderDetail;
            this.CcDetails = ccDetails;
            this.CreatedDate = createdDate;
            this.ActivityDate = activityDate;
            this.ActivityBy = activityBy;
            this.MessageTitle = messageTitle;
            this.Status = status;
            this.SignerDetails = signerDetails;
            this.EnableSigningOrder = enableSigningOrder;
            this.TemplateName = templateName;
            this.TemplateDescription = templateDescription;
            this.AccessType = accessType;
            this.AccessTid = accessTid;
            this.BehalfOf = behalfOf;
            this.TemplateLabels = templateLabels;
            this.Labels = labels;
            this.BrandId = brandId;

            // use default value if no "isTemplate" provided
            if (isTemplate == null)
            {
                this.IsTemplate = false;
            }
            else
            {
                this.IsTemplate = isTemplate;
            }
        }

        /// <summary>
        ///      Gets or sets the document status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DocumentStatus? Status { get; set; }

        /// <summary>
        ///     Gets or sets template access type.
        /// </summary>
        [DataMember(Name = "accessType", EmitDefaultValue = false)]
        public TemplateAccessType? AccessType { get; set; }

        /// <summary>
        ///      Gets or sets document Id.
        /// </summary>
        /// <value> Gets or sets documentId.</value>
        [DataMember(Name = "documentId", EmitDefaultValue = true)]
        public string DocumentId { get; set; }

        /// <summary>
        ///      Gets or sets sender details.
        /// </summary>
        [DataMember(Name = "senderDetail", EmitDefaultValue = false)]
        public TemplateSenderDetails SenderDetail { get; set; }

        /// <summary>
        ///      Gets or sets the CC details.
        /// </summary>
        /// <value> Gets or sets the CC details.</value>
        [DataMember(Name = "ccDetails", EmitDefaultValue = true)]
        public List<TemplateCC> CcDetails { get; set; }

        /// <summary>
        ///      Gets or sets the created date.
        /// </summary>
        /// <value> Gets or sets the createdDate.</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public long CreatedDate { get; set; }

        /// <summary>
        ///      Gets or sets the activity date which is the date of any particular action by user on a document.
        /// </summary>
        /// <value> Gets or sets the activityDate.</value>
        [DataMember(Name = "activityDate", EmitDefaultValue = true)]
        public long? ActivityDate { get; set; }

        /// <summary>
        ///      Gets or sets the name of the user who performed an action on a document.
        /// </summary>
        /// <value> Gets or sets the activityBy.</value>
        [DataMember(Name = "activityBy", EmitDefaultValue = true)]
        public string ActivityBy { get; set; }

        /// <summary>
        ///      Gets or sets the message title.
        /// </summary>
        /// <value> Gets or sets the messageTitle.</value>
        [DataMember(Name = "messageTitle", EmitDefaultValue = true)]
        public string MessageTitle { get; set; }

        /// <summary>
        ///      Gets or sets the signer details.
        /// </summary>
        /// <value> Gets or sets the signerDetails.</value>
        [DataMember(Name = "signerDetails", EmitDefaultValue = true)]
        public List<TemplateSignerDetails> SignerDetails { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether signing order is enabled.
        /// </summary>
        /// <value> Gets or sets a value indicating whether the SigningOrder is enabled.</value>
        [DataMember(Name = "enableSigningOrder", EmitDefaultValue = false)]
        public bool EnableSigningOrder { get; set; }

        /// <summary>
        ///      Gets or sets the template name.
        /// </summary>
        /// <value> Gets or sets the templateName.</value>
        [DataMember(Name = "templateName", EmitDefaultValue = true)]
        public string TemplateName { get; set; }

        /// <summary>
        ///      Gets or sets the template description.
        /// </summary>
        /// <value> Gets or sets the templateDescription.</value>
        [DataMember(Name = "templateDescription", EmitDefaultValue = true)]
        public string TemplateDescription { get; set; }

        /// <summary>
        ///     &lt;br&gt; Gets or sets the shared Team ID.  &lt;br&gt;The value represents the Team ID of the template shared to.
        /// </summary>
        /// <value>
        ///     &lt;br&gt; Gets or sets the shared Team ID.  &lt;br&gt;The value represents the Team ID of the template shared
        ///     to.
        /// </value>
        [DataMember(Name = "accessTid", EmitDefaultValue = true)]
        public string AccessTid { get; set; }

        /// <summary>
        ///      Gets or sets a value indicating whether it is a template.
        /// </summary>
        /// <value> Gets or sets a value indicating whether get or Set the isTemplate.</value>
        [DataMember(Name = "isTemplate", EmitDefaultValue = false)]
        public bool IsTemplate { get; set; }

        /// <summary>
        /// Gets or sets the behalf of details.
        /// </summary>
        [DataMember(Name = "behalfOf", EmitDefaultValue = false)]
        public BehalfOf BehalfOf { get; set; }

        /// <summary>
        /// Gets or sets the template labels.
        /// </summary>
        [DataMember(Name = "templateLabels", EmitDefaultValue = false)]
        public List<string> TemplateLabels { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// Gets or sets the brandId.
        /// </summary>
        [DataMember(Name = "brandId", EmitDefaultValue = false)]
        public string BrandId { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
