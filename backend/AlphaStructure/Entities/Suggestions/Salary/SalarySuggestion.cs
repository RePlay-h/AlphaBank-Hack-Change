using AlphaOfferService.AlphaStructure.Services.Suggestions;
using Microsoft.EntityFrameworkCore;

namespace AlphaOfferService.AlphaStructure.Entities.Suggestions.Salary
{
    [PrimaryKey(nameof(Title))]
    public class Suggestion : ISuggestion
    {
        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Link { get; set; } = null!;
    }
}
