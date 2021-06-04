using BLAPI;
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
    /// Interaction logic for VirtualSequenceWindow.xaml
    /// </summary>
    public partial class VirtualSequenceWindow : Window
    {
        IBL bl;
        string seq;
        BO.VirtualSequence selected;
        private DataTable dataTable = new DataTable();
        public VirtualSequenceWindow(IBL _bl)
        {
            InitializeComponent();
            bl = _bl;
            cutComboBox.ItemsSource = Enum.GetValues(typeof(BO.CuttingType));
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if((sender as ComboBox).SelectedItem.ToString() =="Five")
            //virtualSequenceDataGrid.DataContext = bl.GetAllVirtualSequences();

            InitializeComponent();
            //if (dc.DatabaseExists())
            //    proteinDataGrid.ItemsSource = dc.proteinsTables;




            //using (SqlConnection conn = new SqlConnection())
            {
                

                string connString = @"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true";
                string query = "SELECT Sequence,count FROM VSTable ";

                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);
                virtualSequenceDataGrid.ItemsSource = dataTable.DefaultView;
                conn.Close();
                da.Dispose();
                conn.Close();
            }
        }

        private void virtualSequenceDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //selected = (sender as DataGrid).SelectedItem as BO.VirtualSequence;
           // seq = ((sender as DataGrid).SelectedItem. as DataRow).ItemArray[0] as string;
            seq = ((sender as DataGrid).SelectedValue as DataRowView).Row.ItemArray[0].ToString();
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            //seq.ToString();
            //string v = ((sender as Button).Parent as DataGridRow).ToString();
            //int i = 0;
            //string seq = ((sender as Button).Parent as DataGridRow).ToString();
            //  Cells[0].Value.ToString();
            DetailsWindow detailsWindow = new DetailsWindow (seq);
            detailsWindow.Show();
        }
    }
}
