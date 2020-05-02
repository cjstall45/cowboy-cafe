using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// the price of the order item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// the special instructions for the order item
        /// </summary>
        List<string> SpecialInstructions { get; }

        uint Calories { get; }
    }
}
