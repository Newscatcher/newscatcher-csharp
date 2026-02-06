namespace NewscatcherApi;

public partial interface INewscatcherApiClient
{
    public ISearchClient Search { get; }
    public ILatestheadlinesClient Latestheadlines { get; }
    public IBreakingNewsClient BreakingNews { get; }
    public IAuthorsClient Authors { get; }
    public ISearchLinkClient SearchLink { get; }
    public ISearchsimilarClient Searchsimilar { get; }
    public ISourcesClient Sources { get; }
    public IAggregationClient Aggregation { get; }
    public ISubscriptionClient Subscription { get; }
}
