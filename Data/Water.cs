/*
* Author: Charlie Stallbaumer
* Class name:Water
* Purposes: to create a class for the water drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the water drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// the price of the water
        /// </summary>
        public override double Price { get; } = .12;
        /// <summary>
        /// the calories of the water 
        /// </summary>
        public override uint Calories { get; } = 0;
        /// <summary>
        /// a bool for adding lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// instructions for makeing water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice)
                    instructions.Add("hold ice");
                if (Lemon)
                    instructions.Add("Add Lemon");
                return instructions;
            }
        }
    }
}
