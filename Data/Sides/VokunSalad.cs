/*
 * Author: John Nettles
 * Class name: VokunSalad.cs
 * Purpose: to create objects to represent the fruit salad option on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Creates objects to represent Vokun Salad
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// private backing variable for Price
        /// </summary>
        private double price;

        /// <summary>
        /// Property that holds the price
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

                    price = .93;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = 1.28;
                }

                if (Size.Equals(Size.Large))
                {

                    price = 1.82;
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

                    calories = 41;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 52;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 73;
                }
            }
        }

        /// <summary>
        /// Property that holds the size of the salad
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// An empty list of special instructions
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string that says "(Size) Vokun Salad"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Vokun Salad";
        }
    }
}
