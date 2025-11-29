using AlphaOfferService.AlphaStructure.Clients;
using AlphaOfferService.AlphaStructure.Services.Suggestions;

namespace AlphaOfferService.AlphaStructure.Entities.Suggestions.Salary
{
    public class AverageSalarySuggestionService : RepositorySuggestionService<SalarySuggestion>
    {
        public const int MinimalSalary = 22440;

        public AverageSalarySuggestionService(ISuggestionsRepository<SalarySuggestion> suggestionsRepository) : base(suggestionsRepository)
        {
        }

        public override async Task<List<SalarySuggestion>> SelectSuggestionsForClient(IClient client, List<SalarySuggestion> suggestions)
        {
            return [.. suggestions.Where(s => Math.Exp(client.AverageSalary) - 1 < MinimalSalary)];
        }
    }

    public class SalarySuggestion : Suggestion
    {
    }
}
