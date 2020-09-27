/*
 * Author: John Nettles
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk aj = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(aj);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MarkarthMilk aj = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk co = new MarkarthMilk();
            Assert.False(co.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk co = new MarkarthMilk();
            Assert.Equal(Size.Small, co.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk co = new MarkarthMilk();
            co.Ice = true;
            Assert.True(co.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk co = new MarkarthMilk();
            co.Size = Size.Medium;
            Assert.Equal(Size.Medium, co.Size);
            co.Size = Size.Large;
            Assert.Equal(Size.Large, co.Size);
            co.Size = Size.Small;
            Assert.Equal(Size.Small, co.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk co = new MarkarthMilk();
            co.Size = size;
            Assert.Equal(price, co.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk co = new MarkarthMilk();
            co.Size = size;
            Assert.Equal(cal, co.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk co = new MarkarthMilk();
            co.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", co.SpecialInstructions);
            if (!includeIce) Assert.Empty(co.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk co = new MarkarthMilk();
            co.Size = size;
            Assert.Equal(name, co.ToString());
        }
    }
}