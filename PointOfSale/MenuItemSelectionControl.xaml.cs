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
           // AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClick;
            AddCowpokeChiliButton.Click += OnItemButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClick;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClick;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClick;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClick;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClick;
            AddDakotaDoubleButton.Click += OnAddDakotaDoubleBurgerButtonClick;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClick;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClick;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClick;
            AddRustlersRibsButton.Click += OnAddRustlerRibsButtonClick;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClick;
            AddTexasTripleButton.Click += OnAddTexasTripleBurgerButtonClick;
            AddTrailburgerButton.Click += OnAddTrailBurgerButtonClick;
            AddWaterButton.Click += OnAddWaterButtonClick;
            
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
                            var entree = new CowpokeChili();
                            var screen = new CustomizeCowpokeChili();
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


