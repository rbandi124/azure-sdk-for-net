// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    internal class ServiceFabricManagedServiceOperationSource : IOperationSource<ServiceFabricManagedServiceResource>
    {
        private readonly ArmClient _client;

        internal ServiceFabricManagedServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceFabricManagedServiceResource IOperationSource<ServiceFabricManagedServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServiceFabricManagedServiceData.DeserializeServiceFabricManagedServiceData(document.RootElement);
            return new ServiceFabricManagedServiceResource(_client, data);
        }

        async ValueTask<ServiceFabricManagedServiceResource> IOperationSource<ServiceFabricManagedServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServiceFabricManagedServiceData.DeserializeServiceFabricManagedServiceData(document.RootElement);
            return new ServiceFabricManagedServiceResource(_client, data);
        }
    }
}
