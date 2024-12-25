using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record AuthorsGetRequest
{
    public required string AuthorName { get; set; }

    public string? NotAuthorName { get; set; }

    public required string Sources { get; set; }

    public required string PredefinedSources { get; set; }

    public required string NotSources { get; set; }

    public required string Lang { get; set; }

    public required string NotLang { get; set; }

    public required string Countries { get; set; }

    public required string NotCountries { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    public string? PublishedDatePrecision { get; set; }

    public bool? ByParseDate { get; set; }

    public string? SortBy { get; set; }

    public string? RankedOnly { get; set; }

    public int? FromRank { get; set; }

    public int? ToRank { get; set; }

    public bool? IsHeadline { get; set; }

    public bool? IsOpinion { get; set; }

    public bool? IsPaidContent { get; set; }

    public required string ParentUrl { get; set; }

    public required string AllLinks { get; set; }

    public required string AllDomainLinks { get; set; }

    public int? WordCountMin { get; set; }

    public int? WordCountMax { get; set; }

    public int? Page { get; set; }

    public int? PageSize { get; set; }

    public bool? IncludeNlpData { get; set; }

    public bool? HasNlp { get; set; }

    public string? Theme { get; set; }

    public string? NotTheme { get; set; }

    public double? TitleSentimentMin { get; set; }

    public double? TitleSentimentMax { get; set; }

    public double? ContentSentimentMin { get; set; }

    public double? ContentSentimentMax { get; set; }

    public required string IptcTags { get; set; }

    public required string NotIptcTags { get; set; }

    public required string IabTags { get; set; }

    public required string NotIabTags { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
