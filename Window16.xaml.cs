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
    /// Interaction logic for Window16.xaml
    /// </summary>
    public partial class Window16 : Window
    {
        public Window16()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Istanbul(object sender, RoutedEventArgs e)
        {
            Window17 window17 = new Window17();
            window17.Show();
            this.Close();
        }

        private void Napoli(object sender, RoutedEventArgs e)
        {
            Window18 window18 = new Window18();
            window18.Show();
            this.Close();
        }

        private void Mexico(object sender, RoutedEventArgs e)
        {
            Window19 window19 = new Window19();
            window19.Show();
            this.Close();
        }

        private void Barcelona(object sender, RoutedEventArgs e)
        {
            Window20 window20 = new Window20();
            window20.Show();
            this.Close();
        }
    }
}
