using System.Text.Json;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

public partial class AggregationClient : IAggregationClient
{
    private RawClient _client;

    internal AggregationClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>>
    > GetAsyncCore(
        AggregationGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NewscatcherApi.Core.QueryStringBuilder.Builder(capacity: 44)
            .Add("q", request.Q)
            .Add("aggregation_by", request.AggregationBy)
            .Add("search_in", request.SearchIn)
            .Add("predefined_sources", request.PredefinedSources)
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
            .Add("word_count_min", request.WordCountMin)
            .Add("word_count_max", request.WordCountMax)
            .Add("page", request.Page)
            .Add("page_size", request.PageSize)
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
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "api/aggregation_count",
                    QueryString = _queryString,
                    Headers = _headers,
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
                var responseData = JsonUtils.Deserialize<
                    OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
                >(responseBody)!;
                return new WithRawResponse<
                    OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
                >()
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

    private async Task<
        WithRawResponse<OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>>
    > PostAsyncCore(
        AggregationPostRequest request,
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
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "api/aggregation_count",
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
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                var responseData = JsonUtils.Deserialize<
                    OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
                >(responseBody)!;
                return new WithRawResponse<
                    OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
                >()
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
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    /// <example><code>
    /// await client.Aggregation.GetAsync(
    ///     new AggregationGetRequest
    ///     {
    ///         Q = "\"supply chain\" AND Amazon NOT China",
    ///         SearchIn = "title_content, title_content_translated",
    ///         PredefinedSources = "top 100 US, top 5 GB",
    ///         Sources = "nytimes.com",
    ///         NotSources = "cnn.com",
    ///         Lang = "en",
    ///         NotLang = "fr",
    ///         Countries = "US",
    ///         NotCountries = "UK",
    ///         NotAuthorName = "John Doe",
    ///         From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
    ///         To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
    ///         ParentUrl = "https://www.washingtonpost.com/politics",
    ///         AllLinks = "https://aiindex.stanford.edu/report",
    ///         AllDomainLinks = "nvidia.com",
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
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<
        OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
    > GetAsync(
        AggregationGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<
            OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
        >(GetAsyncCore(request, options, cancellationToken));
    }

    /// <summary>
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    /// <example><code>
    /// await client.Aggregation.PostAsync(
    ///     new AggregationPostRequest
    ///     {
    ///         Q = "\"supply chain\" AND Amazon NOT China",
    ///         AggregationBy = AggregationBy.Day,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<
        OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
    > PostAsync(
        AggregationPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<
            OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
        >(PostAsyncCore(request, options, cancellationToken));
    }
}
