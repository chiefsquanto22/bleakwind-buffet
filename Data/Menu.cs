using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Linq;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// 
    /// </summary>
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {

            BriarheartBurger a = new BriarheartBurger();
            DoubleDragr b = new DoubleDragr();
            ThalmorTriple c = new ThalmorTriple();
            GardenOrcOmelette d = new GardenOrcOmelette();
            PhillyPoacher e = new PhillyPoacher();
            SmokehouseSkeleton f = new SmokehouseSkeleton();
            ThugsTBone g = new ThugsTBone();
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            list.Add(e);
            list.Add(f);
            list.Add(g);
            IEnumerable<IOrderItem> entrees = from n in list select n;
            return entrees;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            VokunSalad a = new VokunSalad();
            DragonbornWaffleFries b = new DragonbornWaffleFries();
            MadOtarGrits c = new MadOtarGrits();
            FriedMiraak d = new FriedMiraak();
            List<IOrderItem> list = new List<IOrderItem>();
            for (int i = 0; i < 3; i++)
            {
                a.Size = (Enums.Size)i;
                list.Add(a);

            }
            for (int i = 0; i < 3; i++)
            {
                b.Size = (Enums.Size)i;
                list.Add(b);

            }
            for (int i = 0; i < 3; i++)
            {
                c.Size = (Enums.Size)i;
                list.Add(c);

            }
            for (int i = 0; i < 3; i++)
            {
                d.Size = (Enums.Size)i;
                list.Add(d);

            }
            IEnumerable<IOrderItem> sides = from n in list select n;


            return sides;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            AretinoAppleJuice a = new AretinoAppleJuice();
            for (int i = 0; i < 3; i++)
            {
                a.Size = (Enums.Size)i;
                list.Add(a);

            }
            CandlehearthCoffee b = new CandlehearthCoffee();
            for (int i = 0; i < 3; i++)
            {
                b.Size = (Enums.Size)i;
                list.Add(b);
                b.RoomForCream = true;
                list.Add(b);

            }
            MarkarthMilk c = new MarkarthMilk();
            for (int i = 0; i < 3; i++)
            {
                c.Size = (Enums.Size)i;
                list.Add(c);

            }
            SailorSoda d = new SailorSoda();

            for (int i = 0; i < 3; i++)
            {
                d.Size = (Enums.Size)i;
                for (int j = 0; j < 7; j++)
                {
                    d.Flavor = (Enums.SodaFlavor)j;
                    list.Add(d);
                }


            }
            WarriorWater e = new WarriorWater();
            for (int i = 0; i < 3; i++)
            {
                e.Size = (Enums.Size)i;
                list.Add(e);
            }
            IEnumerable<IOrderItem> drinks = from n in list select n;
            return drinks;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            BriarheartBurger a = new BriarheartBurger();
            DoubleDragr b = new DoubleDragr();
            ThalmorTriple c = new ThalmorTriple();
            GardenOrcOmelette d = new GardenOrcOmelette();
            PhillyPoacher e = new PhillyPoacher();
            SmokehouseSkeleton f = new SmokehouseSkeleton();
            ThugsTBone g = new ThugsTBone();

            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            list.Add(e);
            list.Add(f);
            list.Add(g);

            VokunSalad vs = new VokunSalad();
            DragonbornWaffleFries db = new DragonbornWaffleFries();
            MadOtarGrits mo = new MadOtarGrits();
            FriedMiraak fm = new FriedMiraak();

            list.Add(vs);
            list.Add(db);
            list.Add(mo);
            list.Add(fm);

            AretinoAppleJuice aa = new AretinoAppleJuice();
            for (int i = 0; i < 3; i++)
            {
                aa.Size = (Enums.Size)i;
                list.Add(aa);

            }
            CandlehearthCoffee bb = new CandlehearthCoffee();
            for (int i = 0; i < 3; i++)
            {
                bb.Size = (Enums.Size)i;
                list.Add(bb);
                bb.RoomForCream = true;
                list.Add(bb);

            }
            MarkarthMilk cc = new MarkarthMilk();
            for (int i = 0; i < 3; i++)
            {
                cc.Size = (Enums.Size)i;
                list.Add(cc);

            }
            SailorSoda dd = new SailorSoda();

            for (int i = 0; i < 3; i++)
            {
                dd.Size = (Enums.Size)i;
                for (int j = 0; j < 7; j++)
                {
                    dd.Flavor = (Enums.SodaFlavor)j;
                    list.Add(dd);
                }
            }
            WarriorWater ee = new WarriorWater();
            for (int i = 0; i < 3; i++)
            {
                ee.Size = (Enums.Size)i;
                list.Add(ee);
            }
            IEnumerable<IOrderItem> menu = from n in list select n;
            return menu;
        }
    }
}
