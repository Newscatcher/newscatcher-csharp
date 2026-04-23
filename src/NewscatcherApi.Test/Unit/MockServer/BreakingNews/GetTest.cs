using NUnit.Framework;
using NewscatcherApi.Test.Unit.MockServer;
using NewscatcherApi;
using NewscatcherApi.Test.Utils;

namespace NewscatcherApi.Test.Unit.MockServer.BreakingNews;

[TestFixture][Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
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
          "breaking_news_events": [
            {
              "event_id": "event_id",
              "articles_count": 1,
              "articles": [
                {
                  "title": "title",
                  "link": "link",
                  "domain_url": "domain_url",
                  "full_domain_url": "full_domain_url",
                  "parent_url": "parent_url",
                  "rank": 1,
                  "id": "id",
                  "score": 1.1
                }
              ]
            }
          ],
          "user_input": {
            "key": "value"
          }
        }
        """;

        Server.Given(WireMock.RequestBuilders.Request.Create().WithPath("/api/breaking_news").WithParam("from_rank", "100").WithParam("to_rank", "100").WithParam("page", "2").WithParam("page_size", "50").WithParam("top_n_articles", "5").WithParam("theme", "Finance,Tech").WithParam("not_theme", "Crime,Sports").WithParam("ORG_entity_name", ""Apple Inc" OR Microsoft").WithParam("PER_entity_name", ""Elon Musk" OR "Jeff Bezos"").WithParam("LOC_entity_name", ""San Francisco" OR "New York City"").WithParam("MISC_entity_name", "AWS OR "Microsoft Azure"").WithParam("title_sentiment_min", "-0.5").WithParam("title_sentiment_max", "0.5").WithParam("content_sentiment_min", "-0.5").WithParam("content_sentiment_max", "0.5").UsingGet())

        .RespondWith(WireMock.ResponseBuilders.Response.Create()
        .WithStatusCode(200)
        .WithBody(mockResponse));

        var response = await Client.BreakingNews.GetAsync(new GetBreakingNewsRequest {
            RankedOnly = true,
            FromRank = 100,
            ToRank = 100,
            Page = 2,
            PageSize = 50,
            TopNArticles = 5,
            IncludeTranslationFields = true,
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
            ContentSentimentMax = 0.5f
        });
        JsonAssert.AreEqual(response, mockResponse);
    }

}
