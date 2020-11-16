/*
 * Author: John Nettles
 * Class name: GardenOrcOmelette.cs
 * Purpose: to create objects to represent the Vegeterian Omelette
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Garden Orc Omelette veggie omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Property to hold the price
        /// </value>
        public override double Price { get => 4.57; }

        /// <value>
        /// Property to hold the number of Calories
        /// </value>
        public override uint Calories { get => 404; }

        /// <summary>
        /// A description of the item
        /// </summary>
        public override string Description { get => "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese."; }

        /// <value>
        /// Property to hold status of the broccoli. Default true.
        /// </value>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                if (broccoli != value)
                {
                    broccoli = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        private bool broccoli = true;

        /// <value>
        /// Property to hold status of the mushrooms. Default true.
        /// </value>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (mushrooms != value)
                {
                    mushrooms = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        private bool mushrooms = true;

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
        /// Property to hold status of the cheddar. Default true.
        /// </value>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (cheddar != value)
                {
                    cheddar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        private bool cheddar = true;

        /// <value>
        /// List containing special instructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {

                List<string> specialInstructions = new List<string>();
                if (!Broccoli) specialInstructions.Add("Hold broccoli");
                if (!Mushrooms) specialInstructions.Add("Hold mushrooms");
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Cheddar) specialInstructions.Add("Hold cheddar");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> returns the string "Garden Orc Omelette" </returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
