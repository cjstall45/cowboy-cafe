/*
* Author: Charlie Stallbaumer
* Class name: CornDodgers
* Purposes: to create data for a corn dodgers side
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// to create data for a corn dodgers side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// the calories of corn dodgers depending on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// the price of corn dodgers depending on the size
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
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
