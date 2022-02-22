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

namespace WpfRoutedEvent_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event by textbox");
            e.Handled = radBut1.IsChecked.Value;
        }

        private void Grid_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event by grid");
            e.Handled = radBut2.IsChecked.Value;
        }

        private void Window_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event by window");
            e.Handled = radBut3.IsChecked.Value;
        }
    }
}
