using NewscatcherApi;
using NewscatcherApi.Test.Unit.MockServer;
using NewscatcherApi.Test.Utils;
using NUnit.Framework;

namespace NewscatcherApi.Test.Unit.MockServer.SearchByLink;

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
                    .WithPath("/api/search_by_link")
                    .WithParam("ids", "5f8d0d55b6e45e00179c6e7e")
                    .WithParam("links", "https://nytimes.com/article1", "https://bbc.com/article2")
                    .WithParam("from_", "1 day ago")
                    .WithParam("to_", "now")
                    .WithParam("page", "2")
                    .WithParam("page_size", "50")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.SearchByLink.GetAsync(
            new GetSearchByLinkRequest
            {
                Ids = "5f8d0d55b6e45e00179c6e7e",
                Links = "https://nytimes.com/article1,https://bbc.com/article2",
                From = "1 day ago",
                To = "now",
                Page = 2,
                PageSize = 50,
                RobotsCompliant = true,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
