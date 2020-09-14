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
    {
        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }
    }
}
