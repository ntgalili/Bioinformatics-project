﻿using System;
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
        IEnumerable<BO.Pentamer> GetAllPentamer();
        IEnumerable<BO.Pentamer> GetPentamerByProteinGI(string ProteinGI);
        IEnumerable<BO.Pentamer> GetPentamerByProteinName(string ProteinName);
        BO.Pentamer GetPentamerBySequence(string Sequence);
        void AddPentamer(BO.Pentamer pentamer);
        void DeletePentamer(string proteinGI, string sequence, int firstIndex);
        IEnumerable<BO.Pentamer> Search(BO.Pentamer pntaDO);
        #endregion


        #region Protein
        BO.Protein GetProteinBySequence(string str);
        BO.Protein GetProteinByName(string name);
        BO.Protein GetProteinByGI(int numOfGI);
        BO.Protein GetProtein(string ProteinGI, string ProteinName);
        void AddProtein(BO.Protein protein);
        void DeleteProtein(string ProteinGI, string ProteinName);
        IEnumerable<BO.Protein> GetALLProtein();
        #endregion


        #region VirtualSequence
        IEnumerable<BO.VirtualSequence> GetAllVirtualSequences();
        #endregion
    }
}
    