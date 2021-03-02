using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using DLAPI;
//using DO;
using DS;

namespace DL
{
    sealed class DLObject : IDL    //internal

    {
        #region singelton
        static readonly DLObject instance = new DLObject();
        static DLObject() { }// static ctor to ensure instance init is done just before first usage
        DLObject() { } // default => private
        public static DLObject Instance { get => instance; }// The public Instance property to use
        #endregion

        #region Pentamer
        public IEnumerable<DO.Pentamer> Search(DO.Pentamer pntaDO)
        {
            return from P in DataSource.ListOfPentamers
                   where P.Sequence == pntaDO.Sequence
                   select P;
        }
        #endregion


        #region Protein
        public DO.Protein GetProteinBySequence(string str)
        {
            return (DataSource.ListOfProteins.FirstOrDefault(p => p.Sequence == str)).Clone();
        }
        public DO.Protein GetProteinByName(string name)
        {
            return (DataSource.ListOfProteins.FirstOrDefault(p => p.ProteinName == name)).Clone();
        }
        public DO.Protein GetProteinByGI(int numOfGI)
        {
            return (DataSource.ListOfProteins.FirstOrDefault(p => p.ProteinGI == numOfGI)).Clone();
        }
        #endregion


        #region VirtualSequence
        //public void AddVirtualSequence();

        public IEnumerable<DO.VirtualSequence> GetAllVirtualSequences()
        {
            return(from item in DataSource.ListOfVS
                   orderby item.Sequence
                   select item.Clone());
        }
        #endregion
    }
}