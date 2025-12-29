using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// Sentiment scores for the article's title and content.
/// </summary>
[Serializable]
public record SentimentScores : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The sentiment score for the article title (-1.0 to 1.0).
    /// </summary>
    [JsonPropertyName("title")]
    public float? Title { get; set; }

    /// <summary>
    /// The sentiment score for the article content (-1.0 to 1.0).
    /// </summary>
    [JsonPropertyName("content")]
    public float? Content { get; set; }

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
