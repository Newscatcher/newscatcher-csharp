using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SubscriptionResponse
{
    [JsonPropertyName("active")]
    public required bool Active { get; set; }

    [JsonPropertyName("calls_per_seconds")]
    public int? CallsPerSeconds { get; set; }

    [JsonPropertyName("plan_name")]
    public required string PlanName { get; set; }

    [JsonPropertyName("usage_assigned_calls")]
    public int? UsageAssignedCalls { get; set; }

    [JsonPropertyName("usage_remaining_calls")]
    public int? UsageRemainingCalls { get; set; }

    [JsonPropertyName("historical_days")]
    public int? HistoricalDays { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
