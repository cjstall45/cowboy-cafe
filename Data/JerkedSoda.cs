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
        private SodaFlavor flavor;
        /// <summary>
        /// the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor { get { return flavor; }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Flavor");
            }
        }

        /// <summary>
        /// instructions for making the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                
                if (!Ice)
                    instructions.Add("Hold Ice");
                
                return instructions;
            }
        }
        /// <summary>
        /// an override of the defalt to string method
        /// </summary>
        /// <returns>a string with the size, flavor, and object type</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    switch (Flavor)
                    {
                        case SodaFlavor.BirchBeer:
                            return "Small Birch Beer Jerked Soda";
                        case SodaFlavor.CreamSoda:
                            return "Small Cream Soda Jerked Soda";
                        case SodaFlavor.OrangeSoda:
                            return "Small Orange Soda Jerked Soda";
                        case SodaFlavor.RootBeer:
                            return "Small Root Beer Jerked Soda";
                        default:
                            return "Small Sarsparilla Jerked Soda";
                    }
                case Size.Medium:
                    switch (Flavor)
                    {
                        case SodaFlavor.BirchBeer:
                            return "Medium Birch Beer Jerked Soda";
                        case SodaFlavor.CreamSoda:
                            return "Medium Cream Soda Jerked Soda";
                        case SodaFlavor.OrangeSoda:
                            return "Medium Orange Soda Jerked Soda";
                        case SodaFlavor.RootBeer:
                            return "Medium Root Beer Jerked Soda";
                        default:
                            return "Medium Sarsparilla Jerked Soda";
                    }
                case Size.Large:
                    switch (Flavor)
                    {
                        case SodaFlavor.BirchBeer:
                            return "Large Birch Beer Jerked Soda";
                        case SodaFlavor.CreamSoda:
                            return "Large Cream Soda Jerked Soda";
                        case SodaFlavor.OrangeSoda:
                            return "Large Orange Soda Jerked Soda";
                        case SodaFlavor.RootBeer:
                            return "Large Root Beer Jerked Soda";
                        default:
                            return "Large Sarsparilla Jerked Soda";
                    }
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
