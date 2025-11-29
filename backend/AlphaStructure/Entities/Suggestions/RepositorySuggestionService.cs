using AlphaOfferService.AlphaStructure.Clients;
using AlphaOfferService.AlphaStructure.Services.Suggestions;

namespace AlphaOfferService.AlphaStructure.Entities.Suggestions
{
    public abstract class RepositorySuggestionService<TSuggestion> : ISuggestionService where TSuggestion : ISuggestion
    {
        private readonly ISuggestionsRepository<TSuggestion> _suggestionsRepository;

        public RepositorySuggestionService(ISuggestionsRepository<TSuggestion> suggestionsRepository)
        {
            _suggestionsRepository = suggestionsRepository;
        }

        public abstract Task<List<TSuggestion>> SelectSuggestionsForClient(IClient client, List<TSuggestion> suggestions);

        public async Task<List<ISuggestion>> GetSuggestionsAsync(IClient client)
        {
            return [.. await SelectSuggestionsForClient(client, _suggestionsRepository.Suggestions)];
        }
    }
}
