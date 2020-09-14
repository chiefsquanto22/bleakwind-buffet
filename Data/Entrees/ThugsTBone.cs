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
    public class ThugsTBone : Entree
    {
        /// <value>
        /// Property that holds the price
        /// </value>
        public override double Price { get => 6.44; }

        /// <value>
        /// Property that holds the number of Calories
        /// </value>
        public override uint Calories { get => 982; }

        /// <value>
        /// Creates an empty list. You don't change a T Bone.
        /// </value>
        public override List<string> SpecialInstructions 
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// Overrides the generic ToString() method.
        /// </summary>
        /// <returns> a string saying "Thugs T-Bone" </returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
