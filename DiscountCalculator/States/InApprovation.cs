namespace DiscountCalculator.States
{
    public class InApprovation : IState
    {
        public bool AlreadyDiscounted { get; set; }

        public void ApplyDiscount(Budget budget)
        {
            if (AlreadyDiscounted)
            {
                throw new Exception("Desconto já aplicado para este estado");
            }

            budget.Value *= 0.95;
            AlreadyDiscounted = true;
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
