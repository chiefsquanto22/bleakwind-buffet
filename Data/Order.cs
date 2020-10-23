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
            Items.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        public void Remove(IOrderItem item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(IOrderItem item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<IOrderItem>.Remove(IOrderItem item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();
    }
}
