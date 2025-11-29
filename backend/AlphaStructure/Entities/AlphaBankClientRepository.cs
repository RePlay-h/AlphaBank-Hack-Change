using AlphaOfferService.AlphaStructure.Clients;

namespace AlphaOfferService.AlphaStructure.Entities
{
    public class AlphaBankClientRepository : IClientRepository
    {
        private readonly List<AlphaBankClient> _clients =
        [
            new AlphaBankClient("1", 26,  Gender.Male,  11.484045f, true, 50103.000000f, 11.231901f,  false, 0.352713f, 8.376090f, 9.488444f)
        ];

        public async Task<IClient?> GetClientByIdAsync(string clientId)
        {
            return await Task.FromResult(_clients.FirstOrDefault(c => c.Id == clientId));
        }
    }
}
