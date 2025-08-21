using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[Serializable]
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
