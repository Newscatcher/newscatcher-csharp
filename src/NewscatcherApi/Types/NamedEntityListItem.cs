using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record NamedEntityListItem
{
    /// <summary>
    /// The name of the entity identified in the article.
    /// </summary>
    [JsonPropertyName("entity_name")]
    public string? EntityName { get; set; }

    /// <summary>
    /// The number of times this entity appears in the article.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
