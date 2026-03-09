namespace NewscatcherApi;

public partial interface ISearchLinkClient
{
    /// <summary>
    /// Searches for articles based on specified links or IDs. You can filter results by date range.
    /// </summary>
    WithRawResponseTask<SearchResponseDto> SearchUrlGetAsync(
        SearchUrlGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for articles using their ID(s) or link(s).
    /// </summary>
    WithRawResponseTask<SearchResponseDto> SearchUrlPostAsync(
        SearchUrlPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
