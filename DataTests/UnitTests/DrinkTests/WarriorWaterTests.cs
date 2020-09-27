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
        public void ShouldBeADrink()
        {
            WarriorWater aj = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(aj);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            WarriorWater aj = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater co = new WarriorWater();
            Assert.True(co.Ice);
        }
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater co = new WarriorWater();
            Assert.False(co.Lemon);
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
            co.Ice = false;
            Assert.False(co.Ice);
            co.Ice = true;
            Assert.True(co.Ice);
        }
        [Fact]
        public void ShouldByAbleToLemonIce()
        {
            WarriorWater co = new WarriorWater();
            co.Lemon = true;
            Assert.True(co.Lemon);
            co.Lemon = false;
            Assert.False(co.Lemon);
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
        [InlineData(true, true)]
        [InlineData(false, false)]
        [InlineData(false, true)]
        [InlineData(true, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater co = new WarriorWater();
            co.Ice = includeIce;
            co.Lemon = includeLemon;
            if (!includeIce) Assert.Contains("Hold ice", co.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", co.SpecialInstructions);
            if (includeIce && !includeLemon) Assert.Empty(co.SpecialInstructions);
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