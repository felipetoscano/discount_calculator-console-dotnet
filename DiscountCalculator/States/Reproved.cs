namespace DiscountCalculator.States
{
    public class Reproved : IState
    {
        public void ApplyDiscount(Budget budget)
        {

        }

        public void Approve(Budget budget)
        {
            throw new Exception("Orçamento já reprovado");
        }

        public void End(Budget budget)
        {
            budget.State = new Ended();
        }

        public void Reprove(Budget budget)
        {
            throw new Exception("Orçamento já reprovado");
        }
    }
}
