// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class CacheHealth
    {
        internal static CacheHealth DeserializeCacheHealth(JsonElement element)
        {
            Optional<HealthStateType> state = default;
            Optional<string> statusDescription = default;
            Optional<IReadOnlyList<Condition>> conditions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new HealthStateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusDescription"))
                {
                    statusDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("conditions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Condition> array = new List<Condition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Condition.DeserializeCondition(item));
                    }
                    conditions = array;
                    continue;
                }
            }
            return new CacheHealth(Optional.ToNullable(state), statusDescription.Value, Optional.ToList(conditions));
        }
    }
}
