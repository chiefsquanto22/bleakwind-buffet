using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
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
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
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
            VokunSalad aa = new VokunSalad();
            aa.Size = Size.Small;
            VokunSalad ab = new VokunSalad();
            ab.Size = Size.Medium;
            VokunSalad ac = new VokunSalad();
            ac.Size = Size.Large;
            DragonbornWaffleFries ba = new DragonbornWaffleFries();
            ba.Size = Size.Small;
            DragonbornWaffleFries bb = new DragonbornWaffleFries();
            bb.Size = Size.Medium;
            DragonbornWaffleFries bc = new DragonbornWaffleFries();
            bc.Size = Size.Large;
            MadOtarGrits ca = new MadOtarGrits();
            ca.Size = Size.Small;
            MadOtarGrits cb = new MadOtarGrits();
            cb.Size = Size.Medium;
            MadOtarGrits cc = new MadOtarGrits();
            cc.Size = Size.Large;
            FriedMiraak da = new FriedMiraak();
            da.Size = Size.Small;
            FriedMiraak db = new FriedMiraak();
            db.Size = Size.Medium;
            FriedMiraak dc = new FriedMiraak();
            dc.Size = Size.Large;
            IEnumerable<IOrderItem> sides = Menu.Sides();
            Assert.Collection<IOrderItem>(sides,
                item => Assert.Equal(item.ToString(), aa.ToString()),
            item => Assert.Equal(item.ToString(), ab.ToString()),
            item => Assert.Equal(item.ToString(), ac.ToString()),
            item => Assert.Equal(item.ToString(), ba.ToString()),
            item => Assert.Equal(item.ToString(), bb.ToString()),
            item => Assert.Equal(item.ToString(), bc.ToString()),
            item => Assert.Equal(item.ToString(), ca.ToString()),
            item => Assert.Equal(item.ToString(), cb.ToString()),
            item => Assert.Equal(item.ToString(), cc.ToString()),
            item => Assert.Equal(item.ToString(), da.ToString()),
            item => Assert.Equal(item.ToString(), db.ToString()),
            item => Assert.Equal(item.ToString(), dc.ToString()));
        }

        [Fact]
        public void ShouldHaveAListOfDrinks()
        {
            AretinoAppleJuice aa = new AretinoAppleJuice();
            AretinoAppleJuice ab = new AretinoAppleJuice();
            AretinoAppleJuice ac = new AretinoAppleJuice();
            aa.Size = Size.Small;
            ab.Size = Size.Medium;
            ac.Size = Size.Large;

            CandlehearthCoffee ba = new CandlehearthCoffee();
            CandlehearthCoffee bb = new CandlehearthCoffee();
            CandlehearthCoffee bc = new CandlehearthCoffee();
            CandlehearthCoffee bd = new CandlehearthCoffee();
            CandlehearthCoffee be = new CandlehearthCoffee();
            CandlehearthCoffee bf = new CandlehearthCoffee();
            ba.Size = Size.Small;
            bb.Size = Size.Medium;
            bc.Size = Size.Large;
            bd.Size = Size.Small;
            be.Size = Size.Medium;
            bf.Size = Size.Large;
            bd.RoomForCream = true;
            be.RoomForCream = true;
            bf.RoomForCream = true;

            MarkarthMilk ca = new MarkarthMilk();
            MarkarthMilk cb = new MarkarthMilk();
            MarkarthMilk cc = new MarkarthMilk();
            ca.Size = Size.Small;
            cb.Size = Size.Medium;
            cc.Size = Size.Large;

            SailorSoda da = new SailorSoda();
            da.Flavor = SodaFlavor.Blackberry;
            da.Size = Size.Small;
            SailorSoda db = new SailorSoda();
            db.Flavor = SodaFlavor.Blackberry;
            db.Size = Size.Medium;
            SailorSoda dc = new SailorSoda();
            dc.Flavor = SodaFlavor.Blackberry;
            dc.Size = Size.Large;

            SailorSoda dd = new SailorSoda();
            dd.Flavor = SodaFlavor.Cherry;
            dd.Size = Size.Small;
            SailorSoda de = new SailorSoda();
            de.Flavor = SodaFlavor.Cherry;
            de.Size = Size.Medium;
            SailorSoda df = new SailorSoda();
            df.Flavor = SodaFlavor.Cherry;
            df.Size = Size.Large;

            SailorSoda dg = new SailorSoda();
            dg.Flavor = SodaFlavor.Grapefruit;
            dg.Size = Size.Small;
            SailorSoda dh = new SailorSoda();
            dh.Flavor = SodaFlavor.Grapefruit;
            dh.Size = Size.Medium;
            SailorSoda di = new SailorSoda();
            di.Flavor = SodaFlavor.Grapefruit;
            di.Size = Size.Large;

            SailorSoda dj = new SailorSoda();
            dj.Flavor = SodaFlavor.Lemon;
            dj.Size = Size.Small;
            SailorSoda dk = new SailorSoda();
            dk.Flavor = SodaFlavor.Lemon;
            dk.Size = Size.Medium;
            SailorSoda dl = new SailorSoda();
            dl.Flavor = SodaFlavor.Lemon;
            dl.Size = Size.Large;

            SailorSoda dm = new SailorSoda();
            dm.Flavor = SodaFlavor.Peach;
            dm.Size = Size.Small;
            SailorSoda dn = new SailorSoda();
            dn.Flavor = SodaFlavor.Peach;
            dn.Size = Size.Medium;
            SailorSoda doo = new SailorSoda();
            doo.Flavor = SodaFlavor.Peach;
            doo.Size = Size.Large;

            SailorSoda dp = new SailorSoda();
            dp.Flavor = SodaFlavor.Watermelon;
            dp.Size = Size.Small;
            SailorSoda dq = new SailorSoda();
            dq.Flavor = SodaFlavor.Watermelon;
            dq.Size = Size.Medium;
            SailorSoda dr = new SailorSoda();
            dr.Flavor = SodaFlavor.Watermelon;
            dr.Size = Size.Large;

            WarriorWater ea = new WarriorWater();
            WarriorWater eb = new WarriorWater();
            WarriorWater ec = new WarriorWater();
            ea.Size = Size.Small;
            eb.Size = Size.Medium;
            ec.Size = Size.Large;

            IEnumerable<IOrderItem> sides = Menu.Drinks();
            Assert.Collection<IOrderItem>(sides,
                   item => Assert.Equal(item.ToString(), aa.ToString()),
               item => Assert.Equal(item.ToString(), ab.ToString()),
               item => Assert.Equal(item.ToString(), ac.ToString()),
               item => Assert.Equal(item.ToString(), ba.ToString()),
               item => Assert.Equal(item.ToString(), bb.ToString()),
               item => Assert.Equal(item.ToString(), bc.ToString()),
               item => Assert.Equal(item.ToString(), bd.ToString()),
               item => Assert.Equal(item.ToString(), be.ToString()),
               item => Assert.Equal(item.ToString(), bf.ToString()),
               item => Assert.Equal(item.ToString(), ca.ToString()),
               item => Assert.Equal(item.ToString(), cb.ToString()),
               item => Assert.Equal(item.ToString(), cc.ToString()),
               item => Assert.Equal(item.ToString(), da.ToString()),
               item => Assert.Equal(item.ToString(), db.ToString()),
               item => Assert.Equal(item.ToString(), dc.ToString()),
               item => Assert.Equal(item.ToString(), dd.ToString()),
               item => Assert.Equal(item.ToString(), de.ToString()),
               item => Assert.Equal(item.ToString(), df.ToString()),
               item => Assert.Equal(item.ToString(), dg.ToString()),
               item => Assert.Equal(item.ToString(), dh.ToString()),
               item => Assert.Equal(item.ToString(), di.ToString()),
               item => Assert.Equal(item.ToString(), dj.ToString()),
               item => Assert.Equal(item.ToString(), dk.ToString()),
               item => Assert.Equal(item.ToString(), dl.ToString()),
               item => Assert.Equal(item.ToString(), dm.ToString()),
               item => Assert.Equal(item.ToString(), dn.ToString()),
               item => Assert.Equal(item.ToString(), doo.ToString()),
               item => Assert.Equal(item.ToString(), dp.ToString()),
               item => Assert.Equal(item.ToString(), dq.ToString()),
               item => Assert.Equal(item.ToString(), dr.ToString()),
               item => Assert.Equal(item.ToString(), ea.ToString()),
               item => Assert.Equal(item.ToString(), eb.ToString()),
               item => Assert.Equal(item.ToString(), ec.ToString()));
        }

        [Fact]
        public void ShouldHaveFullMenu()
        {
            BriarheartBurger a = new BriarheartBurger();
            DoubleDragr b = new DoubleDragr();
            ThalmorTriple c = new ThalmorTriple();
            GardenOrcOmelette d = new GardenOrcOmelette();
            PhillyPoacher e = new PhillyPoacher();
            SmokehouseSkeleton f = new SmokehouseSkeleton();
            ThugsTBone g = new ThugsTBone();

            VokunSalad aas = new VokunSalad();
            aas.Size = Size.Small;
            VokunSalad abs = new VokunSalad();
            abs.Size = Size.Medium;
            VokunSalad acs = new VokunSalad();
            acs.Size = Size.Large;

            DragonbornWaffleFries bas = new DragonbornWaffleFries();
            bas.Size = Size.Small;
            DragonbornWaffleFries bbs = new DragonbornWaffleFries();
            bbs.Size = Size.Medium;
            DragonbornWaffleFries bcs = new DragonbornWaffleFries();
            bcs.Size = Size.Large;

            MadOtarGrits cas = new MadOtarGrits();
            cas.Size = Size.Small;
            MadOtarGrits cbs = new MadOtarGrits();
            cbs.Size = Size.Medium;
            MadOtarGrits ccs = new MadOtarGrits();
            ccs.Size = Size.Large;

            FriedMiraak das = new FriedMiraak();
            das.Size = Size.Small;
            FriedMiraak dbs = new FriedMiraak();
            dbs.Size = Size.Medium;
            FriedMiraak dcs = new FriedMiraak();
            dcs.Size = Size.Large;

            AretinoAppleJuice aad = new AretinoAppleJuice();
            AretinoAppleJuice abd = new AretinoAppleJuice();
            AretinoAppleJuice acd = new AretinoAppleJuice();
            aad.Size = Size.Small;
            abd.Size = Size.Medium;
            acd.Size = Size.Large;
            CandlehearthCoffee bad = new CandlehearthCoffee();
            CandlehearthCoffee bbd = new CandlehearthCoffee();
            CandlehearthCoffee bcd = new CandlehearthCoffee();
            CandlehearthCoffee bdd = new CandlehearthCoffee();
            CandlehearthCoffee bed = new CandlehearthCoffee();
            CandlehearthCoffee bfd = new CandlehearthCoffee();
            bad.Size = Size.Small;
            bbd.Size = Size.Medium;
            bcd.Size = Size.Large;
            bdd.Size = Size.Small;
            bed.Size = Size.Medium;
            bfd.Size = Size.Large;
            bdd.RoomForCream = true;
            bed.RoomForCream = true;
            bfd.RoomForCream = true;
            MarkarthMilk cad = new MarkarthMilk();
            MarkarthMilk cbd = new MarkarthMilk();
            MarkarthMilk ccd = new MarkarthMilk();
            cad.Size = Size.Small;
            cbd.Size = Size.Medium;
            ccd.Size = Size.Large;

            SailorSoda dad = new SailorSoda();
            dad.Flavor = SodaFlavor.Blackberry;
            dad.Size = Size.Small;
            SailorSoda dbd = new SailorSoda();
            dbd.Flavor = SodaFlavor.Blackberry;
            dbd.Size = Size.Medium;
            SailorSoda dcd = new SailorSoda();
            dcd.Flavor = SodaFlavor.Blackberry;
            dcd.Size = Size.Large;

            SailorSoda ddd = new SailorSoda();
            ddd.Flavor = SodaFlavor.Cherry;
            ddd.Size = Size.Small;
            SailorSoda ded = new SailorSoda();
            ded.Flavor = SodaFlavor.Cherry;
            ded.Size = Size.Medium;
            SailorSoda dfd = new SailorSoda();
            dfd.Flavor = SodaFlavor.Cherry;
            dfd.Size = Size.Large;

            SailorSoda dgd = new SailorSoda();
            dgd.Flavor = SodaFlavor.Grapefruit;
            dgd.Size = Size.Small;
            SailorSoda dhd = new SailorSoda();
            dhd.Flavor = SodaFlavor.Grapefruit;
            dhd.Size = Size.Medium;
            SailorSoda did = new SailorSoda();
            did.Flavor = SodaFlavor.Grapefruit;
            did.Size = Size.Large;

            SailorSoda djd = new SailorSoda();
            djd.Flavor = SodaFlavor.Lemon;
            djd.Size = Size.Small;
            SailorSoda dkd = new SailorSoda();
            dkd.Flavor = SodaFlavor.Lemon;
            dkd.Size = Size.Medium;
            SailorSoda dld = new SailorSoda();
            dld.Flavor = SodaFlavor.Lemon;
            dld.Size = Size.Large;

            SailorSoda dmd = new SailorSoda();
            dmd.Flavor = SodaFlavor.Peach;
            dmd.Size = Size.Small;
            SailorSoda dnd = new SailorSoda();
            dnd.Flavor = SodaFlavor.Peach;
            dnd.Size = Size.Medium;
            SailorSoda doo = new SailorSoda();
            doo.Flavor = SodaFlavor.Peach;
            doo.Size = Size.Large;

            SailorSoda dpd = new SailorSoda();
            dpd.Flavor = SodaFlavor.Watermelon;
            dpd.Size = Size.Small;
            SailorSoda dqd = new SailorSoda();
            dqd.Flavor = SodaFlavor.Watermelon;
            dqd.Size = Size.Medium;
            SailorSoda drd = new SailorSoda();
            drd.Flavor = SodaFlavor.Watermelon;
            drd.Size = Size.Large;

            WarriorWater ead = new WarriorWater();
            WarriorWater ebd = new WarriorWater();
            WarriorWater ecd = new WarriorWater();
            ead.Size = Size.Small;
            ebd.Size = Size.Medium;
            ecd.Size = Size.Large;

            IEnumerable<IOrderItem> sides = Menu.FullMenu();
            Assert.Collection<IOrderItem>(sides,
                item => Assert.Equal(item.ToString(), a.ToString()),
                item => Assert.Equal(item.ToString(), b.ToString()),
                item => Assert.Equal(item.ToString(), c.ToString()),
                item => Assert.Equal(item.ToString(), d.ToString()),
                item => Assert.Equal(item.ToString(), e.ToString()),
                item => Assert.Equal(item.ToString(), f.ToString()),
                item => Assert.Equal(item.ToString(), g.ToString()),
                item => Assert.Equal(item.ToString(), aas.ToString()),
                item => Assert.Equal(item.ToString(), abs.ToString()),
                item => Assert.Equal(item.ToString(), acs.ToString()),
                item => Assert.Equal(item.ToString(), bas.ToString()),
                item => Assert.Equal(item.ToString(), bbs.ToString()),
                item => Assert.Equal(item.ToString(), bcs.ToString()),
                item => Assert.Equal(item.ToString(), cas.ToString()),
                item => Assert.Equal(item.ToString(), cbs.ToString()),
                item => Assert.Equal(item.ToString(), ccs.ToString()),
                item => Assert.Equal(item.ToString(), das.ToString()),
                item => Assert.Equal(item.ToString(), dbs.ToString()),
                item => Assert.Equal(item.ToString(), dcs.ToString()),
                item => Assert.Equal(item.ToString(), aad.ToString()),
                item => Assert.Equal(item.ToString(), abd.ToString()),
                item => Assert.Equal(item.ToString(), acd.ToString()),
                item => Assert.Equal(item.ToString(), bad.ToString()),
                item => Assert.Equal(item.ToString(), bbd.ToString()),
                item => Assert.Equal(item.ToString(), bcd.ToString()),
                item => Assert.Equal(item.ToString(), bdd.ToString()),
                item => Assert.Equal(item.ToString(), bed.ToString()),
                item => Assert.Equal(item.ToString(), bfd.ToString()),
                item => Assert.Equal(item.ToString(), cad.ToString()),
                item => Assert.Equal(item.ToString(), cbd.ToString()),
                item => Assert.Equal(item.ToString(), ccd.ToString()),
                item => Assert.Equal(item.ToString(), dad.ToString()),
                item => Assert.Equal(item.ToString(), dbd.ToString()),
                item => Assert.Equal(item.ToString(), dcd.ToString()),
                item => Assert.Equal(item.ToString(), ddd.ToString()),
                item => Assert.Equal(item.ToString(), ded.ToString()),
                item => Assert.Equal(item.ToString(), dfd.ToString()),
               item => Assert.Equal(item.ToString(), dgd.ToString()),
               item => Assert.Equal(item.ToString(), dhd.ToString()),
               item => Assert.Equal(item.ToString(), did.ToString()),
               item => Assert.Equal(item.ToString(), djd.ToString()),
               item => Assert.Equal(item.ToString(), dkd.ToString()),
               item => Assert.Equal(item.ToString(), dld.ToString()),
               item => Assert.Equal(item.ToString(), dmd.ToString()),
               item => Assert.Equal(item.ToString(), dnd.ToString()),
               item => Assert.Equal(item.ToString(), doo.ToString()),
               item => Assert.Equal(item.ToString(), dpd.ToString()),
               item => Assert.Equal(item.ToString(), dqd.ToString()),
               item => Assert.Equal(item.ToString(), drd.ToString()),
               item => Assert.Equal(item.ToString(), ead.ToString()),
               item => Assert.Equal(item.ToString(), ebd.ToString()),
               item => Assert.Equal(item.ToString(), ecd.ToString()));
        }
    }
}
