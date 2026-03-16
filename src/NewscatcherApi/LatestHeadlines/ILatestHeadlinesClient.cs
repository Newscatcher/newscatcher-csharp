using OneOf;

namespace NewscatcherApi;

public partial interface ILatestHeadlinesClient
{
    /// <summary>
    /// Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
    /// </summary>
    WithRawResponseTask<
        OneOf<SearchResponseDto, ClusteredSearchResponseDto>
    > LatestHeadlinesGetAsync(
        LatestHeadlinesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
    /// </summary>
    WithRawResponseTask<
        OneOf<SearchResponseDto, ClusteredSearchResponseDto>
    > LatestHeadlinesPostAsync(
        LatestHeadlinesPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
