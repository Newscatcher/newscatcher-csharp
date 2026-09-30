using NewscatcherApi;
using NewscatcherApi.Test.Unit.MockServer;
using NewscatcherApi.Test.Utils;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer.Sources;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
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
                    .WithParam("lang", "en", "es")
                    .WithParam("countries", "US", "CA")
                    .WithParam("predefined_sources", "top 50 US", " top 20 GB")
                    .WithParam("source_name", "sport", "tech")
                    .WithParam("source_url", "bbc.com")
                    .WithParam("news_type", "General News Outlets", "Tech News and Updates")
                    .WithParam("from_rank", "100")
                    .WithParam("to_rank", "100")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Sources.GetAsync(
            new GetSourcesRequest
            {
                Lang = "en,es",
                Countries = "US,CA",
                PredefinedSources = "top 50 US, top 20 GB",
                SourceName = "sport,tech",
                SourceUrl = "bbc.com",
                IncludeAdditionalInfo = true,
                IsNewsDomain = true,
                NewsType = "General News Outlets,Tech News and Updates",
                FromRank = 100,
                ToRank = 100,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
