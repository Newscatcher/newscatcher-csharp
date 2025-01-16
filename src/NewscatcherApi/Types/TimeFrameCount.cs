using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record TimeFrameCount
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
