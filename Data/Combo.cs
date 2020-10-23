using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public double Price => throw new NotImplementedException();

        public uint Calories { get; set; }

        public List<string> SpecialInstructions => throw new NotImplementedException();
    }
}
