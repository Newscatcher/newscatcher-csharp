using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<SearchGetRequestPublishedDatePrecision>))]
[Serializable]
public readonly record struct SearchGetRequestPublishedDatePrecision : IStringEnum
{
    public static readonly SearchGetRequestPublishedDatePrecision Full = new(Values.Full);

    public static readonly SearchGetRequestPublishedDatePrecision TimezoneUnknown = new(
        Values.TimezoneUnknown
    );

    public static readonly SearchGetRequestPublishedDatePrecision Date = new(Values.Date);

    public SearchGetRequestPublishedDatePrecision(string value)
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
    public static SearchGetRequestPublishedDatePrecision FromCustom(string value)
    {
        return new SearchGetRequestPublishedDatePrecision(value);
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

    public static bool operator ==(SearchGetRequestPublishedDatePrecision value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SearchGetRequestPublishedDatePrecision value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SearchGetRequestPublishedDatePrecision value) =>
        value.Value;

    public static explicit operator SearchGetRequestPublishedDatePrecision(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Full = "full";

        public const string TimezoneUnknown = "timezone unknown";

        public const string Date = "date";
    }
}
