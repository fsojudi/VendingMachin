using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
   public  class Cigarette : Product
    {
        String brand { get; set; }
        
        public Cigarette (int id , string name, int costproduct,string Brand):base(id, name , costproduct )
        {
            Brand = brand;
        }


        public override string Examine()
        {
            
        }

        public override string Use()
        {
            
        }
    }
}
