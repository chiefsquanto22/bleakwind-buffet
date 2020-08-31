/*
 * Author: John Nettles
 * Class name: MadOtarGrits.cs
 * Purpose: to create objects to represent the cheesy grits
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
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

                    price = 1.22;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = 1.58;
                }

                if (Size.Equals(Size.Large))
                {

                    price = 1.93;
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

                    calories = 105;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 142;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 179;
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
            return Size.ToString() + " Mad Otar Grits";
        }
    }
}
