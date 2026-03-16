using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// Detailed information about a link found in an article.
/// </summary>
[Serializable]
public record AllLinksDataItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The domain of the linked URL.
    /// </summary>
    [JsonPropertyName("domain_url")]
    public required string DomainUrl { get; set; }

    /// <summary>
    /// The complete URL of the link.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; set; }

    /// <summary>
    /// The anchor text of the link.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

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
