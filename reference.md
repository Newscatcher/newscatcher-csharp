# Reference
## Search
<details><summary><code>client.Search.<a href="/src/NewscatcherApi/Search/SearchClient.cs">GetAsync</a>(SearchGetRequest { ... }) -> OneOf<SearchResponse, ClusteringSearchResponse></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
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
        Q = "q",
        PredefinedSources = "predefined_sources",
        Sources = "sources",
        NotSources = "not_sources",
        Lang = "lang",
        NotLang = "not_lang",
        Countries = "countries",
        NotCountries = "not_countries",
        NotAuthorName = "not_author_name",
        ParentUrl = "parent_url",
        AllLinks = "all_links",
        AllDomainLinks = "all_domain_links",
        IptcTags = "iptc_tags",
        NotIptcTags = "not_iptc_tags",
        SourceName = "source_name",
        IabTags = "iab_tags",
        NotIabTags = "not_iab_tags",
        NewsDomainType = "news_domain_type",
        NewsType = "news_type",
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

<details><summary><code>client.Search.<a href="/src/NewscatcherApi/Search/SearchClient.cs">PostAsync</a>(SearchRequest { ... }) -> OneOf<SearchResponse, ClusteringSearchResponse></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
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
await client.Search.PostAsync(new SearchRequest { Q = "q" });
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

**request:** `SearchRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Latestheadlines
<details><summary><code>client.Latestheadlines.<a href="/src/NewscatcherApi/Latestheadlines/LatestheadlinesClient.cs">GetAsync</a>(LatestHeadlinesGetRequest { ... }) -> OneOf<ClusteringSearchResponse, LatestHeadlinesResponse></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.
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
        Lang = "lang",
        NotLang = "not_lang",
        Countries = "countries",
        NotCountries = "not_countries",
        Sources = "sources",
        PredefinedSources = "predefined_sources",
        NotSources = "not_sources",
        NotAuthorName = "not_author_name",
        ParentUrl = "parent_url",
        AllLinks = "all_links",
        AllDomainLinks = "all_domain_links",
        IptcTags = "iptc_tags",
        NotIptcTags = "not_iptc_tags",
        IabTags = "iab_tags",
        NotIabTags = "not_iab_tags",
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

<details><summary><code>client.Latestheadlines.<a href="/src/NewscatcherApi/Latestheadlines/LatestheadlinesClient.cs">PostAsync</a>(LatestHeadlinesRequest { ... }) -> OneOf<ClusteringSearchResponse, LatestHeadlinesResponse></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.
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
await client.Latestheadlines.PostAsync(new LatestHeadlinesRequest());
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

**request:** `LatestHeadlinesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Authors
<details><summary><code>client.Authors.<a href="/src/NewscatcherApi/Authors/AuthorsClient.cs">GetAsync</a>(AuthorsGetRequest { ... }) -> OneOf<SearchResponse, FailedSearchResponse></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to search for articles by author. You need to specify the author name. You can also filter by language, country, source, and more.
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
        AuthorName = "author_name",
        Sources = "sources",
        PredefinedSources = "predefined_sources",
        NotSources = "not_sources",
        Lang = "lang",
        NotLang = "not_lang",
        Countries = "countries",
        NotCountries = "not_countries",
        ParentUrl = "parent_url",
        AllLinks = "all_links",
        AllDomainLinks = "all_domain_links",
        IptcTags = "iptc_tags",
        NotIptcTags = "not_iptc_tags",
        IabTags = "iab_tags",
        NotIabTags = "not_iab_tags",
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

<details><summary><code>client.Authors.<a href="/src/NewscatcherApi/Authors/AuthorsClient.cs">PostAsync</a>(AuthorSearchRequest { ... }) -> OneOf<SearchResponse, FailedSearchResponse></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to search for articles by author. You need to specify the author name. You can also filter by language, country, source, and more.
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
await client.Authors.PostAsync(new AuthorSearchRequest { AuthorName = "author_name" });
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

**request:** `AuthorSearchRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SearchLink
<details><summary><code>client.SearchLink.<a href="/src/NewscatcherApi/SearchLink/SearchLinkClient.cs">SearchUrlGetAsync</a>(SearchUrlGetRequest { ... }) -> SearchResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to search for articles. You can search for articles by id(s) or link(s).
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
await client.SearchLink.SearchUrlGetAsync(new SearchUrlGetRequest { Ids = "ids", Links = "links" });
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

<details><summary><code>client.SearchLink.<a href="/src/NewscatcherApi/SearchLink/SearchLinkClient.cs">SearchUrlPostAsync</a>(SearchUrlRequest { ... }) -> SearchResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to search for articles. You can search for articles by id(s) or link(s).
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
await client.SearchLink.SearchUrlPostAsync(new SearchUrlRequest());
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

**request:** `SearchUrlRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Searchsimilar
<details><summary><code>client.Searchsimilar.<a href="/src/NewscatcherApi/Searchsimilar/SearchsimilarClient.cs">GetAsync</a>(SearchSimilarGetRequest { ... }) -> OneOf<SearchResponse, FailedSearchResponse></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
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
        Q = "q",
        PredefinedSources = "predefined_sources",
        Sources = "sources",
        NotSources = "not_sources",
        Lang = "lang",
        NotLang = "not_lang",
        Countries = "countries",
        NotCountries = "not_countries",
        ParentUrl = "parent_url",
        AllLinks = "all_links",
        AllDomainLinks = "all_domain_links",
        IptcTags = "iptc_tags",
        NotIptcTags = "not_iptc_tags",
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

<details><summary><code>client.Searchsimilar.<a href="/src/NewscatcherApi/Searchsimilar/SearchsimilarClient.cs">PostAsync</a>(MoreLikeThisRequest { ... }) -> OneOf<SearchResponse, FailedSearchResponse></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
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
await client.Searchsimilar.PostAsync(new MoreLikeThisRequest { Q = "q" });
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

**request:** `MoreLikeThisRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Sources
<details><summary><code>client.Sources.<a href="/src/NewscatcherApi/Sources/SourcesClient.cs">GetAsync</a>(SourcesGetRequest { ... }) -> SourceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
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
        Lang = "lang",
        Countries = "countries",
        PredefinedSources = "predefined_sources",
        SourceName = "source_name",
        SourceUrl = "source_url",
        NewsDomainType = "news_domain_type",
        NewsType = "news_type",
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

<details><summary><code>client.Sources.<a href="/src/NewscatcherApi/Sources/SourcesClient.cs">PostAsync</a>(SourcesRequest { ... }) -> SourceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
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
await client.Sources.PostAsync(new SourcesRequest());
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

**request:** `SourcesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Subscription
<details><summary><code>client.Subscription.<a href="/src/NewscatcherApi/Subscription/SubscriptionClient.cs">GetAsync</a>() -> SubscriptionResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to get info about your subscription plan.
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

<details><summary><code>client.Subscription.<a href="/src/NewscatcherApi/Subscription/SubscriptionClient.cs">PostAsync</a>() -> SubscriptionResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint allows you to get info about your subscription plan.
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
