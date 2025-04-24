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
    /// Interaction logic for Window26.xaml
    /// </summary>
    public partial class Window26 : Window
    {
        public Window26()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Hawaii(object sender, RoutedEventArgs e)
        {
            Window27 window27 = new Window27();
            window27.Show();
            this.Close();
        }

        private void Santorini(object sender, RoutedEventArgs e)
        {
            Window28 window28 = new Window28();
            window28.Show();
            this.Close();
        }

        private void Bahamas(object sender, RoutedEventArgs e)
        {
            Window29 window29 = new Window29();
            window29.Show();
            this.Close();
        }

        private void Phuket(object sender, RoutedEventArgs e)
        {
            Window30 window30 = new Window30();
            window30.Show();
            this.Close();
        }
    }
}
