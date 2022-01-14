namespace DiscountCalculator.Discounts
{
    public class NoDiscount : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Calculate(Budget budget)
        {
            return 0;
        }
    }
}
