using OneOf;

namespace NewscatcherApi;

public partial interface ISearchClient
{
    /// <summary>
    /// Searches for articles based on specified criteria such as keywords, language, country, source, and more.
    /// </summary>
    WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> GetAsync(
        GetSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for articles based on specified criteria such as keywords, language, country, source, and more.
    /// </summary>
    WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> PostAsync(
        PostSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
