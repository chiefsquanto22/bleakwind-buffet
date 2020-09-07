/*
 * Author: John Nettles
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater co = new WarriorWater();
            Assert.True(co.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater co = new WarriorWater();
            Assert.Equal(Size.Small, co.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            WarriorWater co = new WarriorWater();
            co.Ice = true;
            Assert.True(co.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater co = new WarriorWater();
            co.Size = Size.Medium;
            Assert.Equal(Size.Medium, co.Size);
            co.Size = Size.Large;
            Assert.Equal(Size.Large, co.Size);
            co.Size = Size.Small;
            Assert.Equal(Size.Small, co.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater co = new WarriorWater();
            co.Size = size;
            Assert.Equal(price, co.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater co = new WarriorWater();
            co.Size = size;
            Assert.Equal(cal, co.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            WarriorWater co = new WarriorWater();
            co.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", co.SpecialInstructions);
            if (includeIce) Assert.Empty(co.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater co = new WarriorWater();
            co.Size = size;
            Assert.Equal(name, co.ToString());
        }
    }
}