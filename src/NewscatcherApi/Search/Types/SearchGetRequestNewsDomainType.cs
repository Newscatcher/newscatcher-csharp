using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<SearchGetRequestNewsDomainType>))]
[Serializable]
public readonly record struct SearchGetRequestNewsDomainType : IStringEnum
{
    public static readonly SearchGetRequestNewsDomainType OriginalContent = new(
        Values.OriginalContent
    );

    public static readonly SearchGetRequestNewsDomainType Aggregator = new(Values.Aggregator);

    public static readonly SearchGetRequestNewsDomainType PressReleases = new(Values.PressReleases);

    public static readonly SearchGetRequestNewsDomainType Republisher = new(Values.Republisher);

    public static readonly SearchGetRequestNewsDomainType Other = new(Values.Other);

    public SearchGetRequestNewsDomainType(string value)
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
    public static SearchGetRequestNewsDomainType FromCustom(string value)
    {
        return new SearchGetRequestNewsDomainType(value);
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

    public static bool operator ==(SearchGetRequestNewsDomainType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SearchGetRequestNewsDomainType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SearchGetRequestNewsDomainType value) => value.Value;

    public static explicit operator SearchGetRequestNewsDomainType(string value) => new(value);

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
