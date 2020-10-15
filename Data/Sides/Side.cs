/*
 * Author: John Nettles
 * Class name: Side.cs
 * Purpose: Acts a base class for the Sides
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing side orders
    /// </summary>
    /// <remarks>
    /// Implements IOrderItem for generic properties
    /// </remarks>
    public abstract class Side : IOrderItem
    {

        public virtual event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// The size of the item
        /// </summary>
        public virtual Size Size
        {
            get => size;
            set
            {
                if (size != value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
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
        /// A list of special instructions about the order
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
