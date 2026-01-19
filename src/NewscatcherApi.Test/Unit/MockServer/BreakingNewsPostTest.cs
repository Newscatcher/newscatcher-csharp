using NewscatcherApi;
using NewscatcherApi.Core;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer;

[TestFixture]
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
                      "content": "content",
                      "id": "id",
                      "score": 1.1,
                      "robots_compliant": true
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
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<BreakingNewsResponseDto>(mockResponse)).UsingDefaults()
        );
    }
}
