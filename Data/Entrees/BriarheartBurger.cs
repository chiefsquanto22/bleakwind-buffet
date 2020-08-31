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
    public class BriarheartBurger
    {
        /// <summary>
        /// Property that holds the price.
        /// </summary>
        public double Price { get => 6.32; }
        /// <summary>
        /// Property that holds the number of calories.
        /// </summary>
        public uint Calories { get => 743; }
        /// <summary>
        /// Property to hold status of the bun. Default true.
        /// </summary>
        public bool Bun { get; set; }
        /// <summary>
        /// Property to hold status of the ketchup. Default true.
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Property to hold status of the mustard. Default true.
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Property to hold status of the pickle. Default true.
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Property to hold status of the cheese. Default true.
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// List holding any special instructions for the order
        /// </summary>
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
        public string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
