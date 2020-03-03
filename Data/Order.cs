using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing a cowboy cafe order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        
        private static uint ordernumber = 0;
        /// <summary>
        /// the items in the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// an event handler which updates the UI 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// the public items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }
        /// <summary>
        /// the total cost of the order
        /// </summary>
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
        /// <summary>
        /// the order number 
        /// </summary>
        public uint OrderNumber 
        { 
            get
            {
                return ordernumber++;

            } 
        }
        /// <summary>
        /// a methoid to add menu items to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
        /// <summary>
        /// a method to remove menu items from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
