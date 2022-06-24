// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary> A class representing the AuthorizationRule data model. </summary>
    public partial class AuthorizationRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of AuthorizationRuleData. </summary>
        public AuthorizationRuleData()
        {
            Rights = new ChangeTrackingList<AccessRight>();
        }

        /// <summary> Initializes a new instance of AuthorizationRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="rights"> The rights associated with the rule. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal AuthorizationRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<AccessRight> rights, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Rights = rights;
            Location = location;
        }

        /// <summary> The rights associated with the rule. </summary>
        public IList<AccessRight> Rights { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
