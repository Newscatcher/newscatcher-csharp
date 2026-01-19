using OneOf;

namespace NewscatcherApi;

public partial interface IAuthorsClient
{
    /// <summary>
    /// Searches for articles written by a specified author. You can filter results by language, country, source, and more.
    /// </summary>
    Task<OneOf<SearchResponseDto, FailedAuthorsResponseDto>> GetAsync(
        AuthorsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for articles by author. You can filter results by language, country, source, and more.
    /// </summary>
    Task<OneOf<SearchResponseDto, FailedAuthorsResponseDto>> PostAsync(
        AuthorsPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
