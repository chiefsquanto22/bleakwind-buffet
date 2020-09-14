/*
 * Author: John Nettles
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton aj = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(aj);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton co = new SmokehouseSkeleton();
            Assert.True(co.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton co = new SmokehouseSkeleton();
            Assert.True(co.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton co = new SmokehouseSkeleton();
            Assert.True(co.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton co = new SmokehouseSkeleton();
            Assert.True(co.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton co = new SmokehouseSkeleton();
            co.SausageLink = false;
            Assert.False(co.SausageLink);
            co.SausageLink = true;
            Assert.True(co.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton co = new SmokehouseSkeleton();
            co.Egg = false;
            Assert.False(co.Egg);
            co.Egg = true;
            Assert.True(co.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton co = new SmokehouseSkeleton();
            co.HashBrowns = false;
            Assert.False(co.HashBrowns);
            co.HashBrowns = true;
            Assert.True(co.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton co = new SmokehouseSkeleton();
            co.Pancake = false;
            Assert.False(co.Pancake);
            co.Pancake = true;
            Assert.True(co.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton aj = new SmokehouseSkeleton();
            Assert.Equal(5.62, aj.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton aj = new SmokehouseSkeleton();
            Assert.Equal(602, (double)aj.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton co = new SmokehouseSkeleton();
            co.SausageLink = includeSausage;
            if (!includeSausage) Assert.Contains("Hold sausage", co.SpecialInstructions);
            co.Egg = includeEgg;
            if (!includeEgg) Assert.Contains("Hold egg", co.SpecialInstructions);
            co.HashBrowns = includeHashbrowns;
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", co.SpecialInstructions);
            co.Pancake = includePancake;
            if (!includePancake) Assert.Contains("Hold pancakes", co.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton aj = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", aj.ToString());
        }
    }
}