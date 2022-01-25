namespace DiscountCalculator.States
{
    public class Ended : IState
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
            throw new Exception("Orçamento já encerrado");
        }

        public void End(Budget budget)
        {
            throw new Exception("Orçamento já encerrado");
        }

        public void Reprove(Budget budget)
        {
            throw new Exception("Orçamento já encerrado");
        }
    }
}
