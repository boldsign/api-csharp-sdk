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
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The reminder settings have properties include enabling auto reminder, reminder recurring count, and so on.
    /// </summary>
    [DataContract]
    public partial class ReminderSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReminderSettings" /> class.
        /// </summary>
        /// <param name="enableAutoReminder">Gets or sets a value indicating whether enable auto reminder..</param>
        /// <param name="reminderDays">Gets or sets the reminder days. (default to 3).</param>
        /// <param name="reminderCount">Gets or sets the reminder count. (default to 3).</param>
        public ReminderSettings(int? reminderDays = 3, int? reminderCount = 3)
        {
            this.EnableAutoReminder = true;
            // use default value if no "reminderDays" provided
            if (reminderDays == null)
            {
                this.ReminderDays = 3;
            }
            else
            {
                this.ReminderDays = reminderDays;
            }
            // use default value if no "reminderCount" provided
            if (reminderCount == null)
            {
                this.ReminderCount = 3;
            }
            else
            {
                this.ReminderCount = reminderCount;
            }
        }

        /// <summary>
        ///  Gets or sets a value indicating whether to enable auto reminder.
        /// </summary>
        /// <value>Gets or sets a value indicating whether enable auto reminder.</value>
        [DataMember(Name = "enableAutoReminder", EmitDefaultValue = false)]
        public bool? EnableAutoReminder { get; set; }

        /// <summary>
        /// Gets or sets the reminder in number of days.
        /// </summary>
        /// <value>Gets or sets the reminder days.</value>
        [DataMember(Name = "reminderDays", EmitDefaultValue = false)]
        public int? ReminderDays { get; set; }

        /// <summary>
        /// Gets or sets the reminder recurring count.
        /// </summary>
        /// <value>Gets or sets the reminder count.</value>
        [DataMember(Name = "reminderCount", EmitDefaultValue = false)]
        public int? ReminderCount { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
