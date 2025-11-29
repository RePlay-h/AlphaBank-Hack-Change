using AlphaOfferService.AlphaStructure.Clients;
using AlphaOfferService.AlphaStructure.Entities.Suggestions.Income;
using AlphaOfferService.AlphaStructure.Entities.Suggestions.Salary;
using AlphaOfferService.AlphaStructure.Services.Suggestions;
using Microsoft.EntityFrameworkCore;

namespace AlphaOfferService.AlphaStructure.Entities
{
    public class AlphaBankRepository : DbContext, IClientRepository, ISuggestionsRepository<IncomeSuggestion>, ISuggestionsRepository<SalarySuggestion>, ISuggestionsRepository<CashflowAtmSuggestion>
    {
        public DbSet<AlphaBankClient> Clients { get; set; }

        private List<IncomeSuggestion>? _incomeSuggestions;

        public DbSet<IncomeSuggestion> IncomeSuggestions { get; set; }

        private List<SalarySuggestion>? _salarySuggestions;

        public DbSet<SalarySuggestion> SalarySuggestions { get; set; }

        private List<CashflowAtmSuggestion>? _cashflowAtmSuggestions;

        public DbSet<CashflowAtmSuggestion> CashflowAtmSuggestions { get; set; }

        List<IncomeSuggestion> ISuggestionsRepository<IncomeSuggestion>.Suggestions
        {
            get
            {
                _incomeSuggestions ??= [.. IncomeSuggestions];
                return _incomeSuggestions;
            }
        }

        List<SalarySuggestion> ISuggestionsRepository<SalarySuggestion>.Suggestions
        {
            get
            {
                _salarySuggestions ??= [.. SalarySuggestions];
                return _salarySuggestions;
            }
        }

        List<CashflowAtmSuggestion> ISuggestionsRepository<CashflowAtmSuggestion>.Suggestions
        {
            get
            {
                _cashflowAtmSuggestions ??= [.. CashflowAtmSuggestions];
                return _cashflowAtmSuggestions;
            }
        }

        public AlphaBankRepository(DbContextOptions<AlphaBankRepository> options) : base(options)
        {
        }

        public async Task<IClient?> GetClientByIdAsync(string clientId)
        {
            return await Clients.FirstOrDefaultAsync(c => c.Id == clientId);
        }
    }
}
