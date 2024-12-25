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
    /// This endpoint allows you to search for articles. You can search for articles by id(s) or link(s).
    /// </summary>
    /// <example>
    /// <code>
    /// await client.SearchLink.SearchUrlGetAsync(new SearchUrlGetRequest { Ids = "ids", Links = "links" });
    /// </code>
    /// </example>
    public async Task<SearchResponse> SearchUrlGetAsync(
        SearchUrlGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["ids"] = request.Ids;
        _query["links"] = request.Links;
        if (request.From != null)
        {
            _query["from_"] = request.From;
        }
        if (request.To != null)
        {
            _query["to_"] = request.To;
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
                return JsonUtils.Deserialize<SearchResponse>(responseBody)!;
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
                case 422:
                    throw new UnprocessableEntityError(
                        JsonUtils.Deserialize<HttpValidationError>(responseBody)
                    );
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
    /// This endpoint allows you to search for articles. You can search for articles by id(s) or link(s).
    /// </summary>
    /// <example>
    /// <code>
    /// await client.SearchLink.SearchUrlPostAsync(new SearchUrlRequest());
    /// </code>
    /// </example>
    public async Task<SearchResponse> SearchUrlPostAsync(
        SearchUrlRequest request,
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
                return JsonUtils.Deserialize<SearchResponse>(responseBody)!;
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
                case 422:
                    throw new UnprocessableEntityError(
                        JsonUtils.Deserialize<HttpValidationError>(responseBody)
                    );
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
