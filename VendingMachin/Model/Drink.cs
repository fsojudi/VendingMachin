using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
   public  class Drink:Product 
    {
        public bool hotDrink { get; set; }

        public Drink(int id, string name, int price, string  Information, bool HotDrink) : base(id, name, price, Information )
        {
           HotDrink = hotDrink;
        }

        public override string Examine()
        {
            hotDrink = false;
            if (hotDrink == true)
            {
                return $"Products Name:{name }- Price: {price }-Type of Drink: Hot Drink";
            }
            else 
                return $"Products Name:{name }- Price: {price }-Type of Drink: Cold Drink";
        }


        public override string Use()
        {
            VendingMachinService vendingMachin = new VendingMachinService();
            foreach (Product product in vendingMachin.storage)
            {

               

                if (vendingMachin.Purchase(id,vendingMachin.payment) != null)
                {
                    return $"Instruction:{information}";

                }
            }
            return null;
        }
    }
}
