// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The result of a request to list key-values. </summary>
    internal partial class AppConfigurationKeyValueListResult
    {
        /// <summary> Initializes a new instance of AppConfigurationKeyValueListResult. </summary>
        internal AppConfigurationKeyValueListResult()
        {
            Value = new ChangeTrackingList<AppConfigurationKeyValueData>();
        }

        /// <summary> Initializes a new instance of AppConfigurationKeyValueListResult. </summary>
        /// <param name="value"> The collection value. </param>
        /// <param name="nextLink"> The URI that can be used to request the next set of paged results. </param>
        internal AppConfigurationKeyValueListResult(IReadOnlyList<AppConfigurationKeyValueData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection value. </summary>
        public IReadOnlyList<AppConfigurationKeyValueData> Value { get; }
        /// <summary> The URI that can be used to request the next set of paged results. </summary>
        public string NextLink { get; }
    }
}
