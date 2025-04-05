using FuckApi.Models;

namespace FuckApi.Services;

public interface IParsingService
{
    Task<List<Item>> ParseItemsForHeroes(List<string> heroTags, int count);
}