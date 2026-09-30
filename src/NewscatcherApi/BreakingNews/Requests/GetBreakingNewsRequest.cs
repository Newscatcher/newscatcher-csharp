using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[Serializable]
public record GetBreakingNewsRequest
{
    [JsonIgnore]
    public SortBy? SortBy { get; set; }

    [JsonIgnore]
    public bool? RankedOnly { get; set; }

    [JsonIgnore]
    public int? FromRank { get; set; }

    [JsonIgnore]
    public int? ToRank { get; set; }

    [JsonIgnore]
    public int? Page { get; set; }

    [JsonIgnore]
    public int? PageSize { get; set; }

    [JsonIgnore]
    public int? TopNArticles { get; set; }

    [JsonIgnore]
    public bool? IncludeTranslationFields { get; set; }

    [JsonIgnore]
    public bool? IncludeNlpData { get; set; }

    [JsonIgnore]
    public bool? HasNlp { get; set; }

    [JsonIgnore]
    public string? Theme { get; set; }

    [JsonIgnore]
    public string? NotTheme { get; set; }

    [JsonIgnore]
    public string? OrgEntityName { get; set; }

    [JsonIgnore]
    public string? PerEntityName { get; set; }

    [JsonIgnore]
    public string? LocEntityName { get; set; }

    [JsonIgnore]
    public string? MiscEntityName { get; set; }

    [JsonIgnore]
    public float? TitleSentimentMin { get; set; }

    [JsonIgnore]
    public float? TitleSentimentMax { get; set; }

    [JsonIgnore]
    public float? ContentSentimentMin { get; set; }

    [JsonIgnore]
    public float? ContentSentimentMax { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
