using AlphaOfferService.AlphaStructure.Services.Suggestions;
using Microsoft.EntityFrameworkCore;

namespace AlphaOfferService.AlphaStructure.Entities.Suggestions.Income
{
    [PrimaryKey(nameof(Title))]
    public class IncomeSuggestion : ISuggestion
    {
        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Link { get; set; } = null!;

        public int MinIncome { get; set; }

        public int MaxIncome { get; set; }
    }
}
