using AlphaOfferService.AlphaStructure.Clients;

namespace AlphaOfferService.AlphaStructure.Services.Suggestions
{
    public interface ISuggestionService
    {
        public Task<List<ISuggestion>> GetSuggestionsAsync(IClient client);
    }
}
