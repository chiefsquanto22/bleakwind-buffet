/*
 * Author: John Nettles
 * Class name: GardenOrcOmelette.cs
 * Purpose: to create objects to represent the Vegeterian Omelette
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class GardenOrcOmelette
    {
        public double Price = 4.57;
        public uint Calories = 404;

        public bool Broccoli { get; set; } = true;
        public bool Mushrooms { get; set; } = true;
        public bool Tomato { get; set; } = true;
        public bool Cheddar { get; set; } = true;

        List<string> SpecialInstructions
        {
            get
            {

                List<string> specialInstructions = new List<string>();
                if (!Broccoli) specialInstructions.Add("Hold broccoli");
                if (!Mushrooms) specialInstructions.Add("Hold mushrooms");
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Cheddar) specialInstructions.Add("Hold cheddar");
                return specialInstructions;
            }
        }
    }
}
