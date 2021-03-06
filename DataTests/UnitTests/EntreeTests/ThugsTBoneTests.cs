﻿/*
 * Author: John Nettles
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone aj = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(aj);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThugsTBone aj = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone aj = new ThugsTBone();
            Assert.Equal(6.44, aj.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone aj = new ThugsTBone();
            Assert.Equal(982, (double)aj.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone aj = new ThugsTBone();
            Assert.Empty(aj.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone aj = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", aj.ToString());
        }
    }
}