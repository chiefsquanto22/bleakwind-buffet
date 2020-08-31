/*
 * Author: John Nettles 
 * Class name: AretinoAppleJuice.cs
 * Purpose: To create objects to represent the apple juice.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        public double Price;
        public uint Calories;
        public bool Ice { get; set; } = false;

        public Size Size
        {
            get { return Size; }
            set
            {
                if (Size.Equals(Size.Small))
                {
                    Price = .62;
                    Calories = 44;
                }

                if (Size.Equals(Size.Medium))
                {
                    Price = .87;
                    Calories = 88;
                }

                if (Size.Equals(Size.Large))
                {
                    Price = 1.01;
                    Calories = 132;
                }
            }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specials = new List<string>();
                if (Ice) specials.Add("Add ice");
                return specials;
            }
        }
        public string ToString()
        {
            return Size + " Aretino Apple Juice";
        }
    }
}
