using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SubscriptionResponseDto
{
    /// <summary>
    /// Indicates whether the subscription is currently active.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; set; }

    /// <summary>
    /// The number of API calls allowed per second allowed in the current plan.
    /// </summary>
    [JsonPropertyName("concurrent_calls")]
    public required int ConcurrentCalls { get; set; }

    /// <summary>
    /// The name of the subscription plan.
    /// </summary>
    [JsonPropertyName("plan")]
    public required string Plan { get; set; }

    /// <summary>
    /// The total number of API calls assigned to the current subscription.
    /// </summary>
    [JsonPropertyName("plan_calls")]
    public required int PlanCalls { get; set; }

    /// <summary>
    /// The number of API calls remaining for the current subscription period.
    /// </summary>
    [JsonPropertyName("remaining_calls")]
    public required int RemainingCalls { get; set; }

    /// <summary>
    /// The number of historical days accessible under the current subscription plan.
    /// </summary>
    [JsonPropertyName("historical_days")]
    public required int HistoricalDays { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
