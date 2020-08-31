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
    /// Represents Warrior Water
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// Property to hold price
        /// </summary>
        public double Price { get => 0; }
        /// <summary>
        /// Property to hold Calories
        /// </summary>
        public uint Calories { get => 0; }
        /// <summary>
        /// Property to hold status of ice
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// property to hold status of lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// property to hold status of size
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// Creates a list of special instructions for the order
        /// </summary>
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
        public string ToString()
        {
                return Size.ToString() + " Warrior Water";
        }
    }
}
