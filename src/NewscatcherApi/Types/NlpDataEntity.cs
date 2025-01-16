using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record NlpDataEntity
{
    /// <summary>
    /// The themes or categories identified in the article.
    /// </summary>
    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    /// <summary>
    /// A brief AI-generated summary of the article content.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    [JsonPropertyName("sentiment")]
    public SentimentScores? Sentiment { get; set; }

    /// <summary>
    /// A dense 1024-dimensional vector representation of the article content, generated using  the [multilingual-e5-large](https://huggingface.co/intfloat/multilingual-e5-large) model.
    ///
    /// **Note**: The `new_embedding` field is only available in the `v3_local_news_nlp_embeddings` subscription plan.
    /// </summary>
    [JsonPropertyName("new_embedding")]
    public IEnumerable<float>? NewEmbedding { get; set; }

    /// <summary>
    /// Named Entity Recognition for person entities (individuals' names).
    /// </summary>
    [JsonPropertyName("ner_PER")]
    public IEnumerable<NamedEntityListItem>? NerPer { get; set; }

    /// <summary>
    /// Named Entity Recognition for organization entities (company names, institutions).
    /// </summary>
    [JsonPropertyName("ner_ORG")]
    public IEnumerable<NamedEntityListItem>? NerOrg { get; set; }

    /// <summary>
    /// Named Entity Recognition for miscellaneous entities (events, nationalities, products).
    /// </summary>
    [JsonPropertyName("ner_MISC")]
    public IEnumerable<NamedEntityListItem>? NerMisc { get; set; }

    /// <summary>
    /// Named Entity Recognition for location entities (cities, countries, geographic features).
    /// </summary>
    [JsonPropertyName("ner_LOC")]
    public IEnumerable<NamedEntityListItem>? NerLoc { get; set; }

    /// <summary>
    /// IPTC media topic taxonomy paths identified in the article content. Each path represents a hierarchical category following the IPTC standard.
    /// </summary>
    [JsonPropertyName("iptc_tags_name")]
    public IEnumerable<string>? IptcTagsName { get; set; }

    /// <summary>
    /// IPTC media topic numeric codes identified in the article content. These codes correspond to the standardized IPTC media topic taxonomy.
    /// </summary>
    [JsonPropertyName("iptc_tags_id")]
    public IEnumerable<string>? IptcTagsId { get; set; }

    /// <summary>
    /// IAB content taxonomy paths identified in the article content. Each path represents a hierarchical category following the IAB content standard.
    /// </summary>
    [JsonPropertyName("iab_tags_name")]
    public IEnumerable<string>? IabTagsName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
