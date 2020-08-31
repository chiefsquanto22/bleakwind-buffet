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
                if (Size.Equals(Size.Small))
                {
                    return 1.05;
                }
                if (Size.Equals(Size.Medium))
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }
            }
        }
        /// <summary>
        /// Property to hold the number of Calories based on the size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    return 56;
                }
                if (Size.Equals(Size.Medium))
                {
                    return 72;
                }
                else
                {
                    return 93;
                }
            }
        }
        /// <summary>
        /// Property to hold the status of Ice in the beverage
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Private backing variable for the Size property. Default is small.
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// Property to hold the Size of the beverage
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }
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
        public string ToString()
        {
            return Size + " Markarth Milk";
        }
    }
}
