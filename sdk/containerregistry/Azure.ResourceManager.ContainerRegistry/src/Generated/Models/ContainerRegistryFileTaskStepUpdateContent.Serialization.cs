// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryFileTaskStepUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TaskFilePath))
            {
                writer.WritePropertyName("taskFilePath");
                writer.WriteStringValue(TaskFilePath);
            }
            if (Optional.IsDefined(ValuesFilePath))
            {
                writer.WritePropertyName("valuesFilePath");
                writer.WriteStringValue(ValuesFilePath);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values");
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(StepType.ToString());
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath");
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(ContextAccessToken))
            {
                writer.WritePropertyName("contextAccessToken");
                writer.WriteStringValue(ContextAccessToken);
            }
            writer.WriteEndObject();
        }
    }
}
