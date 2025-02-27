// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
    public partial class RequestStatistics
    {
        /// <summary> Initializes a new instance of RequestStatistics. </summary>
        /// <param name="transactionsCount"> Number of transactions for the request. </param>
        public RequestStatistics(long transactionsCount)
        {
            TransactionsCount = transactionsCount;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of RequestStatistics. </summary>
        /// <param name="transactionsCount"> Number of transactions for the request. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal RequestStatistics(long transactionsCount, IDictionary<string, object> additionalProperties)
        {
            TransactionsCount = transactionsCount;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Number of transactions for the request. </summary>
        public long TransactionsCount { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
