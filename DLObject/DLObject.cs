using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DLAPI;
//using DO;
using DS;

namespace DL
{
    sealed class DLObject    //internal
    {
        #region singelton
        static readonly DLObject instance = new DLObject();
        static DLObject() { }// static ctor to ensure instance init is done just before first usage
        DLObject() { } // default => private
        public static DLObject Instance { get => instance; }// The public Instance property to use
        //#endregion

        SqlConnection conn = new SqlConnection(@"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true");


        #region Protein

        DO.Protein GetProteinBySequence(string sequence)
        {

                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM proteinsTable WHERE  DATALENGTH(Sequence)=" + sequence.Length + "'", conn);
                command.CommandTimeout = 200;
                DO.Protein p = new DO.Protein();
                p.Sequence = sequence;
                p.ProteinGI = "";
                p.ProteinName = "";
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (sequence == reader[2].ToString())
                            {
                                p.ProteinGI = (reader[0]).ToString();
                                p.ProteinName = reader[1].ToString();
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
                conn.Close();

                return p;
            }
        
        DO.Protein GetProteinByName(string name)
        {

            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM proteinsTable2 WHERE ProteinName = " + "'" + name + "' ", conn);
            DO.Protein p = new DO.Protein();
            command.CommandTimeout = 200;
            using (SqlDataReader reader = command.ExecuteReader())
            {

                if (reader.Read())
                {

                        p.ProteinGI = (reader[0]).ToString();
                        p.ProteinName = reader[1].ToString();
                        p.Sequence = reader[2].ToString();


                }
                else
                {
                    throw new DO.BadProteinException(name, " Protein does not exist");
                }
            }
            conn.Close();
            return p;
        }

        DO.Protein GetProteinByGI(string numOfGI)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM proteinsTable2 WHERE ProteinGI = " + "'" + numOfGI + "'", conn);
            command.CommandTimeout = 200;
            DO.Protein p = new DO.Protein();
            using (SqlDataReader reader = command.ExecuteReader())
            {

                if (reader.Read())
                {
                    p.ProteinGI = (reader[0]).ToString();
                    p.ProteinName = reader[1].ToString();
                    p.Sequence = reader[2].ToString();

                }
                else
                {
                    throw new DO.BadProteinException(numOfGI, " Protein does not exist");
                }
            }
            conn.Close();

            return p;
        }

        #endregion

        #region VirtualSequence
        DO.VirtualSequence GetVirtualSequence(string Sequence)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM proteinsTable2 WHERE VSTable = " + "'" + Sequence + "' ", conn);
            DO.VirtualSequence vs = new DO.VirtualSequence();
            command.CommandTimeout = 200;
            using (SqlDataReader reader = command.ExecuteReader())
            {

                if (reader.Read())
                {

                    vs.Sequence = reader[0].ToString();
                    vs.Size = int.Parse(reader[1].ToString());

                }
                else
                {
                    throw new DO.BadProteinException(Sequence, " vs does not exist");
                }
            }
            conn.Close();
            return vs;
        }

        #endregion


        #region Pentamer

        IEnumerable<DO.Pentamer> GetPentamersBySequence(string sequence)
        {

            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM pentamersTable2 WHERE  Sequence= '" + sequence + "'", conn);
            command.CommandTimeout = 200;
            IEnumerable<DO.Pentamer> pentamers = new List<DO.Pentamer>();
            try
            {
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DO.Pentamer penta = new DO.Pentamer();
                        penta.LastIndex =int.Parse( reader[0].ToString());
                        penta.ProteinGI = reader[1].ToString();
                        penta.ProteinName = reader[2].ToString();
                        penta.FirstIndex = int.Parse(reader[3].ToString());
                        penta.Sequence= reader[4].ToString();

                    }
                }
            }
            catch (Exception)
            {

            }
            conn.Close();

            return pentamers;
        }
        IEnumerable<DO.Pentamer> GetPentamerByProteinGI(string ProteinGI)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM pentamersTable2 WHERE ProteinGI= '" + ProteinGI + "'", conn);
            command.CommandTimeout = 200;
            IEnumerable<DO.Pentamer> pentamers = new List<DO.Pentamer>();
            try
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DO.Pentamer penta = new DO.Pentamer();
                        penta.LastIndex = int.Parse(reader[0].ToString());
                        penta.ProteinGI = reader[1].ToString();
                        penta.ProteinName = reader[2].ToString();
                        penta.FirstIndex = int.Parse(reader[3].ToString());
                        penta.Sequence = reader[4].ToString();

                    }
                }
            }
            catch (Exception)
            {

            }
            conn.Close();

            return pentamers;
        }
        IEnumerable<DO.Pentamer> GetPentamerByProteinName(string ProteinName)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM pentamersTable2 WHERE ProteinGI= '" + ProteinName + "'", conn);
            command.CommandTimeout = 200;
            IEnumerable<DO.Pentamer> pentamers = new List<DO.Pentamer>();
            try
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DO.Pentamer penta = new DO.Pentamer();
                        penta.LastIndex = int.Parse(reader[0].ToString());
                        penta.ProteinGI = reader[1].ToString();
                        penta.ProteinName = reader[2].ToString();
                        penta.FirstIndex = int.Parse(reader[3].ToString());
                        penta.Sequence = reader[4].ToString();

                    }
                }
            }
            catch (Exception)
            {

            }
            conn.Close();

            return pentamers;
        }

        #endregion







        //#region Pentamer
        //public IEnumerable<DO.Pentamer> Search(DO.Pentamer pntaDO)
        //{
        //    return from P in DataSource.ListOfPentamers
        //           where P.Sequence == pntaDO.Sequence
        //           select P.Clone();
        //}

        //public IEnumerable<DO.Pentamer> GetPentamersBySequence(string S)
        //{
        //    return from item in DataSource.ListOfPentamers
        //           where item.Sequence == S
        //           orderby item.FirstIndex
        //           orderby item.ProteinName
        //           select item.Clone();
        //}
        //public IEnumerable<DO.Pentamer> GetPentamersByGI(string S)
        //{
        //    return null;
        //}

        //public DO.Pentamer GetPentamerBySequence(string str)
        //{
        //    return null;
        //}

        //#endregion


        //#region Protein
        //DO.Protein GetProtein(string ProteinGI, string ProteinName)
        //{
        //    return null;
        //}

        //void AddProtein(DO.Protein protein)
        //{

        //}
        //void DeleteProtein(string ProteinGI, string ProteinName)
        //{

        //}
        //IEnumerable<DO.Protein> GetALLProtein()
        //{
        //    return null;
        //}
        //public DO.Protein GetProteinBySequence(string str)
        //{
        //    return (DataSource.ListOfProteins.FirstOrDefault(p => p.Sequence == str)).Clone();
        //}
        //public DO.Protein GetProteinByName(string name)
        //{
        //    return (DataSource.ListOfProteins.FirstOrDefault(p => p.ProteinName == name)).Clone();
        //}
        //public DO.Protein GetProteinByGI(int numOfGI)
        //{
        //    return (DataSource.ListOfProteins.FirstOrDefault(p => p.ProteinGI.Equals(numOfGI))).Clone();
        //}

        //#endregion


        //#region VirtualSequence
        ////public void AddVirtualSequence();

        //public IEnumerable<DO.VirtualSequence> GetAllVirtualSequences()
        //{
        //    return (from item in DataSource.ListOfVS
        //            orderby item.Sequence
        //            select item.Clone());
        //}
        //DO.VirtualSequence GetVirtualSequence(string Sequence)
        //{
        //    return null;
        //}
        //void AddVirtualSequence(DO.VirtualSequence VirtualSequence)
        //{

        //}
        //void DeleteVirtualSequence(string Sequence)
        //{

        //}
        //IEnumerable<DO.VirtualSequence> GetALLVirtualSequencesBySize(int size)
        //{
        //    return null;
        //}

        //#endregion
    }
}