using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
    public abstract class Product
    {
        public int id { get; }
        public string name { get; set; }
        public int price { get; set; }
        public string information { get; set; }

        public Product(int Id)
        {
            Id = id;
        }
        public Product(int Id, string Name):this (Id)
        {
            Name = name; 
        }


        public Product(int Id, string Name, int Price,string  Information):this(Id,Name)
        {

            Information = information;
            Price = price;
        }

        public  abstract  string Examine();
        public abstract string Use();

    }
}
