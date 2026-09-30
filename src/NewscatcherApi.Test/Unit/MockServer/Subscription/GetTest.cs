using NewscatcherApi.Test.Unit.MockServer;
using NewscatcherApi.Test.Utils;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer.Subscription;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "active": true,
              "concurrent_calls": 1,
              "plan": "plan",
              "plan_calls": 1,
              "remaining_calls": 1,
              "historical_days": 1
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/api/subscription").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Subscription.GetAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }
}
