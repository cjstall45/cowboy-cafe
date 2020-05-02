using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees
        {
            get
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
        }

        public static IEnumerable<IOrderItem> Sides
        {
            get
            {
                List<IOrderItem> sides = new List<IOrderItem>();
                sides.Add(new BakedBeans());
                sides.Add(new ChiliCheeseFries());
                sides.Add(new CornDodgers());
                sides.Add(new PanDeCampo());
                IEnumerable<IOrderItem> isides = sides;
                return isides;
            }
        }

        public static IEnumerable<IOrderItem> Drinks
        {
            get
            {
                List<IOrderItem> drinks = new List<IOrderItem>();
                drinks.Add(new CowboyCoffee());
                drinks.Add(new JerkedSoda());
                drinks.Add(new TexasTea());
                drinks.Add(new Water());
                IEnumerable<IOrderItem> idrinks = drinks;
                return idrinks;
            }
        }
        public static IEnumerable<IOrderItem> All
        {
            get
            {
                List<IOrderItem> items = new List<IOrderItem>();
                items.Add(new AngryChicken());
                items.Add(new CowpokeChili());
                items.Add(new DakotaDoubleBurger());
                items.Add(new PecosPulledPork());
                items.Add(new RustlersRibs());
                items.Add(new TexasTripleBurger());
                items.Add(new TrailBurger());
                items.Add(new BakedBeans());
                items.Add(new ChiliCheeseFries());
                items.Add(new CornDodgers());
                items.Add(new PanDeCampo());
                items.Add(new CowboyCoffee());
                items.Add(new JerkedSoda());
                items.Add(new TexasTea());
                items.Add(new Water());
                IEnumerable<IOrderItem> Iitems = items;
                return Iitems;
            }
        }
        public static void SideSize(Side side, Size s)
        {
            side.Size = s;

        }

        public static void DrinkSize(Drink drink, Size s)
        {
            drink.Size = s;
        }

        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string term)
        {
            if (term == null) return All;

            List<IOrderItem> results = new List<IOrderItem>();

            foreach(IOrderItem item in items)
            {
                if (item.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
