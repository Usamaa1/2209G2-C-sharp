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

namespace _220G2_wpf
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


        private void prodName_GotFocus(object sender, RoutedEventArgs e)
        {
            if(prodName.Text == "Enter Product Name")
            {
                prodName.Text = "";
                prodName.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void prodName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (prodName.Text == "")
            {
                prodName.Text = "Enter Product Name";
                prodName.Foreground = new SolidColorBrush(Color.FromRgb(127, 140, 141));
            }
        }

        private void prodPrice_GotFocus(object sender, RoutedEventArgs e)
        {
            if (prodPrice.Text == "Enter Price")
            {
                prodPrice.Text = "";
                prodPrice.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void prodPrice_LostFocus(object sender, RoutedEventArgs e)
        {
            if (prodPrice.Text == "")
            {
                prodPrice.Text = "Enter Price";
                prodPrice.Foreground = new SolidColorBrush(Color.FromRgb(127, 140, 141));
            }

        }

        private void prodBarcode_GotFocus(object sender, RoutedEventArgs e)
        {
            if (prodBarcode.Text == "Enter Barcode")
            {
                prodBarcode.Text = "";
                prodBarcode.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }

        }

        private void prodBarcode_LostFocus(object sender, RoutedEventArgs e)
        {
            if (prodBarcode.Text == "")
            {
                prodBarcode.Text = "Enter Barcode";
                prodBarcode.Foreground = new SolidColorBrush(Color.FromRgb(127, 140, 141));
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Product Name: {prodName.Text}\n Product Price: {prodPrice.Text}\n Product Barcode: {prodBarcode.Text}");
        }
    }
}
