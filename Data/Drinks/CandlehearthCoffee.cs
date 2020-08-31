/*
 * Author: John Nettles
 * Class name: CandlehearthCoffee.cs
 * Purpose: to create objects to represent the coffee option
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to represent CandlehearthCoffee
    /// </summary>
    public class CandlehearthCoffee
    {   
        /// <summary>
        /// Property to hold the Price of the beverage based on Size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    return .75;
                }
                if (Size.Equals(Size.Medium))
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }
        
        /// <summary>
        /// private backing variable for Calories
        /// </summary>
        private uint calories;
        
        /// <summary>
        /// Property to hold the number of Calories based on Size
        /// </summary>
        public uint Calories {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    return 7;
                }
                if (Size.Equals(Size.Medium))
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }
        
        /// <summary>
        /// Property to hold the status of Ice ing the beverage
        /// </summary>
        public bool Ice { get; set; } = false;
        
        /// <summary>
        /// Property to hold the status of whether or not the order calls for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        
        /// <summary>
        /// Property to hold whether or not the order calls for decaf coffee
        /// </summary>
        public bool Decaf { get; set; } = false;
        
        /// <summary>
        /// private backing variable for the Size property
        /// </summary>
        private Size size = Size.Small;
        
        /// <summary>
        /// Property to hold the size of the Size of the beverage
        /// </summary>
        public Size Size
        {
            get { return Size; }
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
                if (RoomForCream) specials.Add("Add cream");
                return specials;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string with the size and type of beverage </returns>
        public string ToString()
        {
            if (Decaf)
            {
                return Size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + " Candlehearth Coffee";
            }
        }
    }
}
