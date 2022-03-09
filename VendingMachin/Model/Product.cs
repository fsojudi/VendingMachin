using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
    public abstract class Product
    {
        public int id { get; }
        public string name { get; set; }
        public decimal costproduct { get; set; }
        public string information { get; set; }

        public Product(int Id)
        {
            Id = id;
        }
        public Product(int Id, string Name):this (Id)
        {
            Name = name; 
        }


        public Product(int Id, string Name, decimal Costproduct):this(Id,Name)
        {
           
            Name = name;
            Costproduct = costproduct;
        }

        public  abstract  string Examine();
        public abstract string Use();

    }
}
