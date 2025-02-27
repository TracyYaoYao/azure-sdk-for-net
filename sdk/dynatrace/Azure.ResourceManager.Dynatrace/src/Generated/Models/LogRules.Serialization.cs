// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class LogRules : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SendAadLogs))
            {
                writer.WritePropertyName("sendAadLogs");
                writer.WriteStringValue(SendAadLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendSubscriptionLogs))
            {
                writer.WritePropertyName("sendSubscriptionLogs");
                writer.WriteStringValue(SendSubscriptionLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendActivityLogs))
            {
                writer.WritePropertyName("sendActivityLogs");
                writer.WriteStringValue(SendActivityLogs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags");
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static LogRules DeserializeLogRules(JsonElement element)
        {
            Optional<SendAadLogsStatus> sendAadLogs = default;
            Optional<SendSubscriptionLogsStatus> sendSubscriptionLogs = default;
            Optional<SendActivityLogsStatus> sendActivityLogs = default;
            Optional<IList<FilteringTag>> filteringTags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendAadLogs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendAadLogs = new SendAadLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendSubscriptionLogs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendSubscriptionLogs = new SendSubscriptionLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendActivityLogs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendActivityLogs = new SendActivityLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filteringTags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FilteringTag> array = new List<FilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FilteringTag.DeserializeFilteringTag(item));
                    }
                    filteringTags = array;
                    continue;
                }
            }
            return new LogRules(Optional.ToNullable(sendAadLogs), Optional.ToNullable(sendSubscriptionLogs), Optional.ToNullable(sendActivityLogs), Optional.ToList(filteringTags));
        }
    }
}
