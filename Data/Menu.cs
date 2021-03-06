﻿/*
 * Author: John Nettles
 * Class name: Menu.cs
 * Purpose: To act as a full menu with each option for each item.
 */
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
    /// Creates an instance of a menu
    /// </summary>
    public static class Menu
    {   

        public static string[] Categories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }
        /// <summary>
        /// Creates a list of all the entrees
        /// </summary>
        /// <return> returns an IEnumerable of all the entrees </returns>
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

        /// <summary>
        /// Creates a list of all the Sides
        /// </summary>
        /// <returns> an IEnumerable of every Side, including each available size</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            VokunSalad aas = new VokunSalad();
            aas.Size = Enums.Size.Small;
            VokunSalad abs = new VokunSalad();
            abs.Size = Enums.Size.Medium;
            VokunSalad acs = new VokunSalad();
            acs.Size = Enums.Size.Large;

            DragonbornWafflefries bas = new DragonbornWafflefries();
            bas.Size = Enums.Size.Small;
            DragonbornWafflefries bbs = new DragonbornWafflefries();
            bbs.Size = Enums.Size.Medium;
            DragonbornWafflefries bcs = new DragonbornWafflefries();
            bcs.Size = Enums.Size.Large;

            MadOtarGrits cas = new MadOtarGrits();
            cas.Size = Enums.Size.Small;
            MadOtarGrits cbs = new MadOtarGrits();
            cbs.Size = Enums.Size.Medium;
            MadOtarGrits ccs = new MadOtarGrits();
            ccs.Size = Enums.Size.Large;

            FriedMiraak das = new FriedMiraak();
            das.Size = Enums.Size.Small;
            FriedMiraak dbs = new FriedMiraak();
            dbs.Size = Enums.Size.Medium;
            FriedMiraak dcs = new FriedMiraak();
            dcs.Size = Enums.Size.Large;

            List<IOrderItem> list = new List<IOrderItem>
            {
                aas,
                abs,
                acs,
                bas,
                bbs,
                bcs,
                cas,
                cbs,
                ccs,
                das,
                dbs,
                dcs
            };
            IEnumerable<IOrderItem> sides = from n in list select n;
            return sides;
        }

        /// <summary>
        /// Creates a list of all the drinks
        /// </summary>
        /// <returns> An IEnumerable with every drink, including every flavor, size, and option</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            AretinoAppleJuice aad = new AretinoAppleJuice();
            AretinoAppleJuice abd = new AretinoAppleJuice();
            AretinoAppleJuice acd = new AretinoAppleJuice();
            aad.Size = Enums.Size.Small;
            abd.Size = Enums.Size.Medium;
            acd.Size = Enums.Size.Large;
            list.Add(aad);
            list.Add(abd);
            list.Add(acd);
            
            CandlehearthCoffee bad = new CandlehearthCoffee();
            CandlehearthCoffee bbd = new CandlehearthCoffee();
            CandlehearthCoffee bcd = new CandlehearthCoffee();
            CandlehearthCoffee bdd = new CandlehearthCoffee();
            CandlehearthCoffee bed = new CandlehearthCoffee();
            CandlehearthCoffee bfd = new CandlehearthCoffee();
            bad.Size = Enums.Size.Small;
            bbd.Size = Enums.Size.Medium;
            bcd.Size = Enums.Size.Large;
            bdd.Size = Enums.Size.Small;
            bed.Size = Enums.Size.Medium;
            bfd.Size = Enums.Size.Large;
            bdd.RoomForCream = true;
            bed.RoomForCream = true;
            bfd.RoomForCream = true;
            list.Add(bad);
            list.Add(bbd);
            list.Add(bcd);
            list.Add(bdd);
            list.Add(bed);
            list.Add(bfd);

            MarkarthMilk cad = new MarkarthMilk();
            MarkarthMilk cbd = new MarkarthMilk();
            MarkarthMilk ccd = new MarkarthMilk();
            cad.Size = Enums.Size.Small;
            cbd.Size = Enums.Size.Medium;
            ccd.Size = Enums.Size.Large;
            list.Add(cad);
            list.Add(cbd);
            list.Add(ccd);

            SailorSoda dad = new SailorSoda();
            dad.Flavor = Enums.SodaFlavor.Blackberry;
            dad.Size = Enums.Size.Small;
            SailorSoda dbd = new SailorSoda();
            dbd.Flavor = Enums.SodaFlavor.Blackberry;
            dbd.Size = Enums.Size.Medium;
            SailorSoda dcd = new SailorSoda();
            dcd.Flavor = Enums.SodaFlavor.Blackberry;
            dcd.Size = Enums.Size.Large;

            SailorSoda ddd = new SailorSoda();
            ddd.Flavor = Enums.SodaFlavor.Cherry;
            ddd.Size = Enums.Size.Small;
            SailorSoda ded = new SailorSoda();
            ded.Flavor = Enums.SodaFlavor.Cherry;
            ded.Size = Enums.Size.Medium;
            SailorSoda dfd = new SailorSoda();
            dfd.Flavor = Enums.SodaFlavor.Cherry;
            dfd.Size = Enums.Size.Large;

            SailorSoda dgd = new SailorSoda();
            dgd.Flavor = Enums.SodaFlavor.Grapefruit;
            dgd.Size = Enums.Size.Small;
            SailorSoda dhd = new SailorSoda();
            dhd.Flavor = Enums.SodaFlavor.Grapefruit;
            dhd.Size = Enums.Size.Medium;
            SailorSoda did = new SailorSoda();
            did.Flavor = Enums.SodaFlavor.Grapefruit;
            did.Size = Enums.Size.Large;

            SailorSoda djd = new SailorSoda();
            djd.Flavor = Enums.SodaFlavor.Lemon;
            djd.Size = Enums.Size.Small;
            SailorSoda dkd = new SailorSoda();
            dkd.Flavor = Enums.SodaFlavor.Lemon;
            dkd.Size = Enums.Size.Medium;
            SailorSoda dld = new SailorSoda();
            dld.Flavor = Enums.SodaFlavor.Lemon;
            dld.Size = Enums.Size.Large;

            SailorSoda dmd = new SailorSoda();
            dmd.Flavor = Enums.SodaFlavor.Peach;
            dmd.Size = Enums.Size.Small;
            SailorSoda dnd = new SailorSoda();
            dnd.Flavor = Enums.SodaFlavor.Peach;
            dnd.Size = Enums.Size.Medium;
            SailorSoda doo = new SailorSoda();
            doo.Flavor = Enums.SodaFlavor.Peach;
            doo.Size = Enums.Size.Large;

            SailorSoda dpd = new SailorSoda();
            dpd.Flavor = Enums.SodaFlavor.Watermelon;
            dpd.Size = Enums.Size.Small;
            SailorSoda dqd = new SailorSoda();
            dqd.Flavor = Enums.SodaFlavor.Watermelon;
            dqd.Size = Enums.Size.Medium;
            SailorSoda drd = new SailorSoda();
            drd.Flavor = Enums.SodaFlavor.Watermelon;
            drd.Size = Enums.Size.Large;

            list.Add(dad);
            list.Add(dbd);
            list.Add(dcd);
            list.Add(ddd);
            list.Add(ded);
            list.Add(dfd);
            list.Add(dgd);
            list.Add(dhd);
            list.Add(did);
            list.Add(djd);
            list.Add(dkd);
            list.Add(dld);
            list.Add(dmd);
            list.Add(dnd);
            list.Add(doo);
            list.Add(dpd);
            list.Add(dqd);
            list.Add(drd);


            WarriorWater ead = new WarriorWater();
            WarriorWater ebd = new WarriorWater();
            WarriorWater ecd = new WarriorWater();
            ead.Size = Enums.Size.Small;
            ebd.Size = Enums.Size.Medium;
            ecd.Size = Enums.Size.Large;
            list.Add(ead);
            list.Add(ebd);
            list.Add(ecd);
            IEnumerable<IOrderItem> drinks = from n in list select n;
            return drinks;
        }

        /// <summary>
        /// Creates a list of every item on the menu
        /// </summary>
        /// <returns>an IEnumerable of every item on the menu, including every size, flavor, and option</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            
            foreach(Entree entree in Entrees())
            {
                list.Add(entree);
            }
            foreach(Side side in Sides())
            {
                list.Add(side);
            }

            foreach(Drink drink in Drinks())
            {
                list.Add(drink);
            }

            IEnumerable<IOrderItem> menu = from n in list select n;
          
            return menu;
        }

        /// <summary>
        /// Filters the menu based on the search bar
        /// </summary>
        /// <param name="items"> the menu </param>
        /// <param name="searchTerms"> the search terms entered in the search bar </param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string searchTerms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            // null check
            if (searchTerms == null) return items;

            foreach (IOrderItem item in items)
            {
                // Add the item if title has a match
                if (item.ToString().Contains(searchTerms))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the menu by category
        /// </summary>
        /// <param name="items"> the menu </param>
        /// <param name="category"> the selected categories </param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> category)
        {
            if (category == null || category.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if (item.GetType().ToString().Equals(category.ToString()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the menu based on Calories
        /// </summary>
        /// <param name="items"> the list of items on the menu </param>
        /// <param name="min"> the minimum calories </param>
        /// <param name="max"> the maximum calories </param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the menu based on Price
        /// </summary>
        /// <param name="items"> the menu </param>
        /// <param name="min"> the minimum price </param>
        /// <param name="max"> the maximum price </param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
