// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class AutocompleteItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Text != null)
            {
                writer.WritePropertyName("text");
                writer.WriteStringValue(Text);
            }
            if (QueryPlusText != null)
            {
                writer.WritePropertyName("queryPlusText");
                writer.WriteStringValue(QueryPlusText);
            }
            writer.WriteEndObject();
        }
        internal static AutocompleteItem DeserializeAutocompleteItem(JsonElement element)
        {
            AutocompleteItem result = new AutocompleteItem();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryPlusText"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.QueryPlusText = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}