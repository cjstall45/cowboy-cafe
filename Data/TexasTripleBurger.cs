﻿/*
* Author: Charlie Stallbaumer
* Class name:TexasTripleBurger
* Purposes: to create a class for the texas triple burger entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the texas triple burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// if buns are on the burger
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// if ketchup is on the burger
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// if mustard is on the burger
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// if pickle is on the burger
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// if cheese is on the burger
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// if tomato is on the burger
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// if lettuce is on the burger
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// if mayo is on the burger
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// if bacon is on the burger
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// if egg is on the burger
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// price of the texas triple
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }
        /// <summary>
        /// calories of the texas triple
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }
        /// <summary>
        /// instructions for how to make the Texas Triple
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Cheese) instructions.Add("hold cheese");
                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");

                return instructions;
            }
        }
        /// <summary>
        /// a overrideing of the tostring method
        /// </summary>
        /// <returns>the type of the object as a string</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
