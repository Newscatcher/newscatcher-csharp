using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[Serializable]
public record Error : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A detailed description of the error.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// The HTTP status code of the error.
    /// </summary>
    [JsonPropertyName("status_code")]
    public required int StatusCode { get; set; }

    /// <summary>
    /// A short description of the status code.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
