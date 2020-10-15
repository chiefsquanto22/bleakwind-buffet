/*
 * Author: John Nettles
 * Class name: BriarheartBurger.cs
 * Purpose: To create objects to represent the 1/4lb, single patty Burger.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Briarheart Burger
    /// </summary>
    public class BriarheartBurger : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Property that holds the price.
        /// </value>
        public override double Price { get => 6.32; }

        /// <value>
        /// Property that holds the number of calories.
        /// </value>
        public override uint Calories { get => 743; }

        public bool Bun
        {
            get => bun;
            set
            {
                if (bun != value)
                {
                    bun = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                }
            }
        }
        private bool bun = true;
        /// <value>
        /// Property to hold status of the ketchup. Default true.
        /// </value>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                if (ketchup != value)
                {
                    ketchup = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                }
            }
        }
        private bool ketchup = true;

        /// <value>
        /// Property to hold status of the mustard. Default true.
        /// </value>
        public bool Mustard
        {
            get => mustard;
            set
            {
                if (mustard != value)
                {
                    mustard = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                }
            }
        }
        private bool mustard = true;

        /// <value>
        /// Property to hold status of the pickle. Default true.
        /// </value>
        public bool Pickle
        {
            get => pickle;
            set
            {
                if (pickle != value)
                {
                    pickle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                }
            }
        }
        private bool pickle = true;

        /// <value>
        /// Property to hold status of the cheese. Default true.
        /// </value>
        public bool Cheese
        {
            get => cheese;
            set
            {
                if (cheese != value)
                {
                    cheese = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                }
            }
        }
        private bool cheese = true;

        /// <value>
        /// List holding any special instructions for the order
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
