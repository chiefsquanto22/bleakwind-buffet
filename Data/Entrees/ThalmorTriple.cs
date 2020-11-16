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

        /// <summary>
        /// A description of the item
        /// </summary>
        public override string Description { get => "Think you are strong enough to take on the Thalmor? Includes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg."; }

        /// <value>
        /// Property to hold status of the tomato. Default true.
        /// </value>
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
        /// Property to hold status of the bacon. Default true.
        /// </value>
        public bool Bacon
        {
            get => bacon;
            set
            {
                if (bacon != value)
                {
                    bacon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        private bool bacon = true;

        /// <value>
        /// Property to hold status of the egg. Default true.
        /// </value>
        public bool Egg
        {
            get => egg;
            set
            {
                if (egg != value)
                {
                    egg = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        private bool egg = true;

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
