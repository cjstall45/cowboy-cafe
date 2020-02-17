/*
* Author: Charlie Stallbaumer
* Class name:CowboyCoffee
* Purposes: to create a class for the cowboy coffee drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the Cowboy coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        
        /// <summary>
        /// the price of the cowboy coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// the calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// bool for decaf coffee
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// bool for if room should be left for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// bool for the adding of ice
        /// </summary>
        public override bool Ice { get; set; } = false;
        /// <summary>
        /// instructions for making the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                
                List<string> instructions = new List<string>();

                if (Ice)
                    instructions.Add("Add ice");
                if (RoomForCream)
                    instructions.Add("Room for Cream");
                if (Decaf)
                    instructions.Add("Decaf");

                return instructions;
            }
        }
    }

}
