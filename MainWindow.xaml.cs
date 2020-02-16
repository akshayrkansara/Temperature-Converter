using System;
using System.Windows;
namespace TemperatureConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal x;
        decimal y;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void celToF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                x = decimal.Parse(temp.Text);
                y = (x * 9) / 5 + 32;
                y = decimal.Round(y, 1);
                lblDisp.Content = y.ToString();
            }
            catch
            {
                MessageBox.Show("please enter only numbers to convert");
            }
        }
        private void fToCel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                x = decimal.Parse(temp.Text);
                y = (x - 32) * 5 / 9;
                y = decimal.Round(y, 1, System.MidpointRounding.AwayFromZero);
                lblDisp.Content = y.ToString();
            }
            catch
            {
                MessageBox.Show("please enter only numbers to convert");
            }
        }
    }
}
