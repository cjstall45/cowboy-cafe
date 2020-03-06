/*
* Author: Charlie Stallbaumer
* Class name:Entree
* Purposes: to create a base entree class
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a base entree class
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets the price of an entree
        /// </summary>
        public abstract double Price {get;}
        /// <summary>
        /// gets the calories of an entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// creates a basic empty list of instructions for making an entree
        /// </summary>
        public virtual List<string> SpecialInstructions { get; } = new List<string>();

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
