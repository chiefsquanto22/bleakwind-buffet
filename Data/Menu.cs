using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// 
    /// </summary>
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            IEnumerable<IOrderItem> entrees;
            BriarheartBurger a = new BriarheartBurger();
            DoubleDraugr b = new DoubleDraugr();
            ThalmorTriple c = new ThalmorTriple();
            GardenOrcOmelette d = new GardenOrcOmelette();
            return entrees;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            IEnumerable<IOrderItem> sides;
            sides = 
            return sides;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {

        }

        public static IEnumerable<IOrderItem> FullMenu()
        {

        }
    }
}
