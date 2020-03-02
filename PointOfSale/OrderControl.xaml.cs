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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        Order order = new Order();
        public OrderControl()
        {
            InitializeComponent();
            this.DataContext = order;
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClick;
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

        void OnAddCowpokeChiliButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());
            }
        }

        void OnAddAngryChickenButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());
            }
        }
        void OnAddBakedBeansButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }
        void OnAddChiliCheeseFriesButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }
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
        void OnAddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }
        }
        void OnAddJerkedSodaButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }
        }
        void OnAddPanDeCampoButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }
        void OnAddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }
        }
        void OnAddRustlerRibsButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }
        void OnAddTexasTeaButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }
        }
        void OnAddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }
        }
        void OnAddTrailBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());
            }
        }
        void OnAddWaterButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }
        }
    }
}
