// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryBaseImageTriggerUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseImageTriggerType))
            {
                writer.WritePropertyName("baseImageTriggerType");
                writer.WriteStringValue(BaseImageTriggerType.Value.ToString());
            }
            if (Optional.IsDefined(UpdateTriggerEndpoint))
            {
                writer.WritePropertyName("updateTriggerEndpoint");
                writer.WriteStringValue(UpdateTriggerEndpoint);
            }
            if (Optional.IsDefined(UpdateTriggerPayloadType))
            {
                writer.WritePropertyName("updateTriggerPayloadType");
                writer.WriteStringValue(UpdateTriggerPayloadType.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
    }
}
