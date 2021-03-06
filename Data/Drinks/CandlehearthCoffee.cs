﻿/*
 * Author: John Nettles
 * Class name: CandlehearthCoffee.cs
 * Purpose: to create objects to represent the coffee option
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class that creates an object to represent CandlehearthCoffee
    /// </summary>
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// A description of the item
        /// </summary>
        public override string Description { get => "Fair trade, fresh ground dark roast coffee."; }

        /// <value>
        /// Property to hold the Price of the beverage based on Size
        /// </value>
        public override double Price
        {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    return .75;
                }
                if (Size.Equals(Size.Medium))
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }

        /// <value>
        /// Property to hold the number of Calories based on Size
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small))
                {
                    return 7;
                }
                if (Size.Equals(Size.Medium))
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }

        private bool ice = false;
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

        private bool roomforcream = false;
        /// <value>
        /// Property to hold the status of whether or not the order calls for cream
        /// </value>
        /// <remarks>
        /// Default value is false
        /// </remarks>
        public bool RoomForCream
        {
            get => roomforcream;

            set
            {
                if (roomforcream != value)
                {
                    roomforcream = value;
                    InvokePropertyChanged("RoomForCream");
                    InvokePropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool decaf = false;
        /// <value>
        /// Property to hold whether or not the order calls for decaf coffee
        /// </value>
        /// /// <remarks>
        /// Default value is false
        /// </remarks>
        public bool Decaf 
        { 
            get => decaf;
            set
            {
                if (decaf != value)
                {
                    decaf = value;
                    InvokePropertyChanged("Decaf");
                    InvokePropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <value>
        /// List to hold any special instructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specials = new List<string>();
                if (Ice) specials.Add("Add ice");
                if (RoomForCream) specials.Add("Add cream");
                return specials;
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string with the size and type of beverage </returns>
        public override string ToString()
        {
            if (Decaf == true)
            {
                return Size.ToString() + " Decaf Candlehearth Coffee";

            }
            else
            {
                return Size.ToString() + " Candlehearth Coffee";
            }
        }
    }
}
