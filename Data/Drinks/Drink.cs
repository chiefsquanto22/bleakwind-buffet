﻿/*
 * Author: John Nettles
 * Class name: Drink.cs
 * Purpose: Acts a base class for the Drinks
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks
    /// </summary>
    /// <remarks>
    /// Implements IOrderItem for generic properties
    /// </remarks>
    public abstract class Drink : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Size size = Size.Small;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size
        {
            get => size;
            set
            {
                if (size != value)
                {
                    size = value;
                    InvokePropertyChanged("Size");
                }
            }
        }
        /// <summary>
        /// The price of the item
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The number of Calories in the item
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// A description of the item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// A list of special instructions about the order
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        protected void InvokePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
