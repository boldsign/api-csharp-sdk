// <copyright file="AuthenticationFrequency.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>
namespace BoldSign.Api.Model
{
    /// <summary>
    /// Specifies the frequency of authentication required during a process.
    /// </summary>
    public enum AuthenticationFrequency
    {
        /// <summary>
        /// Represents none authentication frequency.
        /// </summary>
        None = 1,

        /// <summary>
        /// Represents every access verification.
        /// </summary>
        EveryAccess = 2,

        /// <summary>
        /// Represents default sign completed authentication.
        /// </summary>
        UntilSignCompleted = 3,

        /// <summary>
        /// Represents once per document authentication.
        /// </summary>
        OncePerDocument = 4,
    }
}
