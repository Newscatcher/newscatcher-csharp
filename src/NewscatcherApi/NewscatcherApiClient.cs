using NewscatcherApi.Core;

namespace NewscatcherApi;

public partial class NewscatcherApiClient : INewscatcherApiClient
{
    private readonly RawClient _client;

    public NewscatcherApiClient(string? apiKey = null, ClientOptions? clientOptions = null)
    {
        clientOptions ??= new ClientOptions();
        var platformHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "NewscatcherApi" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Newscatcher.Client/2.0.0" },
            }
        );
        foreach (var header in platformHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var clientOptionsWithAuth = clientOptions.Clone();
        var authHeaders = new Headers(
            new Dictionary<string, string>() { { "x-api-token", apiKey ?? "" } }
        );
        foreach (var header in authHeaders)
        {
            clientOptionsWithAuth.Headers[header.Key] = header.Value;
        }
        _client = new RawClient(clientOptionsWithAuth);
        Search = new SearchClient(_client);
        LatestHeadlines = new LatestHeadlinesClient(_client);
        BreakingNews = new BreakingNewsClient(_client);
        Authors = new AuthorsClient(_client);
        SearchByLink = new SearchByLinkClient(_client);
        Sources = new SourcesClient(_client);
        AggregationCount = new AggregationCountClient(_client);
        Subscription = new SubscriptionClient(_client);
    }

    public ISearchClient Search { get; }

    public ILatestHeadlinesClient LatestHeadlines { get; }

    public IBreakingNewsClient BreakingNews { get; }

    public IAuthorsClient Authors { get; }

    public ISearchByLinkClient SearchByLink { get; }

    public ISourcesClient Sources { get; }

    public IAggregationCountClient AggregationCount { get; }

    public ISubscriptionClient Subscription { get; }
}
