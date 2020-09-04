/*
 * Author: John Nettles
 * Class name: DragonbornWaffleFries.cs
 * Purpose: to create objects to represent waffle fries on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Creates an object to represent Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
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

                    price = .42;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = .76;
                }

                if (Size.Equals(Size.Large))
                {

                    price = .96;
                }
            }
        }

        /// <summary>
        /// private backing variable for Calories
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

                    calories = 77;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 89;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 100;
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
        /// <returns> a string saying "(Size) Dragonborn Waffle Fries"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
