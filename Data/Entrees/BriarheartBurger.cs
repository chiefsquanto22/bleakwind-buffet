/*
 * Author: John Nettles
 * Class name: BriarheartBurger.cs
 * Purpose: To create objects to represent the 1/4lb, single patty Burger.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <value>
        /// Property that holds the price.
        /// </value>
        public double Price { get => 6.32; }

        /// <value>
        /// Property that holds the number of calories.
        /// </value>
        public uint Calories { get => 743; }

        /// <value>
        /// Property to hold status of the bun. Default true.
        /// </value>
        public bool Bun { get; set; } = true;

        /// <value>
        /// Property to hold status of the ketchup. Default true.
        /// </value>
        public bool Ketchup { get; set; } = true;

        /// <value>
        /// Property to hold status of the mustard. Default true.
        /// </value>
        public bool Mustard { get; set; } = true;

        /// <value>
        /// Property to hold status of the pickle. Default true.
        /// </value>
        public bool Pickle { get; set; } = true;

        /// <value>
        /// Property to hold status of the cheese. Default true.
        /// </value>
        public bool Cheese { get; set; } = true;

        /// <value>
        /// List holding any special instructions for the order
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Bun) { specialInstructions.Add("Hold bun"); }
                if (!Ketchup) { specialInstructions.Add("Hold ketchup"); }
                if (!Mustard) { specialInstructions.Add("Hold mustard"); }
                if (!Pickle) specialInstructions.Add("Hold pickle");
                if (!Cheese) specialInstructions.Add("Hold cheese");
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> returns the string "Briarheart Burger"</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
