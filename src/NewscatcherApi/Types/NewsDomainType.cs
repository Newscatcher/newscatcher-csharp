using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(NewsDomainType.NewsDomainTypeSerializer))]
[Serializable]
public readonly record struct NewsDomainType : IStringEnum
{
    public static readonly NewsDomainType OriginalContent = new(Values.OriginalContent);

    public static readonly NewsDomainType Aggregator = new(Values.Aggregator);

    public static readonly NewsDomainType PressReleases = new(Values.PressReleases);

    public static readonly NewsDomainType Republisher = new(Values.Republisher);

    public static readonly NewsDomainType Other = new(Values.Other);

    public NewsDomainType(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static NewsDomainType FromCustom(string value)
    {
        return new NewsDomainType(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(NewsDomainType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NewsDomainType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NewsDomainType value) => value.Value;

    public static explicit operator NewsDomainType(string value) => new(value);

    internal class NewsDomainTypeSerializer : JsonConverter<NewsDomainType>
    {
        public override NewsDomainType Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new NewsDomainType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            NewsDomainType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override NewsDomainType ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new NewsDomainType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            NewsDomainType value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string OriginalContent = "Original Content";

        public const string Aggregator = "Aggregator";

        public const string PressReleases = "Press Releases";

        public const string Republisher = "Republisher";

        public const string Other = "Other";
    }
}
