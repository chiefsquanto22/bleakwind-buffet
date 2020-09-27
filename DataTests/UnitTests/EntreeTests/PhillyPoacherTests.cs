/*
 * Author: John Nettles
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher aj = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(aj);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            PhillyPoacher aj = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher co = new PhillyPoacher();
            Assert.True(co.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher co = new PhillyPoacher();
            Assert.True(co.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher co = new PhillyPoacher();
            Assert.True(co.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher co = new PhillyPoacher();
            co.Sirloin = false;
            Assert.False(co.Sirloin);
            co.Sirloin = true;
            Assert.True(co.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher co = new PhillyPoacher();
            co.Onion = false;
            Assert.False(co.Onion);
            co.Onion = true;
            Assert.True(co.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher co = new PhillyPoacher();
            co.Roll = false;
            Assert.False(co.Roll);
            co.Roll = true;
            Assert.True(co.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher aj = new PhillyPoacher();
            Assert.Equal(7.23, aj.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher aj = new PhillyPoacher();
            Assert.Equal(784, (double)aj.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher co = new PhillyPoacher();
            co.Sirloin = includeSirloin;
            if (!includeSirloin) Assert.Contains("Hold sirloin", co.SpecialInstructions);
            co.Onion = includeOnion;
            if (!includeOnion) Assert.Contains("Hold onion", co.SpecialInstructions);
            co.Roll = includeRoll;
            if (!includeRoll) Assert.Contains("Hold roll", co.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher aj = new PhillyPoacher();
            Assert.Equal("Philly Poacher", aj.ToString());
        }
    }
}