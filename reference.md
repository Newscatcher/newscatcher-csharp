# Reference
## Search
<details><summary><code>client.Search.<a href="/src/NewscatcherApi/Search/SearchClient.cs">GetAsync</a>(SearchGetRequest { ... }) -> WithRawResponseTask&lt;OneOf&lt;SearchResponseDto, ClusteredSearchResponseDto&gt;&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles based on specified criteria such as keywords, language, country, source, and more.
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
        PredefinedSources = "top 50 US, top 20 GB",
        SourceName = "sport,tech",
        Sources = "nytimes.com,finance.yahoo.com",
        NotSources = "cnn.com,wsj.com",
        Lang = "en,es",
        NotLang = "fr,de",
        Countries = "US,CA",
        NotCountries = "UK,FR",
        NotAuthorName = "John Doe, Jane Doe",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 01, 01, 00, 00, 00, 000),
        PublishedDatePrecision = "full",
        ByParseDate = true,
        RankedOnly = true,
        FromRank = 100,
        ToRank = 100,
        IsHeadline = true,
        IsOpinion = true,
        IsPaidContent = false,
        ParentUrl = "wsj.com/politics,wsj.com/tech",
        AllLinks = "https://aiindex.stanford.edu/report,https://www.stateof.ai",
        AllDomainLinks = "who.int,nih.gov",
        AllLinksText = "Nvidia,Tesla",
        AdditionalDomainInfo = true,
        IsNewsDomain = true,
        NewsType = "General News Outlets,Tech News and Updates",
        WordCountMin = 300,
        WordCountMax = 1000,
        Page = 2,
        PageSize = 50,
        ClusteringEnabled = true,
        ClusteringThreshold = 0.6f,
        IncludeNlpData = true,
        HasNlp = true,
        Theme = "Finance,Tech",
        NotTheme = "Crime,Sports",
        OrgEntityName = "\"Apple Inc\" OR Microsoft",
        PerEntityName = "\"Elon Musk\" OR \"Jeff Bezos\"",
        LocEntityName = "\"San Francisco\" OR \"New York City\"",
        MiscEntityName = "AWS OR \"Microsoft Azure\"",
        TitleSentimentMin = -0.5f,
        TitleSentimentMax = 0.5f,
        ContentSentimentMin = -0.5f,
        ContentSentimentMax = 0.5f,
        IptcTags = "20000199,20000209",
        NotIptcTags = "20000205,20000209",
        IabTags = "Business,Events",
        NotIabTags = "Agriculture,Metals",
        CustomTags = "Tag1,Tag2",
        ExcludeDuplicates = true,
        RobotsCompliant = true,
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

<details><summary><code>client.Search.<a href="/src/NewscatcherApi/Search/SearchClient.cs">PostAsync</a>(SearchPostRequest { ... }) -> WithRawResponseTask&lt;OneOf&lt;SearchResponseDto, ClusteredSearchResponseDto&gt;&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for articles based on specified criteria such as keywords, language, country, source, and more.
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
<details><summary><code>client.LatestHeadlines.<a href="/src/NewscatcherApi/LatestHeadlines/LatestHeadlinesClient.cs">LatestHeadlinesGetAsync</a>(LatestHeadlinesGetRequest { ... }) -> WithRawResponseTask&lt;OneOf&lt;SearchResponseDto, ClusteredSearchResponseDto&gt;&gt;</code></summary>
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
await client.LatestHeadlines.LatestHeadlinesGetAsync(
    new LatestHeadlinesGetRequest
    {
        When = "7d",
        ByParseDate = true,
        Lang = "en,es",
        NotLang = "fr,de",
        Countries = "US,CA",
        NotCountries = "UK,FR",
        PredefinedSources = "top 50 US, top 20 GB",
        Sources = "nytimes.com,finance.yahoo.com",
        NotSources = "cnn.com,wsj.com",
        NotAuthorName = "John Doe, Jane Doe",
        RankedOnly = true,
        IsHeadline = true,
        IsOpinion = true,
        IsPaidContent = false,
        ParentUrl = "wsj.com/politics,wsj.com/tech",
        AllLinks = "https://aiindex.stanford.edu/report,https://www.stateof.ai",
        AllDomainLinks = "who.int,nih.gov",
        AllLinksText = "Nvidia,Tesla",
        WordCountMin = 300,
        WordCountMax = 1000,
        Page = 2,
        PageSize = 50,
        ClusteringEnabled = true,
        ClusteringThreshold = 0.6f,
        IncludeTranslationFields = true,
        IncludeNlpData = true,
        HasNlp = true,
        Theme = "Finance,Tech",
        NotTheme = "Crime,Sports",
        OrgEntityName = "\"Apple Inc\" OR Microsoft",
        PerEntityName = "\"Elon Musk\" OR \"Jeff Bezos\"",
        LocEntityName = "\"San Francisco\" OR \"New York City\"",
        MiscEntityName = "AWS OR \"Microsoft Azure\"",
        TitleSentimentMin = -0.5f,
        TitleSentimentMax = 0.5f,
        ContentSentimentMin = -0.5f,
        ContentSentimentMax = 0.5f,
        IptcTags = "20000199,20000209",
        NotIptcTags = "20000205,20000209",
        IabTags = "Business,Events",
        NotIabTags = "Agriculture,Metals",
        CustomTags = "Tag1,Tag2",
        RobotsCompliant = true,
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

<details><summary><code>client.LatestHeadlines.<a href="/src/NewscatcherApi/LatestHeadlines/LatestHeadlinesClient.cs">LatestHeadlinesPostAsync</a>(LatestHeadlinesPostRequest { ... }) -> WithRawResponseTask&lt;OneOf&lt;SearchResponseDto, ClusteredSearchResponseDto&gt;&gt;</code></summary>
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
await client.LatestHeadlines.LatestHeadlinesPostAsync(
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

## BreakingNews
<details><summary><code>client.BreakingNews.<a href="/src/NewscatcherApi/BreakingNews/BreakingNewsClient.cs">BreakingNewsGetAsync</a>(BreakingNewsGetRequest { ... }) -> WithRawResponseTask&lt;BreakingNewsResponseDto&gt;</code></summary>
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
        RankedOnly = true,
        FromRank = 100,
        ToRank = 100,
        Page = 2,
        PageSize = 50,
        TopNArticles = 5,
        IncludeTranslationFields = true,
        IncludeNlpData = true,
        HasNlp = true,
        Theme = "Finance,Tech",
        NotTheme = "Crime,Sports",
        OrgEntityName = "\"Apple Inc\" OR Microsoft",
        PerEntityName = "\"Elon Musk\" OR \"Jeff Bezos\"",
        LocEntityName = "\"San Francisco\" OR \"New York City\"",
        MiscEntityName = "AWS OR \"Microsoft Azure\"",
        TitleSentimentMin = -0.5f,
        TitleSentimentMax = 0.5f,
        ContentSentimentMin = -0.5f,
        ContentSentimentMax = 0.5f,
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

<details><summary><code>client.BreakingNews.<a href="/src/NewscatcherApi/BreakingNews/BreakingNewsClient.cs">BreakingNewsPostAsync</a>(BreakingNewsPostRequest { ... }) -> WithRawResponseTask&lt;BreakingNewsResponseDto&gt;</code></summary>
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
<details><summary><code>client.Authors.<a href="/src/NewscatcherApi/Authors/AuthorsClient.cs">GetAsync</a>(AuthorsGetRequest { ... }) -> WithRawResponseTask&lt;OneOf&lt;SearchResponseDto, FailedAuthorsResponseDto&gt;&gt;</code></summary>
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
        NotAuthorName = "John Doe, Jane Doe",
        PredefinedSources = "top 50 US, top 20 GB",
        Sources = "nytimes.com,finance.yahoo.com",
        NotSources = "cnn.com,wsj.com",
        Lang = "en,es",
        NotLang = "fr,de",
        Countries = "US,CA",
        NotCountries = "UK,FR",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 01, 01, 00, 00, 00, 000),
        PublishedDatePrecision = "full",
        ByParseDate = true,
        RankedOnly = true,
        FromRank = 100,
        ToRank = 100,
        IsHeadline = true,
        IsOpinion = true,
        IsPaidContent = false,
        ParentUrl = "wsj.com/politics,wsj.com/tech",
        AllLinks = "https://aiindex.stanford.edu/report,https://www.stateof.ai",
        AllDomainLinks = "who.int,nih.gov",
        AllLinksText = "Nvidia,Tesla",
        WordCountMin = 300,
        WordCountMax = 1000,
        Page = 2,
        PageSize = 50,
        IncludeTranslationFields = true,
        IncludeNlpData = true,
        HasNlp = true,
        Theme = "Finance,Tech",
        NotTheme = "Crime,Sports",
        NerName = "Tesla,Amazon",
        TitleSentimentMin = -0.5f,
        TitleSentimentMax = 0.5f,
        ContentSentimentMin = -0.5f,
        ContentSentimentMax = 0.5f,
        IptcTags = "20000199,20000209",
        NotIptcTags = "20000205,20000209",
        IabTags = "Business,Events",
        NotIabTags = "Agriculture,Metals",
        CustomTags = "Tag1,Tag2",
        RobotsCompliant = true,
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

<details><summary><code>client.Authors.<a href="/src/NewscatcherApi/Authors/AuthorsClient.cs">PostAsync</a>(AuthorsPostRequest { ... }) -> WithRawResponseTask&lt;OneOf&lt;SearchResponseDto, FailedAuthorsResponseDto&gt;&gt;</code></summary>
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

## SearchByLink
<details><summary><code>client.SearchByLink.<a href="/src/NewscatcherApi/SearchByLink/SearchByLinkClient.cs">SearchByLinkGetAsync</a>(SearchByLinkGetRequest { ... }) -> WithRawResponseTask&lt;SearchResponseDto&gt;</code></summary>
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
await client.SearchByLink.SearchByLinkGetAsync(
    new SearchByLinkGetRequest
    {
        Ids = "5f8d0d55b6e45e00179c6e7e",
        Links = "https://nytimes.com/article1,https://bbc.com/article2",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 01, 01, 00, 00, 00, 000),
        Page = 2,
        PageSize = 50,
        RobotsCompliant = true,
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

**request:** `SearchByLinkGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SearchByLink.<a href="/src/NewscatcherApi/SearchByLink/SearchByLinkClient.cs">SearchByLinkPostAsync</a>(SearchByLinkPostRequest { ... }) -> WithRawResponseTask&lt;SearchResponseDto&gt;</code></summary>
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
await client.SearchByLink.SearchByLinkPostAsync(
    new SearchByLinkPostRequest
    {
        Links =
            "https://www.reuters.com/business/energy/oil-prices-up-after-israeli-attacks-oversupply-caps-gains-2025-09-10/",
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

**request:** `SearchByLinkPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Sources
<details><summary><code>client.Sources.<a href="/src/NewscatcherApi/Sources/SourcesClient.cs">GetAsync</a>(SourcesGetRequest { ... }) -> WithRawResponseTask&lt;SourcesResponseDto&gt;</code></summary>
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
        Lang = "en,es",
        Countries = "US,CA",
        PredefinedSources = "top 50 US, top 20 GB",
        SourceName = "sport,tech",
        SourceUrl = "bbc.com",
        IncludeAdditionalInfo = true,
        IsNewsDomain = true,
        NewsType = "General News Outlets,Tech News and Updates",
        FromRank = 100,
        ToRank = 100,
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

<details><summary><code>client.Sources.<a href="/src/NewscatcherApi/Sources/SourcesClient.cs">PostAsync</a>(SourcesPostRequest { ... }) -> WithRawResponseTask&lt;SourcesResponseDto&gt;</code></summary>
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
<details><summary><code>client.Aggregation.<a href="/src/NewscatcherApi/Aggregation/AggregationClient.cs">CountGetAsync</a>(AggregationCountGetRequest { ... }) -> WithRawResponseTask&lt;OneOf&lt;AggregationCountResponseDto, FailedAggregationCountResponseDto&gt;&gt;</code></summary>
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
await client.Aggregation.CountGetAsync(
    new AggregationCountGetRequest
    {
        Q = "\"supply chain\" AND Amazon NOT China",
        SearchIn = "title_content, title_content_translated",
        PredefinedSources = "top 50 US, top 20 GB",
        Sources = "nytimes.com,finance.yahoo.com",
        NotSources = "cnn.com,wsj.com",
        Lang = "en,es",
        NotLang = "fr,de",
        Countries = "US,CA",
        NotCountries = "UK,FR",
        NotAuthorName = "John Doe, Jane Doe",
        From = new DateTime(2024, 07, 01, 00, 00, 00, 000),
        To = new DateTime(2024, 01, 01, 00, 00, 00, 000),
        PublishedDatePrecision = "full",
        ByParseDate = true,
        RankedOnly = true,
        FromRank = 100,
        ToRank = 100,
        IsHeadline = true,
        IsOpinion = true,
        IsPaidContent = false,
        ParentUrl = "wsj.com/politics,wsj.com/tech",
        AllLinks = "https://aiindex.stanford.edu/report,https://www.stateof.ai",
        AllDomainLinks = "who.int,nih.gov",
        AllLinksText = "Nvidia,Tesla",
        WordCountMin = 300,
        WordCountMax = 1000,
        Page = 2,
        PageSize = 50,
        IncludeNlpData = true,
        HasNlp = true,
        Theme = "Finance,Tech",
        NotTheme = "Crime,Sports",
        OrgEntityName = "\"Apple Inc\" OR Microsoft",
        PerEntityName = "\"Elon Musk\" OR \"Jeff Bezos\"",
        LocEntityName = "\"San Francisco\" OR \"New York City\"",
        MiscEntityName = "AWS OR \"Microsoft Azure\"",
        TitleSentimentMin = -0.5f,
        TitleSentimentMax = 0.5f,
        ContentSentimentMin = -0.5f,
        ContentSentimentMax = 0.5f,
        IptcTags = "20000199,20000209",
        NotIptcTags = "20000205,20000209",
        RobotsCompliant = true,
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

**request:** `AggregationCountGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Aggregation.<a href="/src/NewscatcherApi/Aggregation/AggregationClient.cs">CountPostAsync</a>(AggregationCountPostRequest { ... }) -> WithRawResponseTask&lt;OneOf&lt;AggregationCountResponseDto, FailedAggregationCountResponseDto&gt;&gt;</code></summary>
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
await client.Aggregation.CountPostAsync(
    new AggregationCountPostRequest
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

**request:** `AggregationCountPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Subscription
<details><summary><code>client.Subscription.<a href="/src/NewscatcherApi/Subscription/SubscriptionClient.cs">GetAsync</a>() -> WithRawResponseTask&lt;SubscriptionResponseDto&gt;</code></summary>
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

<details><summary><code>client.Subscription.<a href="/src/NewscatcherApi/Subscription/SubscriptionClient.cs">PostAsync</a>() -> WithRawResponseTask&lt;SubscriptionResponseDto&gt;</code></summary>
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

