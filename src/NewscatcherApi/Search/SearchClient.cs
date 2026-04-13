using global::System.Text.Json;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

public partial class SearchClient : ISearchClient
{
    private readonly RawClient _client;

    internal SearchClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<OneOf<SearchResponseDto, ClusteredSearchResponseDto>>
    > GetAsyncCore(
        GetSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NewscatcherApi.Core.QueryStringBuilder.Builder(capacity: 57)
            .Add("q", request.Q)
            .Add("search_in", request.SearchIn)
            .Add("include_translation_fields", request.IncludeTranslationFields)
            .Add("predefined_sources", request.PredefinedSources)
            .Add("source_name", request.SourceName)
            .Add("sources", request.Sources)
            .Add("not_sources", request.NotSources)
            .Add("lang", request.Lang)
            .Add("not_lang", request.NotLang)
            .Add("countries", request.Countries)
            .Add("not_countries", request.NotCountries)
            .Add("not_author_name", request.NotAuthorName)
            .AddDeepObject("from_", request.From)
            .AddDeepObject("to_", request.To)
            .Add("published_date_precision", request.PublishedDatePrecision)
            .Add("by_parse_date", request.ByParseDate)
            .Add("sort_by", request.SortBy)
            .Add("ranked_only", request.RankedOnly)
            .Add("from_rank", request.FromRank)
            .Add("to_rank", request.ToRank)
            .Add("is_headline", request.IsHeadline)
            .Add("is_opinion", request.IsOpinion)
            .Add("is_paid_content", request.IsPaidContent)
            .Add("parent_url", request.ParentUrl)
            .Add("all_links", request.AllLinks)
            .Add("all_domain_links", request.AllDomainLinks)
            .Add("all_links_text", request.AllLinksText)
            .Add("additional_domain_info", request.AdditionalDomainInfo)
            .Add("is_news_domain", request.IsNewsDomain)
            .Add("news_domain_type", request.NewsDomainType)
            .Add("news_type", request.NewsType)
            .Add("word_count_min", request.WordCountMin)
            .Add("word_count_max", request.WordCountMax)
            .Add("page", request.Page)
            .Add("page_size", request.PageSize)
            .Add("clustering_enabled", request.ClusteringEnabled)
            .Add("clustering_variable", request.ClusteringVariable)
            .Add("clustering_threshold", request.ClusteringThreshold)
            .Add("include_nlp_data", request.IncludeNlpData)
            .Add("has_nlp", request.HasNlp)
            .Add("theme", request.Theme)
            .Add("not_theme", request.NotTheme)
            .Add("ORG_entity_name", request.OrgEntityName)
            .Add("PER_entity_name", request.PerEntityName)
            .Add("LOC_entity_name", request.LocEntityName)
            .Add("MISC_entity_name", request.MiscEntityName)
            .Add("title_sentiment_min", request.TitleSentimentMin)
            .Add("title_sentiment_max", request.TitleSentimentMax)
            .Add("content_sentiment_min", request.ContentSentimentMin)
            .Add("content_sentiment_max", request.ContentSentimentMax)
            .Add("iptc_tags", request.IptcTags)
            .Add("not_iptc_tags", request.NotIptcTags)
            .Add("iab_tags", request.IabTags)
            .Add("not_iab_tags", request.NotIabTags)
            .Add("custom_tags", request.CustomTags)
            .Add("exclude_duplicates", request.ExcludeDuplicates)
            .Add("robots_compliant", request.RobotsCompliant)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NewscatcherApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Get,
                    Path = "api/search",
                    QueryString = _queryString,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<
                    OneOf<SearchResponseDto, ClusteredSearchResponseDto>
                >(responseBody)!;
                return new WithRawResponse<OneOf<SearchResponseDto, ClusteredSearchResponseDto>>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NewscatcherApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
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

    private async Task<
        WithRawResponse<OneOf<SearchResponseDto, ClusteredSearchResponseDto>>
    > PostAsyncCore(
        PostSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new NewscatcherApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "api/search",
                    Body = request,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<
                    OneOf<SearchResponseDto, ClusteredSearchResponseDto>
                >(responseBody)!;
                return new WithRawResponse<OneOf<SearchResponseDto, ClusteredSearchResponseDto>>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NewscatcherApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
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
    /// Searches for articles based on specified criteria such as keywords, language, country, source, and more.
    /// </summary>
    /// <example><code>
    /// await client.Search.GetAsync(
    ///     new GetSearchRequest
    ///     {
    ///         Q = "\"supply chain\" AND Amazon NOT China",
    ///         SearchIn = "title_content, title_content_translated",
    ///         IncludeTranslationFields = true,
    ///         PredefinedSources = "top 50 US, top 20 GB",
    ///         SourceName = "sport,tech",
    ///         Sources = "nytimes.com,finance.yahoo.com",
    ///         NotSources = "cnn.com,wsj.com",
    ///         Lang = "en,es",
    ///         NotLang = "fr,de",
    ///         Countries = "US,CA",
    ///         NotCountries = "UK,FR",
    ///         NotAuthorName = "John Doe, Jane Doe",
    ///         From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
    ///         To = new DateTime(2024, 01, 01, 00, 00, 00, 000),
    ///         PublishedDatePrecision = "full",
    ///         ByParseDate = true,
    ///         RankedOnly = true,
    ///         FromRank = 100,
    ///         ToRank = 100,
    ///         IsHeadline = true,
    ///         IsOpinion = true,
    ///         IsPaidContent = false,
    ///         ParentUrl = "wsj.com/politics,wsj.com/tech",
    ///         AllLinks = "https://aiindex.stanford.edu/report,https://www.stateof.ai",
    ///         AllDomainLinks = "who.int,nih.gov",
    ///         AllLinksText = "Nvidia,Tesla",
    ///         AdditionalDomainInfo = true,
    ///         IsNewsDomain = true,
    ///         NewsType = "General News Outlets,Tech News and Updates",
    ///         WordCountMin = 300,
    ///         WordCountMax = 1000,
    ///         Page = 2,
    ///         PageSize = 50,
    ///         ClusteringEnabled = true,
    ///         ClusteringThreshold = 0.6f,
    ///         IncludeNlpData = true,
    ///         HasNlp = true,
    ///         Theme = "Finance,Tech",
    ///         NotTheme = "Crime,Sports",
    ///         OrgEntityName = "\"Apple Inc\" OR Microsoft",
    ///         PerEntityName = "\"Elon Musk\" OR \"Jeff Bezos\"",
    ///         LocEntityName = "\"San Francisco\" OR \"New York City\"",
    ///         MiscEntityName = "AWS OR \"Microsoft Azure\"",
    ///         TitleSentimentMin = -0.5f,
    ///         TitleSentimentMax = 0.5f,
    ///         ContentSentimentMin = -0.5f,
    ///         ContentSentimentMax = 0.5f,
    ///         IptcTags = "20000199,20000209",
    ///         NotIptcTags = "20000205,20000209",
    ///         IabTags = "Business,Events",
    ///         NotIabTags = "Agriculture,Metals",
    ///         CustomTags = "Tag1,Tag2",
    ///         ExcludeDuplicates = true,
    ///         RobotsCompliant = true,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> GetAsync(
        GetSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>>(
            GetAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Searches for articles based on specified criteria such as keywords, language, country, source, and more.
    /// </summary>
    /// <example><code>
    /// await client.Search.PostAsync(
    ///     new PostSearchRequest { Q = "\"supply chain\" AND Amazon NOT China", PageSize = 1 }
    /// );
    /// </code></example>
    public WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> PostAsync(
        PostSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>>(
            PostAsyncCore(request, options, cancellationToken)
        );
    }
}
