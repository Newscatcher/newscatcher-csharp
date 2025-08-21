using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The data model representing a breaking news event with its associated articles.
/// </summary>
[Serializable]
public record BreakingNewsEventEntity
{
    /// <summary>
    /// Unique identifier for the breaking news event/cluster.
    /// </summary>
    [JsonPropertyName("event_id")]
    public required string EventId { get; set; }

    /// <summary>
    /// Number of articles in this breaking news cluster.
    /// </summary>
    [JsonPropertyName("articles_count")]
    public required int ArticlesCount { get; set; }

    /// <summary>
    /// The articles associated with this breaking news event.
    /// </summary>
    [JsonPropertyName("articles")]
    public IEnumerable<BreakingNewsArticleEntity> Articles { get; set; } =
        new List<BreakingNewsArticleEntity>();

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
