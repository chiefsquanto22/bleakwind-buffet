/*
 * Author: John Nettles
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple co = new ThalmorTriple();
            Assert.True(co.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Bun = false;
            Assert.False(co.Bun);
            co.Bun = true;
            Assert.True(co.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Ketchup = false;
            Assert.False(co.Ketchup);
            co.Ketchup = true;
            Assert.True(co.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Mustard = false;
            Assert.False(co.Mustard);
            co.Mustard = true;
            Assert.True(co.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Pickle = false;
            Assert.False(co.Pickle);
            co.Pickle = true;
            Assert.True(co.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Cheese = false;
            Assert.False(co.Cheese);
            co.Cheese = true;
            Assert.True(co.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Tomato = false;
            Assert.False(co.Tomato);
            co.Tomato = true;
            Assert.True(co.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Lettuce = false;
            Assert.False(co.Lettuce);
            co.Lettuce = true;
            Assert.True(co.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Mayo = false;
            Assert.False(co.Mayo);
            co.Mayo = true;
            Assert.True(co.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Bacon = false;
            Assert.False(co.Bacon);
            co.Bacon = true;
            Assert.True(co.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple co = new ThalmorTriple();
            co.Egg = false;
            Assert.False(co.Egg);
            co.Egg = true;
            Assert.True(co.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple aj = new ThalmorTriple();
            Assert.Equal(8.32, aj.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple aj = new ThalmorTriple();
            Assert.Equal(943, (double)aj.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple co = new ThalmorTriple();
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
            co.Bacon = includeBacon;
            if (!includeBacon) Assert.Contains("Hold bacon", co.SpecialInstructions);
            co.Egg = includeEgg;
            if (!includeEgg) Assert.Contains("Hold egg", co.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple aj = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", aj.ToString());
        }
    }
}