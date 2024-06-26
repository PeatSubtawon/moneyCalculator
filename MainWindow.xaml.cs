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

namespace homework1
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

        private void clickCalculate(object sender, RoutedEventArgs e)
        {
            double salary = double.Parse(txtSalary.Text);
            double spending = double.Parse(txtSpending.Text);
            double wanted = double.Parse(txtWanted.Text);

            int day = (int)Math.Ceiling(wanted/(salary-spending));
            MessageBox.Show("Success");
            txtDay.Text = day.ToString();
        }
    }
}
