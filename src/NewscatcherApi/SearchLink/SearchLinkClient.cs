using System.Net.Http;
using System.Text.Json;
using System.Threading;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public partial class SearchLinkClient
{
    private RawClient _client;

    internal SearchLinkClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Searches for articles based on specified links or IDs. You can filter results by date range.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.SearchLink.SearchUrlGetAsync(
    ///     new SearchUrlGetRequest
    ///     {
    ///         From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
    ///         To = new DateTime(2024, 01, 01, 00, 00, 00, 000),
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<SearchResponseDto> SearchUrlGetAsync(
        SearchUrlGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Ids != null)
        {
            _query["ids"] = request.Ids;
        }
        if (request.Links != null)
        {
            _query["links"] = request.Links;
        }
        if (request.From != null)
        {
            _query["from_"] = request.From.ToString();
        }
        if (request.To != null)
        {
            _query["to_"] = request.To.ToString();
        }
        if (request.Page != null)
        {
            _query["page"] = request.Page.ToString();
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "api/search_by_link",
                Query = _query,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<SearchResponseDto>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new NewscatcherApiException("Failed to deserialize response", e);
            }
        }

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
                    throw new UnprocessableEntityError(JsonUtils.Deserialize<Error>(responseBody));
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

    /// <summary>
    /// Searches for articles using their ID(s) or link(s).
    /// </summary>
    /// <example>
    /// <code>
    /// await client.SearchLink.SearchUrlPostAsync(
    ///     new SearchUrlPostRequest
    ///     {
    ///         Ids = new List&lt;string&gt;()
    ///         {
    ///             "8ea8a784568ffaa05cb6d1ab2d2e84dd",
    ///             "0146a551ef05ab1c494a55e806e3ce64",
    ///         },
    ///         Links = new List&lt;string&gt;()
    ///         {
    ///             "https://www.nytimes.com/2024/08/30/technology/ai-chatbot-chatgpt-manipulation.html",
    ///             "https://www.bbc.com/news/articles/c39k379grzlo",
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<SearchResponseDto> SearchUrlPostAsync(
        SearchUrlPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "api/search_by_link",
                Body = request,
                ContentType = "application/json",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<SearchResponseDto>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new NewscatcherApiException("Failed to deserialize response", e);
            }
        }

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
                    throw new UnprocessableEntityError(JsonUtils.Deserialize<Error>(responseBody));
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
