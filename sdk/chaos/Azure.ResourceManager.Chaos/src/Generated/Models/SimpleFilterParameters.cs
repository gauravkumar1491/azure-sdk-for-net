// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents the Simple filter parameters. </summary>
    internal partial class SimpleFilterParameters
    {
        /// <summary> Initializes a new instance of SimpleFilterParameters. </summary>
        public SimpleFilterParameters()
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SimpleFilterParameters. </summary>
        /// <param name="zones"> List of Azure availability zones to filter targets by. </param>
        internal SimpleFilterParameters(IList<string> zones)
        {
            Zones = zones;
        }

        /// <summary> List of Azure availability zones to filter targets by. </summary>
        public IList<string> Zones { get; }
    }
}
