/*
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Client
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    ///     Represents a set of configuration settings
    /// </summary>
    public class Configuration : IReadableConfiguration
    {
        #region Constants

        /// <summary>
        ///     Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "1.0.0";

        /// <summary>
        ///     Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        /// <summary>
        ///     Default base URL of the API endpoint.
        /// </summary>
        /// <value>Default base URL of the API endpoint.</value>
        public const string ApiBaseUrl = "https://api.boldsign.com";

        #endregion Constants

        #region Static Members

        private static readonly object GlobalConfigSync = new { };
        private static Configuration _globalConfiguration;

        /// <summary>
        ///     Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            var status = (int)response.StatusCode;

            if (status >= 400)
            {
                return new ApiException(
                    status,
                    string.Format("Error calling {0}: {1}", methodName, response.Content),
                    response.Content);
            }

            if (status == 0)
            {
                return new ApiException(
                    status,
                    string.Format("Error calling {0}: {1}", methodName, response.ErrorMessage), response.ErrorMessage);
            }

            return null;
        };

        /// <summary>
        ///     Gets or sets the default Configuration.
        /// </summary>
        /// <value>Configuration.</value>
        public static Configuration Default
        {
            get => _globalConfiguration;
            set
            {
                lock (GlobalConfigSync)
                {
                    _globalConfiguration = value;
                }
            }
        }

        #endregion Static Members

        #region Private Members

        /// <summary>
        ///     Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        private IDictionary<string, string> _apiKey;

        /// <summary>
        ///     Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        private IDictionary<string, string> _apiKeyPrefix;

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        private string _tempFolderPath = Path.GetTempPath();

        #endregion Private Members

        #region Constructors

        static Configuration() => _globalConfiguration = new GlobalConfiguration();

        /// <summary>
        ///     Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        public Configuration()
        {
            this.UserAgent = "OpenAPI-Generator/1.0.0/csharp";
            this.BasePath = ApiBaseUrl;
            this.DefaultHeader = new ConcurrentDictionary<string, string>();
            this.ApiKey = new ConcurrentDictionary<string, string>();
            this.ApiKeyPrefix = new ConcurrentDictionary<string, string>();

            // Setting Timeout has side effects (forces ApiClient creation).
            this.Timeout = 100000;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        public Configuration(
            IDictionary<string, string> defaultHeader,
            IDictionary<string, string> apiKey,
            IDictionary<string, string> apiKeyPrefix,
            string basePath = ApiBaseUrl) : this()
        {
            if (string.IsNullOrWhiteSpace(basePath))
            {
                throw new ArgumentException("The provided basePath is invalid.", "basePath");
            }

            if (defaultHeader == null)
            {
                throw new ArgumentNullException("defaultHeader");
            }

            if (apiKey == null)
            {
                throw new ArgumentNullException("apiKey");
            }

            if (apiKeyPrefix == null)
            {
                throw new ArgumentNullException("apiKeyPrefix");
            }

            this.BasePath = basePath;

            foreach (var keyValuePair in defaultHeader)
            {
                this.DefaultHeader.Add(keyValuePair);
            }

            foreach (var keyValuePair in apiKey)
            {
                this.ApiKey.Add(keyValuePair);
            }

            foreach (var keyValuePair in apiKeyPrefix)
            {
                this.ApiKeyPrefix.Add(keyValuePair);
            }
        }

        #endregion Constructors

        #region Properties

        private ApiClient _apiClient;

        /// <summary>
        ///     Gets an instance of an ApiClient for this configuration
        /// </summary>
        public virtual ApiClient ApiClient
        {
            get => this._apiClient ?? (this._apiClient = this.CreateApiClient());

            set => this._apiClient = value;
        }

        private string _basePath;

        /// <summary>
        ///     Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath
        {
            get => this._basePath;
            set
            {
                this._basePath = value;

                // pass-through to ApiClient if it's set.
                if (this._apiClient != null)
                {
                    this._apiClient.RestClient.BaseUrl = new Uri(this._basePath);
                }
            }
        }

        /// <summary>
        ///     Gets or sets the default header.
        /// </summary>
        public virtual IDictionary<string, string> DefaultHeader { get; set; }

        /// <summary>
        ///     Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public virtual int Timeout
        {
            get => this.ApiClient.RestClient.Timeout;
            set => this.ApiClient.RestClient.Timeout = value;
        }

        /// <summary>
        ///     Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public virtual string UserAgent { get; set; }

        /// <summary>
        ///     Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        internal string Username { get; set; }

        /// <summary>
        ///     Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        internal string Password { get; set; }

        /// <summary>
        ///     Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        internal string GetApiKeyWithPrefix(string apiKeyIdentifier)
        {
            var apiKeyValue = "";
            this.ApiKey.TryGetValue(apiKeyIdentifier, out apiKeyValue);
            var apiKeyPrefix = "";

            if (this.ApiKeyPrefix.TryGetValue(apiKeyIdentifier, out apiKeyPrefix))
            {
                return apiKeyPrefix + " " + apiKeyValue;
            }

            return apiKeyValue;
        }

        /// <summary>
        ///     Gets or sets the access token for OAuth2 authentication.
        /// </summary>
        /// <value>The access token.</value>
        internal string AccessToken { get; set; }

        /// <summary>
        ///     Gets or sets the authentication token for OAuth2 authentication as Bearer token in the header.
        /// </summary>
        /// <value>The access token.</value>
        public virtual string BearerToken
        {
            set => this.SetBearerToken(value);
        }

        /// <summary>
        ///     Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public virtual string TempFolderPath
        {
            get => this._tempFolderPath;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this._tempFolderPath = Path.GetTempPath();

                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                {
                    Directory.CreateDirectory(value);
                }

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                {
                    this._tempFolderPath = value;
                }
                else
                {
                    this._tempFolderPath = value + Path.DirectorySeparatorChar;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the date time format used when serializing in the ApiClient
        ///     By default, it's set to ISO 8601 - "o", for others see:
        ///     https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        ///     and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        ///     No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string DateTimeFormat
        {
            get => this._dateTimeFormat;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    this._dateTimeFormat = ISO8601_DATETIME_FORMAT;

                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                this._dateTimeFormat = value;
            }
        }

        /// <summary>
        ///     Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        internal IDictionary<string, string> ApiKeyPrefix
        {
            get => this._apiKeyPrefix;
            set => this._apiKeyPrefix = value ?? throw new InvalidOperationException("ApiKeyPrefix collection may not be null.");
        }

        /// <summary>
        ///     Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        internal IDictionary<string, string> ApiKey
        {
            get => this._apiKey;
            set => this._apiKey = value ?? throw new InvalidOperationException("ApiKey collection may not be null.");
        }

        /// <summary>
        ///     Sets the authentication token for OAuth2 authentication as Bearer token in the header.
        /// </summary>
        /// <value>The API key.</value>
        public void SetBearerToken(string accessToken)
        {
            this.ApiKey = new Dictionary<string, string>()
            {
                ["Authorization"] = accessToken,
            };

            this.ApiKeyPrefix = new Dictionary<string, string>()
            {
                ["Authorization"] = "Bearer",
            };
        }

        #endregion Properties

        #region Methods

        /// <summary>
        ///     Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string key, string value)
        {
            this.DefaultHeader[key] = value;
        }

        /// <summary>
        ///     Creates a new <see cref="ApiClient" /> based on this <see cref="Configuration" /> instance.
        /// </summary>
        /// <returns></returns>
        internal ApiClient CreateApiClient() => new ApiClient(this.BasePath) { Configuration = this };

        /// <summary>
        ///     Returns a string with essential information for debugging.
        /// </summary>
        public static string ToDebugReport()
        {
            var report = "C# SDK (Org.OpenAPITools) Debug Report:\n";
            report += "    OS: " + Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + Environment.Version + "\n";
            report += "    Version of the API: 1\n";
            report += "    SDK Package Version: 1.0.0\n";

            return report;
        }

        /// <summary>
        ///     Add Api Key Header.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        /// <returns></returns>
        internal void AddApiKey(string key, string value)
        {
            this.ApiKey[key] = value;
        }

        /// <summary>
        ///     Sets the API key prefix.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        internal void AddApiKeyPrefix(string key, string value)
        {
            this.ApiKeyPrefix[key] = value;
        }

        #endregion Methods
    }
}
