/*
 * Author: John Nettles
 * Class name: PhillyPoacher.cs
 * Purpose: to create objects to represent the Philly Cheesesteak
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        public double Price = 7.23;
        public uint Calories = 784;

        public bool Sirloin { get; set; } = true;
        public bool Onion { get; set; } = true;
        public bool Roll { get; set; } = true;
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Sirloin) specialInstructions.Add("Hold sirloin");
                if (!Onion) specialInstructions.Add("Hold onion");
                if (!Roll) specialInstructions.Add("Hold roll");
                return specialInstructions;
            }
        }

        public string ToString()
        {
            return "Philly Poacher";
        }
    }
}
