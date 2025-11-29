using AlphaOfferService.AlphaStructure.Clients;
using AlphaOfferService.AlphaStructure.Services.Suggestions;
using AlphaOfferService.Core;

namespace AlphaOfferService.AlphaStructure.Entities.Suggestions.Income
{
    public class IncomeSuggestionService : RepositorySuggestionService<IncomeSuggestion>
    {
        private readonly IIncomeService _incomeService;

        public IncomeSuggestionService(IIncomeService incomeService, ISuggestionsRepository<IncomeSuggestion> suggestionsRepository) : base(suggestionsRepository)
        {
            _incomeService = incomeService;
        }

        public override async Task<List<IncomeSuggestion>> SelectSuggestionsForClient(IClient client, List<IncomeSuggestion> suggestions)
        {
            var income = await _incomeService.GetClientIncomeAsync(client);
            return [.. suggestions.Where(suggestion => suggestion.MinIncome < income && suggestion.MaxIncome > income)];
        }
    }
}
