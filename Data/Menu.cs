using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();

        }

        public static IEnumerable<IOrderItem> Sides()
        {

        }

        public static void SideSize(Side side, Size s)
        {
            side.Size = s;

        }

        public static void DrinkSize(Drink drink, Size s)
        {
            drink.Size = s;
        }

    }
}
