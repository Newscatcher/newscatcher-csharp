namespace NewscatcherApi;

public partial interface INewscatcherApiClient
{
    public ISearchClient Search { get; }
    public ILatestHeadlinesClient LatestHeadlines { get; }
    public IBreakingNewsClient BreakingNews { get; }
    public IAuthorsClient Authors { get; }
    public ISearchByLinkClient SearchByLink { get; }
    public ISourcesClient Sources { get; }
    public IAggregationClient Aggregation { get; }
    public ISubscriptionClient Subscription { get; }
}
