/*
 * Author: John Nettles
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger aj = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(aj);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            BriarheartBurger aj = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger co = new BriarheartBurger();
            Assert.True(co.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger co = new BriarheartBurger();
            Assert.True(co.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger co = new BriarheartBurger();
            Assert.True(co.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger co = new BriarheartBurger();
            Assert.True(co.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger co = new BriarheartBurger();
            Assert.True(co.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger co = new BriarheartBurger();
            co.Bun = false;
            Assert.False(co.Bun);
            co.Bun = true;
            Assert.True(co.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger co = new BriarheartBurger();
            co.Ketchup = false;
            Assert.False(co.Ketchup);
            co.Ketchup = true;
            Assert.True(co.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger co = new BriarheartBurger();
            co.Mustard = false;
            Assert.False(co.Mustard);
            co.Mustard = true;
            Assert.True(co.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger co = new BriarheartBurger();
            co.Pickle = false;
            Assert.False(co.Pickle);
            co.Pickle = true;
            Assert.True(co.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger co = new BriarheartBurger();
            co.Cheese = false;
            Assert.False(co.Cheese);
            co.Cheese = true;
            Assert.True(co.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger aj = new BriarheartBurger();
            Assert.Equal(6.32, aj.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger aj = new BriarheartBurger();
            Assert.Equal(743, (double)aj.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger co = new BriarheartBurger();
            co.Bun = includeBun;
            if (!includeBun) Assert.Contains("Hold bun", co.SpecialInstructions);
            co.Ketchup = includeKetchup;
            if (!includeKetchup) Assert.Contains("Hold ketchup", co.SpecialInstructions);
            co.Mustard = includeMustard;
            if (!includeMustard) Assert.Contains("Hold mustard", co.SpecialInstructions);
            co.Pickle = includePickle;
            if (!includePickle) Assert.Contains("Hold pickle", co.SpecialInstructions);
            co.Cheese = includeCheese;
            if (!includeCheese) Assert.Contains("Hold cheese", co.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger aj = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", aj.ToString());
        }
    }
}