using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        private static uint ordernumber = 0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public event PropertyChangedEventHandler PropertyChanged;
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        public double Subtotal 
        {
            get
            {
                double total = 0;
                foreach (IOrderItem item in Items)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        public uint OrderNumber 
        { 
            get
            {
                return ordernumber++;

            } 
        }

        public void Add(IOrderItem item) 
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
