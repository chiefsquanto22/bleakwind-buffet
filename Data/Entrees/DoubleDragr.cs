/*
 * Author: John Nettles
 * Class name: DoubleDragr.cs
 * Purpose: To create objects to represent the 1/2lb, double patty burger.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDragr
    {
        /// <summary>
        /// Property that holds the price
        /// </summary>
        public double Price { get => 7.32; }
        /// <summary>
        /// Property that holds the number of calories
        /// </summary>
        public uint Calories { get => 843; }
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
        /// Property to hold status of the tomato. Default true.
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Property to hold status of the lettuce. Default true.
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Property to hold status of the mayo. Default true.
        /// </summary>
        public bool Mayo { get; set; } = true;

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
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Lettuce) specialInstructions.Add("Hold lettuce");
                if (!Mayo) specialInstructions.Add("Hold mayo");
                return specialInstructions;
            }
        }

        public string ToString()
        {
            return "Double Dragr";
        }
    }
}

