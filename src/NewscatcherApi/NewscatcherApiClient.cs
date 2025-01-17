using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public partial class NewscatcherApiClient
{
    private RawClient _client;

    public NewscatcherApiClient(string? apiKey = null, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "x-api-token", apiKey },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "NewscatcherApi" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Newscatcher.Client/1.1.0" },
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
        Authors = new AuthorsClient(_client);
        SearchLink = new SearchLinkClient(_client);
        Searchsimilar = new SearchsimilarClient(_client);
        Sources = new SourcesClient(_client);
        Aggregation = new AggregationClient(_client);
        Subscription = new SubscriptionClient(_client);
    }

    public SearchClient Search { get; init; }

    public LatestheadlinesClient Latestheadlines { get; init; }

    public AuthorsClient Authors { get; init; }

    public SearchLinkClient SearchLink { get; init; }

    public SearchsimilarClient Searchsimilar { get; init; }

    public SourcesClient Sources { get; init; }

    public AggregationClient Aggregation { get; init; }

    public SubscriptionClient Subscription { get; init; }
}
