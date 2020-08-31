/*
 * Author: John Nettles
 * Class name: ThugsT_Bone.cs
 * Purpose: To create objects to represent the T-Bone steak.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsT_Bone
    {
        public double Price = 6.44;
        public uint Calories = 982;

        public List<string> SpecialInstructions 
        {
            get
            {
                return new List<string>();
            }
        }

        public string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
