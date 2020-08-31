/*
 * Author: John Nettles
 * Class name: VokunSalad.cs
 * Purpose: to create objects to represent the fruit salad option on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
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

                    price = .93;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = 1.28;
                }

                if (Size.Equals(Size.Large))
                {

                    price = 1.82;
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

                    calories = 41;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 52;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 73;
                }
            }
        }
        private Size size = Size.Small;
        public Size Size
        {
            get { return Size; }
            set
            {
                size = value;
            }
        }
        public string ToString()
        {
            return Size.ToString() + " Vokun Salad";
        }
    }
}
