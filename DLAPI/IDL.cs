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
        //#region Protein
        //DO.Protein GetProtein(string ProteinGI, string ProteinName);
        DO.Protein GetProteinBySequence(string sequence);
        DO.Protein GetProteinByName(string name);
        DO.Protein GetProteinByGI(int numOfGI);
        //void AddProtein(DO.Protein protein);
        //void DeleteProtein(string ProteinGI, string ProteinName);
        //IEnumerable<DO.Protein> GetALLProtein();
        //#endregion

        //#region VirtualSequence
        //DO.VirtualSequence GetVirtualSequence(string Sequence);
        //void AddVirtualSequence(DO.VirtualSequence VirtualSequence);
        //void DeleteVirtualSequence(string Sequence);
        //IEnumerable<DO.VirtualSequence> GetALLVirtualSequencesBySize(int size);
        IEnumerable<DO.VirtualSequence> GetAllVirtualSequences();
        //#endregion


        //#region Pentamer
        //IEnumerable<DO.Pentamer> GetAllPentamer();
        IEnumerable<DO.Pentamer> GetPentamersBySequence(string sequence);
       // DO.Pentamer GetPentamerByProteinGI(string ProteinGI);
        //DO.Pentamer GetPentamerByProteinName(string ProteinName);
        DO.Pentamer GetPentamerBySequence(string Sequence);
        //void AddPentamer(DO.Pentamer pentamer);
        //void DeletePentamer(string proteinGI, string sequence, int firstIndex);
        IEnumerable<DO.Pentamer> Search(DO.Pentamer pntaDO);
        //#endregion
    }
}
