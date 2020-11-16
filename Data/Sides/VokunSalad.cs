/*
 * Author: John Nettles
 * Class name: VokunSalad.cs
 * Purpose: to create objects to represent the fruit salad option on the menu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Creates objects to represent Vokun Salad
    /// </summary>
    public class VokunSalad : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// A description of the item
        /// </summary>
        public override string Description { get => "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges."; }

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

                    price = .93;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = 1.28;
                }

                if (Size.Equals(Size.Large))
                {

                    price = 1.82;
                }
                return price;
            }
        }

        /// <value>
        /// Private backing variable for Calories
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

                    calories = 41;
                }

                if (Size.Equals(Size.Medium))
                {

                    calories = 52;
                }

                if (Size.Equals(Size.Large))
                {

                    calories = 73;
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
        /// <returns> a string that says "(Size) Vokun Salad"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Vokun Salad";
        }
    }
}
