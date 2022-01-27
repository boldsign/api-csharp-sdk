namespace BoldSign.Api
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using BoldSign.Model;

    internal static class FromRequestHelper
    {
        public static Dictionary<string, string> ConvertToFormRequest(SendForSign signRequestDetails, Dictionary<string, string> localVarFormParams)
        {
            if (signRequestDetails.Title != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.Title), signRequestDetails.Title);
            }

            string expiryDays = signRequestDetails.ExpiryDays > 0 ? signRequestDetails.ExpiryDays.ToString() : "60";

            localVarFormParams.Add(nameof(signRequestDetails.ExpiryDays), expiryDays);

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

            if (signRequestDetails.Labels != null)
            {
                var i = -1;
                foreach (var tag in signRequestDetails.Labels)
                {
                    localVarFormParams.Add($"{nameof(signRequestDetails.Labels)}[{++i}]", tag?.ToString());
                }
            }

            if (signRequestDetails.BrandId != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.BrandId), signRequestDetails.BrandId);
            }

            if (signRequestDetails.ReminderSettings != null)
            {
                localVarFormParams.Add($"{nameof(signRequestDetails.ReminderSettings)}.{nameof(signRequestDetails.ReminderSettings.EnableAutoReminder)}", signRequestDetails.ReminderSettings.EnableAutoReminder.ToString());
                localVarFormParams.Add($"{nameof(signRequestDetails.ReminderSettings)}.{nameof(signRequestDetails.ReminderSettings.ReminderDays)}", signRequestDetails.ReminderSettings.ReminderDays.ToString());
                localVarFormParams.Add($"{nameof(signRequestDetails.ReminderSettings)}.{nameof(signRequestDetails.ReminderSettings.ReminderCount)}", signRequestDetails.ReminderSettings.ReminderCount.ToString());
            }

            localVarFormParams.Add(nameof(signRequestDetails.EnableSigningOrder), signRequestDetails.EnableSigningOrder ? "true" : "false");

#pragma warning disable CS0618 // Type or member is obsolete
            localVarFormParams.Add(
                nameof(signRequestDetails.DisableEmails),
                signRequestDetails.DisableEmails || signRequestDetails.EnableEmbeddedSigning ? "true" : "false");
#pragma warning restore CS0618 // Type or member is obsolete

            localVarFormParams.Add(nameof(signRequestDetails.HideDocumentId), signRequestDetails.HideDocumentId ? "true" : "false");

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

                if (value is Enum)
                {
                    var enumType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                    var enumValues = Enum.GetValues(enumType);

                    if (enumValues.Cast<object>().Any(enumValue => Convert.ToInt32(value).ToString() == Convert.ToInt32(enumValue).ToString()))
                    {
                        localVarFormParams.Add(name, value.ToString());
                    }
                }
                else if (value is string || prop.PropertyType.IsPrimitive)
                {
                    localVarFormParams.Add(name, value.ToString());
                }
                else if (value is IEnumerable)
                {
                    ToFormParameter(localVarFormParams, value, name);
                }
                else if (prop.PropertyType.IsClass)
                {
                    ToFormParameter(localVarFormParams, value, name);
                }
            }

            return localVarFormParams;
        }
    }
}
