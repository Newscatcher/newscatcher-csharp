using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<SearchSimilarGetRequestSortBy>))]
[Serializable]
public readonly record struct SearchSimilarGetRequestSortBy : IStringEnum
{
    public static readonly SearchSimilarGetRequestSortBy Relevancy = new(Values.Relevancy);

    public static readonly SearchSimilarGetRequestSortBy Date = new(Values.Date);

    public static readonly SearchSimilarGetRequestSortBy Rank = new(Values.Rank);

    public SearchSimilarGetRequestSortBy(string value)
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
    public static SearchSimilarGetRequestSortBy FromCustom(string value)
    {
        return new SearchSimilarGetRequestSortBy(value);
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

    public static bool operator ==(SearchSimilarGetRequestSortBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SearchSimilarGetRequestSortBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SearchSimilarGetRequestSortBy value) => value.Value;

    public static explicit operator SearchSimilarGetRequestSortBy(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Relevancy = "relevancy";

        public const string Date = "date";

        public const string Rank = "rank";
    }
}
