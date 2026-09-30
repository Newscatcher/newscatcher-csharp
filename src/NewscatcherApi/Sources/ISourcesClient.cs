namespace NewscatcherApi;

public partial interface ISourcesClient
{
    /// <summary>
    /// Retrieves a list of sources based on specified criteria such as language, country, rank, and more.
    /// </summary>
    WithRawResponseTask<SourcesResponseDto> GetAsync(
        GetSourcesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the list of sources available in the database. You can filter the sources by language, country, and more.
    /// </summary>
    WithRawResponseTask<SourcesResponseDto> PostAsync(
        PostSourcesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
