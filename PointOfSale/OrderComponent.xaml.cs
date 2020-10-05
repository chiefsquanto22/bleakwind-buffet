using BleakwindBuffet.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        private int currentListIndex = 0;
        
        public OrderComponent()
        {
            InitializeComponent();
            HandleButtons();
        }

        void AddItemToOrder(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            MenuComponent menu = new MenuComponent();
            
            
            currentListIndex++;
            containerBorder.Child = menu;
            
            HandleButtons();
        }

        void RemoveItem(object sender, RoutedEventArgs e)
        {
            totalOrder.Items.Remove(totalOrder.SelectedItem); 
            currentListIndex--;
            HandleButtons();
        }

        /// <summary>
        /// Opens up the selected item to be modified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ModifyItem(object sender, RoutedEventArgs e)
        {
            
        }

        void HandleButtons()
        {
            if(totalOrder.Items.Count < 1)
            {
                modifyItem.IsEnabled = false;
                removeItem.IsEnabled = false;
            }

            else
            {
                modifyItem.IsEnabled = true;
                removeItem.IsEnabled = true;
            }
        }
    }
}
