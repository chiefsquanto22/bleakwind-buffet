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
            totalOrder.Items.Add(button.Content);

            currentListIndex++;
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
            if (totalOrder.Items.Count < 1)
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

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            
            if (button.Name == "BriarheartBurger")
            {
                containerBorder.Child = new BriarheartBurgerCustom();
            }
            if (button.Name == "DoubleDragr")
            {
                containerBorder.Child = new DoubleDragrCustom();
            }
            if (button.Name == "ThalmorTriple")
            {
                containerBorder.Child = new ThalmorTripleCustom();
            }
            if (button.Name == "GardenOrcOmelette")
            {
                containerBorder.Child = new GardenOrcOmeletteCustom();
            }
            if (button.Name == "PhillyPoacher")
            {
                containerBorder.Child = new PhillyPoacherCustom();
            }
            if (button.Name == "SmokehouseSkeleton")
            {
                containerBorder.Child = new SmokehouseSkeletonCustom();
            }
            if (button.Name == "AretinoAppleJuice")
            {
                containerBorder.Child = new AretinoAppleJuiceCustom();
            }
            if (button.Name == "CandlehearthCoffee")
            {
                containerBorder.Child = new CandlehearthCoffeeCustom();
            }
            if (button.Name == "MarkarthMilk")
            {
                containerBorder.Child = new AretinoAppleJuiceCustom();
            }
            if (button.Name == "SailorSoda")
            {
                containerBorder.Child = new SailorSodaCustom();
            }
            if (button.Name == "WarriorWater")
            {
                containerBorder.Child = new WarriorWaterCustom();
            }
            if (button.Name == "DragonbornWafflefries")
            {
                containerBorder.Child = new SideCustom();
            }
            if (button.Name == "FriedMiraak")
            {
                containerBorder.Child = new SideCustom();
            }
            if (button.Name == "MadOtarGrits")
            {
                containerBorder.Child = new SideCustom();
            }
            if (button.Name == "VokunSalad")
            {
                containerBorder.Child = new SideCustom();
            }            
        }
        public void Done_Click(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = null;
        }
    }
}
