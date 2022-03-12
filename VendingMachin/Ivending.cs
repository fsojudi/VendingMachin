using System;
using System.Collections.Generic;
using System.Text;
using VendingMachin.Model;

namespace VendingMachin
{
   public  interface IVending
    {
        Product Purchase(int Id);

        List<Product>ShowAll();

        string Details(Product selctedproduct);

        void InsertMoney(int payment);

        public Dictionary<int, int> Pending(Product product);



    }
}
