using NUnit.Framework;
using NewscatcherApi.Test.Unit.MockServer;
using NewscatcherApi;
using System.Globalization;
using NewscatcherApi.Test.Utils;

namespace NewscatcherApi.Test.Unit.MockServer.Aggregation;

[TestFixture][Parallelizable(ParallelScope.Self)]
public class CountGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest() {

        const string mockResponse = """
        {
          "status": "status",
          "total_hits": 1,
          "page": 1,
          "total_pages": 1,
          "page_size": 1,
          "aggregations": {
            "aggregation_count": [
              {
                "time_frame": "2024-12-31T00:00:00.000Z",
                "article_count": 86
              }
            ]
          },
          "user_input": {
            "key": "value"
          }
        }
        """;

        Server.Given(WireMock.RequestBuilders.Request.Create().WithPath("/api/aggregation_count").WithParam("q", ""supply chain" AND Amazon NOT China").WithParam("search_in", "title_content, title_content_translated").WithParam("predefined_sources", "top 50 US, top 20 GB").WithParam("sources", "nytimes.com,finance.yahoo.com").WithParam("not_sources", "cnn.com,wsj.com").WithParam("lang", "en,es").WithParam("not_lang", "fr,de").WithParam("countries", "US,CA").WithParam("not_countries", "UK,FR").WithParam("not_author_name", "John Doe, Jane Doe").WithParam("from_", "2024-07-01T00:00:00Z").WithParam("to_", "2024-01-01T00:00:00Z").WithParam("published_date_precision", "full").WithParam("from_rank", "100").WithParam("to_rank", "100").WithParam("parent_url", "wsj.com/politics,wsj.com/tech").WithParam("all_links", "https://aiindex.stanford.edu/report,https://www.stateof.ai").WithParam("all_domain_links", "who.int,nih.gov").WithParam("all_links_text", "Nvidia,Tesla").WithParam("word_count_min", "300").WithParam("word_count_max", "1000").WithParam("page", "2").WithParam("page_size", "50").WithParam("theme", "Finance,Tech").WithParam("not_theme", "Crime,Sports").WithParam("ORG_entity_name", ""Apple Inc" OR Microsoft").WithParam("PER_entity_name", ""Elon Musk" OR "Jeff Bezos"").WithParam("LOC_entity_name", ""San Francisco" OR "New York City"").WithParam("MISC_entity_name", "AWS OR "Microsoft Azure"").WithParam("title_sentiment_min", "-0.5").WithParam("title_sentiment_max", "0.5").WithParam("content_sentiment_min", "-0.5").WithParam("content_sentiment_max", "0.5").WithParam("iptc_tags", "20000199,20000209").WithParam("not_iptc_tags", "20000205,20000209").UsingGet())

        .RespondWith(WireMock.ResponseBuilders.Response.Create()
        .WithStatusCode(200)
        .WithBody(mockResponse));

        var response = await Client.Aggregation.CountGetAsync(new AggregationCountGetRequest {
            Q = "\"supply chain\" AND Amazon NOT China",
            SearchIn = "title_content, title_content_translated",
            PredefinedSources = "top 50 US, top 20 GB",
            Sources = "nytimes.com,finance.yahoo.com",
            NotSources = "cnn.com,wsj.com",
            Lang = "en,es",
            NotLang = "fr,de",
            Countries = "US,CA",
            NotCountries = "UK,FR",
            NotAuthorName = "John Doe, Jane Doe",
            From = DateTime.Parse("2024-07-01T00:00:00.000Z", null, DateTimeStyles.AdjustToUniversal),
            To = DateTime.Parse("2024-01-01T00:00:00.000Z", null, DateTimeStyles.AdjustToUniversal),
            PublishedDatePrecision = "full",
            ByParseDate = true,
            RankedOnly = true,
            FromRank = 100,
            ToRank = 100,
            IsHeadline = true,
            IsOpinion = true,
            IsPaidContent = false,
            ParentUrl = "wsj.com/politics,wsj.com/tech",
            AllLinks = "https://aiindex.stanford.edu/report,https://www.stateof.ai",
            AllDomainLinks = "who.int,nih.gov",
            AllLinksText = "Nvidia,Tesla",
            WordCountMin = 300,
            WordCountMax = 1000,
            Page = 2,
            PageSize = 50,
            IncludeNlpData = true,
            HasNlp = true,
            Theme = "Finance,Tech",
            NotTheme = "Crime,Sports",
            OrgEntityName = "\"Apple Inc\" OR Microsoft",
            PerEntityName = "\"Elon Musk\" OR \"Jeff Bezos\"",
            LocEntityName = "\"San Francisco\" OR \"New York City\"",
            MiscEntityName = "AWS OR \"Microsoft Azure\"",
            TitleSentimentMin = -0.5f,
            TitleSentimentMax = 0.5f,
            ContentSentimentMin = -0.5f,
            ContentSentimentMax = 0.5f,
            IptcTags = "20000199,20000209",
            NotIptcTags = "20000205,20000209",
            RobotsCompliant = true
        });
        JsonAssert.AreEqual(response, mockResponse);
    }

}
