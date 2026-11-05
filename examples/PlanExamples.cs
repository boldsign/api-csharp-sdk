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
        [Obsolete("Use GetSubscriptionCredits instead; the corresponding API endpoint is deprecated and will be removed in a future version.")]
        public BillingViewModel GetApiCreditsCount()
        {
            var billingViewModel = this.PlanClient.GetApiCreditsCount();
            return billingViewModel;
        }

        /// <summary>
        /// Gets the subscription credit details across all features and credit sources.
        /// </summary>
        public SubscriptionCredits GetSubscriptionCredits()
        {
            try
            {
                var subscriptionCredits = this.PlanClient.GetSubscriptionCredits();
                return subscriptionCredits;
            }
            catch (SubscriptionCreditsException ex)
            {
                switch (ex.SubscriptionCreditsError.ErrorType)
                {
                    case SubscriptionCreditsErrorType.AdminOnly:
                        Console.WriteLine("Only the account admin can view the subscription credits.");
                        break;
                    case SubscriptionCreditsErrorType.OAuthAppCreatorBilled:
                        Console.WriteLine("Use the OAuth app creator's own credentials to view the subscription credits.");
                        break;
                    default:
                        Console.WriteLine(ex.SubscriptionCreditsError.Error);
                        break;
                }

                throw;
            }
        }
    }
}