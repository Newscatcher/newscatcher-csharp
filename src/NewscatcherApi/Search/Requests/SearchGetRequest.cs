using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SearchGetRequest
{
    public required string Q { get; set; }

    public string? SearchIn { get; set; }

    public required string PredefinedSources { get; set; }

    public required string Sources { get; set; }

    public required string NotSources { get; set; }

    public required string Lang { get; set; }

    public required string NotLang { get; set; }

    public required string Countries { get; set; }

    public required string NotCountries { get; set; }

    public required string NotAuthorName { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    public string? PublishedDatePrecision { get; set; }

    public string? ByParseDate { get; set; }

    public string? SortBy { get; set; }

    public string? RankedOnly { get; set; }

    public string? FromRank { get; set; }

    public string? ToRank { get; set; }

    public string? IsHeadline { get; set; }

    public string? IsOpinion { get; set; }

    public string? IsPaidContent { get; set; }

    public required string ParentUrl { get; set; }

    public required string AllLinks { get; set; }

    public required string AllDomainLinks { get; set; }

    public string? WordCountMin { get; set; }

    public string? WordCountMax { get; set; }

    public string? Page { get; set; }

    public string? PageSize { get; set; }

    public string? ClusteringVariable { get; set; }

    public string? ClusteringEnabled { get; set; }

    public double? ClusteringThreshold { get; set; }

    public string? IncludeNlpData { get; set; }

    public bool? HasNlp { get; set; }

    public string? Theme { get; set; }

    public string? NotTheme { get; set; }

    public string? OrgEntityName { get; set; }

    public string? PerEntityName { get; set; }

    public string? LocEntityName { get; set; }

    public string? MiscEntityName { get; set; }

    public double? TitleSentimentMin { get; set; }

    public double? TitleSentimentMax { get; set; }

    public double? ContentSentimentMin { get; set; }

    public double? ContentSentimentMax { get; set; }

    public required string IptcTags { get; set; }

    public required string NotIptcTags { get; set; }

    public required string SourceName { get; set; }

    public required string IabTags { get; set; }

    public required string NotIabTags { get; set; }

    public bool? ExcludeDuplicates { get; set; }

    public bool? AdditionalDomainInfo { get; set; }

    public bool? IsNewsDomain { get; set; }

    public required string NewsDomainType { get; set; }

    public required string NewsType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
