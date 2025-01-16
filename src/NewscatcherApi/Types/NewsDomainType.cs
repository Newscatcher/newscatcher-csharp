using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

[JsonConverter(typeof(EnumSerializer<NewsDomainType>))]
public enum NewsDomainType
{
    [EnumMember(Value = "Original Content")]
    OriginalContent,

    [EnumMember(Value = "Aggregator")]
    Aggregator,

    [EnumMember(Value = "Press Releases")]
    PressReleases,

    [EnumMember(Value = "Republisher")]
    Republisher,

    [EnumMember(Value = "Other")]
    Other,
}