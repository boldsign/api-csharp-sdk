namespace BoldSign.Api
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using BoldSign.Api.Extensions;
    using BoldSign.Api.Model;
    using BoldSign.Api.Resources;
    using BoldSign.Model;
    using BoldSign.Model.IdVerification;

    internal static class FromRequestHelper
    {
        public static Dictionary<string, string> ConvertToFormRequest(SendForSign signRequestDetails, Dictionary<string, string> localVarFormParams)
        {
            if (signRequestDetails.Title != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.Title), signRequestDetails.Title);
            }

            localVarFormParams.Add(nameof(signRequestDetails.ExpiryValue), signRequestDetails.ExpiryValue.ToString(CultureInfo.CurrentCulture));

            localVarFormParams.Add(nameof(signRequestDetails.ExpiryDateType), signRequestDetails.ExpiryDateType.ToString());

            if (signRequestDetails.ScheduledSendTime != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.ScheduledSendTime), signRequestDetails.ScheduledSendTime.Value.ToString(CultureInfo.CurrentCulture));
            }

            if (signRequestDetails.Message != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.Message), signRequestDetails.Message);
            }

            if (signRequestDetails.Signers != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, signRequestDetails.Signers.ToList(), nameof(signRequestDetails.Signers));
            }

            if (signRequestDetails.CC != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, signRequestDetails.CC.ToList(), nameof(signRequestDetails.CC));
            }

            if (signRequestDetails.DocumentInfo != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, signRequestDetails.DocumentInfo.ToList(), nameof(signRequestDetails.DocumentInfo));
            }

            if (signRequestDetails.TextTagDefinitions != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, signRequestDetails.TextTagDefinitions.ToList(), nameof(signRequestDetails.TextTagDefinitions));
            }

            if (signRequestDetails.FormGroups != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, signRequestDetails.FormGroups.ToList(), nameof(signRequestDetails.FormGroups));
            }

            if (signRequestDetails.Labels != null)
            {
                var i = -1;
                foreach (var tag in signRequestDetails.Labels)
                {
                    if (string.IsNullOrEmpty(tag))
                    {
                        throw new ApiException(400, ApiValidationMessages.EmptyLabels);
                    }

                    localVarFormParams.Add($"{nameof(signRequestDetails.Labels)}[{++i}]", tag?.ToString());
                }
            }

            if (signRequestDetails.AllowedSignatureTypes != null)
            {
                AllowedSignatureTypesToFormParameter(signRequestDetails.AllowedSignatureTypes, localVarFormParams);
            }

            if (signRequestDetails.BrandId != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.BrandId), signRequestDetails.BrandId);
            }

            if (!string.IsNullOrEmpty(signRequestDetails.OnBehalfOf))
            {
                localVarFormParams.Add(nameof(signRequestDetails.OnBehalfOf), signRequestDetails.OnBehalfOf);
            }

            if (signRequestDetails.DownloadFileName != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.DownloadFileName), signRequestDetails.DownloadFileName);
            }

            if (signRequestDetails.ReminderSettings != null)
            {
                localVarFormParams.Add($"{nameof(signRequestDetails.ReminderSettings)}.{nameof(signRequestDetails.ReminderSettings.EnableAutoReminder)}", signRequestDetails.ReminderSettings.EnableAutoReminder.ToString());
                localVarFormParams.Add($"{nameof(signRequestDetails.ReminderSettings)}.{nameof(signRequestDetails.ReminderSettings.ReminderDays)}", signRequestDetails.ReminderSettings.ReminderDays.ToString());
                localVarFormParams.Add($"{nameof(signRequestDetails.ReminderSettings)}.{nameof(signRequestDetails.ReminderSettings.ReminderCount)}", signRequestDetails.ReminderSettings.ReminderCount.ToString());
            }

            if (signRequestDetails.RecipientNotificationSettings != null)
            {
                InitializeRecipientNotificationSettings(localVarFormParams, signRequestDetails.RecipientNotificationSettings);
            }

            if (signRequestDetails is IEmbeddedRequest embeddedRequest)
            {
                if (embeddedRequest.RedirectUrl != null)
                {
                    localVarFormParams.Add(nameof(embeddedRequest.RedirectUrl), embeddedRequest.RedirectUrl.ToString());
                }

                localVarFormParams.Add(nameof(embeddedRequest.ShowToolbar), embeddedRequest.ShowToolbar ? "true" : "false");
                localVarFormParams.Add(nameof(embeddedRequest.ShowSaveButton), embeddedRequest.ShowSaveButton ? "true" : "false");
                localVarFormParams.Add(nameof(embeddedRequest.ShowSendButton), embeddedRequest.ShowSendButton ? "true" : "false");
                localVarFormParams.Add(nameof(embeddedRequest.ShowPreviewButton), embeddedRequest.ShowPreviewButton ? "true" : "false");
                localVarFormParams.Add(nameof(embeddedRequest.ShowNavigationButtons), embeddedRequest.ShowNavigationButtons ? "true" : "false");
                localVarFormParams.Add(nameof(embeddedRequest.SendViewOption), embeddedRequest.SendViewOption.ToString());
                localVarFormParams.Add(nameof(embeddedRequest.Locale), embeddedRequest.Locale.ToString());
                localVarFormParams.Add(nameof(embeddedRequest.ShowTooltip), embeddedRequest.ShowTooltip ? "true" : "false");

                if (embeddedRequest.SendLinkValidTill.HasValue)
                {
                    localVarFormParams.Add(nameof(embeddedRequest.SendLinkValidTill), embeddedRequest.SendLinkValidTill.ToString());
                }
            }

            localVarFormParams.Add(nameof(signRequestDetails.EnableSigningOrder), signRequestDetails.EnableSigningOrder ? "true" : "false");
            localVarFormParams.Add(nameof(signRequestDetails.AutoDetectFields), signRequestDetails.AutoDetectFields ? "true" : "false");
            localVarFormParams.Add(nameof(signRequestDetails.UseTextTags), signRequestDetails.UseTextTags ? "true" : "false");

#pragma warning disable CS0618 // Type or member is obsolete
            localVarFormParams.Add(
                nameof(signRequestDetails.DisableEmails),
                signRequestDetails.DisableEmails || signRequestDetails.EnableEmbeddedSigning ? "true" : "false");
#pragma warning restore CS0618 // Type or member is obsolete

            localVarFormParams.Add(nameof(signRequestDetails.DisableSMS), signRequestDetails.DisableSMS ? "true" : "false");

            if (signRequestDetails.HideDocumentId != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.HideDocumentId), signRequestDetails.HideDocumentId == true ? "true" : "false");
            }

            if (signRequestDetails.DisableExpiryAlert != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.DisableExpiryAlert), signRequestDetails.DisableExpiryAlert.Value ? "true" : "false");
            }
            localVarFormParams.Add(nameof(signRequestDetails.EnablePrintAndSign), signRequestDetails.EnablePrintAndSign ? "true" : "false");
            localVarFormParams.Add(nameof(signRequestDetails.EnableReassign), signRequestDetails.EnableReassign ? "true" : "false");
            localVarFormParams.Add(nameof(signRequestDetails.AllowScheduledSend), signRequestDetails.AllowScheduledSend ? "true" : "false");

            if (signRequestDetails.DocumentDownloadOption != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.DocumentDownloadOption), signRequestDetails.DocumentDownloadOption.ToString());
            }

            if (signRequestDetails.MetaData != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, signRequestDetails.MetaData, nameof(signRequestDetails.MetaData));
            }

            if (signRequestDetails.EnableAuditTrailLocalization != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.EnableAuditTrailLocalization), signRequestDetails.EnableAuditTrailLocalization == true ? "true" : "false");
            }

            return localVarFormParams;
        }
        /// <summary>
        /// Represents a ConvertToFormRequest.
        /// </summary>
        /// <param name="templateRequest">template request.</param>
        /// <param name="localVarFormParams">local VarForm Params.</param>
        /// <returns>localVarFormParams.</returns>
        public static Dictionary<string, string> ConvertToFormRequestForTemplate(CreateTemplateRequest templateRequest, Dictionary<string, string> localVarFormParams)
        {
            if (templateRequest.Title != null)
            {
                localVarFormParams.Add(nameof(templateRequest.Title), templateRequest.Title);
            }

            if (templateRequest.DocumentInfo != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, templateRequest.DocumentInfo.ToList(), nameof(templateRequest.DocumentInfo));
            }

            if (templateRequest.Description != null)
            {
                localVarFormParams.Add(nameof(templateRequest.Description), templateRequest.Description);
            }

            if (templateRequest.DocumentTitle != null)
            {
                localVarFormParams.Add(nameof(templateRequest.DocumentTitle), templateRequest.DocumentTitle);
            }

            if (templateRequest.DocumentMessage != null)
            {
                localVarFormParams.Add(nameof(templateRequest.DocumentMessage), templateRequest.DocumentMessage);
            }

            if (templateRequest.Roles != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, templateRequest.Roles.ToList(), nameof(templateRequest.Roles));
            }

            if (templateRequest.CC != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, templateRequest.CC.ToList(), nameof(templateRequest.CC));
            }

            if (templateRequest.BrandId != null)
            {
                localVarFormParams.Add(nameof(templateRequest.BrandId), templateRequest.BrandId);
            }

            if (templateRequest.TextTagDefinitions != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, templateRequest.TextTagDefinitions.ToList(), nameof(templateRequest.TextTagDefinitions));
            }

            if (templateRequest.AllowedSignatureTypes != null)
            {
                AllowedSignatureTypesToFormParameter(templateRequest.AllowedSignatureTypes, localVarFormParams);
            }

            if (templateRequest.RecipientNotificationSettings != null)
            {
                InitializeRecipientNotificationSettings(localVarFormParams, templateRequest.RecipientNotificationSettings);
            }

            if (templateRequest.FormGroups != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, templateRequest.FormGroups.ToList(), nameof(templateRequest.FormGroups));
            }

            if (templateRequest.FormFieldPermission != null)
            {
                InitializeFormFieldPermissionSettings(localVarFormParams, templateRequest.FormFieldPermission);
            }

            if (templateRequest is CreateEmbeddedTemplateRequest embeddedRequest)
            {
                if (embeddedRequest.RedirectUrl != null)
                {
                    localVarFormParams.Add(nameof(embeddedRequest.RedirectUrl), embeddedRequest.RedirectUrl.ToString());
                }

                localVarFormParams.Add(nameof(embeddedRequest.ShowToolbar), embeddedRequest.ShowToolbar ? "true" : "false");
                localVarFormParams.Add(nameof(embeddedRequest.ShowSaveButton), embeddedRequest.ShowSaveButton ? "true" : "false");

#pragma warning disable CS0618//Type or member is obsolete
                if (embeddedRequest.ShowSendButton != null)
                {
                    localVarFormParams.Add(nameof(embeddedRequest.ShowSendButton), embeddedRequest.ShowSendButton == true ? "true" : "false");
                }
#pragma warning restore CS0618//Type or member is obsolete

                localVarFormParams.Add(nameof(embeddedRequest.ShowCreateButton), embeddedRequest.ShowCreateButton ? "true" : "false");
                localVarFormParams.Add(nameof(embeddedRequest.ShowPreviewButton), embeddedRequest.ShowPreviewButton ? "true" : "false");
                localVarFormParams.Add(nameof(embeddedRequest.ShowNavigationButtons), embeddedRequest.ShowNavigationButtons ? "true" : "false");
                localVarFormParams.Add(nameof(embeddedRequest.ViewOption), embeddedRequest.ViewOption.ToString());
                localVarFormParams.Add(nameof(embeddedRequest.Locale), embeddedRequest.Locale.ToString());
                localVarFormParams.Add(nameof(embeddedRequest.ShowTooltip), embeddedRequest.ShowTooltip ? "true" : "false");

                if (embeddedRequest.LinkValidTill.HasValue)
                {
                    localVarFormParams.Add(nameof(embeddedRequest.LinkValidTill), embeddedRequest.LinkValidTill.ToString());
                }
            }

            localVarFormParams.Add(nameof(templateRequest.EnableSigningOrder), templateRequest.EnableSigningOrder ? "true" : "false");
            localVarFormParams.Add(nameof(templateRequest.EnablePrintAndSign), templateRequest.EnablePrintAndSign ? "true" : "false");
            localVarFormParams.Add(nameof(templateRequest.EnableReassign), templateRequest.EnableReassign ? "true" : "false");
            localVarFormParams.Add(nameof(templateRequest.AllowNewRoles), templateRequest.AllowNewRoles ? "true" : "false");
            localVarFormParams.Add(nameof(templateRequest.AllowNewFiles), templateRequest.AllowNewFiles ? "true" : "false");
            localVarFormParams.Add(nameof(templateRequest.AllowModifyFiles), templateRequest.AllowModifyFiles ? "true" : "false");
            localVarFormParams.Add(nameof(templateRequest.AllowMessageEditing), templateRequest.AllowMessageEditing ? "true" : "false");
            localVarFormParams.Add(nameof(templateRequest.UseTextTags), templateRequest.UseTextTags ? "true" : "false");
            localVarFormParams.Add(nameof(templateRequest.AutoDetectFields), templateRequest.AutoDetectFields ? "true" : "false");

            if (!string.IsNullOrEmpty(templateRequest.OnBehalfOf))
            {
                localVarFormParams.Add(nameof(templateRequest.OnBehalfOf), templateRequest.OnBehalfOf);
            }

            if (templateRequest.Labels != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, templateRequest.Labels.ToList(), nameof(templateRequest.Labels));
            }

            if (templateRequest.TemplateLabels != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, templateRequest.TemplateLabels.ToList(), nameof(templateRequest.TemplateLabels));
            }

            return localVarFormParams;
        }

        /// <summary>
        /// Convert File URL to form parameter.
        /// </summary>
        /// <param name="localVarFileUrlParams">File Url.</param>
        /// <param name="fileUrls">File URLs.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>localVarFileUrlParams.</returns>
        public static Dictionary<string, Uri> ToFormParameter(Dictionary<string, Uri> localVarFileUrlParams, List<Uri> fileUrls, string parameterName)
        {
            for (int i = 0; i < fileUrls.Count; i++)
            {
                localVarFileUrlParams.Add($"{parameterName}[{i}]", fileUrls[i]);
            }

            return localVarFileUrlParams;
        }

        /// <summary>
        /// Initialize Recipient Notification Settings.
        /// </summary>
        /// <param name="localVarFormParams">localVarFormParams.</param>
        /// <param name="recipientNotificationSettings">recipientNotificationSettings.</param>
        private static void InitializeRecipientNotificationSettings(Dictionary<string, string> localVarFormParams, RecipientNotificationSettings recipientNotificationSettings)
        {
            const string baseKey = "RecipientNotificationSettings";

            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.SignatureRequest)}", recipientNotificationSettings.SignatureRequest ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.Declined)}", recipientNotificationSettings.Declined ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.Revoked)}", recipientNotificationSettings.Revoked ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.Signed)}", recipientNotificationSettings.Signed ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.Completed)}", recipientNotificationSettings.Completed ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.Expired)}", recipientNotificationSettings.Expired ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.Reassigned)}", recipientNotificationSettings.Reassigned ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.Deleted)}", recipientNotificationSettings.Deleted ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.Reminders)}", recipientNotificationSettings.Reminders ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.EditRecipient)}", recipientNotificationSettings.EditRecipient ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.EditDocument)}", recipientNotificationSettings.EditDocument ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(recipientNotificationSettings.Viewed)}", recipientNotificationSettings.Viewed ? "true" : "false");
        }

        private static Dictionary<string, string> AllowedSignatureTypesToFormParameter(List<SignatureType> signatureTypes,  Dictionary<string,string> localVarFormParams)
        {
            var index = 0;
            foreach (var tag in signatureTypes)
            {
                localVarFormParams.Add($"{nameof(SendForSign.AllowedSignatureTypes)}[{index}]", tag.ToString());
                index++;
            }
            return localVarFormParams;
        }


        /// <summary>
        /// Initialize formField permission settings.
        /// </summary>
        /// <param name="localVarFormParams">localVarFormParams.</param>
        /// <param name="formFieldPermission">formFieldPermission.</param>
        private static void InitializeFormFieldPermissionSettings(Dictionary<string, string> localVarFormParams, FormFieldPermission formFieldPermission)
        {
            const string baseKey = "FormFieldPermission";
            localVarFormParams.Add($"{baseKey}.{nameof(FormFieldPermission.CanAdd)}", formFieldPermission.CanAdd ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(FormFieldPermission.CanModify)}", formFieldPermission.CanModify ? "true" : "false");
            localVarFormParams.Add($"{baseKey}.{nameof(FormFieldPermission.CanModifyDefaultValue)}", formFieldPermission.CanModifyDefaultValue ? "true" : "false");
        }

        private static Dictionary<string, string> ToFormParameter(Dictionary<string, string> localVarFormParams, List<string> array, string parameterName)
        {
            for (int i = 0; i < array.Count; i++)
            {
                localVarFormParams.Add($"{parameterName}[{i}]", array[i]);
            }

            return localVarFormParams;
        }

        private static Dictionary<string, string> ToFormParameter(Dictionary<string, string> localVarFormParams, object property, string parameterName)
        {
            switch (property)
            {
                case null:
                    return localVarFormParams;
                case IEnumerable enumerable:
                    {
                        var i = -1;

                        foreach (var item in enumerable)
                        {
                            ToFormParameter(localVarFormParams, item, $"{parameterName}[{++i}]");
                        }

                        return localVarFormParams;
                    }
            }

            var props = property.GetType().GetProperties();

            foreach (var prop in props)
            {
                var value = prop.GetValue(property, new object[] { });

                if (value == null)
                {
                    continue;
                }

                var name = $"{parameterName}[{prop.Name}]";

                if (value is IEnumerable<string> items)
                {
                    var i = 0;
                    foreach (var item in items)
                    {
                        localVarFormParams.Add($"{name}[{i++}]", item);
                    }
                }

                if (prop.Name == "AllowedDocumentTypes" && value is List<AllowedDocumentType> allowedDocumentTypes)
                {
                    var i = -1;
                    foreach (var allowedDocumentType in allowedDocumentTypes)
                    {
                        localVarFormParams.Add($"{name}[{++i}]", allowedDocumentType.ToString());
                    }
                }

                var propertyType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                if (value is Enum)
                {
                    var enumValues = Enum.GetValues(propertyType);

                    if (enumValues.Cast<object>().Any(enumValue => Convert.ToInt32(value).ToString() == Convert.ToInt32(enumValue).ToString()))
                    {
                        localVarFormParams.Add(name, value.ToString());
                    }
                }
                else if (value is string || propertyType.IsPrimitive)
                {
                    localVarFormParams.Add(name, value.ToInvariantString());
                }
                else if (value is int)
                {
                    localVarFormParams.Add(name, value.ToString());
                }
                else if (value is bool)
                {
                    localVarFormParams.Add(name, value.ToString());
                }
                else if (value is DateTime)
                {
                    localVarFormParams.Add(name, ((DateTime)value).ToString(CultureInfo.CurrentCulture));
                }
                else if (value is IEnumerable)
                {
                    ToFormParameter(localVarFormParams, value, name);
                }
                else if (propertyType.IsClass)
                {
                    ToFormParameter(localVarFormParams, value, name);
                }
            }

            return localVarFormParams;
        }
    }
}
