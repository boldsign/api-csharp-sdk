/*
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BoldSign.Api.Resources;
    using BoldSign.Model;
    using RestSharp;

    /// <summary>
    ///    Represents a function to interact with the API endpoints. The function perform action such as getting the Api credit details and so on.
    /// </summary>
    public class PlanClient : IPlanClient
    {
        private ExceptionFactory exceptionFactory = (name, response) => null;

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlanClient" /> class.
        /// </summary>
        /// <returns></returns>
        public PlanClient(string basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlanClient" /> class.
        /// </summary>
        /// <returns></returns>
        public PlanClient()
        {
            this.Configuration = Configuration.Default;

            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlanClient" /> class
        ///     using Configuration object.
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PlanClient(Configuration configuration = null)
        {
            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlanApi" /> class
        ///     using Configuration object.
        /// </summary>
        /// <param name="apiClient">An instance of ApiClient</param>
        /// <returns></returns>
        public PlanClient(ApiClient apiClient)
        {
            this.Configuration = (Configuration)apiClient.Configuration;
            this.Configuration.ApiClient = apiClient;

            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }


        /// <summary>
        ///     Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath() => this.Configuration.ApiClient.RestClient.BaseUrl.ToString();

        /// <summary>
        ///     Gets or sets the configuration object.
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        ///     Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (this.exceptionFactory != null && this.exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }

                return this.exceptionFactory;
            }
            set => this.exceptionFactory = value;
        }
        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>BillingViewModel</returns>
        public BillingViewModel GetApiCreditsCount()
        {
            var localVarResponse = this.GetApiCreditsCountWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BillingViewModel</returns>
        public ApiResponse<BillingViewModel> GetApiCreditsCountWithHttpInfo()
        {
            var localVarPath = "/v1/plan/apiCreditsCount";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, List<IDocumentFile>>();
            var localVarFileUrlParams = new Dictionary<string, Uri>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[]
            {
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new[]
            {
                "application/json",
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(
                localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, localVarFileUrlParams);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = this.ExceptionFactory?.Invoke("GetApiCreditsCount", localVarResponse);

            if (exception != null)
            {
                throw exception;
            }

            return new ApiResponse<BillingViewModel>(
                localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BillingViewModel)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingViewModel)));
        }

        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BillingViewModel)</returns>
        public async Task<BillingViewModel> GetApiCreditsCountAsync()
        {
            var localVarResponse = await this.GetApiCreditsCountAsyncWithHttpInfo();

            return localVarResponse.Data;
        }

        /// <summary>
        ///    Gets the Api credits details of the user.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BillingViewModel</returns>
        public async Task<ApiResponse<BillingViewModel>> GetApiCreditsCountAsyncWithHttpInfo()
        {
            var localVarPath = "/v1/plan/apiCreditsCount";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, List<IDocumentFile>>();
            var localVarFileUrlParams = new Dictionary<string, Uri>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[]
            {
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new[]
            {
                "application/json",
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, localVarFileUrlParams);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = this.ExceptionFactory?.Invoke("GetApiCreditsCount", localVarResponse);

            if (exception != null)
            {
                throw exception;
            }

            return new ApiResponse<BillingViewModel>(
                localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BillingViewModel)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingViewModel)));
        }
    }
}
