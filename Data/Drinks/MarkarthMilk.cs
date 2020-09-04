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
        /// <summary>
        /// Private backing variable for Price
        /// </summary>
        private double price;

        /// <summary>
        /// Property to hold the Price
        /// </summary>
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
                else
                {
                    price = 1.05;
                }
                return price;
            }
        }

        /// <summary>
        /// Private backing variable for Calories.
        /// </summary>
        private uint calories;

        /// <summary>
        /// Property to hold the number of Calories based on the size
        /// </summary>
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
                else
                {
                    calories = 93;
                }
                return calories;
            }
        }

        /// <summary>
        /// Property to hold the status of Ice in the beverage
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Property to hold the Size of the beverage
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// List to hold any special instructions for the order
        /// </summary>
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
