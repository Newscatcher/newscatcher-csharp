namespace NewscatcherApi;

public partial interface ISearchByLinkClient
{
    /// <summary>
    /// Searches for articles based on specified links or IDs. You can filter results by date range.
    /// </summary>
    WithRawResponseTask<SearchResponseDto> GetAsync(
        GetSearchByLinkRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for articles using their ID(s) or link(s).
    /// </summary>
    WithRawResponseTask<SearchResponseDto> PostAsync(
        PostSearchByLinkRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
