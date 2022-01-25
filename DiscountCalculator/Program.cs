namespace DiscountCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var b1 = new Budget(500);

            Console.WriteLine($"Orçamento Inicial: {b1.Value}");

            b1.ApplyDiscount();

            Console.WriteLine($"Orçamento em aprovação: {b1.Value}");

            b1.Approve();
            b1.ApplyDiscount();

            Console.WriteLine($"Orçamento depois de aprovado: {b1.Value}");
        }
    }
}