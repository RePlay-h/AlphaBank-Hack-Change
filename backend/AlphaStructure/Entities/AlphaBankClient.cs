using AlphaOfferService.AlphaStructure.Clients;

namespace AlphaOfferService.AlphaStructure.Entities
{
    public class AlphaBankClient : IClient
    {
        public string Id { get; }

        public float Age { get; }

        public Gender Gender { get; }

        public float AverageSalary { get; }

        public bool IsSalaryKnown { get; }

        public float AverageRegionIncomePerCapita { get; }

        public float AverageCurrentCreditTurnover { get; }

        public bool IsNaTurnOtherCrAvgAct { get; }

        public float SupermarketTransactionCategoryPercent { get; }

        public float RestaurantTransactionCategoryPercent { get; }

        public float AverageMonthlyTravelCategoryTransactionAmountOverYear { get; }

        public AlphaBankClient(
            string id,
            float age,
            Gender gender,
            float averageSalary,
            bool isSalaryKnown,
            float averageRegionIncomePerCapita,
            float averageCurrentCreditTurnover,
            bool isNaTurnOtherCrAvgAct,
            float supermarketTransactionCategoryPercent,
            float restaurantTransactionCategoryPercent,
            float averageMonthlyTravelCategoryTransactionAmountOverYear)
        {
            Id = id;
            Age = age;
            Gender = gender;
            AverageSalary = averageSalary;
            IsSalaryKnown = isSalaryKnown;
            AverageRegionIncomePerCapita = averageRegionIncomePerCapita;
            AverageCurrentCreditTurnover = averageCurrentCreditTurnover;
            IsNaTurnOtherCrAvgAct = isNaTurnOtherCrAvgAct;
            SupermarketTransactionCategoryPercent = supermarketTransactionCategoryPercent;
            RestaurantTransactionCategoryPercent = restaurantTransactionCategoryPercent;
            AverageMonthlyTravelCategoryTransactionAmountOverYear = averageMonthlyTravelCategoryTransactionAmountOverYear;
        }
    }
}
