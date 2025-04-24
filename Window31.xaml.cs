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
    /// Interaction logic for Window31.xaml
    /// </summary>
    public partial class Window31 : Window
    {
        public Window31()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void NewYork(object sender, RoutedEventArgs e)
        {
            Window32 window32 = new Window32();
            window32.Show();
            this.Close();
        }

        private void Berlin(object sender, RoutedEventArgs e)
        {
            Window33 window33 = new Window33();
            window33.Show();
            this.Close();
        }

        private void Paris(object sender, RoutedEventArgs e)
        {
            Window34 window34 = new Window34();
            window34.Show();
            this.Close();
        }

        private void Amsterdam(object sender, RoutedEventArgs e)
        {
            Window35 window35 = new Window35();
            window35.Show();
            this.Close();
        }
    }
}
