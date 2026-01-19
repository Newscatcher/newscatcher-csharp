using OneOf;

namespace NewscatcherApi;

public partial interface ISearchsimilarClient
{
    /// <summary>
    /// Searches for articles similar to a specified query.
    /// </summary>
    Task<OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>> GetAsync(
        SearchSimilarGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for articles similar to the specified query. You can filter results by language, country, source, and more.
    /// </summary>
    Task<OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto>> PostAsync(
        SearchSimilarPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
