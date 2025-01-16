using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

[JsonConverter(typeof(EnumSerializer<AggregationBy>))]
public enum AggregationBy
{
    [EnumMember(Value = "day")]
    Day,

    [EnumMember(Value = "hour")]
    Hour,
}
