namespace DiscountCalculator.States
{
    public class Approved : IState
    {
        public bool AlreadyDiscounted { get; set; }

        public void ApplyDiscount(Budget budget)
        {
            if (AlreadyDiscounted)
            {
                throw new Exception("Desconto já aplicado para este estado");
            }

            budget.Value *= 0.98;
            AlreadyDiscounted = true;
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
