using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The data model for information about a news source.
/// </summary>
[Serializable]
public record SourceInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
