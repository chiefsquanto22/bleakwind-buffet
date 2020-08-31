/*
 * Author: John Nettles
 * Class name: PhillyPoacher.cs
 * Purpose: to create objects to represent the Philly Cheesesteak
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Property that holds the price
        /// </summary>
        public double Price { get => 7.23; }
        /// <summary>
        /// Property that holds the number of calories
        /// </summary>
        public uint Calories { get => 784; }

        /// <summary>
        /// Property to hold status of the sirloin. Default true.
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// Property to hold status of the onion. Default true.
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// Property to hold status of the roll. Default true.
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// List holding special instructions for the order
        /// </summary>
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
        public string ToString()
        {
            return "Philly Poacher";
        }
    }
}
