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
    }
}
