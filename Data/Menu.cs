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
            entree.Add(new AngryChicken());
            entree.Add(new CowpokeChili());
            entree.Add(new DakotaDoubleBurger());
            entree.Add(new PecosPulledPork());
            entree.Add(new RustlersRibs());
            entree.Add(new TexasTripleBurger());
            entree.Add(new TrailBurger());
            IEnumerable<IOrderItem> ientree = entree;
            return ientree;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());
            IEnumerable<IOrderItem> isides = sides;
            return isides;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());
            IEnumerable<IOrderItem> idrinks = drinks;
            return idrinks;
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
