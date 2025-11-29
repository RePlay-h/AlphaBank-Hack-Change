namespace AlphaOfferService.AlphaStructure.Services.Suggestions
{
    public interface ISuggestionsRepository<TSuggest> where TSuggest : ISuggestion
    {
        public List<TSuggest> Suggestions { get; }
    }
}
