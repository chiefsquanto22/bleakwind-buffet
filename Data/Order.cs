using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged, INotifyCollectionChanged, ICollection
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private static int nextOrderNumber = 1;

        public int Number { get; }

        public double SalesTaxRate = .12;

        public double Subtotal;

        public double Tax;

        public double Total;

        public uint Calories;

        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        public void Add(IOrderItem item)
        {

        }

        public void Remove(IOrderItem item)
        {

        }
    }
}
