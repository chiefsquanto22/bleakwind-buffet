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
        public double Price = 5.62;
        public uint Calories = 602;

        public bool SausageLinks { get; set; } = true;
        public bool Egg { get; set; } = true;
        public bool HashBrowns { get; set; } = true;
        public bool Pancake { get; set; } = true;


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

        public string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
