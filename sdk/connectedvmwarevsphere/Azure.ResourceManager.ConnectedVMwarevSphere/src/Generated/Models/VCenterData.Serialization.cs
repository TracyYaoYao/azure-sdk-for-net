// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class VCenterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("fqdn");
            writer.WriteStringValue(Fqdn);
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials");
                writer.WriteObjectValue(Credentials);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VCenterData DeserializeVCenterData(JsonElement element)
        {
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> uuid = default;
            string fqdn = default;
            Optional<int> port = default;
            Optional<string> version = default;
            Optional<string> instanceUuid = default;
            Optional<string> connectionStatus = default;
            Optional<string> customResourceName = default;
            Optional<VICredential> credentials = default;
            Optional<IReadOnlyList<ResourceStatus>> statuses = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uuid"))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fqdn"))
                        {
                            fqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceUuid"))
                        {
                            instanceUuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"))
                        {
                            connectionStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customResourceName"))
                        {
                            customResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("credentials"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            credentials = VICredential.DeserializeVICredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("statuses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResourceStatus> array = new List<ResourceStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResourceStatus.DeserializeResourceStatus(item));
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VCenterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, kind.Value, uuid.Value, fqdn, Optional.ToNullable(port), version.Value, instanceUuid.Value, connectionStatus.Value, customResourceName.Value, credentials.Value, Optional.ToList(statuses), provisioningState.Value);
        }
    }
}
