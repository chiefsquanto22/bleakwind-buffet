/*
 * Author: John Nettles
 * Class name: Entree.cs
 * Purpose: Acts a base class for the Entrees
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing common properties of Entrees
    /// </summary>
    /// <remarks>
    /// Implements IOrderItem for generic properties
    /// </remarks>
    public abstract class Entree : IOrderItem
    {/// <summary>
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
    }
}
