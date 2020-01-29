using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngeryChicken
    {
        private bool bread = true;
        /// <summary>
        /// If chicken is has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
        private bool pickle = true;
        ///<summary>
        /// If the chicken has pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// the price of the entree
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// the Calories of the chicken
        /// </summary>

        public uint Calories
        {
            get
            {
                return 190;
            }
        }
        /// <summary>
        /// list of instructions for the preperation of the chicken
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");
               

                return instructions;
            }
        }
    }
}
