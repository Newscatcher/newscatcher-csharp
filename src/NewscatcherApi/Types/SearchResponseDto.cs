using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The response model for the search requests applies to the `Search`, `Latest Headlines`, `Search by link`, and `Authors` endpoints. Response field behavior:
/// - Required fields are guaranteed to be present and non-null.
/// - Optional fields may be `null` or `undefined` if the data point is not presented or couldn't be extracted during processing.
/// - To access article properties in the `articles` response array, use array index notation. For example, `articles[n].title`, where `n` is the zero-based index of the article object (0, 1, 2, etc.).
/// - The `nlp` property within the article object `articles[n].nlp` is only available with NLP-enabled subscription plans.
/// </summary>
[Serializable]
public record SearchResponseDto
{
    [JsonPropertyName("articles")]
    public IEnumerable<ArticleEntity>? Articles { get; set; }

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
