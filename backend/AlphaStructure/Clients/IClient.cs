namespace AlphaOfferService.AlphaStructure.Clients
{
    public interface IClient
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

        public float AverageCashflowAtms { get; }
            
    }
}
