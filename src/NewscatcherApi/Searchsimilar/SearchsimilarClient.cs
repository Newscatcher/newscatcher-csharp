using System.Text.Json;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

public partial class SearchsimilarClient : ISearchsimilarClient
{
    private readonly RawClient _client;

    internal SearchsimilarClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>>
    > GetAsyncCore(
        SearchSimilarGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NewscatcherApi.Core.QueryStringBuilder.Builder(capacity: 44)
            .Add("q", request.Q)
            .Add("search_in", request.SearchIn)
            .Add("include_translation_fields", request.IncludeTranslationFields)
            .Add("include_similar_documents", request.IncludeSimilarDocuments)
            .Add("similar_documents_number", request.SimilarDocumentsNumber)
            .Add("similar_documents_fields", request.SimilarDocumentsFields)
            .Add("predefined_sources", request.PredefinedSources)
            .Add("sources", request.Sources)
            .Add("not_sources", request.NotSources)
            .Add("lang", request.Lang)
            .Add("not_lang", request.NotLang)
            .Add("countries", request.Countries)
            .Add("not_countries", request.NotCountries)
            .AddDeepObject("from_", request.From)
            .AddDeepObject("to_", request.To)
            .Add("by_parse_date", request.ByParseDate)
            .Add("published_date_precision", request.PublishedDatePrecision)
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
            .Add("ner_name", request.NerName)
            .Add("title_sentiment_min", request.TitleSentimentMin)
            .Add("title_sentiment_max", request.TitleSentimentMax)
            .Add("content_sentiment_min", request.ContentSentimentMin)
            .Add("content_sentiment_max", request.ContentSentimentMax)
            .Add("iptc_tags", request.IptcTags)
            .Add("not_iptc_tags", request.NotIptcTags)
            .Add("custom_tags", request.CustomTags)
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
                    Path = "api/search_similar",
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
                    OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>
                >(responseBody)!;
                return new WithRawResponse<
                    OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>
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
        WithRawResponse<OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>>
    > PostAsyncCore(
        SearchSimilarPostRequest request,
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
                    Path = "api/search_similar",
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
                    OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>
                >(responseBody)!;
                return new WithRawResponse<
                    OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>
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
    /// Searches for articles similar to a specified query.
    /// </summary>
    /// <example><code>
    /// await client.Searchsimilar.GetAsync(
    ///     new SearchSimilarGetRequest
    ///     {
    ///         Q = "\"supply chain\" AND Amazon NOT China",
    ///         SearchIn = "title_content, title_content_translated",
    ///         IncludeTranslationFields = true,
    ///         SimilarDocumentsFields = "title,summary",
    ///         PredefinedSources = "top 100 US, top 5 GB",
    ///         Sources = "nytimes.com",
    ///         NotSources = "cnn.com",
    ///         Lang = "en",
    ///         NotLang = "fr",
    ///         Countries = "US",
    ///         NotCountries = "UK",
    ///         From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
    ///         To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
    ///         ParentUrl = "https://www.washingtonpost.com/politics",
    ///         AllLinks = "https://aiindex.stanford.edu/report",
    ///         AllDomainLinks = "nvidia.com",
    ///         IncludeNlpData = true,
    ///         HasNlp = true,
    ///         Theme = "Business,Finance",
    ///         NotTheme = "Crime",
    ///         NerName = "Tesla",
    ///         IptcTags = "20000199,20000209",
    ///         NotIptcTags = "20000205,20000209",
    ///         CustomTags = "Tag1,Tag2,Tag3",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<
        OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>
    > GetAsync(
        SearchSimilarGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<
            OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>
        >(GetAsyncCore(request, options, cancellationToken));
    }

    /// <summary>
    /// Searches for articles similar to the specified query. You can filter results by language, country, source, and more.
    /// </summary>
    /// <example><code>
    /// await client.Searchsimilar.PostAsync(
    ///     new SearchSimilarPostRequest
    ///     {
    ///         Q = "\"supply chain\" AND Amazon NOT China",
    ///         IncludeSimilarDocuments = true,
    ///         SimilarDocumentsNumber = 5,
    ///         PageSize = 10,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<
        OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>
    > PostAsync(
        SearchSimilarPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<
            OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>
        >(PostAsyncCore(request, options, cancellationToken));
    }
}
