using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
    class Snack : Product
    {
        String categori { get; set; }

        public Snack(int Id, string Name, int Costproduct, string Categori) : base(Id, Name, Costproduct)
        {
            Categori =categori ;
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
