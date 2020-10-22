using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem
    {
        public double Price => throw new NotImplementedException();

        public uint Calories => throw new NotImplementedException();

        public List<string> SpecialInstructions => throw new NotImplementedException();
    }
}
