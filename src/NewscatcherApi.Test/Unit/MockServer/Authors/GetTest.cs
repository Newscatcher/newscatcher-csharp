using NewscatcherApi;
using NewscatcherApi.Test.Unit.MockServer;
using NewscatcherApi.Test.Utils;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer.Authors;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
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

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/authors")
                    .WithParam("author_name", "Jane Smith")
                    .WithParam("not_author_name", "John Doe", " Jane Doe")
                    .WithParam("predefined_sources", "top 50 US", " top 20 GB")
                    .WithParam("sources", "nytimes.com", "finance.yahoo.com")
                    .WithParam("not_sources", "cnn.com", "wsj.com")
                    .WithParam("lang", "en", "es")
                    .WithParam("not_lang", "fr", "de")
                    .WithParam("countries", "US", "CA")
                    .WithParam("not_countries", "UK", "FR")
                    .WithParam("from_", "1 day ago")
                    .WithParam("to_", "now")
                    .WithParam("published_date_precision", "full")
                    .WithParam("from_rank", "100")
                    .WithParam("to_rank", "100")
                    .WithParam("parent_url", "wsj.com/politics", "wsj.com/tech")
                    .WithParam(
                        "all_links",
                        "https://aiindex.stanford.edu/report",
                        "https://www.stateof.ai"
                    )
                    .WithParam("all_domain_links", "who.int", "nih.gov")
                    .WithParam("all_links_text", "Nvidia", "Tesla")
                    .WithParam("word_count_min", "300")
                    .WithParam("word_count_max", "1000")
                    .WithParam("page", "2")
                    .WithParam("page_size", "50")
                    .WithParam("theme", "Finance", "Tech")
                    .WithParam("not_theme", "Crime", "Sports")
                    .WithParam("ner_name", "Tesla", "Amazon")
                    .WithParam("title_sentiment_min", "-0.5")
                    .WithParam("title_sentiment_max", "0.5")
                    .WithParam("content_sentiment_min", "-0.5")
                    .WithParam("content_sentiment_max", "0.5")
                    .WithParam("iptc_tags", "20000199", "20000209")
                    .WithParam("not_iptc_tags", "20000205", "20000209")
                    .WithParam("iab_tags", "Business", "Events")
                    .WithParam("not_iab_tags", "Agriculture", "Metals")
                    .WithParam("custom_tags", "Tag1", "Tag2")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Authors.GetAsync(
            new GetAuthorsRequest
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
                From = "1 day ago",
                To = "now",
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
        JsonAssert.AreEqual(response, mockResponse);
    }
}
