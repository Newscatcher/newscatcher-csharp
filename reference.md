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
        Q = "\"supply chain\" AND Amazon NOT China",
        SearchIn = "title_content, title_content_translated",
        IncludeTranslationFields = true,
        PredefinedSources = "top 100 US, top 5 GB",
        SourceName = "sport",
        Sources = "nytimes.com",
        NotSources = "cnn.com",
        Lang = "en",
        NotLang = "fr",
        Countries = "US",
        NotCountries = "UK",
        NotAuthorName = "John Doe",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        ParentUrl = "https://www.washingtonpost.com/politics",
        AllLinks = "https://aiindex.stanford.edu/report",
        AllDomainLinks = "nvidia.com",
        NewsType = "General News Outlets",
        IncludeNlpData = true,
        HasNlp = true,
        Theme = "Business,Finance",
        NotTheme = "Crime",
        OrgEntityName = "Apple",
        PerEntityName = "Elon Musk",
        LocEntityName = "California",
        MiscEntityName = "Bitcoin",
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
    new SearchPostRequest { Q = "\"supply chain\" AND Amazon NOT China", PageSize = 1 }
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
        When = "7d",
        Lang = "en",
        NotLang = "fr",
        Countries = "US",
        NotCountries = "UK",
        PredefinedSources = "top 100 US, top 5 GB",
        Sources = "nytimes.com",
        NotSources = "cnn.com",
        NotAuthorName = "John Doe",
        ParentUrl = "https://www.washingtonpost.com/politics",
        AllLinks = "https://aiindex.stanford.edu/report",
        AllDomainLinks = "nvidia.com",
        IncludeTranslationFields = true,
        IncludeNlpData = true,
        HasNlp = true,
        Theme = "Business,Finance",
        NotTheme = "Crime",
        OrgEntityName = "Apple",
        PerEntityName = "Elon Musk",
        LocEntityName = "California",
        MiscEntityName = "Bitcoin",
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
    new LatestHeadlinesPostRequest { When = "7d", PageSize = 1 }
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

## Breaking News
<details><summary><code>client.BreakingNews.<a href="/src/NewscatcherApi/BreakingNews/BreakingNewsClient.cs">BreakingNewsGetAsync</a>(BreakingNewsGetRequest { ... }) -> BreakingNewsResponseDto</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves breaking news articles and sorts them based on specified criteria.
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
await client.BreakingNews.BreakingNewsGetAsync(
    new BreakingNewsGetRequest
    {
        TopNArticles = 5,
        IncludeTranslationFields = true,
        IncludeNlpData = true,
        HasNlp = true,
        Theme = "Business,Finance",
        NotTheme = "Crime",
        OrgEntityName = "Apple",
        PerEntityName = "Elon Musk",
        LocEntityName = "California",
        MiscEntityName = "Bitcoin",
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

**request:** `BreakingNewsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BreakingNews.<a href="/src/NewscatcherApi/BreakingNews/BreakingNewsClient.cs">BreakingNewsPostAsync</a>(BreakingNewsPostRequest { ... }) -> BreakingNewsResponseDto</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves breaking news articles and sorts them based on specified criteria.
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
await client.BreakingNews.BreakingNewsPostAsync(
    new BreakingNewsPostRequest
    {
        SortBy = SortBy.Relevancy,
        RankedOnly = true,
        TopNArticles = 1,
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

**request:** `BreakingNewsPostRequest` 
    
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
        NotAuthorName = "John Doe",
        PredefinedSources = "top 100 US, top 5 GB",
        Sources = "nytimes.com",
        NotSources = "cnn.com",
        Lang = "en",
        NotLang = "fr",
        Countries = "US",
        NotCountries = "UK",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        ParentUrl = "https://www.washingtonpost.com/politics",
        AllLinks = "https://aiindex.stanford.edu/report",
        AllDomainLinks = "nvidia.com",
        IncludeTranslationFields = true,
        IncludeNlpData = true,
        HasNlp = true,
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
await client.Authors.PostAsync(new AuthorsPostRequest { AuthorName = "David Muir" });
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
        Ids = "5f8d0d55b6e45e00179c6e7e",
        Links = "https://nytimes.com/article1",
        Source = "articles.id,articles.title,articles.link,articles.published_date",
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
        Links =
            "https://www.reuters.com/business/energy/oil-prices-up-after-israeli-attacks-oversupply-caps-gains-2025-09-10/",
        Source = "articles.id,articles.title,articles.link,articles.canonical_url",
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
        Q = "\"supply chain\" AND Amazon NOT China",
        SearchIn = "title_content, title_content_translated",
        IncludeTranslationFields = true,
        SimilarDocumentsFields = "title,summary",
        PredefinedSources = "top 100 US, top 5 GB",
        Sources = "nytimes.com",
        NotSources = "cnn.com",
        Lang = "en",
        NotLang = "fr",
        Countries = "US",
        NotCountries = "UK",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        ParentUrl = "https://www.washingtonpost.com/politics",
        AllLinks = "https://aiindex.stanford.edu/report",
        AllDomainLinks = "nvidia.com",
        IncludeNlpData = true,
        HasNlp = true,
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
        Q = "\"supply chain\" AND Amazon NOT China",
        IncludeSimilarDocuments = true,
        SimilarDocumentsNumber = 5,
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
    new SourcesGetRequest
    {
        Lang = "en",
        Countries = "US",
        PredefinedSources = "top 100 US, top 5 GB",
        SourceName = "sport",
        SourceUrl = "bbc.com",
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
await client.Sources.PostAsync(new SourcesPostRequest { PredefinedSources = "top 10 US" });
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
        Q = "\"supply chain\" AND Amazon NOT China",
        SearchIn = "title_content, title_content_translated",
        PredefinedSources = "top 100 US, top 5 GB",
        Sources = "nytimes.com",
        NotSources = "cnn.com",
        Lang = "en",
        NotLang = "fr",
        Countries = "US",
        NotCountries = "UK",
        NotAuthorName = "John Doe",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        ParentUrl = "https://www.washingtonpost.com/politics",
        AllLinks = "https://aiindex.stanford.edu/report",
        AllDomainLinks = "nvidia.com",
        IncludeNlpData = true,
        HasNlp = true,
        Theme = "Business,Finance",
        NotTheme = "Crime",
        OrgEntityName = "Apple",
        PerEntityName = "Elon Musk",
        LocEntityName = "California",
        MiscEntityName = "Bitcoin",
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
        Q = "\"supply chain\" AND Amazon NOT China",
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
