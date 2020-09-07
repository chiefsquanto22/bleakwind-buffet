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
    /// <summary>
    /// Class to represent the Sailor's Soda option
    /// </summary>
    public class SailorSoda
    {
        /// <value>
        /// Private backing variable for Price
        /// </value>
        private double price;

        /// <value>
        /// Property to represent the price
        /// </value>
        public double Price
        {
            get
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
                return price;
            }
        }
        /// <value>
        /// Private backing variable for Calories
        /// </value>
        private uint calories;

        /// <value>
        /// Property to hold the number of Calories based on size
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    calories = 117;
                }
                if (Size.Equals(Size.Medium))
                {
                    calories = 153;
                }
                if(Size.Equals(Size.Large))
                {
                    calories = 205;
                }
                return calories;
            }
        }
        /// <value>
        /// Property to hold status of Ice in the order
        /// </value>
        public bool Ice { get; set; } = true;

        /// <value>
        /// Property to hold the flavor of the soda
        /// </value>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        /// <value>
        /// Property to hold the Size of the soda
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// List of special instructions to modify the order
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specials = new List<string>();
                if (!Ice) specials.Add("Hold ice");
                return specials;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string witht the size and flavor of the Sailor's Soda</returns>
        public override string ToString()
        {
            return Size.ToString() +" "+ Flavor.ToString() + " Sailor Soda";
        }
    }
}
