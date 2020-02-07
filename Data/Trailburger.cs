/*
* Author: Charlie Stallbaumer
* Class name:TrailBurger
* Purposes: to create a class that describes the trailburger
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class that describes the trailburger
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// the price of the Trailburger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// the calories of the Trailburger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }
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
        /// instructions to make the trailburger
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

                return instructions;
            }
        }

    }
}
