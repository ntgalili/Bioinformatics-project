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

        #endregion



        #region Protein
        BO.Protein proteinDoBoAdapter(DO.Protein DOProtein)
        {
            BO.Protein BOProtein = new BO.Protein();
            DOProtein.CopyPropertiesTo(BOProtein);
            return BOProtein;
        }
        public BO.Protein GetProteinBySequence(string str)
        {
            return proteinDoBoAdapter(dl.GetProteinBySequence(str));
        }
        public BO.Protein GetProteinByName(string name)
        {
            return proteinDoBoAdapter(dl.GetProteinByName(name));
        }
        public BO.Protein GetProteinByGI(int numOfGI)
        {
            return proteinDoBoAdapter(dl.GetProteinByGI(numOfGI));
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
        #endregion
    }
}
