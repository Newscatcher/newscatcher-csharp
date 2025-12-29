using NewscatcherApi.Core;

namespace NewscatcherApi;

public partial class NewscatcherApiClient
{
    private readonly RawClient _client;

    public NewscatcherApiClient(string? apiKey = null, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "x-api-token", apiKey ?? "" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "NewscatcherApi" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Newscatcher.Client/AUTO" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
        Search = new SearchClient(_client);
        Latestheadlines = new LatestheadlinesClient(_client);
        BreakingNews = new BreakingNewsClient(_client);
        Authors = new AuthorsClient(_client);
        SearchLink = new SearchLinkClient(_client);
        Searchsimilar = new SearchsimilarClient(_client);
        Sources = new SourcesClient(_client);
        Aggregation = new AggregationClient(_client);
        Subscription = new SubscriptionClient(_client);
    }

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
