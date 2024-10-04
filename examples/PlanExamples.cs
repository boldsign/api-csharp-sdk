namespace BoldSign.Examples
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using BoldSign.Api;
    using BoldSign.Api.Resources;
    using BoldSign.Model;

    /// <summary>
    ///     The plan examples.
    /// </summary>
    public class PlanExamples
    {
        private readonly PlanClient PlanClient;

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlanExamples" /> class.
        /// </summary>
        /// <param name="PlanClient">The document api.</param>
        public PlanExamples(PlanClient PlanClient) => this.PlanClient = PlanClient;

        /// <summary>
        ///     Gets the Api credits details.
        /// </summary>
        public BillingViewModel GetApiCreditsCount()
        {
            var billingViewModel = this.PlanClient.GetApiCreditsCount();
            return billingViewModel;
        }
    }
}