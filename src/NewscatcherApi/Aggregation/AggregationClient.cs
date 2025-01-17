using System.Net.Http;
using System.Text.Json;
using System.Threading;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public partial class AggregationClient
{
    private RawClient _client;

    internal AggregationClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Aggregation.GetAsync(
    ///     new AggregationGetRequest
    ///     {
    ///         Q = "technology AND (Apple OR Microsoft) NOT Google",
    ///         PredefinedSources = "top 100 US, top 5 GB",
    ///         From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
    ///         To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
    ///         Theme = "Business,Finance",
    ///         NotTheme = "Crime",
    ///         IptcTags = "20000199,20000209",
    ///         NotIptcTags = "20000205,20000209",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<
        OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
    > GetAsync(
        AggregationGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["q"] = request.Q;
        if (request.SearchIn != null)
        {
            _query["search_in"] = request.SearchIn;
        }
        if (request.PredefinedSources != null)
        {
            _query["predefined_sources"] = request.PredefinedSources;
        }
        if (request.Sources != null)
        {
            _query["sources"] = request.Sources;
        }
        if (request.NotSources != null)
        {
            _query["not_sources"] = request.NotSources;
        }
        if (request.Lang != null)
        {
            _query["lang"] = request.Lang;
        }
        if (request.NotLang != null)
        {
            _query["not_lang"] = request.NotLang;
        }
        if (request.Countries != null)
        {
            _query["countries"] = request.Countries;
        }
        if (request.NotCountries != null)
        {
            _query["not_countries"] = request.NotCountries;
        }
        if (request.NotAuthorName != null)
        {
            _query["not_author_name"] = request.NotAuthorName;
        }
        if (request.From != null)
        {
            _query["from_"] = request.From.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.To != null)
        {
            _query["to_"] = request.To.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.PublishedDatePrecision != null)
        {
            _query["published_date_precision"] = request.PublishedDatePrecision.Value.Stringify();
        }
        if (request.ByParseDate != null)
        {
            _query["by_parse_date"] = request.ByParseDate.ToString();
        }
        if (request.SortBy != null)
        {
            _query["sort_by"] = request.SortBy.Value.Stringify();
        }
        if (request.RankedOnly != null)
        {
            _query["ranked_only"] = request.RankedOnly.ToString();
        }
        if (request.FromRank != null)
        {
            _query["from_rank"] = request.FromRank.ToString();
        }
        if (request.ToRank != null)
        {
            _query["to_rank"] = request.ToRank.ToString();
        }
        if (request.IsHeadline != null)
        {
            _query["is_headline"] = request.IsHeadline.ToString();
        }
        if (request.IsOpinion != null)
        {
            _query["is_opinion"] = request.IsOpinion.ToString();
        }
        if (request.IsPaidContent != null)
        {
            _query["is_paid_content"] = request.IsPaidContent.ToString();
        }
        if (request.ParentUrl != null)
        {
            _query["parent_url"] = request.ParentUrl;
        }
        if (request.AllLinks != null)
        {
            _query["all_links"] = request.AllLinks;
        }
        if (request.AllDomainLinks != null)
        {
            _query["all_domain_links"] = request.AllDomainLinks;
        }
        if (request.WordCountMin != null)
        {
            _query["word_count_min"] = request.WordCountMin.ToString();
        }
        if (request.WordCountMax != null)
        {
            _query["word_count_max"] = request.WordCountMax.ToString();
        }
        if (request.Page != null)
        {
            _query["page"] = request.Page.ToString();
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.ToString();
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
        if (request.IptcTags != null)
        {
            _query["iptc_tags"] = request.IptcTags;
        }
        if (request.NotIptcTags != null)
        {
            _query["not_iptc_tags"] = request.NotIptcTags;
        }
        if (request.AggregationBy != null)
        {
            _query["aggregation_by"] = request.AggregationBy.Value.Stringify();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "api/aggregation_count",
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
                    OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
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
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Aggregation.PostAsync(
    ///     new AggregationPostRequest
    ///     {
    ///         Q = "renewable energy",
    ///         PredefinedSources = "top 50 US",
    ///         From = new DateTime(2024, 01, 01, 00, 00, 00, 000),
    ///         To = new DateTime(2024, 06, 30, 00, 00, 00, 000),
    ///         AggregationBy = AggregationBy.Day,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<
        OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
    > PostAsync(
        AggregationPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "api/aggregation_count",
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
                    OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
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
