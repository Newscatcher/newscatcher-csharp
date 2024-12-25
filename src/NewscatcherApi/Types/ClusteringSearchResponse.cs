using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record ClusteringSearchResponse
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("total_hits")]
    public required int TotalHits { get; set; }

    [JsonPropertyName("page")]
    public required int Page { get; set; }

    [JsonPropertyName("total_pages")]
    public required int TotalPages { get; set; }

    [JsonPropertyName("page_size")]
    public required int PageSize { get; set; }

    [JsonPropertyName("clusters_count")]
    public required int ClustersCount { get; set; }

    [JsonPropertyName("clusters")]
    public IEnumerable<Cluster> Clusters { get; set; } = new List<Cluster>();

    [JsonPropertyName("user_input")]
    public object UserInput { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
