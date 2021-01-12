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

namespace Calc
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string stringCalc = textString.Text;
            StringSplitter splitter = new StringSplitter();
            string result = "";

            splitter.StringCalc = stringCalc;
            splitter.execute();

            Calculator calculator = new Calculator(splitter.ListValues, splitter.ListOperators);
            result = calculator.calculate();

            resultOutput.Content = result;
        }
    }
}
