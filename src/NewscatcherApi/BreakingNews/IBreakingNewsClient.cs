namespace NewscatcherApi;

public partial interface IBreakingNewsClient
{
    /// <summary>
    /// Retrieves breaking news articles and sorts them based on specified criteria.
    /// </summary>
    WithRawResponseTask<BreakingNewsResponseDto> GetAsync(
        GetBreakingNewsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves breaking news articles and sorts them based on specified criteria.
    /// </summary>
    WithRawResponseTask<BreakingNewsResponseDto> PostAsync(
        PostBreakingNewsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
