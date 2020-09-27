/*
 * Author: John Nettles
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette aj = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(aj);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette aj = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette co = new GardenOrcOmelette();
            Assert.True(co.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette co = new GardenOrcOmelette();
            Assert.True(co.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette co = new GardenOrcOmelette();
            Assert.True(co.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette co = new GardenOrcOmelette();
            Assert.True(co.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette co = new GardenOrcOmelette();
            co.Broccoli = false;
            Assert.False(co.Broccoli);
            co.Broccoli = true;
            Assert.True(co.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette co = new GardenOrcOmelette();
            co.Mushrooms = false;
            Assert.False(co.Mushrooms);
            co.Mushrooms = true;
            Assert.True(co.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette co = new GardenOrcOmelette();
            co.Tomato = false;
            Assert.False(co.Tomato);
            co.Tomato = true;
            Assert.True(co.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette co = new GardenOrcOmelette();
            co.Cheddar = false;
            Assert.False(co.Cheddar);
            co.Cheddar = true;
            Assert.True(co.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette aj = new GardenOrcOmelette();
            Assert.Equal(4.57, aj.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette aj = new GardenOrcOmelette();
            Assert.Equal(404, (double)aj.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette co = new GardenOrcOmelette();
            co.Broccoli = includeBroccoli;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", co.SpecialInstructions);
            co.Mushrooms = includeMushrooms;
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", co.SpecialInstructions);
            co.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", co.SpecialInstructions);
            co.Cheddar = includeCheddar;
            if (!includeCheddar) Assert.Contains("Hold cheddar", co.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette aj = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", aj.ToString());
        }
    }
}