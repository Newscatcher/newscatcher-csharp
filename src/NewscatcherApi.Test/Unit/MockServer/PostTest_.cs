using NewscatcherApi;
using NewscatcherApi.Test.Utils;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer;

[TestFixture]
public class PostTest_ : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "q": "\"supply chain\" AND Amazon NOT China",
              "aggregation_by": "day"
            }
            """;

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

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/aggregation_count")
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

        var response = await Client.Aggregation.PostAsync(
            new AggregationPostRequest
            {
                Q = "\"supply chain\" AND Amazon NOT China",
                AggregationBy = AggregationBy.Day,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
