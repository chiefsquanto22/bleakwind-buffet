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
    public class SmokehouseSkeleton
    {
        public double Price { get => 5.62; }
        public uint Calories { get => 602; }
        /// <summary>
        /// Property to hold status of the sausage links. Default true.
        /// </summary>
        public bool SausageLinks { get; set; } = true;
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
                if (!SausageLinks) specialInstructions.Add("Hold sausage");
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
        public string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
