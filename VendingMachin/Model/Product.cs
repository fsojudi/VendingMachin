using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
    public abstract class Product
    {
        private readonly int Id;
        public  int id { get { return Id; } }
        public string name { get; set; }
        public int price { get; set; }
        public string information { get; set; }

        public Product() { }
        public Product(int Id)
        {
           this.Id  = Id;
        }
        public Product(int Id, string Name):this (Id)
        {
            name = Name; 
        }


        public Product(int Id, string Name, int Price):this(Id,Name)
        {

            
            price = Price;
        }
        public Product(int Id, string Name, int Price, string Information) : this(Id, Name,Price)
        {
            information = Information;
       
        }

        public  abstract  string Examine();
        public abstract string Use();

    }
}
