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
using System.Windows.Shapes;

namespace PlacesWorthVisiting
{
    /// <summary>
    /// Interaction logic for Window36.xaml
    /// </summary>
    public partial class Window36 : Window
    {
        public Window36()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void EiffelTower(object sender, RoutedEventArgs e)
        {
            Window37 window37 = new Window37();
            window37.Show();
            this.Close();
        }

        private void BurjKhalifa(object sender, RoutedEventArgs e)
        {
            Window38 window38 = new Window38();
            window38.Show();
            this.Close();
        }

        private void Pisa(object sender, RoutedEventArgs e)
        {
            Window39 window39 = new Window39();
            window39.Show();
            this.Close();
        }

        private void StatueOfLiberty(object sender, RoutedEventArgs e)
        {
            Window40 window40 = new Window40();
            window40.Show();
            this.Close();
        }
    }
}
