/*
 * Author: John Nettles 
 * Class name: MarkarthMilk.cs
 * Purpose: to create objects to represent the milk option on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
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

                    price = 1.05;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = 1.11;
                }

                if (Size.Equals(Size.Large))
                {

                    price = 1.22;
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

                    calories = 56;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 72;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 93;
                }
            }
        }
        public bool Ice { get; set; } = false;
        private Size size = Size.Small;
        public Size Size
        {
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
                if (Ice) specials.Add("Add ice");
                return specials;
            }
        }
        public string ToString()
        {
            return Size + " Markarth Milk";
        }
    }
}
