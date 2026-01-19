namespace NewscatcherApi;

public partial interface IBreakingNewsClient
{
    /// <summary>
    /// Retrieves breaking news articles and sorts them based on specified criteria.
    /// </summary>
    Task<BreakingNewsResponseDto> BreakingNewsGetAsync(
        BreakingNewsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves breaking news articles and sorts them based on specified criteria.
    /// </summary>
    Task<BreakingNewsResponseDto> BreakingNewsPostAsync(
        BreakingNewsPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
