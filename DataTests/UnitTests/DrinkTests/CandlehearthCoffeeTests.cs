/*
 * Author: John Nettles
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee aj = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(aj);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            Assert.False(co.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            Assert.False(co.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            Assert.False(co.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            Assert.Equal(Size.Small, co.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            co.Ice = true;
            Assert.True(co.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            co.Decaf = true;
            Assert.True(co.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            co.RoomForCream = true;
            Assert.True(co.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            co.Size = Size.Medium;
            Assert.Equal(Size.Medium, co.Size);
            co.Size = Size.Large;
            Assert.Equal(Size.Large, co.Size);
            co.Size = Size.Small;
            Assert.Equal(Size.Small, co.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            co.Size = size;
            Assert.Equal(price, co.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            co.Size = size;
            Assert.Equal(cal, co.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            co.Ice = includeIce;
            co.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", co.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", co.SpecialInstructions);
            if (!includeIce && !includeCream) Assert.Empty(co.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee co = new CandlehearthCoffee();
            co.Size = size;
            co.Decaf = decaf;
            Assert.Equal(name, co.ToString());
        }
    }
}
