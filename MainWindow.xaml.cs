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

namespace WpfApp2
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

        private void ctof_Click(object sender, RoutedEventArgs e)
        {
            double c = double.Parse(tbSatu.Text);

            double num = 9.0 / 5.0;
            double hasil = c * num + 32.0;

            labelHasil.Content = hasil;
        }

        private void ctor_Click(object sender, RoutedEventArgs e)
        {
            double c = double.Parse(tbSatu.Text);

            double num = 4.0 / 5.0;
            double hasil = c * num;

            labelHasil.Content = hasil;
        }

        private void ctok_Click(object sender, RoutedEventArgs e)
        {
            double c = double.Parse(tbSatu.Text);

            double hasil = c + 273.15;

            labelHasil.Content = hasil;
        }

        private void ftoc_Click(object sender, RoutedEventArgs e)
        {
            double f = double.Parse(tbSatu.Text);

            double num = 5.0 / 9.0;
            double hasil = (f - 32.0) * num;

            labelHasil.Content = hasil;
        }

        private void ftor_Click(object sender, RoutedEventArgs e)
        {
            double f = double.Parse(tbSatu.Text);

            double num = 4.0 / 9.0;
            double hasil = (f - 32.0) * num;

            labelHasil.Content = hasil;
        }

        private void ftok_Click(object sender, RoutedEventArgs e)
        {
            double f = double.Parse(tbSatu.Text);

            double num = 5.0 / 9.0;
            double hasil = (f - 32.0) * num - 273.15;

            labelHasil.Content = hasil;
        }

        private void rtoc_Click(object sender, RoutedEventArgs e)
        {
            double r = double.Parse(tbSatu.Text);

            double num = 5.0 / 4.0;
            double hasil = r * num;

            labelHasil.Content = hasil;
        }

        private void rtof_Click(object sender, RoutedEventArgs e)
        {
            double r = double.Parse(tbSatu.Text);

            double num = 9.0 / 4.0;
            double hasil = r * num + 32.0;

            labelHasil.Content = hasil;
        }

        private void rtok_Click(object sender, RoutedEventArgs e)
        {
            double r = double.Parse(tbSatu.Text);

            double num = 5.0 / 4.0;
            double hasil = r * num + 273.15;

            labelHasil.Content = hasil;
        }

        private void ktoc_Click(object sender, RoutedEventArgs e)
        {
            double k = double.Parse(tbSatu.Text);

            double hasil = k - 273.15;

            labelHasil.Content = hasil;
        }

        private void ktof_Click(object sender, RoutedEventArgs e)
        {
            double k = double.Parse(tbSatu.Text);

            double num = 9.0 / 5.0;
            double hasil = (k - 273.15) * num + 32.0;

            labelHasil.Content = hasil;
        }

        private void ktor_Click(object sender, RoutedEventArgs e)
        {
            double k = double.Parse(tbSatu.Text);

            double num = 4.0 / 5.0;
            double hasil = (k - 273.15) * num;

            labelHasil.Content = hasil;
        }
    }
}
