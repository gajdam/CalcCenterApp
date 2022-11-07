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

namespace CalcCenterApp
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
        private void SimpleCalc_onClick(object sender, RoutedEventArgs e)
        {
            SimpleCalcWindow SimpleCalcWindow = new SimpleCalcWindow();
            SimpleCalcWindow.Show();
        }

        private void TempCalculator_onClick(object sender, RoutedEventArgs e)
        {
            CalcTempWindow CalcTempWindow = new CalcTempWindow();        
            CalcTempWindow.Show();
        }
        private void PrintHello()
        {
            
        }
    }
}
