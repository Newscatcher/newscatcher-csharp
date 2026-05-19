using global::System.Text.Json;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

public partial class AuthorsClient : IAuthorsClient
{
    private readonly RawClient _client;

    internal AuthorsClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<OneOf<SearchResponseDto, FailedAuthorsResponseDto>>
    > GetAsyncCore(
        GetAuthorsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NewscatcherApi.Core.QueryStringBuilder.Builder(capacity: 44)
            .Add("author_name", request.AuthorName)
            .Add("not_author_name", request.NotAuthorName)
            .Add("predefined_sources", request.PredefinedSources)
            .Add("sources", request.Sources)
            .Add("not_sources", request.NotSources)
            .Add("lang", request.Lang)
            .Add("not_lang", request.NotLang)
            .Add("countries", request.Countries)
            .Add("not_countries", request.NotCountries)
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
            .Add("word_count_min", request.WordCountMin)
            .Add("word_count_max", request.WordCountMax)
            .Add("page", request.Page)
            .Add("page_size", request.PageSize)
            .Add("include_translation_fields", request.IncludeTranslationFields)
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
            .Add("iab_tags", request.IabTags)
            .Add("not_iab_tags", request.NotIabTags)
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
                    Path = "api/authors",
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
                    OneOf<SearchResponseDto, FailedAuthorsResponseDto>
                >(responseBody)!;
                return new WithRawResponse<OneOf<SearchResponseDto, FailedAuthorsResponseDto>>()
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
        WithRawResponse<OneOf<SearchResponseDto, FailedAuthorsResponseDto>>
    > PostAsyncCore(
        PostAuthorsRequest request,
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
                    Path = "api/authors",
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
                    OneOf<SearchResponseDto, FailedAuthorsResponseDto>
                >(responseBody)!;
                return new WithRawResponse<OneOf<SearchResponseDto, FailedAuthorsResponseDto>>()
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
    /// Searches for articles written by a specified author. You can filter results by language, country, source, and more.
    /// </summary>
    /// <example><code>
    /// await client.Authors.GetAsync(
    ///     new GetAuthorsRequest
    ///     {
    ///         AuthorName = "Jane Smith",
    ///         NotAuthorName = "John Doe, Jane Doe",
    ///         PredefinedSources = "top 50 US, top 20 GB",
    ///         Sources = "nytimes.com,finance.yahoo.com",
    ///         NotSources = "cnn.com,wsj.com",
    ///         Lang = "en,es",
    ///         NotLang = "fr,de",
    ///         Countries = "US,CA",
    ///         NotCountries = "UK,FR",
    ///         From = "1 day ago",
    ///         To = "now",
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
    ///         WordCountMin = 300,
    ///         WordCountMax = 1000,
    ///         Page = 2,
    ///         PageSize = 50,
    ///         IncludeTranslationFields = true,
    ///         IncludeNlpData = true,
    ///         HasNlp = true,
    ///         Theme = "Finance,Tech",
    ///         NotTheme = "Crime,Sports",
    ///         NerName = "Tesla,Amazon",
    ///         TitleSentimentMin = -0.5f,
    ///         TitleSentimentMax = 0.5f,
    ///         ContentSentimentMin = -0.5f,
    ///         ContentSentimentMax = 0.5f,
    ///         IptcTags = "20000199,20000209",
    ///         NotIptcTags = "20000205,20000209",
    ///         IabTags = "Business,Events",
    ///         NotIabTags = "Agriculture,Metals",
    ///         CustomTags = "Tag1,Tag2",
    ///         RobotsCompliant = true,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<OneOf<SearchResponseDto, FailedAuthorsResponseDto>> GetAsync(
        GetAuthorsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OneOf<SearchResponseDto, FailedAuthorsResponseDto>>(
            GetAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Searches for articles by author. You can filter results by language, country, source, and more.
    /// </summary>
    /// <example><code>
    /// await client.Authors.PostAsync(new PostAuthorsRequest { AuthorName = "David Muir" });
    /// </code></example>
    public WithRawResponseTask<OneOf<SearchResponseDto, FailedAuthorsResponseDto>> PostAsync(
        PostAuthorsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OneOf<SearchResponseDto, FailedAuthorsResponseDto>>(
            PostAsyncCore(request, options, cancellationToken)
        );
    }
}
