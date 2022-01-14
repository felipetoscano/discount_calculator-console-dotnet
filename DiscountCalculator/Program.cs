namespace DiscountCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new DiscountProcessor();

            var budget = new Budget(100);
            budget.AddItem(new Item("PEN", 1000));
            budget.AddItem(new Item("PENCIL", 1000));
            budget.AddItem(new Item("i3", 1000));
            budget.AddItem(new Item("i4", 1000));
            //budget.AddItem(new Item("i5", 1000));
            //budget.AddItem(new Item("i6", 1000));

            calculator.Calculate(budget);
        }
    }
}