using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldHaveAListofEntrees()
        {
            BriarheartBurger a = new BriarheartBurger();
            DoubleDragr b = new DoubleDragr();
            ThalmorTriple c = new ThalmorTriple();
            GardenOrcOmelette d = new GardenOrcOmelette();
            PhillyPoacher e = new PhillyPoacher();
            SmokehouseSkeleton f = new SmokehouseSkeleton();
            ThugsTBone g = new ThugsTBone();
            IEnumerable <IOrderItem> entrees = Menu.Entrees();
            Assert.Collection<IOrderItem>(entrees,
                item => Assert.Equal(item.ToString(), a.ToString()),
            item => Assert.Equal(item.ToString(), b.ToString()),
            item => Assert.Equal(item.ToString(), c.ToString()),
            item => Assert.Equal(item.ToString(), d.ToString()),
            item => Assert.Equal(item.ToString(), e.ToString()),
            item => Assert.Equal(item.ToString(), f.ToString()),
            item => Assert.Equal(item.ToString(), g.ToString())
                );
        }

        [Fact]
        public void ShouldHaveAListOfSides()
        {
            VokunSalad a = new VokunSalad();
            DragonbornWaffleFries b = new DragonbornWaffleFries();
            MadOtarGrits c = new MadOtarGrits();
            FriedMiraak d = new FriedMiraak();
            IEnumerable<IOrderItem> sides = Menu.Sides();
            Assert.Collection<IOrderItem>(sides,
                item => Assert.Equal(item.ToString(), a.ToString()),
            item => Assert.Equal(item.ToString(), b.ToString()),

            item => Assert.Equal(item.ToString(), c.ToString()),
            item => Assert.Equal(item.ToString(), d.ToString()));
        }

        [Fact]
        public void ShouldHaveAListOfDrinks()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            CandlehearthCoffee b = new CandlehearthCoffee();
            MarkarthMilk c = new MarkarthMilk();
            SailorSoda d = new SailorSoda();
            WarriorWater e = new WarriorWater();
            IEnumerable<IOrderItem> sides = Menu.Drinks();
            Assert.Collection<IOrderItem>(sides,
                   item => Assert.Equal(item.ToString(), a.ToString()),
               item => Assert.Equal(item.ToString(), b.ToString()),
               item => Assert.Equal(item.ToString(), c.ToString()),
               item => Assert.Equal(item.ToString(), d.ToString()),
               item => Assert.Equal(item.ToString(), e.ToString()));
        }

        [Fact]
        public void ShouldHaveFullMenu()
        {
            
        }
    }
}
