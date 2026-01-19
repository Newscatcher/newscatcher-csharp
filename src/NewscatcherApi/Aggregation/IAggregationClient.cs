using OneOf;

namespace NewscatcherApi;

public partial interface IAggregationClient
{
    /// <summary>
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    Task<OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>> GetAsync(
        AggregationGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
    /// </summary>
    Task<OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto>> PostAsync(
        AggregationPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
