using System;
using System.Collections.Generic;

//using DO;

namespace DLAPI
{
    //CRUD Logic:
    // Create - add new instance
    // Request - ask for an instance or for a collection
    // Update - update properties of an instance
    // Delete - delete an instance
    public interface IDL
    {


        //CRUD Logic:
        // Create - add new instance
        // Request - ask for an instance or for a collection
        // Update - update properties of an instance
        // Delete - delete an instance
            #region Pentamer
            IEnumerable<DO.Pentamer> Search(DO.Pentamer pntaDO);
        IEnumerable<DO.Pentamer> GetPentamersBySequence(string S);
        #endregion


        #region Protein
        DO.Protein GetProteinBySequence(string str);
        DO.Protein GetProteinByName(string name);
        DO.Protein GetProteinByGI(int numOfGI);
        #endregion


        #region VirtualSequence
        IEnumerable<DO.VirtualSequence> GetAllVirtualSequences();
        #endregion


    }
}
