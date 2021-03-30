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


        [Fact]
        public void Human_can_override_eat()
        {
            // arrange
            Human human = new Human();

            // act
            string result = human.Eat();

            //assert
            Assert.Equal("Lets go drink water so we are not hungry and save money to buy bitcoin.", result);
        }

        [Fact]
        public void Naked_mole_can_sleep()
        {
            // arrange
            NakedMoleRat nakedmoleRat = new NakedMoleRat();

            // act
            bool result = nakedmoleRat.SleepIsTrue;

            //assert
            Assert.True(result);
        }

        [Fact]
        public void Naked_mole_rat_is_naked()
        {
            // arrange
            NakedMoleRat nakedmoleRat = new NakedMoleRat();

            // act
            string result = nakedmoleRat.SkinType;

            //assert
            Assert.Equal("Naked", result);
        }

        [Fact]
        public void Sea_turtle_has_shell()
        {
            // arrange
            SeaTurtle seaTurtle = new SeaTurtle();

            // act
            string result = seaTurtle.SkinType;

            //assert
            Assert.Equal("Shell", result);
        }


        [Fact]
        public void Sea_turtle_lays_eggs()
        {
            // arrange
            SeaTurtle seaTurtle = new SeaTurtle();

            // act
            int result = seaTurtle.HowManyEggsDoTheyLay;
       

            //assert
            Assert.Equal(110, result);

        }
        


        [Fact]
        public void Viper_gives_live_birth_lays_eggs_false()
        {
            // arrange
            Viper viper = new Viper();

            // act
            string result = viper.IsColdBlooded();

            //assert
            Assert.Equal("Where's the sun? I am cold!", result);
        }

    }
}
