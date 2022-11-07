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

namespace CalcCenterApp
{
    /// <summary>
    /// Interaction logic for CalcTempWindow.xaml
    /// </summary>
    public partial class CalcTempWindow : Window
    {
        public CalcTempWindow()
        {
            InitializeComponent();
        }
        private void cel1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void dataTemp_TextChanged(object sender, TextChangedEventArgs e)
        {
            //cel na faren
            if (cel1.IsChecked == true && faren2.IsChecked == true)
            {
                double tempC;
                if (double.TryParse(dataTemp.Text, out tempC) || dataTemp.Text == "-")
                {
                    scoreTemp.Content = Convert.ToString((double)Math.Round(1.8 * tempC + 32, 2) + " F");
                }
                else if (dataTemp.Text == "")
                {
                    scoreTemp.Content = "";
                }
            }
            //cel na kel
            else if (cel1.IsChecked == true && kel2.IsChecked == true)
            {
                double tempC;
                if (double.TryParse(dataTemp.Text, out tempC) || dataTemp.Text == "-")
                {
                    scoreTemp.Content = Convert.ToString((double)Math.Round(tempC + 273.15, 2) + " K");
                }
                else if (dataTemp.Text == "")
                {
                    scoreTemp.Content = "";
                }
            }
            // faren na cel
            else if (faren1.IsChecked == true && cel2.IsChecked == true)
            {
                double tempF;
                if (double.TryParse(dataTemp.Text, out tempF) || dataTemp.Text == "-")
                {
                    scoreTemp.Content = Convert.ToString((double)Math.Round(5 / 9f * (tempF - 32), 2) + " C");
                }
                else if (dataTemp.Text == "")
                {
                    scoreTemp.Content = "";
                }
            }
            //faren na kel
            else if (faren1.IsChecked == true && kel2.IsChecked == true)
            {
                double tempF;
                if (double.TryParse(dataTemp.Text, out tempF) || dataTemp.Text == "-")
                {
                    scoreTemp.Content = Convert.ToString((double)Math.Round(5 / 9f * (tempF - 32) + 273.15, 2) + " K");
                }
                else if (dataTemp.Text == "")
                {
                    scoreTemp.Content = "";
                }

            }
            //kel na cel
            else if (kel1.IsChecked == true && cel2.IsChecked == true)
            {
                double tempK;
                if (double.TryParse(dataTemp.Text, out tempK) || dataTemp.Text == "-")
                {
                    scoreTemp.Content = Convert.ToString((double)Math.Round(tempK - 273.15, 2) + " C");
                }
                else if (dataTemp.Text == "")
                {
                    scoreTemp.Content = "";
                }
            }
            else if (kel1.IsChecked == true && faren2.IsChecked == true)
            {
                double tempK;
                if (double.TryParse(dataTemp.Text, out tempK) || dataTemp.Text == "-")
                {
                    scoreTemp.Content = Convert.ToString((double)Math.Round(tempK * 9 / 5f - 459.67, 2) + " C");
                }
                else if (dataTemp.Text == "")
                {
                    scoreTemp.Content = "";
                }
            }
            else if (dataTemp.Text == "")
            {
                scoreTemp.Content = "";
            }
        }
    }
}
