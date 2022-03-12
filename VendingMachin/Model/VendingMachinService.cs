using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachin.Model
{
   public  class VendingMachinService : IVending
    {
        public List <Product> storage=new List <Product>();

        public int[] moneyArray = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public List<int> moneyPool = new List<int>();


        public int payment;
        Dictionary<int, int> transactionDic = new Dictionary<int, int>();// payment as the Key and Left money as the value




        // Creat and Save the Products
        public Product  CreateAndSave(Product data)
        {
            Product product = null;
            if (data is Snack)
            {
                product  = new Snack(
                    ProductSequenser.NextProductId(),
                    data.name,
                    data.price,
                    data.information,
                    (data as Snack ).category
                    
                    );
            }
            else if (data is Drink)
            {
                product = new Drink (
                    ProductSequenser.NextProductId(),
                    data.name,
                    data.price,
                    data .information,
                    (data as Drink ).hotDrink

                    );
            }
            else if (data is Cigarette)
            {
                product = new Cigarette(
                    ProductSequenser.NextProductId(),
                    data.name,
                    data.price,
                    data.information,
                    (data as Cigarette).brand

                    );
            }

            storage.Add(product);

            return product ;
        }

        // Show All Products
        public List<Product> ShowAll()
        {
            return storage;
        }
        public Product FindById(int inputId)
        {
            foreach (Product product in storage)
            {
                if (product.id.Equals(inputId))
                {
                    return product;
                }
            }
            return null;
        }

        // Show  Details of  the Selected Product
        public string Details(Product selctedproduct)
        {
            foreach (Product  product in storage )
            {
                if (selctedproduct == product)
                {
                    if(product is Snack )
                    {
                        return $"Products Id: {product.id } - Products Name:{product.name  } -" +
                           
                            $" Price: {product.price  }-Category of Snack:{ (product as Snack ).category } ";
                    }
                    else if (product is Drink )
                    {
                        if ((product as Drink ).hotDrink ==true )
                        return $"Products Id: {product.id } - Products Name:{product.name  } -" +

                            $" Price: {product.price  }-Hot or Cold Drink? : Hot Drink ";
                        else
                            return $"Products Id: {product.id } - Products Name:{product.name  } -" +

                            $" Price: {product.price  }-Hot or Cold Drink? : Cold Drink ";
                    }
                    if (product is Cigarette )
                    {
                        return $"Products Id: {product.id } - Products Name:{product.name  } -" +

                            $" Price: {product.price  }-Category of Snack:{ (product as Cigarette ).brand  } ";
                    }

                }
            }
            return null;
        }

        public Dictionary<int, int> Pending( Product product)
        {
            int leftMoney =  - product .price;
            transactionDic.Add(payment, leftMoney);
            return transactionDic;
        }

        // End The Transaction 
        public Dictionary<int, int> EndTransaction()
        {
            foreach (Product  product in storage )
            {
                if (Purchase (product .id )!=null)

                 return Pending(product );

            }

            return null;


        }

        // Put The inseted Money in the Moneypool
        public void InsertMoney(int payment)
        {
            if (payment == 0)
                throw new ArgumentNullException("You Have to insert money first.");
            else
            {

                foreach (int kron in moneyArray)
                {
                    if (payment == kron)
                        moneyPool.Add(payment);
                    else
                        throw new ArgumentException("The inserted Money is not Valid .");

                }
            }
               
            

        }

        // Buy the Product with Id
        public Product Purchase(int Id)
        {
            foreach (Product product in storage)
            {
               
                if (payment >= product.price)
                {
                    
                    return product;
                }
                
                    
            }
            return null;
        }
    }
}
