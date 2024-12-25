using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SourcesGetRequest
{
    public required string Lang { get; set; }

    public required string Countries { get; set; }

    public required string PredefinedSources { get; set; }

    public bool? IncludeAdditionalInfo { get; set; }

    public int? FromRank { get; set; }

    public int? ToRank { get; set; }

    public required string SourceName { get; set; }

    public required string SourceUrl { get; set; }

    public bool? IsNewsDomain { get; set; }

    public required string NewsDomainType { get; set; }

    public required string NewsType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
