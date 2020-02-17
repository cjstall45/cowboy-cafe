/*
* Author: Charlie Stallbaumer
* Class name:JerkedSoda
* Purposes: to create a class for the jerked soda drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the jerked soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// the price of the jerked soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.1;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// the calories of the jerked soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// instructions for making the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                
                if (!Ice)
                    instructions.Add("hold ice");
                
                return instructions;
            }
        }
    }
}
