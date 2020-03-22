/*
* Author: Charlie Stallbaumer
* Class name:TexasTea
* Purposes: to create a class for the Texas Tea Drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the texas tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// the price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (DrinkSize)
                {
                    case Size.Small:
                        return 1;
                    case Size.Medium:
                        return 1.5;
                    case Size.Large:
                        return 2;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// the calories of the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (DrinkSize)
                {
                    case Size.Small:
                        if (Sweet)
                            return 10;
                        else
                            return 5;
                    case Size.Medium:
                        if (Sweet)
                            return 22;
                        else
                            return 11;
                    case Size.Large:
                        if (Sweet)
                            return 36;
                        else
                            return 18;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        private bool sweet = true;
        /// <summary>
        /// a bool for if the tea is sweet or not
        /// </summary>
        public bool Sweet 
        {
            get { return sweet; }
            set 
            {
                sweet = value;
                NotifyOfPropertyChanged("Sweet");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("SpecialInstructions");
            } 
        } 
        private bool lemon = false;
        /// <summary>
        /// a bool for adding lemon
        /// </summary>
        public virtual bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyOfPropertyChanged("Lemon");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// instructions for making the tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {

                List<string> instructions = new List<string>();

                if (!Ice)
                    instructions.Add("Hold Ice");
                if (Lemon)
                    instructions.Add("Add Lemon");
                if (!Sweet)
                    instructions.Add("No Sweetener");

                return instructions;
            }
        }

        /// <summary>
        /// an override of the defalt to string method
        /// </summary>
        /// <returns>a string with the size and object type</returns>
        public override string ToString()
        {
            if (Sweet)
            {
                switch (DrinkSize)
                {
                    case Size.Small:
                        return "Small Texas Sweet Tea";
                    case Size.Medium:
                        return "Medium Texas Sweet Tea";
                    case Size.Large:
                        return "Large Texas Sweet Tea";
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                switch (DrinkSize)
                {
                    case Size.Small:
                        return "Small Texas Plain Tea";
                    case Size.Medium:
                        return "Medium Texas Plain Tea";
                    case Size.Large:
                        return "Large Texas Plain Tea";
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
    
}
