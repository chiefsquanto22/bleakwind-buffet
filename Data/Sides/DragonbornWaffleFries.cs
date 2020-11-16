/*
 * Author: John Nettles
 * Class name: DragonbornWaffleFries.cs
 * Purpose: to create objects to represent waffle fries on the menu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Creates an object to represent Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWafflefries : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// A description of the item
        /// </summary>
        public override string Description { get => "Crispy fried potato waffle fries."; }

        /// <value>
        /// private backing variable for Price
        /// </value>
        private double price;

        /// <value>
        /// Property that holds the price
        /// </value>
        public override double Price
        {
            get
            {
                if (Size.Equals(Size.Small))
                {

                    price = .42;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = .76;
                }

                if (Size.Equals(Size.Large))
                {

                    price = .96;
                }
                return price;
            }
        }

        /// <value>
        /// private backing variable for Calories
        /// </value>
        private uint calories;

        /// <value>
        /// Property that holds the number of Calories
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small))
                {

                    calories = 77;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 89;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 100;
                }
                return calories;
            }
        }

        /// <value>
        /// An empty list of special instructions
        /// </value>
        public override List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Overrides the generic ToString() method
        /// </summary>
        /// <returns> a string saying "(Size) Dragonborn Waffle Fries"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
