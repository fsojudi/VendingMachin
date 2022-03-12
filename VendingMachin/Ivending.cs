using System;
using System.Collections.Generic;
using System.Text;
using VendingMachin.Model;

namespace VendingMachin
{
   public  interface Ivending
    {
        void Purchase(int Id);

        List<string>ShowAll(List<Product> produktList);

        string Details(Product product);

        void InsertMoney();

        Dictionary<int, int> EndTransaction();



    }
}
