using HtmlAgilityPack;
using FuckApi.Models;

namespace FuckApi.Services;

public class ParsingService : IParsingService
{
    private readonly HttpClient _httpClient;

    public ParsingService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<Item>> ParseItemsForHero(string heroTag, int count)
    {
        var items = new List<Item>();
        const int itemsPerPage = 10;
        int totalPages = (int)Math.Ceiling((double)count / itemsPerPage);

        for (int page = 0; page < totalPages; page++)
        {
            int start = page * itemsPerPage;

            string url = $"https://steamcommunity.com/market/search?start={start}&count={itemsPerPage}&q=&category_570_Hero%5B%5D=tag_npc_dota_hero_{heroTag}&category_570_Slot%5B%5D=any&category_570_Type%5B%5D=any&appid=570";
            string html = await _httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var resultsContainer = htmlDocument.DocumentNode.SelectSingleNode("//div[@id='searchResultsRows']");
            if (resultsContainer == null)
            {
                Console.WriteLine("No search results found.");
                break;
            }

            var itemNodes = resultsContainer.SelectNodes(".//a[@class='market_listing_row_link']");
            if (itemNodes == null || itemNodes.Count == 0)
            {
                Console.WriteLine("No more items found on page.");
                break;
            }

            foreach (var node in itemNodes)
            {
                var nameNode = node.SelectSingleNode(".//span[@class='market_listing_item_name']");
                var name = nameNode?.InnerText.Trim() ?? "Unknown";

                var priceNode = node.SelectSingleNode(".//span[@class='sale_price']");
                var price = priceNode?.InnerText.Trim() ?? "N/A";

                Console.WriteLine($"Parsed item: Name={name}, Price={price}");

                items.Add(new Item
                {
                    Name = name,
                    Price = price,
                    Hero = heroTag
                });

                if (items.Count >= count)
                {
                    return items.Take(count).ToList();
                }
            }
            await Task.Delay(3000);
        }

        return items;
    }
    
    public async Task<List<Item>> ParseItemsForHeroes(List<string> heroTags, int count)
    {
        var tasks = heroTags.Select(heroTag => ParseItemsForHero(heroTag, count)).ToList();
        var results = await Task.WhenAll(tasks);
        return results.SelectMany(items => items).ToList();
    }
}