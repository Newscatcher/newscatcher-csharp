using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SentimentScores
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
