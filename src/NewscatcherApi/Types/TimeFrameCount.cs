using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// Represents the article count for a specific time frame.
/// </summary>
[Serializable]
public record TimeFrameCount : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The timestamp for the aggregation period in format "YYYY-MM-DD HH:mm:ss"
    /// </summary>
    [JsonPropertyName("time_frame")]
    public required DateTime TimeFrame { get; set; }

    /// <summary>
    /// The number of articles published during this time frame
    /// </summary>
    [JsonPropertyName("article_count")]
    public required int ArticleCount { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
