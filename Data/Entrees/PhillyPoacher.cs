﻿/*
 * Author: John Nettles
 * Class name: PhillyPoacher.cs
 * Purpose: to create objects to represent the Philly Cheesesteak
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class that creates the Philly Poacher object (philly cheesesteak)
    /// </summary>
    public class PhillyPoacher
    {
        /// <value>
        /// Property that holds the price
        /// </value>
        public double Price { get => 7.23; }

        /// <value>
        /// Property that holds the number of calories
        /// </value>
        public uint Calories { get => 784; }

        /// <value>
        /// Property to hold status of the sirloin. Default true.
        /// </value>
        public bool Sirloin { get; set; } = true;

        /// <value>
        /// Property to hold status of the onion. Default true.
        /// </value>
        public bool Onion { get; set; } = true;

        /// <value>
        /// Property to hold status of the roll. Default true.
        /// </value>
        public bool Roll { get; set; } = true;

        /// <value>
        /// List holding special instructions for the order
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Sirloin) specialInstructions.Add("Hold sirloin");
                if (!Onion) specialInstructions.Add("Hold onion");
                if (!Roll) specialInstructions.Add("Hold roll");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> returns a string saying "Philly Poacher" </returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}