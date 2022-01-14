namespace DiscountCalculator
{
    public interface IDiscount
    {
        IDiscount Next { get; set; }
        public double Calculate(Budget budget);
    }
}
