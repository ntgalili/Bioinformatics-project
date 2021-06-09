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
        //public IEnumerable<BO.Pentamer> GetAllPentamer()
        //{    
        //    return from item in dl.GetAllPentamer()
        //           select PentamerDoBoAdapter(item);
        //}
         
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

        public IEnumerable<BO.Pentamer> GetPentamerBySequence(string Sequence)
        {
            return from item in dl.GetPentamersBySequence(Sequence)
                   select PentamerDoBoAdapter(item);


        }
         
        //public void AddPentamer(BO.Pentamer pentamer)
        //{

        //    DO.Pentamer PentamerDO = new DO.Pentamer();
        //    pentamer.CopyPropertiesTo(PentamerDO);
        //    try
        //    {
        //        dl.AddPentamer(PentamerDO);
        //    }
        //    catch (DO.BadPentamerException ex)// אין חרגיה ב  DLXML
        //    {
        //        throw new BO.BadPentamerException("Duplicate Pentamer", ex);
        //    }

        //}
        //public void DeletePentamer(string proteinGI, string sequence, int firstIndex)
        //{
        //    try
        //    {
        //        dl.DeletePentamer(proteinGI, sequence, firstIndex);
        //    }
        //    catch (DO.BadPentamerException ex)
        //    {
        //        throw new BO.BadPentamerException("Pentamer  does not exist", ex);

        //    }
            
        //}
        //public IEnumerable<BO.Pentamer> Search(BO.Pentamer pntaDO)
        //{
        //    DO.Pentamer PentamerDO = new DO.Pentamer();
        //    pntaDO.CopyPropertiesTo(PentamerDO);
        //    return from P in dl.Search(PentamerDO)
        //        select PentamerDoBoAdapter(P);
        //}

        #endregion



        #region Protein
        public BO.Protein proteinDoBoAdapter(DO.Protein DOProtein)
        {
            BO.Protein BOProtein = new BO.Protein();
            DOProtein.CopyPropertiesTo(BOProtein);
            return BOProtein;
        }


        public BO.Protein GetProteinBySequence(string sequence)
        {

            DO.Protein ProteinDO;
            try
            {
                ProteinDO = dl.GetProteinBySequence(sequence);
            }
            catch (DO.BadProteinException ex)
            {
                throw new BO.BadProteinException(" Protein does not exist", ex);
            }
            return proteinDoBoAdapter(ProteinDO);

        }

        public BO.Protein GetProteinByName(string name)
        {
            DO.Protein DOp;
            try
            {
                DOp = dl.GetProteinByGI(name);
            }
            catch (Exception ex)
            {

                throw new BO.BadProteinException(name, " Protein does not exist");
            }

            return proteinDoBoAdapter(DOp);

        }


        public BO.Protein GetProteinByGI(string numOfGI)
        {
            DO.Protein DOp;
            try
            {
                DOp = dl.GetProteinByGI(numOfGI);
            }
            catch(Exception ex)
            {

                throw new BO.BadProteinException(numOfGI, " Protein does not exist");
            }

            return proteinDoBoAdapter(DOp);
        }


        #endregion


        #region VirtualSequence
        //public void AddVirtualSequence();


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

         
        #endregion
    }
}
