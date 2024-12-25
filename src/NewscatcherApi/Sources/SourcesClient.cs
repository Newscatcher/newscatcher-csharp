using System.Net.Http;
using System.Text.Json;
using System.Threading;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public partial class SourcesClient
{
    private RawClient _client;

    internal SourcesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Sources.GetAsync(
    ///     new SourcesGetRequest
    ///     {
    ///         Lang = "lang",
    ///         Countries = "countries",
    ///         PredefinedSources = "predefined_sources",
    ///         SourceName = "source_name",
    ///         SourceUrl = "source_url",
    ///         NewsDomainType = "news_domain_type",
    ///         NewsType = "news_type",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<SourceResponse> GetAsync(
        SourcesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["lang"] = request.Lang;
        _query["countries"] = request.Countries;
        _query["predefined_sources"] = request.PredefinedSources;
        _query["source_name"] = request.SourceName;
        _query["source_url"] = request.SourceUrl;
        _query["news_domain_type"] = request.NewsDomainType;
        _query["news_type"] = request.NewsType;
        if (request.IncludeAdditionalInfo != null)
        {
            _query["include_additional_info"] = request.IncludeAdditionalInfo.ToString();
        }
        if (request.FromRank != null)
        {
            _query["from_rank"] = request.FromRank.ToString();
        }
        if (request.ToRank != null)
        {
            _query["to_rank"] = request.ToRank.ToString();
        }
        if (request.IsNewsDomain != null)
        {
            _query["is_news_domain"] = request.IsNewsDomain.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "api/sources",
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
                return JsonUtils.Deserialize<SourceResponse>(responseBody)!;
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
    /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Sources.PostAsync(new SourcesRequest());
    /// </code>
    /// </example>
    public async Task<SourceResponse> PostAsync(
        SourcesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "api/sources",
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
                return JsonUtils.Deserialize<SourceResponse>(responseBody)!;
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
