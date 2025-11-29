using AlphaOfferService.AlphaStructure.Clients;

namespace AlphaOfferService.Core
{
    public interface IIncomeModel
    {
        public Task<double> CalculateClientIncome(IClient client);
    }
}
