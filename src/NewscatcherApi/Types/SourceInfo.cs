using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SourceInfo
{
    [JsonPropertyName("name_source")]
    public string? NameSource { get; set; }

    [JsonPropertyName("domain_url")]
    public required string DomainUrl { get; set; }

    [JsonPropertyName("logo")]
    public string? Logo { get; set; }

    [JsonPropertyName("additional_info")]
    public AdditionalSourceInfo? AdditionalInfo { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
