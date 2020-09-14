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
    /// <summary>
    /// Class to represent the Garden Orc Omelette veggie omelette
    /// </summary>
    public class GardenOrcOmelette : Entree
    {
        /// <value>
        /// Property to hold the price
        /// </value>
        public override double Price { get => 4.57; }

        /// <value>
        /// Property to hold the number of Calories
        /// </value>
        public override uint Calories { get => 404; }

        /// <value>
        /// Property to hold status of the broccoli. Default true.
        /// </value>
        public bool Broccoli { get; set; } = true;

        /// <value>
        /// Property to hold status of the mushrooms. Default true.
        /// </value>
        public bool Mushrooms { get; set; } = true;

        /// <value>
        /// Property to hold status of the tomato. Default true.
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Property to hold status of the cheddar. Default true.
        /// </value>
        public bool Cheddar { get; set; } = true;

        /// <value>
        /// List containing special instructions for the order
        /// </value>
        public override List<string> SpecialInstructions
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
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
