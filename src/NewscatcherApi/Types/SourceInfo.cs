using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The data model for information about a news source.
/// </summary>
[Serializable]
public record SourceInfo
{
    /// <summary>
    /// The name of the news source.
    /// </summary>
    [JsonPropertyName("name_source")]
    public string? NameSource { get; set; }

    /// <summary>
    /// The domain URL of the news source.
    /// </summary>
    [JsonPropertyName("domain_url")]
    public required string DomainUrl { get; set; }

    /// <summary>
    /// The logo of the news source.
    /// </summary>
    [JsonPropertyName("logo")]
    public string? Logo { get; set; }

    [JsonPropertyName("additional_info")]
    public AdditionalSourceInfo? AdditionalInfo { get; set; }

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
