// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Purview
{
    internal class AccountOperationSource : IOperationSource<AccountResource>
    {
        private readonly ArmClient _client;

        internal AccountOperationSource(ArmClient client)
        {
            _client = client;
        }

        AccountResource IOperationSource<AccountResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AccountData.DeserializeAccountData(document.RootElement);
            return new AccountResource(_client, data);
        }

        async ValueTask<AccountResource> IOperationSource<AccountResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AccountData.DeserializeAccountData(document.RootElement);
            return new AccountResource(_client, data);
        }
    }
}
