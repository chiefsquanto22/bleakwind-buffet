﻿/*
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
        /// <value>
        /// private backing variable for Price
        /// </value>
        private double price;

        /// <value>
        /// Property that holds the price
        /// </value>
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

        /// <value>
        /// private backing variable for Calories
        /// </value>
        private uint calories;

        /// <value>
        /// Property that holds the number of Calories
        /// </value>
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

        /// <value>
        /// Property that holds the Size
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// An empty list of special instructions
        /// </value>
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
