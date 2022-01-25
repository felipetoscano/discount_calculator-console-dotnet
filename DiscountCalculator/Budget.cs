using DiscountCalculator.States;

namespace DiscountCalculator
{
    public class Budget
    {
        public IState State { get; set; }
        public double Value { get; set; }
        public IList<Item> Itens { get; private set; }

        public Budget(double value)
        {
            Value = value;
            Itens = new List<Item>();
            State = new InApprovation();
        }

        public void ApplyDiscount()
        {
            State.ApplyDiscount(this);
        }

        public void Approve()
        {
            State.Approve(this);
        }

        public void Reprove()
        {
            State.Reprove(this);
        }

        public void End()
        {
            State.End(this);
        }

        public void AddItem(Item item) => Itens.Add(item);
        public void RemoveItem(Item item) => Itens.Remove(item);
    }
}
