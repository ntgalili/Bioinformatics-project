using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BO;


namespace BLAPI
{
    public interface IBL
    {


        #region Pentamer
        BO.UniquenessTest search(BO.Pentamer pnta);
        IEnumerable<BO.Pentamer> GetPentamersBySequence(string S);
        //IEnumerable<BO.Pentamer> cutting(string str);
        #endregion


        #region Protein
        BO.Protein GetProteinBySequence(string str);
        BO.Protein GetProteinByName(string name);
        BO.Protein GetProteinByGI(int numOfGI);
        #endregion


        #region VirtualSequence
        IEnumerable<BO.VirtualSequence> GetAllVirtualSequences();
        #endregion
    }
}
    