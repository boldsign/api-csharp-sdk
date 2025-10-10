// <copyright file="SenderIdentityCreator.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model.Webhook
{
  using System.Runtime.Serialization;
  using Newtonsoft.Json;

  /// <summary>
  /// The sender identity data.
  /// </summary>
  [DataContract]
  public class SenderIdentityCreator
  {
      /// <summary>
      /// Gets or sets recipient Name.
      /// </summary>
      /// <value>Gets the value of recipient Name.</value>
      [DataMember(Name = "name", EmitDefaultValue = false)]
      [JsonProperty("name")]
      public string Name { get; set; }

      /// <summary>
      /// Gets or sets the email address.
      /// </summary>
      /// <value>Gets the value of email address.</value>
      [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
      [JsonProperty("emailAddress")]
      public string EmailAddress { get; set; }

      /// <summary>
      /// Gets or sets sender user id.
      /// </summary>
      [DataMember(Name = "userId", EmitDefaultValue = false)]
      [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
      public string UserId { get; set; }

      /// <summary>
      /// Gets or sets sender team id.
      /// </summary>
      [DataMember(Name = "teamId", EmitDefaultValue = false)]
      [JsonProperty("teamId", DefaultValueHandling = DefaultValueHandling.Include)]
      public string TeamId { get; set; }
  }
}
