/*
 * Author: John Nettles
 * Class name: PhillyPoacher.cs
 * Purpose: to create objects to represent the Philly Cheesesteak
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class that creates the Philly Poacher object (philly cheesesteak)
    /// </summary>
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Property that holds the price
        /// </value>
        public override double Price { get => 7.23; }

        /// <value>
        /// Property that holds the number of calories
        /// </value>
        public override uint Calories { get => 784; }

        /// <value>
        /// Property to hold status of the sirloin. Default true.
        /// </value>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                if (sirloin != value)
                {
                    sirloin = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                }
            }
        }
        private bool sirloin = true;

        /// <value>
        /// Property to hold status of the onion. Default true.
        /// </value>
        public bool Onion
        {
            get => onion;
            set
            {
                if (onion != value)
                {
                    onion = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                }
            }
        }
        private bool onion = true;

        /// <value>
        /// Property to hold status of the roll. Default true.
        /// </value>
        public bool Roll
        {
            get => roll;
            set
            {
                if (roll != value)
                {
                    roll = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                }
            }
        }
        private bool roll = true;

        /// <value>
        /// List holding special instructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Sirloin) specialInstructions.Add("Hold sirloin");
                if (!Onion) specialInstructions.Add("Hold onion");
                if (!Roll) specialInstructions.Add("Hold roll");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> returns a string saying "Philly Poacher" </returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
