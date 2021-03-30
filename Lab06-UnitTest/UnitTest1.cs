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
        public void Ostrich_inherits_warm_blooded_from_mammal()
        {
            // arrange
            Ostrich ostrich = new Ostrich();

            // act
            string result = ostrich.AreTheyWarmOrColdBlooded;

            //assert
            Assert.Equal("Warm Blooded", result);
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
        public void Human_inherit_warm_blooded()
        {
            // arrange
            Human human = new Human();

            // act
            string result = human.AreTheyWarmOrColdBlooded;

            //assert
            Assert.Equal("Warm Blooded", result);
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
        public void Sea_turtle_lays_eggs_overrides_both_reptile_and_ILaysEggs()
        {
            // arrange
            SeaTurtle seaTurtle = new SeaTurtle();

            // act
            string result = seaTurtle.HowManyEggsDoTheyLay();
       

            //assert
            Assert.Equal("Sea Turtles lay 110 at a time!", result);

        }



        [Fact]
        public void Viper_gives_live_birth_lays_eggs_override()
        {
            // arrange
            Viper viper = new Viper();

            // act
            string result = viper.HowManyEggsDoTheyLay();

            //assert
            Assert.Equal("Vipers give live birth!", result);
        }



    }
}
