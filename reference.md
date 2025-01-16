# Reference
## Search
<details><summary><code>client.Search.<a href="/src/NewscatcherApi/Search/SearchClient.cs">GetAsync</a>(SearchGetRequest { ... }) -> OneOf<SearchResponseDto, ClusteredSearchResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles based on specified criteria such as keyword, language, country, source, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Search.GetAsync(
    new SearchGetRequest
    {
        Q = "technology AND (Apple OR Microsoft) NOT Google",
        PredefinedSources = "top 100 US, top 5 GB",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        Theme = "Business,Finance",
        NotTheme = "Crime",
        IptcTags = "20000199,20000209",
        NotIptcTags = "20000205,20000209",
        IabTags = "Business,Events",
        NotIabTags = "Agriculture,Metals",
        CustomTags = "Tag1,Tag2,Tag3",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SearchGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Search.<a href="/src/NewscatcherApi/Search/SearchClient.cs">PostAsync</a>(SearchPostRequest { ... }) -> OneOf<SearchResponseDto, ClusteredSearchResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles based on specified criteria such as keyword, language, country, source, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Search.PostAsync(
    new SearchPostRequest
    {
        Q = "renewable energy",
        PredefinedSources = new List<string>() { "top 50 US" },
        Lang = new List<string>() { "en" },
        From = new DateTime(2024, 01, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 06, 30, 00, 00, 00, 000),
        AdditionalDomainInfo = true,
        IsNewsDomain = true,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SearchPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## LatestHeadlines
<details><summary><code>client.Latestheadlines.<a href="/src/NewscatcherApi/Latestheadlines/LatestheadlinesClient.cs">GetAsync</a>(LatestHeadlinesGetRequest { ... }) -> OneOf<SearchResponseDto, ClusteredSearchResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Latestheadlines.GetAsync(
    new LatestHeadlinesGetRequest
    {
        PredefinedSources = "top 100 US, top 5 GB",
        Theme = "Business,Finance",
        NotTheme = "Crime",
        IptcTags = "20000199,20000209",
        NotIptcTags = "20000205,20000209",
        IabTags = "Business,Events",
        NotIabTags = "Agriculture,Metals",
        CustomTags = "Tag1,Tag2,Tag3",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LatestHeadlinesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Latestheadlines.<a href="/src/NewscatcherApi/Latestheadlines/LatestheadlinesClient.cs">PostAsync</a>(LatestHeadlinesPostRequest { ... }) -> OneOf<SearchResponseDto, ClusteredSearchResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves the latest headlines for the specified time period. You can filter results by language, country, source, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Latestheadlines.PostAsync(
    new LatestHeadlinesPostRequest
    {
        Lang = "en",
        PredefinedSources = new List<string>() { "top 50 US", "top 20 GB" },
        IsOpinion = false,
        PageSize = 10,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LatestHeadlinesPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Authors
<details><summary><code>client.Authors.<a href="/src/NewscatcherApi/Authors/AuthorsClient.cs">GetAsync</a>(AuthorsGetRequest { ... }) -> OneOf<SearchResponseDto, FailedAuthorsResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles written by a specified author. You can filter results by language, country, source, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Authors.GetAsync(
    new AuthorsGetRequest
    {
        AuthorName = "Jane Smith",
        PredefinedSources = "top 100 US, top 5 GB",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        Theme = "Business,Finance",
        NotTheme = "Crime",
        NerName = "Tesla",
        IptcTags = "20000199,20000209",
        NotIptcTags = "20000205,20000209",
        IabTags = "Business,Events",
        NotIabTags = "Agriculture,Metals",
        CustomTags = "Tag1,Tag2,Tag3",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuthorsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Authors.<a href="/src/NewscatcherApi/Authors/AuthorsClient.cs">PostAsync</a>(AuthorsPostRequest { ... }) -> OneOf<SearchResponseDto, FailedAuthorsResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles by author. You can filter results by language, country, source, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Authors.PostAsync(
    new AuthorsPostRequest
    {
        AuthorName = "Joanna Stern",
        Sources = new List<string>() { "wsj.com", "nytimes.com" },
        Lang = "en",
        From = new DateTime(2024, 01, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 06, 30, 00, 00, 00, 000),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuthorsPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SearchLink
<details><summary><code>client.SearchLink.<a href="/src/NewscatcherApi/SearchLink/SearchLinkClient.cs">SearchUrlGetAsync</a>(SearchUrlGetRequest { ... }) -> SearchResponseDto</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles based on specified links or IDs. You can filter results by date range.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SearchLink.SearchUrlGetAsync(
    new SearchUrlGetRequest
    {
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 01, 01, 00, 00, 00, 000),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SearchUrlGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SearchLink.<a href="/src/NewscatcherApi/SearchLink/SearchLinkClient.cs">SearchUrlPostAsync</a>(SearchUrlPostRequest { ... }) -> SearchResponseDto</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles using their ID(s) or link(s).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SearchLink.SearchUrlPostAsync(
    new SearchUrlPostRequest
    {
        Ids = new List<string>()
        {
            "8ea8a784568ffaa05cb6d1ab2d2e84dd",
            "0146a551ef05ab1c494a55e806e3ce64",
        },
        Links = new List<string>()
        {
            "https://www.nytimes.com/2024/08/30/technology/ai-chatbot-chatgpt-manipulation.html",
            "https://www.bbc.com/news/articles/c39k379grzlo",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SearchUrlPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SearchSimilar
<details><summary><code>client.Searchsimilar.<a href="/src/NewscatcherApi/Searchsimilar/SearchsimilarClient.cs">GetAsync</a>(SearchSimilarGetRequest { ... }) -> OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles similar to a specified query.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Searchsimilar.GetAsync(
    new SearchSimilarGetRequest
    {
        Q = "technology AND (Apple OR Microsoft) NOT Google",
        SimilarDocumentsFields = "title,summary",
        PredefinedSources = "top 100 US, top 5 GB",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        Theme = "Business,Finance",
        NotTheme = "Crime",
        NerName = "Tesla",
        IptcTags = "20000199,20000209",
        NotIptcTags = "20000205,20000209",
        CustomTags = "Tag1,Tag2,Tag3",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SearchSimilarGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Searchsimilar.<a href="/src/NewscatcherApi/Searchsimilar/SearchsimilarClient.cs">PostAsync</a>(SearchSimilarPostRequest { ... }) -> OneOf<SearchSimilarResponseDto, FailedSearchSimilarResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles similar to the specified query. You can filter results by language, country, source, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Searchsimilar.PostAsync(
    new SearchSimilarPostRequest
    {
        Q = "artificial intelligence",
        IncludeSimilarDocuments = true,
        SimilarDocumentsNumber = 5,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SearchSimilarPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Sources
<details><summary><code>client.Sources.<a href="/src/NewscatcherApi/Sources/SourcesClient.cs">GetAsync</a>(SourcesGetRequest { ... }) -> SourcesResponseDto</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a list of sources based on specified criteria such as language, country, rank, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sources.GetAsync(
    new SourcesGetRequest { PredefinedSources = "top 100 US, top 5 GB", SourceUrl = "bbc.com" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SourcesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sources.<a href="/src/NewscatcherApi/Sources/SourcesClient.cs">PostAsync</a>(SourcesPostRequest { ... }) -> SourcesResponseDto</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves the list of sources available in the database. You can filter the sources by language, country, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sources.PostAsync(
    new SourcesPostRequest
    {
        PredefinedSources = new List<string>() { "top 50 US" },
        IncludeAdditionalInfo = true,
        IsNewsDomain = true,
        NewsDomainType = NewsDomainType.OriginalContent,
        NewsType = "General News Outlets",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SourcesPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Aggregation
<details><summary><code>client.Aggregation.<a href="/src/NewscatcherApi/Aggregation/AggregationClient.cs">GetAsync</a>(AggregationGetRequest { ... }) -> OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Aggregation.GetAsync(
    new AggregationGetRequest
    {
        Q = "technology AND (Apple OR Microsoft) NOT Google",
        PredefinedSources = "top 100 US, top 5 GB",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        Theme = "Business,Finance",
        NotTheme = "Crime",
        IptcTags = "20000199,20000209",
        NotIptcTags = "20000205,20000209",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AggregationGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Aggregation.<a href="/src/NewscatcherApi/Aggregation/AggregationClient.cs">PostAsync</a>(AggregationPostRequest { ... }) -> OneOf<AggregationCountResponseDto, FailedAggregationCountResponseDto></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves the count of articles aggregated by day or hour based on various search criteria, such as keyword, language, country, and source.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Aggregation.PostAsync(
    new AggregationPostRequest
    {
        Q = "renewable energy",
        PredefinedSources = "top 50 US",
        From = new DateTime(2024, 01, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 06, 30, 00, 00, 00, 000),
        AggregationBy = AggregationBy.Day,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AggregationPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Subscription
<details><summary><code>client.Subscription.<a href="/src/NewscatcherApi/Subscription/SubscriptionClient.cs">GetAsync</a>() -> SubscriptionResponseDto</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves information about your subscription plan.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Subscription.GetAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Subscription.<a href="/src/NewscatcherApi/Subscription/SubscriptionClient.cs">PostAsync</a>() -> SubscriptionResponseDto</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves information about your subscription plan.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Subscription.PostAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
