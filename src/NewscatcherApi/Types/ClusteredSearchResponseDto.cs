using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The response model when clustering is enabled, grouping similar articles into clusters. Applies to the `Search` and `Latest headlines` requests. Response field behavior:
/// - Required fields are guaranteed to be present and non-null.
/// - Optional fields may be `null` or `undefined` if the data point is not presented or couldn't be extracted during processing.
/// - To access article properties in the `articles` response array,
/// use array index notation. For example, `articles[n].title`, where `n`
/// is the zero-based index of the article object (0, 1, 2, etc.).
/// - The `nlp` property within the article object `articles[n].nlp`
/// is only available with NLP-enabled subscription plans.
/// </summary>
[Serializable]
public record ClusteredSearchResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("user_input")]
    public Dictionary<string, object?>? UserInput { get; set; }

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
