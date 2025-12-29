using NUnit.Framework;
using NewscatcherApi;
using System.Globalization;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi.Test.Unit.MockServer;

[TestFixture]
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

        Server.Given(WireMock.RequestBuilders.Request.Create().WithPath("/api/search").WithParam("q", ""supply chain" AND Amazon NOT China").WithParam("search_in", "title_content, title_content_translated").WithParam("predefined_sources", "top 100 US, top 5 GB").WithParam("source_name", "sport").WithParam("sources", "nytimes.com").WithParam("not_sources", "cnn.com").WithParam("lang", "en").WithParam("not_lang", "fr").WithParam("countries", "US").WithParam("not_countries", "UK").WithParam("not_author_name", "John Doe").WithParam("from_", "2024-07-01T00:00:00Z").WithParam("to_", "2024-07-01T00:00:00Z").WithParam("parent_url", "https://www.washingtonpost.com/politics").WithParam("all_links", "https://aiindex.stanford.edu/report").WithParam("all_domain_links", "nvidia.com").WithParam("news_type", "General News Outlets").WithParam("theme", "Business,Finance").WithParam("not_theme", "Crime").WithParam("ORG_entity_name", "Apple").WithParam("PER_entity_name", "Elon Musk").WithParam("LOC_entity_name", "California").WithParam("MISC_entity_name", "Bitcoin").WithParam("iptc_tags", "20000199,20000209").WithParam("not_iptc_tags", "20000205,20000209").WithParam("iab_tags", "Business,Events").WithParam("not_iab_tags", "Agriculture,Metals").WithParam("custom_tags", "Tag1,Tag2,Tag3").UsingGet())

        .RespondWith(WireMock.ResponseBuilders.Response.Create()
        .WithStatusCode(200)
        .WithBody(mockResponse));

        var response = await Client.Search.GetAsync(new SearchGetRequest {
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
            From = DateTime.Parse("2024-07-01T00:00:00.000Z", null, DateTimeStyles.AdjustToUniversal),
            To = DateTime.Parse("2024-07-01T00:00:00.000Z", null, DateTimeStyles.AdjustToUniversal),
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
            CustomTags = "Tag1,Tag2,Tag3"
        });
        Assert.That(
                                        response.Value,
                                        Is.EqualTo(
        JsonUtils.Deserialize<OneOf<SearchResponseDto, ClusteredSearchResponseDto>>(mockResponse).Value).UsingDefaults()
        );
    }

}
