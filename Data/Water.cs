﻿/*
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
        
        private bool lemon = false;
        /// <summary>
        /// a bool for adding lemon
        /// </summary>
        public virtual bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyOfPropertyChanged("Lemon");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// instructions for makeing water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice)
                    instructions.Add("Hold Ice");
                if (Lemon)
                    instructions.Add("Add Lemon");
                return instructions;
            }
        }
        /// <summary>
        /// an override of the defalt to string method
        /// </summary>
        /// <returns>a string with the size and object type</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Large:
                    return "Large Water";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
