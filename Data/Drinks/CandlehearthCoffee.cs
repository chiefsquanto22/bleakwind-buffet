/*
 * Author: John Nettles
 * Class name: CandlehearthCoffee.cs
 * Purpose: to create objects to represent the coffee option
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (Size.Equals(Size.Small))
                {

                     price = .75;
                }

                if (Size.Equals(Size.Medium))
                {

                    price = 1.25;
                }

                if (Size.Equals(Size.Large))
                {

                    price = 1.75;
                }
            }
        }

        private uint calories;
        public uint Calories {
            get
            {
                return calories;
            } 
            set 
            {
                if (Size.Equals(Size.Small))
                {
                    
                    calories = 7;
                }

                if (Size.Equals(Size.Medium))
                {
                    
                    calories = 10;
                }

                if (Size.Equals(Size.Large))
                {
                    
                    calories = 20;
                }
            }  
        }
        public bool Ice { get; set; } = false;
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;

        public Size Size
        {
            get { return Size; }
            set
            {
                
            }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specials = new List<string>();
                if (Ice) specials.Add("Add ice");
                if (RoomForCream) specials.Add("Add cream");
                return specials;
            }
        }
        public string ToString()
        {
            if (Decaf)
            {
                return Size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + " Candlehearth Coffee";
            }
        }
    }
}
