/*
 * Author: John Nettles
 * Class name: ThalmorTriple.cs
 * Purpose: To create objects to represent the 1lb, triple patty burger.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Creates an object to represent the Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Property to represent the Price
        /// </value>
        public override double Price { get => 8.32; }

        /// <value>
        /// Property to represent the Calories
        /// </value>
        public override uint Calories { get => 943; }

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
        /// Property to hold status of the tomato. Default true.
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Property to hold status of the lettuce. Default true.
        /// </value>
        public bool Lettuce { get; set; } = true;

        /// <value>
        /// Property to hold status of the mayo. Default true.
        /// </value>
        public bool Mayo { get; set; } = true;

        /// <value>
        /// Property to hold status of the bacon. Default true.
        /// </value>
        public bool Bacon { get; set; } = true;

        /// <value>
        /// Property to hold status of the egg. Default true.
        /// </value>
        public bool Egg { get; set; } = true;

        /// <value>
        /// A list containing special instructions based on the order
        /// </value>
        public override List<string> SpecialInstructions
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
