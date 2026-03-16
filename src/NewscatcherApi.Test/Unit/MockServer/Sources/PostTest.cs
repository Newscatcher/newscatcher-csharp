using NewscatcherApi;
using NewscatcherApi.Test.Unit.MockServer;
using NewscatcherApi.Test.Utils;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer.Sources;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "predefined_sources": "top 10 US"
            }
            """;

        const string mockResponse = """
            {
              "message": "message",
              "sources": [
                {
                  "name_source": "name_source",
                  "domain_url": "domain_url",
                  "logo": "logo",
                  "additional_info": {
                    "nb_articles_for_7d": 153,
                    "country": "US",
                    "rank": 117,
                    "is_news_domain": true,
                    "news_domain_type": "Original Content",
                    "news_type": "General News Outlets",
                    "robots_compliant": "100%"
                  }
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
                    .WithPath("/api/sources")
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

        var response = await Client.Sources.PostAsync(
            new SourcesPostRequest { PredefinedSources = "top 10 US" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
