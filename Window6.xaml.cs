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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Pyramids(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
            this.Close();
        }

        private void HagiaSophia(object sender, RoutedEventArgs e)
        {
            Window8 window8 = new Window8();
            window8.Show();
            this.Close();
        }

        private void Colosseum(object sender, RoutedEventArgs e)
        {
            Window9 window9 = new Window9();
            window9.Show();
            this.Close();
        }

        private void EphesusAntiqueCity(object sender, RoutedEventArgs e)
        {
            Window10 window10 = new Window10();
            window10.Show();
            this.Close();
        }
    }
}
