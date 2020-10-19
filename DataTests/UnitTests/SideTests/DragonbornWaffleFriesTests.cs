/*
 * Author: John Nettles
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            var var = new DragonbornWafflefries();
            Assert.PropertyChanged(var, "Size", () =>
            {
                var.Size = size;
            });
        }
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWafflefries aj = new DragonbornWafflefries();
            Assert.IsAssignableFrom<Side>(aj);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DragonbornWafflefries aj = new DragonbornWafflefries();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWafflefries aj = new DragonbornWafflefries();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWafflefries aj = new DragonbornWafflefries();
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
            DragonbornWafflefries aj = new DragonbornWafflefries();
            Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWafflefries aj = new DragonbornWafflefries();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint cal)
        {
            DragonbornWafflefries aj = new DragonbornWafflefries();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWafflefries aj = new DragonbornWafflefries();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }
    }
}