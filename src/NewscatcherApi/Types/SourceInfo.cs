using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
