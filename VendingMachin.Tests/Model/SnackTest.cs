using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachin.Model;

namespace VendingMachin.Tests.Model
{
    public class SnackTest
    {

        [Fact]
        public void SnackConstrutorTest()
        {
            //Arrange
            int Id = 4;
            string Name = "Micro-Pop";
            int price = 15;
            string information = "Put it in the Microwave before use ! Instructions are written on the package. ";
            string category = "Popcorn";

            //Act 
            Snack result = new Snack(Id, Name, price, information, category);

            //Assert

            Assert.Equal(Id , result.id);
            Assert.Equal(Name, result.name );
            Assert.Equal(price , result.price );
            Assert.Equal(information , result.information );
            Assert.Equal(category, result.category );

        }
       

    }
}
