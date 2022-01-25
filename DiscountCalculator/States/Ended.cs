namespace DiscountCalculator.States
{
    public class Ended : IState
    {
        public void ApplyDiscount(Budget budget)
        {

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
