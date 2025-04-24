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
    /// Interaction logic for Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        public Window11()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Maldives(object sender, RoutedEventArgs e)
        {
            Window12 window12 = new Window12();
            window12.Show();
            this.Close();
        }

        private void RockyMountains(object sender, RoutedEventArgs e)
        {
            Window13 window13 = new Window13();
            window13.Show();
            this.Close();
        }

        private void Blausee(object sender, RoutedEventArgs e)
        {
            Window14 window14 = new Window14();
            window14.Show();
            this.Close();
        }

        private void SalarDeUyuni(object sender, RoutedEventArgs e)
        {
            Window15 window15 = new Window15();
            window15.Show();
            this.Close();
        }
    }
}
