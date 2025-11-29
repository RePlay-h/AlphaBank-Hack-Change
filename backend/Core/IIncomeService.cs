using AlphaOfferService.AlphaStructure.Clients;

namespace AlphaOfferService.Core
{
    public interface IIncomeService
    {
        public Task<double> GetClientIncomeAsync(IClient client);
    }
}
