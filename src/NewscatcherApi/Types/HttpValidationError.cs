using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record HttpValidationError
{
    [JsonPropertyName("detail")]
    public IEnumerable<ValidationError>? Detail { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
