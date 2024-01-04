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

namespace Project
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Clients = new Clients(); //create your new form.
            Clients.Show(); //show the new form.
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Employees = new Employees(); //create your new form.
            Employees.Show(); //show the new form.
            this.Close();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var Requests = new Requests(); //create your new form.
            Requests.Show(); //show the new form.
            this.Close();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            var Products = new Products(); //create your new form.
            Products.Show(); //show the new form.
            this.Close();
        }
    }
}
