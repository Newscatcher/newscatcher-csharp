using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

[JsonConverter(typeof(EnumSerializer<LatestHeadlinesGetRequestClusteringVariable>))]
public enum LatestHeadlinesGetRequestClusteringVariable
{
    [EnumMember(Value = "content")]
    Content,

    [EnumMember(Value = "title")]
    Title,

    [EnumMember(Value = "summary")]
    Summary,
}
