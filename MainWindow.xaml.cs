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

namespace PlacesWorthVisiting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            // Your logic here
        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(); 
            window2.Show(); 
            this.Close(); 
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6(); 
            window6.Show(); 
            this.Close(); 
        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            Window11 window11 = new Window11();
            window11.Show();
            this.Close();
        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            Window16 window16 = new Window16();
            window16.Show();
            this.Close();
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            Window21 window21 = new Window21();
            window21.Show();
            this.Close();
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            Window26 window26 = new Window26();
            window26.Show();
            this.Close();
        }

        private void Button_7(object sender, RoutedEventArgs e)
        {
            Window31 window31 = new Window31();
            window31.Show();
            this.Close();
        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            Window36 window36 = new Window36();
            window36.Show();
            this.Close();
        }
    }

}
