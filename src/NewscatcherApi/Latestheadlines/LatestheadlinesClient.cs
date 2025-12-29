using System.Text.Json;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

public partial class LatestheadlinesClient
{
    private RawClient _client;

    internal LatestheadlinesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
    /// </summary>
    /// <example><code>
    /// await client.Latestheadlines.GetAsync(
    ///     new LatestHeadlinesGetRequest
    ///     {
    ///         When = "7d",
    ///         Lang = "en",
    ///         NotLang = "fr",
    ///         Countries = "US",
    ///         NotCountries = "UK",
    ///         PredefinedSources = "top 100 US, top 5 GB",
    ///         Sources = "nytimes.com",
    ///         NotSources = "cnn.com",
    ///         NotAuthorName = "John Doe",
    ///         ParentUrl = "https://www.washingtonpost.com/politics",
    ///         AllLinks = "https://aiindex.stanford.edu/report",
    ///         AllDomainLinks = "nvidia.com",
    ///         IncludeTranslationFields = true,
    ///         IncludeNlpData = true,
    ///         HasNlp = true,
    ///         Theme = "Business,Finance",
    ///         NotTheme = "Crime",
    ///         OrgEntityName = "Apple",
    ///         PerEntityName = "Elon Musk",
    ///         LocEntityName = "California",
    ///         MiscEntityName = "Bitcoin",
    ///         IptcTags = "20000199,20000209",
    ///         NotIptcTags = "20000205,20000209",
    ///         IabTags = "Business,Events",
    ///         NotIabTags = "Agriculture,Metals",
    ///         CustomTags = "Tag1,Tag2,Tag3",
    ///     }
    /// );
    /// </code></example>
    public async Task<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> GetAsync(
        LatestHeadlinesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.When != null)
        {
            _query["when"] = request.When;
        }
        if (request.ByParseDate != null)
        {
            _query["by_parse_date"] = JsonUtils.Serialize(request.ByParseDate.Value);
        }
        if (request.Lang != null)
        {
            _query["lang"] = request.Lang;
        }
        if (request.NotLang != null)
        {
            _query["not_lang"] = request.NotLang;
        }
        if (request.Countries != null)
        {
            _query["countries"] = request.Countries;
        }
        if (request.NotCountries != null)
        {
            _query["not_countries"] = request.NotCountries;
        }
        if (request.PredefinedSources != null)
        {
            _query["predefined_sources"] = request.PredefinedSources;
        }
        if (request.Sources != null)
        {
            _query["sources"] = request.Sources;
        }
        if (request.NotSources != null)
        {
            _query["not_sources"] = request.NotSources;
        }
        if (request.NotAuthorName != null)
        {
            _query["not_author_name"] = request.NotAuthorName;
        }
        if (request.RankedOnly != null)
        {
            _query["ranked_only"] = JsonUtils.Serialize(request.RankedOnly.Value);
        }
        if (request.IsHeadline != null)
        {
            _query["is_headline"] = JsonUtils.Serialize(request.IsHeadline.Value);
        }
        if (request.IsOpinion != null)
        {
            _query["is_opinion"] = JsonUtils.Serialize(request.IsOpinion.Value);
        }
        if (request.IsPaidContent != null)
        {
            _query["is_paid_content"] = JsonUtils.Serialize(request.IsPaidContent.Value);
        }
        if (request.ParentUrl != null)
        {
            _query["parent_url"] = request.ParentUrl;
        }
        if (request.AllLinks != null)
        {
            _query["all_links"] = request.AllLinks;
        }
        if (request.AllDomainLinks != null)
        {
            _query["all_domain_links"] = request.AllDomainLinks;
        }
        if (request.WordCountMin != null)
        {
            _query["word_count_min"] = request.WordCountMin.Value.ToString();
        }
        if (request.WordCountMax != null)
        {
            _query["word_count_max"] = request.WordCountMax.Value.ToString();
        }
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        if (request.ClusteringEnabled != null)
        {
            _query["clustering_enabled"] = JsonUtils.Serialize(request.ClusteringEnabled.Value);
        }
        if (request.ClusteringVariable != null)
        {
            _query["clustering_variable"] = request.ClusteringVariable.Value.Stringify();
        }
        if (request.ClusteringThreshold != null)
        {
            _query["clustering_threshold"] = request.ClusteringThreshold.Value.ToString();
        }
        if (request.IncludeTranslationFields != null)
        {
            _query["include_translation_fields"] = JsonUtils.Serialize(
                request.IncludeTranslationFields.Value
            );
        }
        if (request.IncludeNlpData != null)
        {
            _query["include_nlp_data"] = JsonUtils.Serialize(request.IncludeNlpData.Value);
        }
        if (request.HasNlp != null)
        {
            _query["has_nlp"] = JsonUtils.Serialize(request.HasNlp.Value);
        }
        if (request.Theme != null)
        {
            _query["theme"] = request.Theme;
        }
        if (request.NotTheme != null)
        {
            _query["not_theme"] = request.NotTheme;
        }
        if (request.OrgEntityName != null)
        {
            _query["ORG_entity_name"] = request.OrgEntityName;
        }
        if (request.PerEntityName != null)
        {
            _query["PER_entity_name"] = request.PerEntityName;
        }
        if (request.LocEntityName != null)
        {
            _query["LOC_entity_name"] = request.LocEntityName;
        }
        if (request.MiscEntityName != null)
        {
            _query["MISC_entity_name"] = request.MiscEntityName;
        }
        if (request.TitleSentimentMin != null)
        {
            _query["title_sentiment_min"] = request.TitleSentimentMin.Value.ToString();
        }
        if (request.TitleSentimentMax != null)
        {
            _query["title_sentiment_max"] = request.TitleSentimentMax.Value.ToString();
        }
        if (request.ContentSentimentMin != null)
        {
            _query["content_sentiment_min"] = request.ContentSentimentMin.Value.ToString();
        }
        if (request.ContentSentimentMax != null)
        {
            _query["content_sentiment_max"] = request.ContentSentimentMax.Value.ToString();
        }
        if (request.IptcTags != null)
        {
            _query["iptc_tags"] = request.IptcTags;
        }
        if (request.NotIptcTags != null)
        {
            _query["not_iptc_tags"] = request.NotIptcTags;
        }
        if (request.IabTags != null)
        {
            _query["iab_tags"] = request.IabTags;
        }
        if (request.NotIabTags != null)
        {
            _query["not_iab_tags"] = request.NotIabTags;
        }
        if (request.CustomTags != null)
        {
            _query["custom_tags"] = request.CustomTags;
        }
        if (request.RobotsCompliant != null)
        {
            _query["robots_compliant"] = JsonUtils.Serialize(request.RobotsCompliant.Value);
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "api/latest_headlines",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<OneOf<SearchResponseDto, ClusteredSearchResponseDto>>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new NewscatcherApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(JsonUtils.Deserialize<Error>(responseBody));
                    case 401:
                        throw new UnauthorizedError(JsonUtils.Deserialize<Error>(responseBody));
                    case 403:
                        throw new ForbiddenError(JsonUtils.Deserialize<Error>(responseBody));
                    case 408:
                        throw new RequestTimeoutError(JsonUtils.Deserialize<Error>(responseBody));
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<Error>(responseBody)
                        );
                    case 429:
                        throw new TooManyRequestsError(JsonUtils.Deserialize<Error>(responseBody));
                    case 500:
                        throw new InternalServerError(JsonUtils.Deserialize<string>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NewscatcherApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
    /// </summary>
    /// <example><code>
    /// await client.Latestheadlines.PostAsync(
    ///     new LatestHeadlinesPostRequest { When = "7d", PageSize = 1 }
    /// );
    /// </code></example>
    public async Task<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> PostAsync(
        LatestHeadlinesPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "api/latest_headlines",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<OneOf<SearchResponseDto, ClusteredSearchResponseDto>>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new NewscatcherApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(JsonUtils.Deserialize<Error>(responseBody));
                    case 401:
                        throw new UnauthorizedError(JsonUtils.Deserialize<Error>(responseBody));
                    case 403:
                        throw new ForbiddenError(JsonUtils.Deserialize<Error>(responseBody));
                    case 408:
                        throw new RequestTimeoutError(JsonUtils.Deserialize<Error>(responseBody));
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<Error>(responseBody)
                        );
                    case 429:
                        throw new TooManyRequestsError(JsonUtils.Deserialize<Error>(responseBody));
                    case 500:
                        throw new InternalServerError(JsonUtils.Deserialize<string>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NewscatcherApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
