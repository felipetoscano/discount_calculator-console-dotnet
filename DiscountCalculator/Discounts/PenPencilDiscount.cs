namespace DiscountCalculator.Discounts
{
    public class PenPencilDiscount : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Calculate(Budget budget)
        {
            var havePen = budget.Itens.FirstOrDefault(i => i.Name == "PEN");
            var havePencil = budget.Itens.FirstOrDefault(i => i.Name == "PENCIL");

            if (havePen != null & havePencil != null)
            {
                return budget.Value * 0.05;
            }
            else
            {
                return Next.Calculate(budget);
            }
        }
    }
}
