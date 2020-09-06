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
        /// <value>
        /// Private backing variable for Price
        /// </value>
        private double price;

        /// <value>
        /// Property that holds the price
        /// </value>
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

        /// <value>
        /// private backing variables for Calories
        /// </value>
        private uint calories;

        /// <value>
        /// Property that holds the number of Calories 
        /// </value>
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

        /// <value>
        /// Property that holds the Size
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// An empty list of special instructions
        /// </value>
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
