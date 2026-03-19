using OneOf;

namespace NewscatcherApi;

public partial interface ILatestHeadlinesClient
{
    /// <summary>
    /// Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
    /// </summary>
    WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> GetAsync(
        GetLatestHeadlinesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
    /// </summary>
    WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> PostAsync(
        PostLatestHeadlinesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
