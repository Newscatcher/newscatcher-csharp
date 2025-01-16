using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

[JsonConverter(typeof(EnumSerializer<AggregationGetRequestSortBy>))]
public enum AggregationGetRequestSortBy
{
    [EnumMember(Value = "relevancy")]
    Relevancy,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "rank")]
    Rank,
}
