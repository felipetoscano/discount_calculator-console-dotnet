namespace DiscountCalculator.States
{
    public interface IState
    {
        public bool AlreadyDiscounted { get; set; }
        public void ApplyDiscount(Budget budget);
        public void Approve(Budget budget);
        public void Reprove(Budget budget);
        public void End(Budget budget);
    }
}
