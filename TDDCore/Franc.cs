using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCore
{
    public class Franc
    {
        int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc dollar = (Franc)obj;
            return amount == dollar.amount;
        }
    }
}
