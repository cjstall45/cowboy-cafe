/*
* Author: Charlie Stallbaumer
* Class name: PecosPulledPork
* Purposes: to create a class for the pulled pork entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the pulled pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// price of the pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// calories of the pulled pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }
        private bool bread = true;
        /// <summary>
        /// If pulled Pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
                NotifyOfPropertyChanged("Bread");
            }
        }
        private bool pickle = true;
        ///<summary>
        /// If the pulled pork has pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyOfPropertyChanged("Pickle");
            }
        }

        /// <summary>
        /// list of instructions for the preperation of the pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
        /// <summary>
        /// a overrideing of the tostring method
        /// </summary>
        /// <returns>the type of the object as a string</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
