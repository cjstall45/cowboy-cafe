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
        public OrderControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClick;
            AddRustlersRibsButton.Click += AddRustlersRibsButton_Click;
            AddPecosPulledPorkButton.Click += AddPecosPulledPorkButton_Click;
            AddTrailburgerButton.Click += AddTrailburgerButton_Click;
            AddDakotaDoubleButton.Click += AddDakotaDoubleButton_Click;
            AddTexasTripleButton.Click += AddTexasTripleButton_Click;
            AddAngryChickenButton.Click += AddAngryChickenButton_Click;
            AddChiliCheeseFriesButton.Click += AddChiliCheeseFriesButton_Click;
            AddCornDodgersButton.Click += AddCornDodgersButton_Click;
            AddPanDeCampoButton.Click += AddPanDeCampoButton_Click;
            AddBakedBeansButton.Click += AddBakedBeansButton_Click;
            AddJerkedSodaButton.Click += AddJerkedSodaButton_Click;
            AddTexasTeaButton.Click += AddTexasTeaButton_Click;
            AddCowboyCoffeeButton.Click += AddCowboyCoffeeButton_Click;
            AddWaterButton.Click += AddWaterButton_Click;

        }

        void OnAddCowpokeChiliButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }

        void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        void AddTrailburgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }

        void AddDakotaDoubleButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        void AddTexasTripleButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

        void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }

        void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }

        void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }

        void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }

        void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }

        void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }

        void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
    }
}
