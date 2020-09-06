/*
 * Author: John Nettles
 * Class name: WarriorWater.cs
 * Purpose: to create objects to represent water on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Creates an object to represent Warrior Water
    /// </summary>
    public class WarriorWater
    {
        /// <value>
        /// Property to hold price
        /// </value>
        public double Price { get => 0; }

        /// <value>
        /// Property to hold Calories
        /// </value>
        public uint Calories { get => 0; }

        /// <value>
        /// Property to hold status of ice
        /// </value>
        public bool Ice { get; set; } = true;

        /// <value>
        /// property to hold status of lemon
        /// </value>
        public bool Lemon { get; set; } = false;

        /// <value>
        /// property to hold status of size
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// Creates a list of special instructions for the order
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specials = new List<string>();
                if (!Ice) specials.Add("Hold ice");
                if (Lemon) specials.Add("Add lemon");
                return specials;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string with the size and type of order </returns>
        public override string ToString()
        {
                return Size.ToString() + " Warrior Water";
        }
    }
}
