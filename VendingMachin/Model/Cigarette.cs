using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
   public  class Cigarette : Product
    {
         public  String brand { get; set; }
        
        
        public Cigarette (int Id , string Name, int Price, string Information, string Brand):base(Id, Name  , Price, Information)
        {
            Brand = brand;
        }


        public override string Examine()
        {
            return $"Products Name:{name }- Price: {price }-Brand:{ brand } ";
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
