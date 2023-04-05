﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cv9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
            Value.Content = calculator.Value;
            ValuePast.Content = calculator.ValuePast;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calculator.Click((sender as Button).Content.ToString());
            Value.Content = calculator.Value;
            ValuePast.Content = calculator.ValuePast + calculator.GetOperation();
        }

    }
}