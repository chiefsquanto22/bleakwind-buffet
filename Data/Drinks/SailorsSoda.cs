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
    public class SailorsSoda
    {
        /// <summary>
        /// Property to represent the price
        /// </summary>
        public double Price
        {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    return 1.42;
                }
                if (Size.Equals(Size.Medium))
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }
            }
        }

        /// <summary>
        /// Property to hold the number of Calories based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    return 117;
                }
                if (Size.Equals(Size.Medium))
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }
        /// <summary>
        /// Property to hold status of Ice in the order
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Property to hold the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;
        /// <summary>
        /// Private backing variable for the Size property
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// Property to hold the Size of the soda
        /// </summary>
        public Size Size {
            get { return size; }

            set
            {
                size = value;
            }
        }
        /// <summary>
        /// List of special instructions to modify the order
        /// </summary>
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
        public string ToString()
        {
            return Size.ToString() +" "+ Flavor.ToString() + " Sailor Soda";
        }


    }
}
