using OneOf;

namespace NewscatcherApi;

public partial interface ISearchClient
{
    /// <summary>
    /// Searches for articles based on specified criteria such as keyword, language, country, source, and more.
    /// </summary>
    WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> GetAsync(
        SearchGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for articles based on specified criteria such as keyword, language, country, source, and more.
    /// </summary>
    WithRawResponseTask<OneOf<SearchResponseDto, ClusteredSearchResponseDto>> PostAsync(
        SearchPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
