using System;
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

namespace WpfHelloWorld
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isDataDirty = false;
        public MyWindow myWin { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            lbl.Content = "Добрый день!";
            

            setBut.IsEnabled = false;
                retBut.IsEnabled = false;

            Top = 25;
            Left = 25;

        }

        private void setBut_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter("username.txt");
                sw.WriteLine(setText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
            retBut.IsEnabled = true;

        }

        private void retBut_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader sr = null;
            try
            {
                using (sr = new System.IO.StreamReader("username.txt"))
                    retLabel.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            setBut.IsEnabled = true;
            isDataDirty = true;

        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {


            if (this.isDataDirty)  {
                string msg = "Данные были изменены, но не сохранены!\n Закрыть окно без сохранения ? ";

    MessageBoxResult result = MessageBox.Show(msg, "Контроль данных", MessageBoxButton.YesNo, MessageBoxImage.Warning);
 if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Main(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void New_Win_Click(object sender, RoutedEventArgs e)
        {
            if (myWin == null)
                myWin = new MyWindow();
            myWin.Show();

            if (myWin == null)
            { MyWindow myWin = new MyWindow(); }
            myWin.Owner = this;
            myWin.Top = this.Top;
            myWin.Left = this.Left + this.Width;
            myWin.Show();

        }
    }
}
