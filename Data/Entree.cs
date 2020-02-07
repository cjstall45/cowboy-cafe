﻿/*
* Author: Charlie Stallbaumer
* Class name:Entree
* Purposes: to create a base entree class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a base entree class
    /// </summary>
    public abstract class Entree
    {
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
    }
}