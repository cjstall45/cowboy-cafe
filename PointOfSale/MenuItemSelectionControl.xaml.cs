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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderControl orderControl;
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += OnItemButtonClicked;
            AddAngryChickenButton.Click += OnItemButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClick;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClick;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClick;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClick;
            AddDakotaDoubleButton.Click += OnItemButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClick;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClick;
            AddPecosPulledPorkButton.Click += OnItemButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlerRibsButtonClick;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClick;
            AddTexasTripleButton.Click += OnItemButtonClicked;
            AddTrailburgerButton.Click += OnItemButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClick;
            
        }
        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("Data Context expected to be an Order.");

            if(screen == null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ansestor of OrderControl failed to be found");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }

            order.Add(item);
        }
        public void OnItemButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                   
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            var chiliEntree = new CowpokeChili();
                            var chiliScreen = new CustomizeCowpokeChili();
                            chiliScreen.DataContext = chiliEntree;
                            order.Add(chiliEntree);
                            orderControl.SwapScreen(chiliScreen);
                            break;
                        case "PecosPulledPork":
                            var porkEntree = new PecosPulledPork();
                            var porkScreen = new CustomizePecosPulledPork();
                            porkScreen.DataContext = porkEntree;
                            order.Add(porkEntree);
                            orderControl.SwapScreen(porkScreen);
                            break;
                        case "Trailburger":
                            var trailentree = new TrailBurger();
                            var trailscreen = new CustomizeTrailburger();
                            trailscreen.DataContext = trailentree;
                            order.Add(trailentree);
                            orderControl.SwapScreen(trailscreen);
                            break;
                        case "DakotaDouble":
                            var dakotaentree = new DakotaDoubleBurger();
                            var dakotascreen = new CustomizeDakotaDouble();
                            dakotascreen.DataContext = dakotaentree;
                            order.Add(dakotaentree);
                            orderControl.SwapScreen(dakotascreen);
                            break;
                        case "TexasTriple":
                            var texasentree = new TexasTripleBurger();
                            var texasscreen = new CustomizeTexasTriple();
                            texasscreen.DataContext = texasentree;
                            order.Add(texasentree);
                            orderControl.SwapScreen(texasscreen);
                            break;
                        case "AngryChicken":
                            var entree = new AngryChicken();
                            var screen = new CustomizeAngryChicken();
                            screen.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen);
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// event handler for Cowpoke chili button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());
            }
        }
        /// <summary>
        /// event handler for angry chicken button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());
            }
        }
        /// <summary>
        /// event handler for Baked Beans Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }
        /// <summary>
        /// event handler for ChiliCheese Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }
        /// <summary>
        /// event handler for Corn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }
        void OnAddCowboyCoffeeButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowboyCoffee());
            }
        }
        /// <summary>
        /// event handler for dakota double button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }
        }
        /// <summary>
        /// event for jerked soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }
        }
        /// <summary>
        /// event for pan de campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPanDeCampoButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }
        /// <summary>
        /// event for pulled pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }
        }
        /// <summary>
        /// event for ribs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlerRibsButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }
        /// <summary>
        /// event for tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }
        }
        /// <summary>
        /// event for triple burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }
        }
        /// <summary>
        /// event for trail burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());
            }
        }
        /// <summary>
        /// event for water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }
        }
    }

}


