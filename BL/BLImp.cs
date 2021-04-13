using System;
using System.Collections.Generic;
using System.Linq;
using DLAPI;
using BLAPI;
using System.Threading;
using BO;
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

        #region Pentamer
        BO.Pentamer PentamerDoBoAdapter(DO.Pentamer DOPentamer)
        {
            BO.Pentamer BOPentamer = new BO.Pentamer();
            DOPentamer.CopyPropertiesTo(BOPentamer);
            return BOPentamer;
        }
        public UniquenessTest search(BO.Pentamer pntaBO)
        {
            int count = 0;
            DO.Pentamer pntaDO = new DO.Pentamer();
            pntaBO.CopyPropertiesTo(pntaDO);
            IEnumerable<DO.Pentamer> pentamerList = dl.Search(pntaDO);
            foreach (DO.Pentamer pntDO in pentamerList)
            {
                if (!pntDO.ProteinGI.Equals(pntaBO.ProteinGI))
                    count++;
            }
            if (count == 0)
                return UniquenessTest.Unique;
            if (count == 1)
                return UniquenessTest.SemiUnique;
            return UniquenessTest.NotUnique;
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
         
        public BO.Pentamer GetPentamerByProteinGI(string ProteinGI)
        {

            DO.Pentamer PentamerDO;
            try
            {
                PentamerDO = dl.GetPentamerByProteinGI(ProteinGI );
            }
            catch (DO.BadPentamerProteinGIException ex)
            {
                throw new BO.BadPentamerProteinGIException(" Pentamer does not exist", ex);
            }
            return PentamerDoBoAdapter(PentamerDO);
             
        }
        public BO.Pentamer GetPentamerByProteinName(string ProteinName)
        {
            DO.Pentamer PentamerDO;
            try
            {
                PentamerDO = dl.GetPentamerByProteinName(ProteinName);
            }
            catch (DO.BadPentamerProteinNameException ex)
            {
                throw new BO.BadPentamerProteinNameException(" Pentamer does not exist", ex);
            }
            return PentamerDoBoAdapter(PentamerDO);
             
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
        BO.Protein proteinDoBoAdapter(DO.Protein DOProtein)
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
                ProteinDO = dl.GetProtein(ProteinGI,  ProteinName); 
            }
            catch (DO.BadProteinException ex)
            {
                throw new BO.BadProteinException(" Protein does not exist", ex);
            }
            return proteinDoBoAdapter(ProteinDO);
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
            DO.Protein ProteinDO;
            try
            {
                ProteinDO = dl.GetProteinByName(name);
            }
            catch (DO.BadProteinException ex)
            {
                throw new BO.BadProteinException(" Protein does not exist", ex);
            }
            return proteinDoBoAdapter(ProteinDO);
            
        }
        public BO.Protein GetProteinByGI(int numOfGI)
        {
            DO.Protein ProteinDO;
            try
            {
                ProteinDO = dl.GetProteinByGI(numOfGI);
            }
            catch (DO.BadProteinException ex)
            {
                throw new BO.BadProteinException(" Protein does not exist", ex);
            }
            return proteinDoBoAdapter(ProteinDO);
            
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
         
        public IEnumerable<DO.Protein> GetALLProtein()
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


        BO.VirtualSequence VirtualSequenceDoBoAdapter(DO.VirtualSequence DOVS)
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
        
        public IEnumerable<DO.VirtualSequence> GetALLVirtualSequencesBySize(int size)
        {
            return (from item in dl.GetALLVirtualSequencesBySize(size)
                    orderby item.Sequence
                    select VirtualSequenceDoBoAdapter(item));
            
        }
         
        #endregion
    }
}
