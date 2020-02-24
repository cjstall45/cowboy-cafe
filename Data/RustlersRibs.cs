/*
* Author: Charlie Stallbaumer
* Class name:RustlersRibs
* Purposes: to create a class for the RustlersRibs entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the RustlersRibs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// Price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// cals of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// a overrideing of the tostring method
        /// </summary>
        /// <returns>the type of the object as a string</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
