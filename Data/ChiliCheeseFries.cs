﻿/*
* Author: Dr.Bean
* Edited by: Charlie Stallbaumer
* Class name: ChiliCheeseFries
* Purposes:to create data for a chilicheese fries side 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// creates data for a chilicheese fries side 
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Calories of the chilicheese fries depending on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// price of the chili cheese fries depending on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
