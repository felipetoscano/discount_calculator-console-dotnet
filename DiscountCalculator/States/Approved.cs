namespace DiscountCalculator.States
{
    public class Approved : IState
    {
        public void ApplyDiscount(Budget budget)
        {
            budget.Value *= 0.98;
        }

        public void Approve(Budget budget)
        {
            throw new Exception("Orçamento já aprovado");
        }

        public void End(Budget budget)
        {
            budget.State = new Ended();
        }

        public void Reprove(Budget budget)
        {
            throw new Exception("Orçamento já aprovado");
        }
    }
}
