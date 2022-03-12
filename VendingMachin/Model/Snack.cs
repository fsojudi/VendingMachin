using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
     public class Snack : Product
    {
       public  String category { get; set; }

        public Snack(int Id, string Name, int Price, string Information, string Category) : base(Id, Name, Price, Information)
        {
            category =Category ;
        }

        
        public override string Examine()
        {
            return $" Products Name:{name }- Price: {price }-The Category of the snack: {category }";
        }

        public override string Use()
        {
            VendingMachinService vendingMachin = new VendingMachinService();
            foreach (Product product in vendingMachin.storage)
            {

              

                if (vendingMachin.Purchase(id) != null)
                {
                    return $"Instruction:{information}";

                }
            }
            return null;
        }
    }
}
