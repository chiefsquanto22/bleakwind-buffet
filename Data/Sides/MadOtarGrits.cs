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
    /// <summary>
    /// Creates an object that represents Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// Private backing variable for Price
        /// </summary>
        private double price;

        /// <summary>
        /// Property that holds the price
        /// </summary>
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

        /// <summary>
        /// private backing variables for Calories
        /// </summary>
        private uint calories;

        /// <summary>
        /// Property that holds the number of Calories 
        /// </summary>
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

        /// <summary>
        /// Property that holds the Size
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// An empty list of special instructions
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns>a string that says "(Size) Mad Otar Grits</returns>
        public override string ToString()
        {
            return Size.ToString() + " Mad Otar Grits";
        }
    }
}
