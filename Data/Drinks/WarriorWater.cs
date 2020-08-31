/*
 * Author: John Nettles
 * Class name: WarriorWater.cs
 * Purpose: to create objects to represent water on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        public double Price { get => 0; }
        public uint Calories { get => 0; }
        public bool Ice { get; set; } = true;
        public bool Lemon { get; set; } = false;
        public Size Size { get; set; } = Size.Small;
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specials = new List<string>();
                if (!Ice) specials.Add("Hold ice");
                if (Lemon) specials.Add("Add lemon");
                return specials;
            }
        }
        public string ToString()
        {
                return Size.ToString() + " Warrior Water";
        }
    }
}
