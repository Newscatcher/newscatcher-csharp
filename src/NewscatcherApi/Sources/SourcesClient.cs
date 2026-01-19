using System.Text.Json;
using NewscatcherApi.Core;

namespace NewscatcherApi;

public partial class SourcesClient : ISourcesClient
{
    private RawClient _client;

    internal SourcesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieves a list of sources based on specified criteria such as language, country, rank, and more.
    /// </summary>
    /// <example><code>
    /// await client.Sources.GetAsync(
    ///     new SourcesGetRequest
    ///     {
    ///         Lang = "en",
    ///         Countries = "US",
    ///         PredefinedSources = "top 100 US, top 5 GB",
    ///         SourceName = "sport",
    ///         SourceUrl = "bbc.com",
    ///         NewsType = "General News Outlets",
    ///     }
    /// );
    /// </code></example>
    public async Task<SourcesResponseDto> GetAsync(
        SourcesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Lang != null)
        {
            _query["lang"] = request.Lang;
        }
        if (request.Countries != null)
        {
            _query["countries"] = request.Countries;
        }
        if (request.PredefinedSources != null)
        {
            _query["predefined_sources"] = request.PredefinedSources;
        }
        if (request.SourceName != null)
        {
            _query["source_name"] = request.SourceName;
        }
        if (request.SourceUrl != null)
        {
            _query["source_url"] = request.SourceUrl;
        }
        if (request.IncludeAdditionalInfo != null)
        {
            _query["include_additional_info"] = JsonUtils.Serialize(
                request.IncludeAdditionalInfo.Value
            );
        }
        if (request.IsNewsDomain != null)
        {
            _query["is_news_domain"] = JsonUtils.Serialize(request.IsNewsDomain.Value);
        }
        if (request.NewsDomainType != null)
        {
            _query["news_domain_type"] = request.NewsDomainType.Value.Stringify();
        }
        if (request.NewsType != null)
        {
            _query["news_type"] = request.NewsType;
        }
        if (request.FromRank != null)
        {
            _query["from_rank"] = request.FromRank.Value.ToString();
        }
        if (request.ToRank != null)
        {
            _query["to_rank"] = request.ToRank.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "api/sources",
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
                return JsonUtils.Deserialize<SourcesResponseDto>(responseBody)!;
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
    /// Retrieves the list of sources available in the database. You can filter the sources by language, country, and more.
    /// </summary>
    /// <example><code>
    /// await client.Sources.PostAsync(new SourcesPostRequest { PredefinedSources = "top 10 US" });
    /// </code></example>
    public async Task<SourcesResponseDto> PostAsync(
        SourcesPostRequest request,
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
                    Path = "api/sources",
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
                return JsonUtils.Deserialize<SourcesResponseDto>(responseBody)!;
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
