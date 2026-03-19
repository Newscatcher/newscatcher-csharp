using OneOf;

namespace NewscatcherApi;

public partial interface IAggregationCountClient
{
    /// <summary>
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    WithRawResponseTask<
        OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
    > GetAsync(
        GetAggregationCountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    WithRawResponseTask<
        OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>
    > PostAsync(
        PostAggregationCountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
