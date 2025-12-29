using NewscatcherApi;
using NewscatcherApi.Core;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer;

[TestFixture]
public class BreakingNewsGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
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
                    .WithParam("top_n_articles", "5")
                    .WithParam("theme", "Business,Finance")
                    .WithParam("not_theme", "Crime")
                    .WithParam("ORG_entity_name", "Apple")
                    .WithParam("PER_entity_name", "Elon Musk")
                    .WithParam("LOC_entity_name", "California")
                    .WithParam("MISC_entity_name", "Bitcoin")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BreakingNews.BreakingNewsGetAsync(
            new BreakingNewsGetRequest
            {
                TopNArticles = 5,
                IncludeTranslationFields = true,
                IncludeNlpData = true,
                HasNlp = true,
                Theme = "Business,Finance",
                NotTheme = "Crime",
                OrgEntityName = "Apple",
                PerEntityName = "Elon Musk",
                LocEntityName = "California",
                MiscEntityName = "Bitcoin",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<BreakingNewsResponseDto>(mockResponse)).UsingDefaults()
        );
    }
}
