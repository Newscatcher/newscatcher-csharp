using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record ClusteredSearchResponseDto
{
    [JsonPropertyName("user_input")]
    public object? UserInput { get; set; }

    /// <summary>
    /// The status of the response.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// The total number of articles matching the search criteria.
    /// </summary>
    [JsonPropertyName("total_hits")]
    public required int TotalHits { get; set; }

    /// <summary>
    /// The current page number of the results.
    /// </summary>
    [JsonPropertyName("page")]
    public required int Page { get; set; }

    /// <summary>
    /// The total number of pages available for the given search criteria.
    /// </summary>
    [JsonPropertyName("total_pages")]
    public required int TotalPages { get; set; }

    /// <summary>
    /// The number of articles per page.
    /// </summary>
    [JsonPropertyName("page_size")]
    public required int PageSize { get; set; }

    /// <summary>
    /// The number of clusters in the search results.
    /// </summary>
    [JsonPropertyName("clusters_count")]
    public required int ClustersCount { get; set; }

    /// <summary>
    /// A list of clusters found in the search results.
    /// </summary>
    [JsonPropertyName("clusters")]
    public IEnumerable<ClusterEntity> Clusters { get; set; } = new List<ClusterEntity>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
