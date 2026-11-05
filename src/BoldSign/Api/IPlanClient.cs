// <copyright file="IPlanClient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System;
    using System.Threading.Tasks;
    using BoldSign.Model;

    /// <summary>
    ///    Represents a function to interact with the API endpoints. The function perform action such as getting the Api credit details and so on.
    /// </summary>
    public interface IPlanClient : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>BillingViewModel</returns>
        [Obsolete("Use GetSubscriptionCredits instead; the corresponding API endpoint is deprecated and will be removed in a future version.")]
        BillingViewModel GetApiCreditsCount();

        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BillingViewModel</returns>
        [Obsolete("Use GetSubscriptionCreditsWithHttpInfo instead; the corresponding API endpoint is deprecated and will be removed in a future version.")]
        ApiResponse<BillingViewModel> GetApiCreditsCountWithHttpInfo();

        /// <summary>
        ///    Gets the subscription credit details of the user across all features and credit sources.
        /// </summary>
        /// <exception cref="SubscriptionCreditsException">Thrown when the request is refused with a typed error (403 or 404).</exception>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>SubscriptionCredits.</returns>
        SubscriptionCredits GetSubscriptionCredits();

        /// <summary>
        ///    Gets the subscription credit details of the user across all features and credit sources.
        /// </summary>
        /// <exception cref="SubscriptionCreditsException">Thrown when the request is refused with a typed error (403 or 404).</exception>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>ApiResponse of SubscriptionCredits.</returns>
        ApiResponse<SubscriptionCredits> GetSubscriptionCreditsWithHttpInfo();
        #endregion Synchronous Operations

        #region Asynchronous Operations
        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BillingViewModel)</returns>
        [Obsolete("Use GetSubscriptionCreditsAsync instead; the corresponding API endpoint is deprecated and will be removed in a future version.")]
        Task<BillingViewModel> GetApiCreditsCountAsync();

        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BillingViewModel</returns>
        [Obsolete("Use GetSubscriptionCreditsAsyncWithHttpInfo instead; the corresponding API endpoint is deprecated and will be removed in a future version.")]
        Task<ApiResponse<BillingViewModel>> GetApiCreditsCountAsyncWithHttpInfo();

        /// <summary>
        ///    Gets the subscription credit details of the user across all features and credit sources.
        /// </summary>
        /// <exception cref="SubscriptionCreditsException">Thrown when the request is refused with a typed error (403 or 404).</exception>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>Task of SubscriptionCredits.</returns>
        Task<SubscriptionCredits> GetSubscriptionCreditsAsync();

        /// <summary>
        ///    Gets the subscription credit details of the user across all features and credit sources.
        /// </summary>
        /// <exception cref="SubscriptionCreditsException">Thrown when the request is refused with a typed error (403 or 404).</exception>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <returns>ApiResponse of SubscriptionCredits.</returns>
        Task<ApiResponse<SubscriptionCredits>> GetSubscriptionCreditsAsyncWithHttpInfo();
        #endregion Asynchronous Operations
    }
}
