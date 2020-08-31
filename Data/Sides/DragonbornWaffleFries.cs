/*
 * Author: John Nettles
 * Class name: DragonbornWaffleFries.cs
 * Purpose: to create objects to represent waffle fries on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (Size.Equals(Size.Small))
                {

                    price = .42;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = .76;
                }

                if (Size.Equals(Size.Large))
                {

                    price = .96;
                }
            }
        }

        private uint calories;
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                if (Size.Equals(Size.Small))
                {

                    calories = 77;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 89;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 100;
                }
            }
        }
        private Size size = Size.Small;

        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }
        public string ToString()
        {
            return Size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
