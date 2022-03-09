using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
    class Drink:Product 
    {
        public bool hotDrink { get; set; }

        public Drink(int id, string name, int costproduct, bool HotDrink) : base(id, name, costproduct)
        {
           HotDrink = hotDrink;
        }

        public override string Examine()
        {
            throw new NotImplementedException();
        }

        public override string Use()
        {
            throw new NotImplementedException();
        }
    }
}
