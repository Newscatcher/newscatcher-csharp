using NUnit.Framework;
using NewscatcherApi.Test.Unit.MockServer;
using NewscatcherApi;
using global::System.Globalization;
using NewscatcherApi.Test.Utils;

namespace NewscatcherApi.Test.Unit.MockServer.Search;

[TestFixture][Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest() {

        const string mockResponse = """
        {
          "status": "status",
          "total_hits": 1,
          "page": 1,
          "total_pages": 1,
          "page_size": 1,
          "articles": [
            {
              "title": "title",
              "author": "author",
              "authors": [
                "authors"
              ],
              "journalists": [
                "journalists"
              ],
              "published_date": "published_date",
              "published_date_precision": "published_date_precision",
              "updated_date": "updated_date",
              "updated_date_precision": "updated_date_precision",
              "parse_date": "parse_date",
              "link": "link",
              "domain_url": "domain_url",
              "full_domain_url": "full_domain_url",
              "name_source": "name_source",
              "is_headline": true,
              "paid_content": true,
              "parent_url": "parent_url",
              "country": "country",
              "rights": "rights",
              "rank": 1,
              "media": "media",
              "language": "language",
              "description": "description",
              "content": "content",
              "title_translated_en": "title_translated_en",
              "content_translated_en": "content_translated_en",
              "word_count": 1,
              "is_opinion": true,
              "twitter_account": "twitter_account",
              "all_links": [
                "all_links"
              ],
              "all_domain_links": [
                "all_domain_links"
              ],
              "all_links_data": [
                {
                  "domain_url": "amazon.de",
                  "link": "https://www.amazon.de/s?k=Künstliche+Intelligenz",
                  "text": "KI Brillen"
                }
              ],
              "id": "id",
              "score": 1.1,
              "robots_compliant": true,
              "custom_tags": {
                "key": [
                  "value"
                ]
              },
              "additional_domain_info": {
                "is_news_domain": true,
                "news_type": "News and Blogs",
                "news_domain_type": "Original Content"
              }
            }
          ],
          "user_input": {
            "key": "value"
          }
        }
        """;

        Server.Given(WireMock.RequestBuilders.Request.Create().WithPath("/api/search").WithParam("q", ""supply chain" AND Amazon NOT China").WithParam("search_in", "title_content, title_content_translated").WithParam("predefined_sources", "top 50 US, top 20 GB").WithParam("source_name", "sport,tech").WithParam("sources", "nytimes.com,finance.yahoo.com").WithParam("not_sources", "cnn.com,wsj.com").WithParam("lang", "en,es").WithParam("not_lang", "fr,de").WithParam("countries", "US,CA").WithParam("not_countries", "UK,FR").WithParam("not_author_name", "John Doe, Jane Doe").WithParam("from_", "2024-07-01T00:00:00Z").WithParam("to_", "2024-01-01T00:00:00Z").WithParam("published_date_precision", "full").WithParam("from_rank", "100").WithParam("to_rank", "100").WithParam("parent_url", "wsj.com/politics,wsj.com/tech").WithParam("all_links", "https://aiindex.stanford.edu/report,https://www.stateof.ai").WithParam("all_domain_links", "who.int,nih.gov").WithParam("all_links_text", "Nvidia,Tesla").WithParam("news_type", "General News Outlets,Tech News and Updates").WithParam("word_count_min", "300").WithParam("word_count_max", "1000").WithParam("page", "2").WithParam("page_size", "50").WithParam("clustering_threshold", "0.6").WithParam("theme", "Finance,Tech").WithParam("not_theme", "Crime,Sports").WithParam("ORG_entity_name", ""Apple Inc" OR Microsoft").WithParam("PER_entity_name", ""Elon Musk" OR "Jeff Bezos"").WithParam("LOC_entity_name", ""San Francisco" OR "New York City"").WithParam("MISC_entity_name", "AWS OR "Microsoft Azure"").WithParam("title_sentiment_min", "-0.5").WithParam("title_sentiment_max", "0.5").WithParam("content_sentiment_min", "-0.5").WithParam("content_sentiment_max", "0.5").WithParam("iptc_tags", "20000199,20000209").WithParam("not_iptc_tags", "20000205,20000209").WithParam("iab_tags", "Business,Events").WithParam("not_iab_tags", "Agriculture,Metals").WithParam("custom_tags", "Tag1,Tag2").UsingGet())

        .RespondWith(WireMock.ResponseBuilders.Response.Create()
        .WithStatusCode(200)
        .WithBody(mockResponse));

        var response = await Client.Search.GetAsync(new GetSearchRequest {
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
            From = DateTime.Parse("2024-07-01T00:00:00.000Z", null, DateTimeStyles.AdjustToUniversal),
            To = DateTime.Parse("2024-01-01T00:00:00.000Z", null, DateTimeStyles.AdjustToUniversal),
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
            RobotsCompliant = true
        });
        JsonAssert.AreEqual(response, mockResponse);
    }

}
