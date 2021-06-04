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
using BLAPI;
namespace PL
{
    /// <summary>
    /// Interaction logic for searchWindow.xaml
    /// </summary>
    public partial class searchWindow : Window
    {
        List<BO.Pentamer> Unique = new List<BO.Pentamer>();
        List<BO.Pentamer> SemiUnique = new List<BO.Pentamer>();
        IBL bl;
        BO.Protein p = new BO.Protein();
        public searchWindow(IBL _bl)
        {
            InitializeComponent();
            bl = _bl;
        }
        public void Cut(BO.Protein protein)
        {
            BO.Pentamer pnta;
            BO.UniquenessTest result;
            Unique = new List<BO.Pentamer>();
            SemiUnique = new List<BO.Pentamer>();
            for (int i = 0; i < protein.Sequence.Length - 4; i++)
            {
                pnta = new BO.Pentamer();
                pnta.Sequence = protein.Sequence.Substring(i, 5);
                pnta.ProteinGI = protein.ProteinGI;
                pnta.ProteinName = protein.ProteinName;
                pnta.LastIndex = i + 4;
                pnta.FirstIndex = i;

                result = bl.search(pnta);
                if (result == BO.UniquenessTest.Unique)
                    Unique.Add(pnta);
                if (result == BO.UniquenessTest.SemiUnique)
                    SemiUnique.Add(pnta);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           // try
            {
                p = bl.GetProteinBySequence(seqTextBox.Text);
            }
         //   catch (Exception ex)
            {
                //p = new BO.Protein();
                //p.Sequence = seqTextBox.Text;
                //p.ProteinGI = "";
                //p.ProteinName = "";
            }
            openReuletWin(p); 
        }





        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            p = bl.GetProteinByName(name);
            openReuletWin(p);

        }



        public void openReuletWin(BO.Protein p)
        {
            Cut(p);
            ResultWindow win = new ResultWindow(bl, p, Unique, SemiUnique);
            win.ShowDialog();
            
        }



        private void GIsubButton_Click(object sender, RoutedEventArgs e)
        {
            string Gi = GITextBox.Text;
            p = bl.GetProteinByGI(Gi);
            openReuletWin(p);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = null;
            GITextBox = null;
            seqTextBox = null;
        }
        /*
using (SqlConnection connection = new SqlConnection(connetionString))
using (SqlCommand command = new SqlCommand(queryString, connection))
{
connection.Open();
using (SqlDataReader reader = command.ExecuteReader())
{
// Call Read before accessing data. 
if (reader.HasRows)
{
  reader.Read();
  professorId = reader.GetInt32(7);

  // Call Close when done reading.

}
reader.Close();
}*/






        //public class PullDataTest
        //{
        //    // your data table
        //    private DataTable dataTable = new DataTable();

        //    public PullDataTest()
        //    {
        //    }

        //    // your method to pull data from database to datatable   
        //    public void PullData()
        //    {
        //        string connString = @"Data Source=DESKTOP-O6INSSA; Initial Catalog=PentamerDataBase; Integrated Security=true";

        //        string query = "select * from pentamerTable ";

        //        SqlConnection conn = new SqlConnection(connString);
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        conn.Open();

        //        // create data adapter
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        // this will query your database and return the result to your datatable
        //        da.Fill(dataTable);
        //        conn.Close();
        //        da.Dispose();
        //    }
        //}


    }
}
   
    

