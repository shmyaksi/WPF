using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Wpf_MVVM.Model;

namespace Wpf_MVVM.ViewModel
{
    class MainViewModel
    {


        public PeopleModel People { get; set; }
        public ICommand ClickCommand { get; set; }

        public MainViewModel()
        {
           
            People = new PeopleModel
            {
                FirstName = "First name",
                LastName = "Last name"
            };
            ClickCommand = new Command(arg => ClickMethod());
        }

        private void ClickMethod()
        {
            MessageBox.Show("Person - " + People.FirstName + " " + People.LastName); 
        }

    }
}