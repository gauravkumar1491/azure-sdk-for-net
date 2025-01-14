// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information of the DPMContainer. </summary>
    internal partial class DpmContainerExtendedInfo
    {
        /// <summary> Initializes a new instance of DpmContainerExtendedInfo. </summary>
        public DpmContainerExtendedInfo()
        {
        }

        /// <summary> Initializes a new instance of DpmContainerExtendedInfo. </summary>
        /// <param name="lastRefreshedOn"> Last refresh time of the DPMContainer. </param>
        internal DpmContainerExtendedInfo(DateTimeOffset? lastRefreshedOn)
        {
            LastRefreshedOn = lastRefreshedOn;
        }

        /// <summary> Last refresh time of the DPMContainer. </summary>
        public DateTimeOffset? LastRefreshedOn { get; set; }
    }
}
