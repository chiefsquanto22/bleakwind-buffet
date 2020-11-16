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

        /// <summary>
        /// A description of the item
        /// </summary>
        public override string Description { get => "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo."; }

        public bool Bun
        {
            get => bun;
            set
            {
                if (bun != value)
                {
                    bun = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        private bool cheese = true;

        /// <value>
        /// Property to hold status of the tomato. Default true.
        /// </value>
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        private bool tomato = true;

        /// <value>
        /// Property to hold status of the lettuce. Default true.
        /// </value>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                if (lettuce != value)
                {
                    lettuce = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        private bool lettuce = true;

        /// <value>
        /// Property to hold status of the mayo. Default true.
        /// </value>
        public bool Mayo
        {
            get => mayo;
            set
            {
                if (mayo != value)
                {
                    mayo = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        private bool mayo = true;

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

