using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<AuthorsGetRequestPublishedDatePrecision>))]
[Serializable]
public readonly record struct AuthorsGetRequestPublishedDatePrecision : IStringEnum
{
    public static readonly AuthorsGetRequestPublishedDatePrecision Full = new(Values.Full);

    public static readonly AuthorsGetRequestPublishedDatePrecision TimezoneUnknown = new(
        Values.TimezoneUnknown
    );

    public static readonly AuthorsGetRequestPublishedDatePrecision Date = new(Values.Date);

    public AuthorsGetRequestPublishedDatePrecision(string value)
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
    public static AuthorsGetRequestPublishedDatePrecision FromCustom(string value)
    {
        return new AuthorsGetRequestPublishedDatePrecision(value);
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

    public static bool operator ==(AuthorsGetRequestPublishedDatePrecision value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AuthorsGetRequestPublishedDatePrecision value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AuthorsGetRequestPublishedDatePrecision value) =>
        value.Value;

    public static explicit operator AuthorsGetRequestPublishedDatePrecision(string value) =>
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
