using OneOf;

namespace NewscatcherApi;

public partial interface IAggregationClient
{
    /// <summary>
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    WithRawResponseTask<
        OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
    > CountGetAsync(
        AggregationCountGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    WithRawResponseTask<
        OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
    > CountPostAsync(
        AggregationCountPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
