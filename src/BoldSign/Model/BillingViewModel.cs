namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///     The BillingViewModel includes action such as getting the Api credit details and so on.
    /// </summary>
    [DataContract]
    public class BillingViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingViewModel" /> class.
        /// </summary>
        /// <param name="balanceCredits">Gets or sets the balance credits.</param>
        public BillingViewModel(double? balanceCredits = default(double?))
        {
            this.BalanceCredits = balanceCredits;
        }
        /// <summary>
        /// Gets or sets the balance credits.
        /// </summary>
        /// <value>Gets or sets the balance credits.</value>
        [DataMember(Name = "balanceCredits", EmitDefaultValue = false)]
        public double? BalanceCredits { get; set; }
    }
}
