using DiscountCalculator.Discounts;

namespace DiscountCalculator
{
    public class DiscountProcessor
    {
        public void Calculate(Budget budget)
        {
            var d1 = new FiveItemsDiscount();
            var d2 = new FiveHundredValueDiscount();
            var d3 = new PenPencilDiscount();
            var d4 = new NoDiscount();

            d1.Next = d2;
            d2.Next = d3;
            d3.Next = d4;

            var result = d1.Calculate(budget);

            Console.WriteLine(result);
        }
    }
}
