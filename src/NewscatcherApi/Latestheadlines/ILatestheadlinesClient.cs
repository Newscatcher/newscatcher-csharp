using OneOf;

namespace NewscatcherApi;

public partial interface ILatestheadlinesClient
{
    /// <summary>
    /// Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
    /// </summary>
    Task<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> GetAsync(
        LatestHeadlinesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
    /// </summary>
    Task<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> PostAsync(
        LatestHeadlinesPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
