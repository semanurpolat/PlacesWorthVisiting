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
    /// Interaction logic for Window21.xaml
    /// </summary>
    public partial class Window21 : Window
    {
        public Window21()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Uludag(object sender, RoutedEventArgs e)
        {
            Window22 window22 = new Window22();
            window22.Show();
            this.Close();
        }

        private void Everest(object sender, RoutedEventArgs e)
        {
            Window23 window23 = new Window23();
            window23.Show();
            this.Close();
        }

        private void Gronland(object sender, RoutedEventArgs e)
        {
            Window24 window24 = new Window24();
            window24.Show();
            this.Close();
        }

        private void Antarctica(object sender, RoutedEventArgs e)
        {
            Window25 window25 = new Window25();
            window25.Show();
            this.Close();
        }
    }
}
