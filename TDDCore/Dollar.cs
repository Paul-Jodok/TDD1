using System;

namespace TDDCore
{
    public class Dollar: Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier) 
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount;
        }
    }
}
