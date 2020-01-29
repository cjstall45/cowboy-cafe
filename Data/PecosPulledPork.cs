using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the pulled pork entree
    /// </summary>
    public class PecosPulledPork
    {
        /// <summary>
        /// price of the pulled pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// calories of the pulled pork
        /// </summary>
        public uint Calories
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
