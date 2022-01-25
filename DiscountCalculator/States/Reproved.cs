namespace DiscountCalculator.States
{
    public class Reproved : IState
    {
        public bool AlreadyDiscounted { get; set; }

        public void ApplyDiscount(Budget budget)
        {
            if (AlreadyDiscounted)
            {
                throw new Exception("Desconto já aplicado para este estado");
            }

            AlreadyDiscounted = true;
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
