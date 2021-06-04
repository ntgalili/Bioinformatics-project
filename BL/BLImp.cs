using System;
using System.Collections.Generic;
using System.Linq;
using DLAPI;
using BLAPI;
using System.Threading;
using BO;
using System.Data.SqlClient;
//using BO;

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using DLAPI;
////using BLAPI;
////using System.Threading;
////using BO;
//

namespace BL
{
    class BLImp : IBL //internal
    {
        IDL dl = DLFactory.GetDL();
        SqlConnection conn = new SqlConnection(@"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true");
        


        #region Pentamer
        BO.Pentamer PentamerDoBoAdapter(DO.Pentamer DOPentamer)
        {
            BO.Pentamer BOPentamer = new BO.Pentamer();
            DOPentamer.CopyPropertiesTo(BOPentamer);
            return BOPentamer;
        }



        public UniquenessTest search(BO.Pentamer pntaBO)
        {
            {
                //conn.ConnectionString = @"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM VSTable WHERE  Sequence = '" + pntaBO.Sequence + "'", conn);
                command.CommandTimeout = 200;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (int.Parse(reader[1].ToString()) == 1)
                        {
                            conn.Close();
                            return UniquenessTest.Unique;
                        }
                        if (int.Parse(reader[1].ToString()) == 2)
                        {
                            conn.Close();
                            return UniquenessTest.SemiUnique;
                        }
                        conn.Close();
                        return UniquenessTest.NotUnique;


                    }
                    else
                    {
                        conn.Close();
                        return UniquenessTest.Unique;
                    }

                }
            }
                
            //    int count = 0;
            //DO.Pentamer pntaDO = new DO.Pentamer();
            //pntaBO.CopyPropertiesTo(pntaDO);
            //IEnumerable<DO.Pentamer> pentamerList = dl.Search(pntaDO);
            //foreach (DO.Pentamer pntDO in pentamerList)
            //{
            //    if (!pntDO.ProteinGI.Equals(pntaBO.ProteinGI))
            //        count++;
            //}
            //if (count == 0)
            //    return UniquenessTest.Unique;
            //if (count == 1)
            //    return UniquenessTest.SemiUnique;
            //return UniquenessTest.NotUnique;
        }


         public IEnumerable<BO.Pentamer> GetPentamersBySequence(string S)
        {
            return from item in dl.GetPentamersBySequence(S)
                   select PentamerDoBoAdapter(item);
        }


        //public IEnumerable<BO.Pentamer> Cut(Protein protein)
        //{
        //    IEnumerable<BO.UniquenessTest> result = new List <BO.UniquenessTest>();
        //    Pentamer pnta;
        //    for (int i = 0; i < protein.Sequence.Length - 4; i++)
        //    {
        //        pnta = new Pentamer();
        //        pnta.Sequence = protein.Sequence.Substring(i, 5);
        //        pnta.ProteinGI = protein.ProteinGI;

        //    }
        //}
        public IEnumerable<BO.Pentamer> GetAllPentamer()
        {    
            return from item in dl.GetAllPentamer()
                   select PentamerDoBoAdapter(item);
        }
         
        public IEnumerable<BO.Pentamer> GetPentamerByProteinGI(string ProteinGI)
        {
                return (from item in dl.GetPentamerByProteinGI(ProteinGI)
                select PentamerDoBoAdapter(item));
        }
        public IEnumerable<BO.Pentamer> GetPentamerByProteinName(string ProteinName)
        {
            return from item in dl.GetPentamerByProteinName(ProteinName)
                   select PentamerDoBoAdapter(item);
             
        }
        public BO.Pentamer GetPentamerBySequence(string Sequence)
        { 
            DO.Pentamer PentamerDO;
            try
            {
                PentamerDO = dl.GetPentamerBySequence(Sequence);
            }
            catch (DO.BadPentamerProteinSequenceException ex)
            {
                throw new BO.BadPentamerProteinSequenceException(" pentamer does not exist", ex);
            }
            return PentamerDoBoAdapter(PentamerDO);
             
                
        }
         
        public void AddPentamer(BO.Pentamer pentamer)
        {

            DO.Pentamer PentamerDO = new DO.Pentamer();
            pentamer.CopyPropertiesTo(PentamerDO);
            try
            {
                dl.AddPentamer(PentamerDO);
            }
            catch (DO.BadPentamerException ex)// אין חרגיה ב  DLXML
            {
                throw new BO.BadPentamerException("Duplicate Pentamer", ex);
            }

        }
        public void DeletePentamer(string proteinGI, string sequence, int firstIndex)
        {
            try
            {
                dl.DeletePentamer(proteinGI, sequence, firstIndex);
            }
            catch (DO.BadPentamerException ex)
            {
                throw new BO.BadPentamerException("Pentamer  does not exist", ex);

            }
            
        }
        public IEnumerable<BO.Pentamer> Search(BO.Pentamer pntaDO)
        {
            DO.Pentamer PentamerDO = new DO.Pentamer();
            pntaDO.CopyPropertiesTo(PentamerDO);
            return from P in dl.Search(PentamerDO)
                select PentamerDoBoAdapter(P);
        }

        #endregion



        #region Protein
        public BO.Protein proteinDoBoAdapter(DO.Protein DOProtein)
        {
            BO.Protein BOProtein = new BO.Protein();
            DOProtein.CopyPropertiesTo(BOProtein);
            return BOProtein;
        }
        //public BO.Protein GetProteinBySequence(string str)
        //{
        //    return proteinDoBoAdapter(dl.GetProteinBySequence(str));
        //}
        

        //public BO.Protein GetProteinByName(string name)
        //{
        //    return proteinDoBoAdapter(dl.GetProteinByName(name));
        //}
        //public BO.Protein GetProteinByGI(int numOfGI)
        //{
        //    return proteinDoBoAdapter(dl.GetProteinByGI(numOfGI));
        //}
        public BO.Protein GetProtein(string ProteinGI, string ProteinName)
        {
            DO.Protein ProteinDO;
            try
            {
                ProteinDO = dl.GetProteinByGI(ProteinGI); 
            }
            catch (DO.BadProteinException ex)
            {
                throw new BO.BadProteinException(" Protein does not exist", ex);
            }
            return proteinDoBoAdapter(ProteinDO);
        }




        public BO.Protein GetProteinBySequence(string sequence)
        {
      
            //DO.Protein ProteinDO;
            //try
            //{
            //    ProteinDO = dl.GetProteinBySequence(sequence);
            //}
            //catch (DO.BadProteinException ex)
            //{
            //    throw new BO.BadProteinException(" Protein does not exist", ex);
            //}
            //return proteinDoBoAdapter(ProteinDO);
            //using (SqlConnection conn = new SqlConnection())
            {
                
                //conn.ConnectionString = @"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM proteinsTable WHERE  DATALENGTH(Sequence)="+ sequence.Length + "'", conn);
                command.CommandTimeout = 200;
                BO.Protein p = new BO.Protein();
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
                catch(Exception )
                {

                }
                conn.Close();

                return p;
            }


        }
        public BO.Protein GetProteinByName(string name)
        {
            /*
             * DO.Protein ProteinDO;
             //try
             //{
             //    ProteinDO = dl.GetProteinByName(name);
             //}
             //catch (DO.BadProteinException ex)
             //{
             //    throw new BO.BadProteinException(" Protein does not exist", ex);
             //} DATALENGTH(Sequence)
             //return proteinDoBoAdapter(ProteinDO);
            */

           // using (SqlConnection conn = new SqlConnection())
            {
                //conn.ConnectionString = @"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM proteinsTable2 WHERE ProteinName = "+"'"+name+"' ", conn);
                BO.Protein p = new BO.Protein();
                command.CommandTimeout = 200;
                using (SqlDataReader reader = command.ExecuteReader())
                {

                     while(reader.Read())
                    {
                       // if (seq == reader[2].ToString())
                        {
                            p.ProteinGI = (reader[0]).ToString();
                            p.ProteinName = reader[1].ToString();
                            p.Sequence = reader[2].ToString();
                        }

                    }
                    //else
                    //{
                    //    throw new BO.BadProteinException(name, " Protein does not exist");
                    //}
                }
                conn.Close();

                return p;
            }


        }


        public BO.Protein GetProteinByGI(string numOfGI)
        {
            //DO.Protein ProteinDO;
            //try
            //{
            //    ProteinDO = dl.GetProteinByGI(numOfGI);
            //}
            //catch (DO.BadProteinException ex)
            //{
            //    throw new BO.BadProteinException(" Protein does not exist", ex);
            //}
            //return proteinDoBoAdapter(ProteinDO);



           // using (SqlConnection conn = new SqlConnection())
            {
                //conn.ConnectionString = @"Server= DESKTOP-O6INSSA; Database=PentamerDataBase ;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM proteinsTable2 WHERE ProteinGI = " + "'" + numOfGI + "'", conn);
                command.CommandTimeout = 200;
                BO.Protein p = new BO.Protein();
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
                        throw new BO.BadProteinException(numOfGI, " Protein does not exist");
                    }
                }
                conn.Close();

                return p;
            }


        }

        public void AddProtein(BO.Protein protein)
        {
            DO.Protein ProteinDO = new DO.Protein();
            protein.CopyPropertiesTo(ProteinDO);
            try
            {
                dl.AddProtein(ProteinDO); 
            }
            catch (DO.BadProteinException ex)
            {
                throw new BO.BadProteinException("Duplicate Protein", ex);
            }
            
        }

        
        public void DeleteProtein(string ProteinGI, string ProteinName)
        {
            try
            {
                dl.DeleteProtein( ProteinGI,   ProteinName); 
            }
            catch (DO.BadProteinException ex)
            {
                throw new BO.BadProteinException("Protein does not exist", ex);

            }
            
            
        }
         
        public IEnumerable<BO.Protein> GetALLProtein()
        {
            return from item in dl.GetALLProtein()
                   select proteinDoBoAdapter(item);
                   
        }


        #endregion


        #region VirtualSequence
        //public void AddVirtualSequence();

        public IEnumerable<BO.VirtualSequence> GetAllVirtualSequences()
        {
            return (from item in dl.GetAllVirtualSequences()
                    orderby item.Sequence
                    select VirtualSequenceDoBoAdapter(item));
        }


        public BO.VirtualSequence VirtualSequenceDoBoAdapter(DO.VirtualSequence DOVS)
        {
            BO.VirtualSequence BOVS = new BO.VirtualSequence();
            DOVS.CopyPropertiesTo(BOVS);
            return BOVS;
        }
        public BO.VirtualSequence GetVirtualSequence(string Sequence)
        {

            DO.VirtualSequence VirtualSequenceDO;
            try
            {
                VirtualSequenceDO = dl.GetVirtualSequence(Sequence);
            }
            catch (DO.BadVirtualSequenceException ex)
            {
                throw new BO.BadVirtualSequenceException(" Virtual Sequence does not exist", ex);
            }
            return VirtualSequenceDoBoAdapter(VirtualSequenceDO);

            
        }
 
        public void AddVirtualSequence(BO.VirtualSequence VirtualSequence)
        {
            DO.VirtualSequence VirtualSequenceDO = new DO.VirtualSequence();
            VirtualSequence.CopyPropertiesTo(VirtualSequenceDO);
            try
            {
                dl.AddVirtualSequence(VirtualSequenceDO);
            }
            catch (DO.BadProteinException ex)
            {
                throw new BO.BadProteinException("Duplicate Virtual Sequence", ex);
            }

 
        }

          
        public void DeleteVirtualSequence(string Sequence)
        {

            try
            {
                dl.DeleteVirtualSequence(Sequence);
            }
            catch (DO.BadVirtualSequenceException ex)
            {
                throw new BO.BadVirtualSequenceException("VirtualSequence does not exist", ex);

            }
            
        }
        
        public IEnumerable<BO.VirtualSequence> GetALLVirtualSequencesBySize(int size)
        {
            return (from item in dl.GetALLVirtualSequencesBySize(size)
                    orderby item.Sequence
                    select VirtualSequenceDoBoAdapter(item));
            
        }
         
        #endregion
    }
}
