using System;
using System.Collections.Generic;
using System.Linq;
using DLAPI;
using BLAPI;
using System.Threading;
using BO;
//using BO;

using System;
using System.Collections.Generic;
using System.Linq;
using DLAPI;
using BLAPI;
using System.Threading;
using BO;
//

namespace BL
{
    class BLImp : IBL //internal
    {
        IDL dl = DLFactory.GetDL();

        #region Pentamer
        public UniquenessTest search(BO.Pentamer pntaBO)
        {
            int count = 0;
            DO.Pentamer pntaDO = new DO.Pentamer();
            pntaBO.CopyPropertiesTo(pntaDO);
            IEnumerable<DO.Pentamer> pentamerList = dl.search(pntaDO);
            foreach (DO.Pentamer pntDO in pentamerList)
            {
                if (pntDO.ProteinGI != pntaBO.ProteinGI)
                    count++;
            }
            if (count == 0)
                return UniquenessTest.Unique;
            if (count == 1)
                return UniquenessTest.SemiUnique;
            return UniquenessTest.NotUnique;
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

    }
}
