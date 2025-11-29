using AlphaOfferService.AlphaStructure.Clients;
using AlphaOfferService.AlphaStructure.Services.Suggestions;

namespace AlphaOfferService.AlphaStructure.Entities.Suggestions.Salary
{
    public class CashflowAtmSuggestionService : RepositorySuggestionService<CashflowAtmSuggestion>
    {
        public const int MedianSalaryAmount = 44123;

        public CashflowAtmSuggestionService(ISuggestionsRepository<CashflowAtmSuggestion> suggestionsRepository) : base(suggestionsRepository)
        {
        }

        public override async Task<List<CashflowAtmSuggestion>> SelectSuggestionsForClient(IClient client, List<CashflowAtmSuggestion> suggestions)
        {
            return [.. suggestions.Where(s => Math.Exp(client.AverageCashflowAtms) - 1 > MedianSalaryAmount)];
        }
    }

    public class CashflowAtmSuggestion : Suggestion
    {
    }
}
