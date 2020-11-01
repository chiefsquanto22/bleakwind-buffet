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
            
            currentListIndex++;
            HandleButtons();
        }

        void RemoveItem(object sender, RoutedEventArgs e)
        {
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
            if (DataContext is Order var)
            {
                if (var.Items.Count < 1)
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

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (DataContext is Order var)
            {
                if (button.Name == "BriarheartBurger")
                {
                    var item = new BriarheartBurgerCustom();
                    var menuItem = new BriarheartBurger();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "DoubleDragr")
                {
                    var item = new DoubleDragrCustom();
                    var menuItem = new DoubleDragr();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "ThalmorTriple")
                {
                    var item = new ThalmorTripleCustom();
                    var menuItem= new ThalmorTriple();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "GardenOrcOmelette")
                {
                    var item = new GardenOrcOmeletteCustom();
                    var menuItem = new GardenOrcOmelette();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "PhillyPoacher")
                {
                    var item = new PhillyPoacherCustom();
                    var menuItem = new PhillyPoacher();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "SmokehouseSkeleton")
                {
                    var item = new SmokehouseSkeletonCustom();
                    var menuItem = new SmokehouseSkeleton();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if(button.Name == "ThugsTBone")
                {
                    var menuItem = new ThugsTBone();
                    var.Add(menuItem);

                }
                if (button.Name == "AretinoAppleJuice")
                {
                    var item = new AretinoAppleJuiceCustom();
                    var menuItem = new AretinoAppleJuice();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "CandlehearthCoffee")
                {
                    var item = new CandlehearthCoffeeCustom();
                    var menuItem = new CandlehearthCoffee();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "MarkarthMilk")
                {
                    var item = new MarkarthMilkCustom();
                    var menuItem = new MarkarthMilk();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "SailorSoda")
                {
                    var item = new SailorSodaCustom();
                    var menuItem = new SailorSoda();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "WarriorWater")
                {
                    var item = new WarriorWaterCustom();
                    var menuItem = new WarriorWater();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "DragonbornWafflefries")
                {
                    var item = new SideCustom();
                    var menuItem = new DragonbornWafflefries();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "FriedMiraak")
                {
                    var item = new SideCustom();
                    var menuItem = new FriedMiraak();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "MadOtarGrits")
                {
                    var item = new SideCustom();
                    var menuItem = new MadOtarGrits();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
                if (button.Name == "VokunSalad")
                {
                    var item = new SideCustom();
                    var menuItem = new VokunSalad();
                    item.DataContext = menuItem;
                    containerBorder.Child = item;
                    var.Add(menuItem);
                }
            }
        }
        public void Done_Click(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = null;
        }
    }
}
