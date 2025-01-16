using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

[JsonConverter(typeof(EnumSerializer<AggregationGetRequestAggregationBy>))]
public enum AggregationGetRequestAggregationBy
{
    [EnumMember(Value = "day")]
    Day,

    [EnumMember(Value = "hour")]
    Hour,
}
