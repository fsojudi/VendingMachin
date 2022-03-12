using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachin.Model;

namespace VendingMachin.Tests.Model
{
    public class VendingMachinServiceTests
    {
        [Fact]
        public void CreatandSaveSnackTest()
        {
            //Arrang

            string name = "Micro-Pop";
            int price = 15;
            string information = "Put it in the Microwave before use ! Instructions are written on the package. ";
            string category = "Popcorn";

            Snack snack = new Snack(int.MaxValue, name, price, information, category);

            //Act
            VendingMachinService service = new VendingMachinService();

            Product productResult = service.CreateAndSave(snack);

            //Assert

            Assert.NotNull(productResult);
            Assert.Contains(productResult, service.ShowAll());
            Assert.NotEqual(0, productResult.id);
            Assert.NotEqual(int.MaxValue, productResult.id);
            Assert.Equal(name, productResult.name);
            Assert.Equal(price, productResult.price);
            Assert.Equal(information, productResult.information);
            Assert.Equal(category, (productResult as Snack).category);

        }


        [Fact]
        public void CreatandSaveDrinkTest()
        {

            //Arrang


            string name = "Soft";
            int price = 25;
            string information = "put the cup on the counter!";
            bool HotDrink = false;

            Drink drink = new Drink(int.MaxValue, name, price, information, HotDrink);

            //Act
            VendingMachinService service = new VendingMachinService();

            Product productResult = service.CreateAndSave(drink);

            //Assert

            Assert.NotNull(productResult);
            Assert.Contains(productResult, service.ShowAll());
            Assert.NotEqual(0, productResult.id);
            Assert.NotEqual(int.MaxValue, productResult.id);
            Assert.Equal(name, productResult.name);
            Assert.Equal(price, productResult.price);
            Assert.Equal(information, productResult.information);
            Assert.Equal(HotDrink, (productResult as Drink).hotDrink);



        }
        /*  public void InsertMoney(int payment)
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
                 }*/
        [Fact]
         public void insertMoneyTest()
        {
            //Arrang
            int payment = 10;

            //Act
            VendingMachinService service = new VendingMachinService();


            service.InsertMoney(payment);

            //Assert
            Assert.Contains(payment, service.moneyPool);


            


        }

    }
}
