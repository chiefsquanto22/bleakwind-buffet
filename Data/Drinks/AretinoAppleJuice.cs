﻿/*
 * Author: John Nettles 
 * Class name: AretinoAppleJuice.cs
 * Purpose: To create objects to represent the apple juice.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for the Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice
    {

        /// <value>
        /// Property to hold the Price of the beverage based on size
        /// </value>
        public double Price
        {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    return .62;
                }
                if (Size.Equals(Size.Medium))
                {
                    return .87;
                }
                else
                {
                    return 1.01;
                }
            }
        }
        /// <value>
        /// Property to hold the number of Calories based on the size of the beverage
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    return 44;
                }
                if (Size.Equals(Size.Medium))
                {
                    return 88;
                }
                else
                {
                    return 132;
                }
            }
        }

        /// <value>
        /// Property to hold the status of Ice on the order. Default false.
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// Property to hold the size of order.
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
                return specials;
            }
        }
        /// <summary>
        /// Overrides the ToString() method
        /// </summary>
        /// <returns> a string with the size and type of beverage </returns>
        public override string ToString()
        {
            return Size.ToString() + " Aretino Apple Juice";
        }
    }
}