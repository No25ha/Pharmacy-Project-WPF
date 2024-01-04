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
using System.Data.SqlClient;
using System.Data;
namespace Project
{
    /// <summary>
    /// Interaction logic for Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BPPT344;Initial Catalog=Drug store;Integrated Security=True");

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BPPT344;Initial Catalog=pharmacy;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmd;
        public Clients()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select* from Clients", con);
            Da.Fill(Dt);
            DataGridClients.ItemsSource = Dt.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Row added successfully", "success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DataGridClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
