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
    /// <summary>
    /// Class to represent Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        /// <value>
        /// Private backing variable for Price
        /// </value>
        private double price;

        /// <value>
        /// Property to hold the Price
        /// </value>
        public double Price
        {
            get
            {
                if (Size.Equals(Size.Medium))
                {
                    price = 1.11;
                }
                if (Size.Equals(Size.Large))
                {
                    price = 1.22;
                }
                if (Size.Equals(Size.Small))
                {
                    price = 1.05;
                }
                return price;
            }
        }

        /// <value>
        /// Private backing variable for Calories.
        /// </value>
        private uint calories;

        /// <value>
        /// Property to hold the number of Calories based on the size
        /// </value>
        public uint Calories
        {
            get
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
                return calories;
            }
        }

        /// <value>
        /// Property to hold the status of Ice in the beverage
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// Property to hold the Size of the beverage
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// List to hold any special instructions for the order
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specials = new List<string>();
                if (Ice) specials.Add("Add ice");
                return specials;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string with the size and name of beverage </returns>
        public override string ToString()
        {
            return Size.ToString() + " Markarth Milk";
        }
    }
}
