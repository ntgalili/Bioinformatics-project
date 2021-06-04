using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace PL
{
    /// <summary>
    /// Interaction logic for ProteinsWindow.xaml
    /// </summary>
    public partial class ProteinsWindow : Window
    {
        //ProteinsDataClasses1DataContext dc = new ProteinsDataClasses1DataContext(
        //  Properties.Settings.Default.PentamerDataBaseConnectionString);
         private DataTable dataTable = new DataTable();


        public ProteinsWindow()
        {
            InitializeComponent();
            //if (dc.DatabaseExists())
            //    proteinDataGrid.ItemsSource = dc.proteinsTables;




            //using (SqlConnection conn = new SqlConnection())
            {
                //conn.ConnectionString = @"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true";
                //conn.Open();
                //SqlCommand command = new SqlCommand("SELECT * FROM proteinsTable", conn);




                string connString = @"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true";
                string query = "SELECT ProteinGI, ProteinName FROM proteinsTable2 ";

                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);
                proteinDataGrid.ItemsSource = dataTable.DefaultView;
                conn.Close();
                da.Dispose();
                conn.Close();
            }
        }
    }
}
