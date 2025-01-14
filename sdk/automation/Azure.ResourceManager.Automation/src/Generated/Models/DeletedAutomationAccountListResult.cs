// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list deleted automation account. </summary>
    internal partial class DeletedAutomationAccountListResult
    {
        /// <summary> Initializes a new instance of DeletedAutomationAccountListResult. </summary>
        internal DeletedAutomationAccountListResult()
        {
            Value = new ChangeTrackingList<DeletedAutomationAccount>();
        }

        /// <summary> Initializes a new instance of DeletedAutomationAccountListResult. </summary>
        /// <param name="value"> Gets or sets the list of deleted automation accounts. </param>
        internal DeletedAutomationAccountListResult(IReadOnlyList<DeletedAutomationAccount> value)
        {
            Value = value;
        }

        /// <summary> Gets or sets the list of deleted automation accounts. </summary>
        public IReadOnlyList<DeletedAutomationAccount> Value { get; }
    }
}
