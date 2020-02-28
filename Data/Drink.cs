/*
* Author: Charlie Stallbaumer
* Class name: Drink
* Purposes: to create a defalt drink class
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a default drink class
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// the size of the drink
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// the price of the drink
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// a bool for if the drink has ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;
        /// <summary>
        /// special instructions for the prep of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


    }
}
