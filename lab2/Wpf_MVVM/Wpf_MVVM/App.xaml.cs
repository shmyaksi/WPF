﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Wpf_MVVM.View;
using Wpf_MVVM.ViewModel;

namespace Wpf_MVVM
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            new MainWindowView
            {
                DataContext = new MainViewModel()
            }.Show();
        }
    }
}
