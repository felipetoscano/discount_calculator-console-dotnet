namespace DiscountCalculator.Discounts
{
    public class FiveItemsDiscount : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Calculate(Budget budget)
        {
            if (budget.Itens.Count > 5)
            {
                return budget.Value * 0.1;
            }
            else
            {
                return Next.Calculate(budget);
            }
        }
    }
}
