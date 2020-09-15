using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing side orders
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the item
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

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
