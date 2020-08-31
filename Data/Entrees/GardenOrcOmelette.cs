/*
 * Author: John Nettles
 * Class name: GardenOrcOmelette.cs
 * Purpose: to create objects to represent the Vegeterian Omelette
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Property to hold the price
        /// </summary>
        public double Price { get => 4.57; }
        /// <summary>
        /// Property to hold the number of Calories
        /// </summary>
        public uint Calories { get => 404; }
        /// <summary>
        /// Property to hold status of the broccoli. Default true.
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// Property to hold status of the mushrooms. Default true.
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// Property to hold status of the tomato. Default true.
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Property to hold status of the cheddar. Default true.
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// List containing special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {

                List<string> specialInstructions = new List<string>();
                if (!Broccoli) specialInstructions.Add("Hold broccoli");
                if (!Mushrooms) specialInstructions.Add("Hold mushrooms");
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Cheddar) specialInstructions.Add("Hold cheddar");
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> returns the string "Garden Orc Omelette" </returns>
        public string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
