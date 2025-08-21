using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(EnumSerializer<SearchGetRequestPublishedDatePrecision>))]
public enum SearchGetRequestPublishedDatePrecision
{
    [EnumMember(Value = "full")]
    Full,

    [EnumMember(Value = "timezone unknown")]
    TimezoneUnknown,

    [EnumMember(Value = "date")]
    Date,
}
