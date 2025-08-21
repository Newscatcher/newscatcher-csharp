using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(EnumSerializer<BreakingNewsGetRequestSortBy>))]
public enum BreakingNewsGetRequestSortBy
{
    [EnumMember(Value = "relevancy")]
    Relevancy,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "rank")]
    Rank,
}
