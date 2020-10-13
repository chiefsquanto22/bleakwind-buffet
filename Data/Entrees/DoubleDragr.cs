/*
 * Author: John Nettles
 * Class name: DoubleDragr.cs
 * Purpose: To create objects to represent the 1/2lb, double patty burger.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Double Dragr burger
    /// </summary>
    public class DoubleDragr : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Property that holds the price
        /// </value>
        public override double Price { get => 7.32; }

        /// <value>
        /// Property that holds the number of calories
        /// </value>
        public override uint Calories { get => 843; }

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
        /// A list containing any special instructions with the order
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
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string that says "Double Dragr" </returns>
        public override string ToString()
        {
            return "Double Dragr";
        }
    }
}

