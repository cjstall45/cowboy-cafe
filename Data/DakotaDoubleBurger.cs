using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger
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
        /// price of the dakota double
        /// </summary>
       
        public double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// calories of the dakota double
        /// </summary>
        public uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// instructions to make the Dakota Double
        /// </summary>
        public List<string> SpecialInstructions
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

                return instructions;
            }
        }
    }
}
