/*
 * Author: John Nettles
 * Classname: FriedMiraak.cs
 * Purpose: to create objects to represent the hash brown pancakes on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBUffet.Data.Sides
{
    public class FriedMiraak
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

                    price = 1.78;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = 2.01;
                }

                if (Size.Equals(Size.Large))
                {

                    price = 2.88;
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

                    calories = 151;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 236;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 306;
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
            return Size.ToString() + " Fried Miraak";
        }
    }
}
