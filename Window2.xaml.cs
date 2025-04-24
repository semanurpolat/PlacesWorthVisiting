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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow(); // Assuming your main window is called MainWindow
            mainWindow.Show(); // This will open the MainWindow
            this.Close(); // This will close the current window (Window1)
        }

        private void Amazon(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(); 
            window1.Show(); 
            this.Close(); 
        }

        private void GrandCanyon(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Close();
        }

        private void Pamukkale(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Close();
        }

        private void NorwegianFjords(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
            this.Close();
        }
    }
}
