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
        
        /// <summary>
        /// A description of the item
        /// </summary>
        public string Description { get => ""; }

        public List<string> SpecialInstructions => throw new NotImplementedException();
    }
}
