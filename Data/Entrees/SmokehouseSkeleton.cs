/* 
 * Author: John Nettles
 * Class name: SmokehouseSkeleton.cs
 * Purpose: To create objects to represent the breakfast combo
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Smokehouse Skeleton breakfast combo
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Property to hold price
        /// </summary>
        public double Price { get => 5.62; }

        /// <summary>
        /// Property to hold the number of Calories
        /// </summary>
        public uint Calories { get => 602; }
        /// <summary>
        /// Property to hold status of the sausage links. Default true.
        /// </summary>
        public bool SausageLink { get; set; } = true;
        /// <summary>
        /// Property to hold status of the egg. Default true.
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// Property to hold status of the hash browns. Default true.
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        /// <summary>
        /// Property to hold status of the pancake. Default true.
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// List of special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions { 
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
