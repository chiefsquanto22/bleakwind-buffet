/* 
 * Author: John Nettles
 * Class name: SmokehouseSkeleton.cs
 * Purpose: To create objects to represent the breakfast combo
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Smokehouse Skeleton breakfast combo
    /// </summary>
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Property to hold price
        /// </value>
        public override double Price { get => 5.62; }

        /// <value>
        /// Property to hold the number of Calories
        /// </value>
        public override uint Calories { get => 602; }

        /// <value>
        /// Property to hold status of the sausage links. Default true.
        /// </value>
        public bool SausageLink { get; set; } = true;

        /// <value>
        /// Property to hold status of the egg. Default true.
        /// </value>
        public bool Egg { get; set; } = true;

        /// <value>
        /// Property to hold status of the hash browns. Default true.
        /// </value>
        public bool HashBrowns { get; set; } = true;

        /// <value>
        /// Property to hold status of the pancake. Default true.
        /// </value>
        public bool Pancake { get; set; } = true;

        /// <value>
        /// List of special instructions for the order
        /// </value>
        public override List<string> SpecialInstructions { 
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!SausageLink) specialInstructions.Add("Hold sausage");
                if (!Egg) specialInstructions.Add("Hold egg");
                if (!HashBrowns) specialInstructions.Add("Hold hash browns");
                if (!Pancake) specialInstructions.Add("Hold pancakes");
                return specialInstructions;
            } 
        }

        /// <summary>
        /// Overrides the generic ToString() method.
        /// </summary>
        /// <returns> returns a string saying "Smokehouse Skeleton" </returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
