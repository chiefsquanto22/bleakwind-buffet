﻿/*
 * Author: John Nettles
 * Class name: WarriorWater.cs
 * Purpose: to create objects to represent water on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using System.Xml.Schema;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Creates an object to represent Warrior Water
    /// </summary>
    public class WarriorWater : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// A description of the item
        /// </summary>
        public override string Description { get => "It's water. Just water."; }

        /// <value>
        /// Property to hold price
        /// </value>
        public override double Price { get => 0; }

        /// <value>
        /// Property to hold Calories
        /// </value>
        public override uint Calories { get => 0; }

        private bool ice = true;
        /// <value>
        /// Property to hold status of ice
        /// </value>
        public bool Ice
        {
            get => ice;
            set
            {
                if (ice != value)
                {
                    ice = value;
                    InvokePropertyChanged("Ice");
                    InvokePropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool lemon = false;
        /// <value>
        /// property to hold status of lemon
        /// </value>
        public bool Lemon
        {
            get => lemon;
            set
            {
                if (lemon != value)
                {
                    lemon = value;
                    InvokePropertyChanged("Lemon");
                    InvokePropertyChanged("SpecialInstructions");
                }
            }
        }
        

        /// <value>
        /// Creates a list of special instructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specials = new List<string>();
                if (!Ice) specials.Add("Hold ice");
                if (Lemon) specials.Add("Add lemon");
                return specials;
            }
        }

        

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string with the size and type of order </returns>
        public override string ToString()
        {
                return Size.ToString() + " Warrior Water";
        }
    }
}
