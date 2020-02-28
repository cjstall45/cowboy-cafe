/*
* Author: Charlie Stallbaumer
* Class name:AngryChicken
* Purposes: to create  a class representing the Angry Chicken entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree 
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
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// the Calories of the chicken
        /// </summary>

        public override uint Calories
        {
            get
            {
                return 190;
            }
        }
        /// <summary>
        /// list of instructions for the preperation of the chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");
               

                return instructions;
            }
        }
        /// <summary>
        /// a overrideing of the tostring method
        /// </summary>
        /// <returns>the type of the object as a string</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
