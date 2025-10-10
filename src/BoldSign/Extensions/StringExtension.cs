// <copyright file="StringExtension.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Extensions
{
    using System;
    using System.Globalization;

    /// <summary>
    /// The string extension.
    /// </summary>
    internal static class StringExtension
    {
        /// <summary>
        /// Transforms given string to invariant culture.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>string.</returns>
        internal static string ToInvariantString(this object value)
        {
            return Convert.ToString(value, CultureInfo.InvariantCulture);
        }
    }
}


