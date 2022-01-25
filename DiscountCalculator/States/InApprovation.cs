namespace DiscountCalculator.States
{
    public class InApprovation : IState
    {
        public void ApplyDiscount(Budget budget)
        {
            budget.Value *= 0.95;
        }

        public void Approve(Budget budget)
        {
            budget.State = new Approved();
        }

        public void End(Budget budget)
        {
            budget.State = new Ended();
        }

        public void Reprove(Budget budget)
        {
            budget.State = new Reproved();
        }
    }
}
