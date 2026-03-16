using NewscatcherApi;
using NewscatcherApi.Test.Unit.MockServer;
using NewscatcherApi.Test.Utils;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer.BreakingNews;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BreakingNewsPostTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "sort_by": "relevancy",
              "ranked_only": true,
              "top_n_articles": 1
            }
            """;

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

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/breaking_news")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BreakingNews.BreakingNewsPostAsync(
            new BreakingNewsPostRequest
            {
                SortBy = SortBy.Relevancy,
                RankedOnly = true,
                TopNArticles = 1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
