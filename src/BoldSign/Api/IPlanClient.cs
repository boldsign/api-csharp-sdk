namespace BoldSign.Api
{
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
        BillingViewModel GetApiCreditsCount();

        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BillingViewModel</returns>
        ApiResponse<BillingViewModel> GetApiCreditsCountWithHttpInfo();
        #endregion Synchronous Operations

        #region Asynchronous Operations
        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BillingViewModel)</returns>
        Task<BillingViewModel> GetApiCreditsCountAsync();

        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BillingViewModel</returns>
        Task<ApiResponse<BillingViewModel>> GetApiCreditsCountAsyncWithHttpInfo();
        #endregion Asynchronous Operations
    }
}
