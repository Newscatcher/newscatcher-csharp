using NewscatcherApi;
using NewscatcherApi.Core;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer;

[TestFixture]
public class SearchUrlPostTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "links": "https://www.reuters.com/business/energy/oil-prices-up-after-israeli-attacks-oversupply-caps-gains-2025-09-10/",
              "_source": "articles.id,articles.title,articles.link,articles.canonical_url"
            }
            """;

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
                  "canonical_url": true,
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
                    .WithPath("/api/search_by_link")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.SearchLink.SearchUrlPostAsync(
            new SearchUrlPostRequest
            {
                Links =
                    "https://www.reuters.com/business/energy/oil-prices-up-after-israeli-attacks-oversupply-caps-gains-2025-09-10/",
                Source = "articles.id,articles.title,articles.link,articles.canonical_url",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<SearchResponseDto>(mockResponse)).UsingDefaults()
        );
    }
}
