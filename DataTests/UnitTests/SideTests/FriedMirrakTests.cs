/*
 * Author: John Nettles
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak aj = new FriedMiraak();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak aj = new FriedMiraak();
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak aj = new FriedMiraak();
            Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak aj = new FriedMiraak();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint cal)
        {
            FriedMiraak aj = new FriedMiraak();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak aj = new FriedMiraak();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }
    }
}