using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged, INotifyCollectionChanged, ICollection<IOrderItem>
    {
        public ICollection<IOrderItem> Items;

        public Collection<IOrderItem> Items;

        public event PropertyChangedEventHandler PropertyChanged;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private static int nextOrderNumber = 1;

        public int Number { get; }

        public double SalesTaxRate { get; set; } = .12;

        public double Subtotal { get; }

        public double Tax { get => Subtotal * SalesTaxRate; }

        public double Total { get => Subtotal + Tax; }

        private uint calories = 0;
        public uint Calories
        {
            get
            {
                foreach(IOrderItem item in Items)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

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
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();
    }
}
