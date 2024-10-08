﻿// <copyright file="ContactDetails.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

/*
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    ///     The current page templates view model.
    /// </summary>
    [DataContract]
    public class ContactDetails
    {
        /// <summary>
        /// Gets or sets the contact id.
        /// </summary>
        [DataMember(Name = "email")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the contact id.
        /// </summary>
        [DataMember(Name = "name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the contact id.
        /// </summary>
        [DataMember(Name = "companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the contact id.
        /// </summary>
        [DataMember(Name = "jobTitle")]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the contact id.
        /// </summary>
        [DataMember(Name = "phoneNumber")]
        public PhoneNumber PhoneNumber { get; set; }
    }
}
