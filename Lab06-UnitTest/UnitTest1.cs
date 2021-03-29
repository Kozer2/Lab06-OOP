using System;
using Xunit;
using Lab06_OOP;
using Lab06_OOP.Classes;

namespace Lab06_UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Ostrich_can_eat()
        {
            // arrange
            Ostrich ostrich = new Ostrich();

            // act
            string result = ostrich.Eat();

            //assert
            Assert.Equal("Eat the Food!", result);
        }

        [Fact]
        public void Ostrich_can_fly_false()
        {
            // arrange
            Ostrich ostrich = new Ostrich();

            // act
            bool result = ostrich.CanFly;

            //assert
            Assert.False(result);
        }


        [Fact]
        public void Human_wears_clothes()
        {
            // arrange
            Human human = new Human();

            // act
            string result = human.WearsClothes();

            //assert
            Assert.Equal("Looking Pretty Fly", result);
        }
    }
}
