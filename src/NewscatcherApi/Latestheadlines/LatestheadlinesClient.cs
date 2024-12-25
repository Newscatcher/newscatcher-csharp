using System.Net.Http;
using System.Text.Json;
using System.Threading;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public partial class LatestheadlinesClient
{
    private RawClient _client;

    internal LatestheadlinesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Latestheadlines.GetAsync(
    ///     new LatestHeadlinesGetRequest
    ///     {
    ///         Lang = "lang",
    ///         NotLang = "not_lang",
    ///         Countries = "countries",
    ///         NotCountries = "not_countries",
    ///         Sources = "sources",
    ///         PredefinedSources = "predefined_sources",
    ///         NotSources = "not_sources",
    ///         NotAuthorName = "not_author_name",
    ///         ParentUrl = "parent_url",
    ///         AllLinks = "all_links",
    ///         AllDomainLinks = "all_domain_links",
    ///         IptcTags = "iptc_tags",
    ///         NotIptcTags = "not_iptc_tags",
    ///         IabTags = "iab_tags",
    ///         NotIabTags = "not_iab_tags",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<OneOf<ClusteringSearchResponse, LatestHeadlinesResponse>> GetAsync(
        LatestHeadlinesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["lang"] = request.Lang;
        _query["not_lang"] = request.NotLang;
        _query["countries"] = request.Countries;
        _query["not_countries"] = request.NotCountries;
        _query["sources"] = request.Sources;
        _query["predefined_sources"] = request.PredefinedSources;
        _query["not_sources"] = request.NotSources;
        _query["not_author_name"] = request.NotAuthorName;
        _query["parent_url"] = request.ParentUrl;
        _query["all_links"] = request.AllLinks;
        _query["all_domain_links"] = request.AllDomainLinks;
        _query["iptc_tags"] = request.IptcTags;
        _query["not_iptc_tags"] = request.NotIptcTags;
        _query["iab_tags"] = request.IabTags;
        _query["not_iab_tags"] = request.NotIabTags;
        if (request.When != null)
        {
            _query["when"] = request.When;
        }
        if (request.ByParseDate != null)
        {
            _query["by_parse_date"] = request.ByParseDate;
        }
        if (request.SortBy != null)
        {
            _query["sort_by"] = request.SortBy;
        }
        if (request.RankedOnly != null)
        {
            _query["ranked_only"] = request.RankedOnly;
        }
        if (request.IsHeadline != null)
        {
            _query["is_headline"] = request.IsHeadline;
        }
        if (request.IsOpinion != null)
        {
            _query["is_opinion"] = request.IsOpinion;
        }
        if (request.IsPaidContent != null)
        {
            _query["is_paid_content"] = request.IsPaidContent;
        }
        if (request.WordCountMin != null)
        {
            _query["word_count_min"] = request.WordCountMin;
        }
        if (request.WordCountMax != null)
        {
            _query["word_count_max"] = request.WordCountMax;
        }
        if (request.Page != null)
        {
            _query["page"] = request.Page;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        if (request.ClusteringVariable != null)
        {
            _query["clustering_variable"] = request.ClusteringVariable;
        }
        if (request.ClusteringEnabled != null)
        {
            _query["clustering_enabled"] = request.ClusteringEnabled;
        }
        if (request.ClusteringThreshold != null)
        {
            _query["clustering_threshold"] = request.ClusteringThreshold.ToString();
        }
        if (request.IncludeNlpData != null)
        {
            _query["include_nlp_data"] = request.IncludeNlpData.ToString();
        }
        if (request.HasNlp != null)
        {
            _query["has_nlp"] = request.HasNlp.ToString();
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
            _query["title_sentiment_min"] = request.TitleSentimentMin.ToString();
        }
        if (request.TitleSentimentMax != null)
        {
            _query["title_sentiment_max"] = request.TitleSentimentMax.ToString();
        }
        if (request.ContentSentimentMin != null)
        {
            _query["content_sentiment_min"] = request.ContentSentimentMin.ToString();
        }
        if (request.ContentSentimentMax != null)
        {
            _query["content_sentiment_max"] = request.ContentSentimentMax.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "api/latest_headlines",
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
                return JsonUtils.Deserialize<
                    OneOf<ClusteringSearchResponse, LatestHeadlinesResponse>
                >(responseBody)!;
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
    /// This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Latestheadlines.PostAsync(new LatestHeadlinesRequest());
    /// </code>
    /// </example>
    public async Task<OneOf<ClusteringSearchResponse, LatestHeadlinesResponse>> PostAsync(
        LatestHeadlinesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "api/latest_headlines",
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
                return JsonUtils.Deserialize<
                    OneOf<ClusteringSearchResponse, LatestHeadlinesResponse>
                >(responseBody)!;
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
