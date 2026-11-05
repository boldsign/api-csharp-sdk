// <copyright file="SubscriptionCreditsErrorType.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    /// <summary>
    ///     The types of error a subscription credits request can be refused with.
    /// </summary>
    /// <remarks>
    ///     The values are plain strings, so a value added by the server later is still read without an error.
    /// </remarks>
    public static class SubscriptionCreditsErrorType
    {
        /// <summary>
        ///     The AdminOnly value: the caller is not the account admin.
        /// </summary>
        public const string AdminOnly = "AdminOnly";

        /// <summary>
        ///     The OAuthAppCreatorBilled value: the request was made through an OAuth app that is billed to its creator.
        /// </summary>
        public const string OAuthAppCreatorBilled = "OAuthAppCreatorBilled";

        /// <summary>
        ///     The PlanDetailsNotFound value: the plan details of the subscription could not be resolved.
        /// </summary>
        public const string PlanDetailsNotFound = "PlanDetailsNotFound";
    }
}
