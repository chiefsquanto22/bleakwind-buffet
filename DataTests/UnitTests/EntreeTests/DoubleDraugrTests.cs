/*
 * Author: John Nettles
 * Class: DoubleDragrTests.cs
 * Purpose: Test the DoubleDragr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr co = new DoubleDraugr();
            Assert.True(co.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr co = new DoubleDraugr();
            Assert.True(co.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr co = new DoubleDraugr();
            Assert.True(co.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr co = new DoubleDraugr();
            Assert.True(co.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr co = new DoubleDraugr();
            Assert.True(co.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr co = new DoubleDraugr();
            Assert.True(co.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr co = new DoubleDraugr();
            Assert.True(co.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr co = new DoubleDraugr();
            Assert.True(co.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr co = new DoubleDraugr();
            co.Bun = false;
            Assert.False(co.Bun);
            co.Bun = true;
            Assert.True(co.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr co = new DoubleDraugr();
            co.Ketchup = false;
            Assert.False(co.Ketchup);
            co.Ketchup = true;
            Assert.True(co.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr co = new DoubleDraugr();
            co.Mustard = false;
            Assert.False(co.Mustard);
            co.Mustard = true;
            Assert.True(co.Mustard);
        }


        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr co = new DoubleDraugr();
            co.Pickle = false;
            Assert.False(co.Pickle);
            co.Pickle = true;
            Assert.True(co.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr co = new DoubleDraugr();
            co.Cheese = false;
            Assert.False(co.Cheese);
            co.Cheese = true;
            Assert.True(co.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr co = new DoubleDraugr();
            co.Tomato = false;
            Assert.False(co.Tomato);
            co.Tomato = true;
            Assert.True(co.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr co = new DoubleDraugr();
            co.Lettuce = false;
            Assert.False(co.Lettuce);
            co.Lettuce = true;
            Assert.True(co.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr co = new DoubleDraugr();
            co.Mayo = false;
            Assert.False(co.Mayo);
            co.Mayo = true;
            Assert.True(co.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr co = new DoubleDraugr();
            Assert.Equal(7.32 , (double)co.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr aj = new DoubleDraugr();
            Assert.Equal(843, (double)aj.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr co = new DoubleDraugr();
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
            co.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", co.SpecialInstructions);
            co.Lettuce = includeLettuce;
            if (!includeLettuce) Assert.Contains("Hold lettuce", co.SpecialInstructions);
            co.Mayo = includeMayo;
            if (!includeMayo) Assert.Contains("Hold mayo", co.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr aj = new DoubleDraugr();
            Assert.Equal("Double Dragr", aj.ToString());
        }
    }
}