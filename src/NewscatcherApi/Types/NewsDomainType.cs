using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<NewsDomainType>))]
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
