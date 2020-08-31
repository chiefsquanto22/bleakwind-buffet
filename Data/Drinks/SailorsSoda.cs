/*
 * Author: John Nettles
 * Class name: SailorSoda.cs
 * Purpose: to create objects to represent the soda and flavors available
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorsSoda
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

                    price = 1.42;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = 1.74;
                }

                if (Size.Equals(Size.Large))
                {

                    price = 2.07;
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

                    calories = 117;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 153;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 205;
                }
            }
        }
        public bool Ice { get; set; } = true;
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        private Size size = Size.Small;
        public Size Size {
            get { return size; }

            set
            {
                size = value;
            }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specials = new List<string>();
                if (!Ice) specials.Add("Hold ice");
                return specials;
            }
        }

        public string ToString()
        {
            return Size.ToString() +" "+ Flavor.ToString() + " Sailor Soda";
        }


    }
}
