﻿using System;
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
    /// Interaction logic for MenuComponent.xaml
    /// </summary>
    public partial class MenuComponent : UserControl
    {
        public string buttonClicked;
        public MenuComponent()
        {
            InitializeComponent();
        }

        void ButtonClick(object sender, RoutedEventArgs e)
        {
            sender = (Button)sender;
            buttonClicked = sender.ToString();
        }
    }
}
