/*
 * Author: John C. Nettles, Jr.
 * Class name: IOrderItem.cs
 * Purpose: a public interface to use as a base for Side.cs, Entree.cs and Drink.cs
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The number of calories in the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// A list of special instructions for the order
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
