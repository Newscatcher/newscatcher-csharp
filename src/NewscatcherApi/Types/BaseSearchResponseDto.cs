using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The base response model containing common fields for search operations.
/// </summary>
[Serializable]
public record BaseSearchResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
