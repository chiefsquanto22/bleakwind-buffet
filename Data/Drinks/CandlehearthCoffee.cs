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
    /// Class that creates an object to represent CandlehearthCoffee
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <value>
        /// Property to hold the Price of the beverage based on Size
        /// </value>
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

        /// <value>
        /// Property to hold the number of Calories based on Size
        /// </value>
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

        /// <value>
        /// Property to hold the status of Ice ing the beverage
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// Property to hold the status of whether or not the order calls for cream
        /// </value>
        public bool RoomForCream { get; set; } = false;

        /// <value>
        /// Property to hold whether or not the order calls for decaf coffee
        /// </value>
        public bool Decaf { get; set; } = false;

        /// <value>
        /// Property to hold the size of the Size of the beverage
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
                if (RoomForCream) specials.Add("Add cream");
                return specials;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string with the size and type of beverage </returns>
        public override string ToString()
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
