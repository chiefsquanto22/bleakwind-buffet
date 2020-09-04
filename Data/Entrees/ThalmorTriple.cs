/*
 * Author: John Nettles
 * Class name: ThalmorTriple.cs
 * Purpose: To create objects to represent the 1lb, triple payy burger.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Property to represent the Price
        /// </summary>
        public double Price { get => 8.32; }

        /// <summary>
        /// Property to represent the Calories
        /// </summary>
        public uint Calories { get => 943; }

        /// <summary>
        /// Property to hold status of the bun. Default true.
        /// </summary>
        public bool Bun { get; set; } = true;

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

        /// <summary>
        /// Property to hold status of the bacon. Default true.
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Property to hold status of the egg. Default true.
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// A list containing special instructions based on the order
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
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Lettuce) specialInstructions.Add("Hold lettuce");
                if (!Mayo) specialInstructions.Add("Hold mayo");
                if (!Bacon) specialInstructions.Add("Hold bacon");
                if (!Egg) specialInstructions.Add("Hold egg");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> returns a string saying "Thalmor Triple" </returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
