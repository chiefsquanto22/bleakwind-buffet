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
    public class DoubleDragrTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDragr aj = new DoubleDragr();
            Assert.IsAssignableFrom<Entree>(aj);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDragr co = new DoubleDragr();
            Assert.True(co.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDragr co = new DoubleDragr();
            Assert.True(co.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDragr co = new DoubleDragr();
            Assert.True(co.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDragr co = new DoubleDragr();
            Assert.True(co.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDragr co = new DoubleDragr();
            Assert.True(co.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDragr co = new DoubleDragr();
            Assert.True(co.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDragr co = new DoubleDragr();
            Assert.True(co.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDragr co = new DoubleDragr();
            Assert.True(co.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDragr co = new DoubleDragr();
            co.Bun = false;
            Assert.False(co.Bun);
            co.Bun = true;
            Assert.True(co.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDragr co = new DoubleDragr();
            co.Ketchup = false;
            Assert.False(co.Ketchup);
            co.Ketchup = true;
            Assert.True(co.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDragr co = new DoubleDragr();
            co.Mustard = false;
            Assert.False(co.Mustard);
            co.Mustard = true;
            Assert.True(co.Mustard);
        }


        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDragr co = new DoubleDragr();
            co.Pickle = false;
            Assert.False(co.Pickle);
            co.Pickle = true;
            Assert.True(co.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDragr co = new DoubleDragr();
            co.Cheese = false;
            Assert.False(co.Cheese);
            co.Cheese = true;
            Assert.True(co.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDragr co = new DoubleDragr();
            co.Tomato = false;
            Assert.False(co.Tomato);
            co.Tomato = true;
            Assert.True(co.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDragr co = new DoubleDragr();
            co.Lettuce = false;
            Assert.False(co.Lettuce);
            co.Lettuce = true;
            Assert.True(co.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDragr co = new DoubleDragr();
            co.Mayo = false;
            Assert.False(co.Mayo);
            co.Mayo = true;
            Assert.True(co.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDragr co = new DoubleDragr();
            Assert.Equal(7.32 , (double)co.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDragr aj = new DoubleDragr();
            Assert.Equal(843, (double)aj.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDragr co = new DoubleDragr();
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
            DoubleDragr aj = new DoubleDragr();
            Assert.Equal("Double Dragr", aj.ToString());
        }
    }
}