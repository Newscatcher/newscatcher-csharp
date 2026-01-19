namespace NewscatcherApi;

public partial interface INewscatcherApiClient
{
    public SearchClient Search { get; }
    public LatestheadlinesClient Latestheadlines { get; }
    public BreakingNewsClient BreakingNews { get; }
    public AuthorsClient Authors { get; }
    public SearchLinkClient SearchLink { get; }
    public SearchsimilarClient Searchsimilar { get; }
    public SourcesClient Sources { get; }
    public AggregationClient Aggregation { get; }
    public SubscriptionClient Subscription { get; }
}
