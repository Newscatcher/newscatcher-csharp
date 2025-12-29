using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<SourcesGetRequestNewsDomainType>))]
[Serializable]
public readonly record struct SourcesGetRequestNewsDomainType : IStringEnum
{
    public static readonly SourcesGetRequestNewsDomainType OriginalContent = new(
        Values.OriginalContent
    );

    public static readonly SourcesGetRequestNewsDomainType Aggregator = new(Values.Aggregator);

    public static readonly SourcesGetRequestNewsDomainType PressReleases = new(
        Values.PressReleases
    );

    public static readonly SourcesGetRequestNewsDomainType Republisher = new(Values.Republisher);

    public static readonly SourcesGetRequestNewsDomainType Other = new(Values.Other);

    public SourcesGetRequestNewsDomainType(string value)
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
    public static SourcesGetRequestNewsDomainType FromCustom(string value)
    {
        return new SourcesGetRequestNewsDomainType(value);
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

    public static bool operator ==(SourcesGetRequestNewsDomainType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SourcesGetRequestNewsDomainType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SourcesGetRequestNewsDomainType value) => value.Value;

    public static explicit operator SourcesGetRequestNewsDomainType(string value) => new(value);

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
