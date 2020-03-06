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
            CancelOrderButton.Click += OnCancelOrderButtonClick;
            CompleteOrderButton.Click += OnCompleteOrderButtonClick;
            ItemSelectionButton.Click += OnMenuItemSelectionButtonClick;
        }
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
        /// <summary>
        /// event handler for Cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButtonClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
        /// <summary>
        /// event handler for Complete Order Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButtonClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        void OnMenuItemSelectionButtonClick(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
    }
}
