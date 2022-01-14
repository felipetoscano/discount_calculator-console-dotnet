namespace DiscountCalculator.Discounts
{
    public class FiveHundredValueDiscount : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Calculate(Budget budget)
        {
            if (budget.Value > 500)
            {
                return budget.Value * 0.07;
            }
            else
            {
                return Next.Calculate(budget);
            }
        }
    }
}
