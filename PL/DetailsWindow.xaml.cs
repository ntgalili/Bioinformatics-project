﻿using BLAPI;
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
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        IBL bl;
        BO.VirtualSequence vs;

        public DetailsWindow(string seq)
        {
            InitializeComponent();
            //bl = _bl;
            //vs = _vs;

            seqLable.Content = seq;
            //using (SqlConnection conn = new SqlConnection())
            {


                string connString = @"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true";
                string query = "SELECT* FROM pentamersTable2 WHERE Sequence LIKE '"+ seq+ "'";

                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 200;
                conn.Open();

                // create data adapter
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);
                pentamerDataGrid.ItemsSource = dataTable.DefaultView;
                conn.Close();
                da.Dispose();
                conn.Close();
            }
        }
        // pentamerDataGrid.DataContext = bl.GetPentamersBySequence(vs.Sequence);
    }


   
}
