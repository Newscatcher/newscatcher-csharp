using NewscatcherApi;
using NewscatcherApi.Core;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer;

[TestFixture]
public class GetTest_ : BaseMockServerTest
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
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<SubscriptionResponseDto>(mockResponse)).UsingDefaults()
        );
    }
}
