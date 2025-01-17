using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

[JsonConverter(typeof(EnumSerializer<PublishedDatePrecision>))]
public enum PublishedDatePrecision
{
    [EnumMember(Value = "full")]
    Full,

    [EnumMember(Value = "timezone unknown")]
    TimezoneUnknown,

    [EnumMember(Value = "date")]
    Date,
}
