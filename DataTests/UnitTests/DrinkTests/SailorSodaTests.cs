/*
 * Author: John Nettles
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda aj = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(aj);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SailorSoda aj = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda co = new SailorSoda();
            Assert.True(co.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda co = new SailorSoda();
            Assert.Equal(Size.Small, co.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda co = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, co.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda co = new SailorSoda();
            co.Ice = true;
            Assert.True(co.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda co = new SailorSoda();
            co.Size = Size.Medium;
            Assert.Equal(Size.Medium, co.Size);
            co.Size = Size.Large;
            Assert.Equal(Size.Large, co.Size);
            co.Size = Size.Small;
            Assert.Equal(Size.Small, co.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda co = new SailorSoda();
            co.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, co.Flavor);
            co.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, co.Flavor);
            co.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, co.Flavor);
            co.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, co.Flavor);
            co.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, co.Flavor);
            co.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, co.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda co = new SailorSoda();
            co.Size = size;
            Assert.Equal(price, co.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda co = new SailorSoda();
            co.Size = size;
            Assert.Equal(cal, co.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda co = new SailorSoda();
            co.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", co.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda co = new SailorSoda();
            co.Size = size;
            co.Flavor = flavor;
            Assert.Equal(name, co.ToString());
        }
    }
}
