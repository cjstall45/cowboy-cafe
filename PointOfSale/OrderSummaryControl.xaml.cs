using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        private OrderControl order;
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        public void SwitchScreen(object sender, RoutedEventArgs e)
        {
            
            if(sender is ListBox box)
            {
                if(box.SelectedItem is IOrderItem item)
                {
                    box.SelectedItem = null;
                    if(item is AngryChicken chicken)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeAngryChicken();
                        screen.DataContext = chicken;
                        order.SwapScreen(screen);
                    }
                    else if (item is BakedBeans bean)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeSide();
                        screen.DataContext = bean;
                        order.SwapScreen(screen);
                    }
                    else if (item is ChiliCheeseFries fries)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeSide();
                        screen.DataContext = fries;
                        order.SwapScreen(screen);
                    }
                    else if (item is CornDodgers corn)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeSide();
                        screen.DataContext = corn;
                        order.SwapScreen(screen);
                    }
                    else if (item is CowboyCoffee coffee)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeCowboyCoffee();
                        screen.DataContext = coffee;
                        order.SwapScreen(screen);
                    }
                    else if (item is CowpokeChili chili)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeCowpokeChili();
                        screen.DataContext = chili;
                        order.SwapScreen(screen);
                    }
                    else if (item is DakotaDoubleBurger dakota)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeDakotaDouble();
                        screen.DataContext = dakota;
                        order.SwapScreen(screen);
                    }
                    else if (item is JerkedSoda soda)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeJerkedSoda();
                        screen.DataContext = soda;
                        order.SwapScreen(screen);
                    }
                    else if (item is PanDeCampo pan)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeSide();
                        screen.DataContext = pan;
                        order.SwapScreen(screen);
                    }
                    else if (item is PecosPulledPork pork)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizePecosPulledPork();
                        screen.DataContext = pork;
                        order.SwapScreen(screen);
                    }
                    else if (item is TexasTea tea)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeTexasTea();
                        screen.DataContext = tea;
                        order.SwapScreen(screen);
                    }
                    else if (item is TexasTripleBurger tex)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeTexasTriple();
                        screen.DataContext = tex;
                        order.SwapScreen(screen);
                    }
                    else if (item is TrailBurger burger)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeTrailburger();
                        screen.DataContext = burger;
                        order.SwapScreen(screen);
                    }
                    else if (item is Water water)
                    {
                        order = this.FindAncestor<OrderControl>();
                        var screen = new CustomizeWater();
                        screen.DataContext = water;
                        order.SwapScreen(screen);
                    }
                }
            }
        }

        public void RemoveItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is Button but)
                {
                    if(but.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }
    }
}
