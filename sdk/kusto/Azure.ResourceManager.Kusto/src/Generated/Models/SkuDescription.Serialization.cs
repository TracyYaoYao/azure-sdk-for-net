// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class SkuDescription
    {
        internal static SkuDescription DeserializeSkuDescription(JsonElement element)
        {
            Optional<string> resourceType = default;
            Optional<string> name = default;
            Optional<string> tier = default;
            Optional<IReadOnlyList<string>> locations = default;
            Optional<IReadOnlyList<SkuLocationInfoItem>> locationInfo = default;
            Optional<IReadOnlyList<BinaryData>> restrictions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("locationInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SkuLocationInfoItem> array = new List<SkuLocationInfoItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuLocationInfoItem.DeserializeSkuLocationInfoItem(item));
                    }
                    locationInfo = array;
                    continue;
                }
                if (property.NameEquals("restrictions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    restrictions = array;
                    continue;
                }
            }
            return new SkuDescription(resourceType.Value, name.Value, tier.Value, Optional.ToList(locations), Optional.ToList(locationInfo), Optional.ToList(restrictions));
        }
    }
}
