using System.Text.Json;
using NewscatcherApi.Core;

namespace NewscatcherApi;

public partial class BreakingNewsClient
{
    private RawClient _client;

    internal BreakingNewsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieves breaking news articles and sorts them based on specified criteria.
    /// </summary>
    /// <example><code>
    /// await client.BreakingNews.BreakingNewsGetAsync(
    ///     new BreakingNewsGetRequest
    ///     {
    ///         TopNArticles = 5,
    ///         IncludeTranslationFields = true,
    ///         IncludeNlpData = true,
    ///         HasNlp = true,
    ///         Theme = "Business,Finance",
    ///         NotTheme = "Crime",
    ///         OrgEntityName = "Apple",
    ///         PerEntityName = "Elon Musk",
    ///         LocEntityName = "California",
    ///         MiscEntityName = "Bitcoin",
    ///     }
    /// );
    /// </code></example>
    public async Task<BreakingNewsResponseDto> BreakingNewsGetAsync(
        BreakingNewsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.SortBy != null)
        {
            _query["sort_by"] = request.SortBy.Value.Stringify();
        }
        if (request.RankedOnly != null)
        {
            _query["ranked_only"] = JsonUtils.Serialize(request.RankedOnly.Value);
        }
        if (request.FromRank != null)
        {
            _query["from_rank"] = request.FromRank.Value.ToString();
        }
        if (request.ToRank != null)
        {
            _query["to_rank"] = request.ToRank.Value.ToString();
        }
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        if (request.TopNArticles != null)
        {
            _query["top_n_articles"] = request.TopNArticles.Value.ToString();
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
                    Path = "api/breaking_news",
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
                return JsonUtils.Deserialize<BreakingNewsResponseDto>(responseBody)!;
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
    /// Retrieves breaking news articles and sorts them based on specified criteria.
    /// </summary>
    /// <example><code>
    /// await client.BreakingNews.BreakingNewsPostAsync(
    ///     new BreakingNewsPostRequest
    ///     {
    ///         SortBy = SortBy.Relevancy,
    ///         RankedOnly = true,
    ///         TopNArticles = 1,
    ///     }
    /// );
    /// </code></example>
    public async Task<BreakingNewsResponseDto> BreakingNewsPostAsync(
        BreakingNewsPostRequest request,
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
                    Path = "api/breaking_news",
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
                return JsonUtils.Deserialize<BreakingNewsResponseDto>(responseBody)!;
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
