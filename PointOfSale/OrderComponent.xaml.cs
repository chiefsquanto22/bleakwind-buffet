using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
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
                var item = new BriarheartBurgerCustom();
                item.DataContext = new BriarheartBurger();
                containerBorder.Child = item;
            }
            if (button.Name == "DoubleDragr")
            {
                var item = new DoubleDragrCustom();
                item.DataContext = new DoubleDragr();
                containerBorder.Child = item;
            }
            if (button.Name == "ThalmorTriple")
            {
                var item = new ThalmorTripleCustom();
                item.DataContext = new ThalmorTriple();
                containerBorder.Child = item;
            }
            if (button.Name == "GardenOrcOmelette")
            {
                var item = new GardenOrcOmeletteCustom();
                item.DataContext = new GardenOrcOmelette();
                containerBorder.Child = item;
            }
            if (button.Name == "PhillyPoacher")
            {
                var item = new PhillyPoacherCustom();
                item.DataContext = new PhillyPoacher();
                containerBorder.Child = item;
            }
            if (button.Name == "SmokehouseSkeleton")
            {
                var item = new SmokehouseSkeletonCustom();
                item.DataContext = new SmokehouseSkeleton();
                containerBorder.Child = item;
            }
            if (button.Name == "AretinoAppleJuice")
            {
                var item = new AretinoAppleJuiceCustom();
                item.DataContext = new AretinoAppleJuice();
                containerBorder.Child = item;
            }
            if (button.Name == "CandlehearthCoffee")
            {
                var item = new CandlehearthCoffeeCustom();
                item.DataContext = new CandlehearthCoffee();
                containerBorder.Child = item;
            }
            if (button.Name == "MarkarthMilk")
            {
                var item = new MarkarthMilkCustom();
                item.DataContext = new MarkarthMilk();
                containerBorder.Child = item;
            }
            if (button.Name == "SailorSoda")
            {
                var item = new SailorSodaCustom();
                item.DataContext = new SailorSoda();
                containerBorder.Child = item;
            }
            if (button.Name == "WarriorWater")
            {
                var item = new WarriorWaterCustom();
                item.DataContext = new WarriorWater();
                containerBorder.Child = item;
            }
            if (button.Name == "DragonbornWafflefries")
            {
                var item = new SideCustom();
                item.DataContext = new DragonbornWafflefries();
                containerBorder.Child = item;
            }
            if (button.Name == "FriedMiraak")
            {
                var item = new SideCustom();
                item.DataContext = new FriedMiraak();
                containerBorder.Child = item;
            }
            if (button.Name == "MadOtarGrits")
            {
                var item = new SideCustom();
                item.DataContext = new MadOtarGrits();
                containerBorder.Child = item;
            }
            if (button.Name == "VokunSalad")
            {
                var item = new SideCustom();
                item.DataContext = new VokunSalad();
                containerBorder.Child = item;
            }            
        }
        public void Done_Click(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = null;
        }
    }
}
