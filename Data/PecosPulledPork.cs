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
        /// <summary>
        /// if bread is on the pulled pork
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// if pickles is on the pulled pork
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// list of instructions for the preperation of the pulled pork
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
    }
}
