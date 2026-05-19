using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

/// <summary>
/// The response model for a successful `Sources` request retrieving news sources matching the specified criteria. Response field behavior:
/// - Required fields are guaranteed to be present and non-null.
/// - Optional fields may be `null` or `undefined` if the data point is not presented or couldn't be extracted during processing.
/// </summary>
[Serializable]
public record SourcesResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A message indicating the result of the request.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// A list of news sources that match the specified criteria.
    /// </summary>
    [JsonPropertyName("sources")]
    public IEnumerable<OneOf<SourceInfo, string>> Sources { get; set; } =
        new List<OneOf<SourceInfo, string>>();

    /// <summary>
    /// The user input parameters for the request.
    /// </summary>
    [JsonPropertyName("user_input")]
    public Dictionary<string, object?> UserInput { get; set; } = new Dictionary<string, object?>();

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
