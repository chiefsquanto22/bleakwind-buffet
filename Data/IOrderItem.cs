using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class IOrderItem
    {
        double Price { get; }
        uint Calories { get; }
        List<string> SpecialInstructions { get; }
    }
}
