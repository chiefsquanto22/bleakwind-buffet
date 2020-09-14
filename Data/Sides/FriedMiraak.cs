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
    public class FriedMiraak : Side
    {
        /// <value>
        /// Private backing variable for Price
        /// </value>
        private double price;

        /// <value>
        /// Property that holds the Price
        /// </value>
        public override double Price
        {
            get
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
                return price;
            }
        }

        /// <value>
        /// Private backing variable for Calories
        /// </value>
        private uint calories;

        /// <value>
        /// Property that holds the number of Calories
        /// </value>
        public override uint Calories
        {
            get
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
                return calories;
            }
        }

        /// <value>
        /// An empty list of special instructions
        /// </value>
        public override List<string> SpecialInstructions { get => new List<string>(); }

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
