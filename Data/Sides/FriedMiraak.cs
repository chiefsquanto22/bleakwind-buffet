/*
 * Author: John Nettles
 * Classname: FriedMiraak.cs
 * Purpose: to create objects to represent the hash brown pancakes on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Creates objects to represent Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        /// <summary>
        /// Private backing variable for Price
        /// </summary>
        private double price;

        /// <summary>
        /// Property that holds the Price
        /// </summary>
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

                    price = 1.78;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = 2.01;
                }

                if (Size.Equals(Size.Large))
                {

                    price = 2.88;
                }
            }
        }

        /// <summary>
        /// Private backing variable for Calories
        /// </summary>
        private uint calories;

        /// <summary>
        /// Property that holds the number of Calories
        /// </summary>
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

                    calories = 151;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 236;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 306;
                }
            }
        }

        /// <summary>
        /// Property that holds the Size
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// An empty list of special instructions
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns>a string that says "(Size) Fried Miraak"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Fried Miraak";
        }
    }
}
