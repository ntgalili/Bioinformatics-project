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
        public IEnumerable<DO.Pentamer> search(DO.Pentamer pntaDO)
        {
            return from P in DataSource.ListOfPentamers
                   where P.Sequence == pntaDO.Sequence
                   select P;
        }
        #endregion
    }
}