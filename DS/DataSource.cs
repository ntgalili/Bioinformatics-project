﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DO;
namespace DS
{
    public static class DataSource
    {


        /// <summary>
        /// 
        /// </summary>
        public static List<Pentamer> ListOfPentamers;
        public static List<Protein> ListOfProteins;
        public static List<VirtualSequence> ListOfVS;




        public static void SaveListToXMLSerializer<T>(List<T> list, string filePath)
        {
            try
            {
                FileStream file = new FileStream(@"xml\" + filePath, FileMode.Create);
                XmlSerializer x = new XmlSerializer(list.GetType());
                x.Serialize(file, list);
                file.Close();
            }
            catch (Exception ex)
            {
                //  throw new DO.XMLFileLoadCreateException(filePath, $"fail to create xml file: {filePath}", ex);
            }
        }

        static DataSource()
        {
            InitAllLists();
            SaveListToXMLSerializer(ListOfPentamers, @"ListOfPentamersXml.xml");
            SaveListToXMLSerializer(ListOfProteins, @"ListOfProteinsXml.xml");
            SaveListToXMLSerializer(ListOfVS, @"ListOfVSXml.xml");

        }


        static void InitAllLists()
        {
            ListOfPentamers = new List<Pentamer>
            {
               new Pentamer
              {
                 FirstIndex=0,
                 LastIndex=4,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MDTDS",
            },
             new Pentamer
              {
                 FirstIndex=1,
                 LastIndex=5,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DTDSQ",
            },
             new Pentamer
              {
                 FirstIndex=2,
                 LastIndex=6,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TDSQR",
            },
             new Pentamer
              {
                 FirstIndex=3,
                 LastIndex=7,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DSQRS",
            },
             new Pentamer
              {
                 FirstIndex=4,
                 LastIndex=8,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SQRSH",
            },
             new Pentamer
              {
                 FirstIndex=5,
                 LastIndex=9,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QRSHL",
            },
             new Pentamer
              {
                 FirstIndex=6,
                 LastIndex=10,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RSHLS",
            },
             new Pentamer
              {
                 FirstIndex=7,
                 LastIndex=11,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SHLSS",
            },
             new Pentamer
              {
                 FirstIndex=8,
                 LastIndex=12,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HLSSF",
            },
             new Pentamer
              {
                 FirstIndex=9,
                 LastIndex=13,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSSFT",
            },
             new Pentamer
              {
                 FirstIndex=10,
                 LastIndex=14,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSFTM",
            },
             new Pentamer
              {
                 FirstIndex=11,
                 LastIndex=15,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SFTMK",
            },
             new Pentamer
              {
                 FirstIndex=12,
                 LastIndex=16,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FTMKL",
            },
             new Pentamer
              {
                 FirstIndex=13,
                 LastIndex=17,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TMKLM",
            },
             new Pentamer
              {
                 FirstIndex=14,
                 LastIndex=18,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MKLMD",
            },
             new Pentamer
              {
                 FirstIndex=15,
                 LastIndex=19,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KLMDK",
            },
             new Pentamer
              {
                 FirstIndex=16,
                 LastIndex=20,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LMDKF",
            },
             new Pentamer
              {
                 FirstIndex=17,
                 LastIndex=21,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MDKFH",
            },
             new Pentamer
              {
                 FirstIndex=18,
                 LastIndex=22,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DKFHS",
            },
             new Pentamer
              {
                 FirstIndex=19,
                 LastIndex=23,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KFHSP",
            },
             new Pentamer
              {
                 FirstIndex=20,
                 LastIndex=24,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FHSPK",
            },
             new Pentamer
              {
                 FirstIndex=21,
                 LastIndex=25,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HSPKI",
            },
             new Pentamer
              {
                 FirstIndex=22,
                 LastIndex=26,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPKIK",
            },
             new Pentamer
              {
                 FirstIndex=23,
                 LastIndex=27,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PKIKR",
            },
             new Pentamer
              {
                 FirstIndex=24,
                 LastIndex=28,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KIKRT",
            },
             new Pentamer
              {
                 FirstIndex=25,
                 LastIndex=29,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IKRTP",
            },
             new Pentamer
              {
                 FirstIndex=26,
                 LastIndex=30,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KRTPS",
            },
             new Pentamer
              {
                 FirstIndex=27,
                 LastIndex=31,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RTPSK",
            },
             new Pentamer
              {
                 FirstIndex=28,
                 LastIndex=32,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TPSKK",
            },
             new Pentamer
              {
                 FirstIndex=29,
                 LastIndex=33,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PSKKG",
            },
             new Pentamer
              {
                 FirstIndex=30,
                 LastIndex=34,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SKKGK",
            },
             new Pentamer
              {
                 FirstIndex=31,
                 LastIndex=35,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KKGKP",
            },
             new Pentamer
              {
                 FirstIndex=32,
                 LastIndex=36,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KGKPA",
            },
             new Pentamer
              {
                 FirstIndex=33,
                 LastIndex=37,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GKPAE",
            },
             new Pentamer
              {
                 FirstIndex=34,
                 LastIndex=38,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KPAEV",
            },
             new Pentamer
              {
                 FirstIndex=35,
                 LastIndex=39,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PAEVS",
            },
             new Pentamer
              {
                 FirstIndex=36,
                 LastIndex=40,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AEVSV",
            },
             new Pentamer
              {
                 FirstIndex=37,
                 LastIndex=41,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EVSVK",
            },
             new Pentamer
              {
                 FirstIndex=38,
                 LastIndex=42,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VSVKI",
            },
             new Pentamer
              {
                 FirstIndex=39,
                 LastIndex=43,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SVKIP",
            },
             new Pentamer
              {
                 FirstIndex=40,
                 LastIndex=44,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VKIPE",
            },
             new Pentamer
              {
                 FirstIndex=41,
                 LastIndex=45,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KIPEK",
            },
             new Pentamer
              {
                 FirstIndex=42,
                 LastIndex=46,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IPEKP",
            },
             new Pentamer
              {
                 FirstIndex=43,
                 LastIndex=47,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PEKPV",
            },
             new Pentamer
              {
                 FirstIndex=44,
                 LastIndex=48,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKPVN",
            },
             new Pentamer
              {
                 FirstIndex=45,
                 LastIndex=49,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KPVNK",
            },
             new Pentamer
              {
                 FirstIndex=46,
                 LastIndex=50,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PVNKE",
            },
             new Pentamer
              {
                 FirstIndex=47,
                 LastIndex=51,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VNKEA",
            },
             new Pentamer
              {
                 FirstIndex=48,
                 LastIndex=52,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NKEAT",
            },
             new Pentamer
              {
                 FirstIndex=49,
                 LastIndex=53,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KEATD",
            },
             new Pentamer
              {
                 FirstIndex=50,
                 LastIndex=54,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EATDR",
            },
             new Pentamer
              {
                 FirstIndex=51,
                 LastIndex=55,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ATDRF",
            },
             new Pentamer
              {
                 FirstIndex=52,
                 LastIndex=56,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TDRFL",
            },
             new Pentamer
              {
                 FirstIndex=53,
                 LastIndex=57,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DRFLP",
            },
             new Pentamer
              {
                 FirstIndex=54,
                 LastIndex=58,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RFLPE",
            },
             new Pentamer
              {
                 FirstIndex=55,
                 LastIndex=59,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FLPEG",
            },
             new Pentamer
              {
                 FirstIndex=56,
                 LastIndex=60,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPEGY",
            },
             new Pentamer
              {
                 FirstIndex=57,
                 LastIndex=61,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PEGYP",
            },
             new Pentamer
              {
                 FirstIndex=58,
                 LastIndex=62,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EGYPL",
            },
             new Pentamer
              {
                 FirstIndex=59,
                 LastIndex=63,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GYPLP",
            },
             new Pentamer
              {
                 FirstIndex=60,
                 LastIndex=64,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YPLPL",
            },
             new Pentamer
              {
                 FirstIndex=61,
                 LastIndex=65,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLPLD",
            },
             new Pentamer
              {
                 FirstIndex=62,
                 LastIndex=66,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPLDL",
            },
             new Pentamer
              {
                 FirstIndex=63,
                 LastIndex=67,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLDLE",
            },
             new Pentamer
              {
                 FirstIndex=64,
                 LastIndex=68,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LDLEQ",
            },
             new Pentamer
              {
                 FirstIndex=65,
                 LastIndex=69,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DLEQQ",
            },
             new Pentamer
              {
                 FirstIndex=66,
                 LastIndex=70,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LEQQA",
            },
             new Pentamer
              {
                 FirstIndex=67,
                 LastIndex=71,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EQQAV",
            },
             new Pentamer
              {
                 FirstIndex=68,
                 LastIndex=72,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QQAVE",
            },
             new Pentamer
              {
                 FirstIndex=69,
                 LastIndex=73,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QAVEF",
            },
             new Pentamer
              {
                 FirstIndex=70,
                 LastIndex=74,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AVEFM",
            },
             new Pentamer
              {
                 FirstIndex=71,
                 LastIndex=75,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VEFMS",
            },
             new Pentamer
              {
                 FirstIndex=72,
                 LastIndex=76,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EFMST",
            },
             new Pentamer
              {
                 FirstIndex=73,
                 LastIndex=77,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FMSTS",
            },
             new Pentamer
              {
                 FirstIndex=74,
                 LastIndex=78,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MSTSA",
            },
             new Pentamer
              {
                 FirstIndex=75,
                 LastIndex=79,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="STSAV",
            },
             new Pentamer
              {
                 FirstIndex=76,
                 LastIndex=80,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TSAVA",
            },
             new Pentamer
              {
                 FirstIndex=77,
                 LastIndex=81,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SAVAS",
            },
             new Pentamer
              {
                 FirstIndex=78,
                 LastIndex=82,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AVASR",
            },
             new Pentamer
              {
                 FirstIndex=79,
                 LastIndex=83,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VASRS",
            },
             new Pentamer
              {
                 FirstIndex=80,
                 LastIndex=84,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ASRSQ",
            },
             new Pentamer
              {
                 FirstIndex=81,
                 LastIndex=85,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SRSQR",
            },
             new Pentamer
              {
                 FirstIndex=82,
                 LastIndex=86,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RSQRQ",
            },
             new Pentamer
              {
                 FirstIndex=83,
                 LastIndex=87,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SQRQK",
            },
             new Pentamer
              {
                 FirstIndex=84,
                 LastIndex=88,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QRQKN",
            },
             new Pentamer
              {
                 FirstIndex=85,
                 LastIndex=89,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RQKNL",
            },
             new Pentamer
              {
                 FirstIndex=86,
                 LastIndex=90,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QKNLS",
            },
             new Pentamer
              {
                 FirstIndex=87,
                 LastIndex=91,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KNLSW",
            },
             new Pentamer
              {
                 FirstIndex=88,
                 LastIndex=92,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NLSWL",
            },
             new Pentamer
              {
                 FirstIndex=89,
                 LastIndex=93,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSWLE",
            },
             new Pentamer
              {
                 FirstIndex=90,
                 LastIndex=94,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SWLEE",
            },
             new Pentamer
              {
                 FirstIndex=91,
                 LastIndex=95,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="WLEEK",
            },
             new Pentamer
              {
                 FirstIndex=92,
                 LastIndex=96,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LEEKE",
            },
             new Pentamer
              {
                 FirstIndex=93,
                 LastIndex=97,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EEKEK",
            },
             new Pentamer
              {
                 FirstIndex=94,
                 LastIndex=98,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKEKE",
            },
             new Pentamer
              {
                 FirstIndex=95,
                 LastIndex=99,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KEKEV",
            },
             new Pentamer
              {
                 FirstIndex=96,
                 LastIndex=100,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKEVV",
            },
             new Pentamer
              {
                 FirstIndex=97,
                 LastIndex=101,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KEVVS",
            },
             new Pentamer
              {
                 FirstIndex=98,
                 LastIndex=102,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EVVSA",
            },
             new Pentamer
              {
                 FirstIndex=99,
                 LastIndex=103,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VVSAL",
            },
             new Pentamer
              {
                 FirstIndex=100,
                 LastIndex=104,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VSALR",
            },
             new Pentamer
              {
                 FirstIndex=101,
                 LastIndex=105,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SALRY",
            },
             new Pentamer
              {
                 FirstIndex=102,
                 LastIndex=106,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ALRYF",
            },
             new Pentamer
              {
                 FirstIndex=103,
                 LastIndex=107,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LRYFK",
            },
             new Pentamer
              {
                 FirstIndex=104,
                 LastIndex=108,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RYFKT",
            },
             new Pentamer
              {
                 FirstIndex=105,
                 LastIndex=109,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YFKTI",
            },
             new Pentamer
              {
                 FirstIndex=106,
                 LastIndex=110,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FKTIV",
            },
             new Pentamer
              {
                 FirstIndex=107,
                 LastIndex=111,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KTIVD",
            },
             new Pentamer
              {
                 FirstIndex=108,
                 LastIndex=112,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TIVDK",
            },
             new Pentamer
              {
                 FirstIndex=109,
                 LastIndex=113,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IVDKM",
            },
             new Pentamer
              {
                 FirstIndex=110,
                 LastIndex=114,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VDKMA",
            },
             new Pentamer
              {
                 FirstIndex=111,
                 LastIndex=115,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DKMAI",
            },
             new Pentamer
              {
                 FirstIndex=112,
                 LastIndex=116,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KMAID",
            },
             new Pentamer
              {
                 FirstIndex=113,
                 LastIndex=117,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MAIDK",
            },
             new Pentamer
              {
                 FirstIndex=114,
                 LastIndex=118,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AIDKK",
            },
             new Pentamer
              {
                 FirstIndex=115,
                 LastIndex=119,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IDKKV",
            },
             new Pentamer
              {
                 FirstIndex=116,
                 LastIndex=120,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DKKVL",
            },
             new Pentamer
              {
                 FirstIndex=117,
                 LastIndex=121,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KKVLE",
            },
             new Pentamer
              {
                 FirstIndex=118,
                 LastIndex=122,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KVLEM",
            },
             new Pentamer
              {
                 FirstIndex=119,
                 LastIndex=123,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VLEML",
            },
             new Pentamer
              {
                 FirstIndex=120,
                 LastIndex=124,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LEMLP",
            },
             new Pentamer
              {
                 FirstIndex=121,
                 LastIndex=125,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EMLPG",
            },
             new Pentamer
              {
                 FirstIndex=122,
                 LastIndex=126,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MLPGS",
            },
             new Pentamer
              {
                 FirstIndex=123,
                 LastIndex=127,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPGSA",
            },
             new Pentamer
              {
                 FirstIndex=124,
                 LastIndex=128,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PGSAS",
            },
             new Pentamer
              {
                 FirstIndex=125,
                 LastIndex=129,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GSASK",
            },
             new Pentamer
              {
                 FirstIndex=126,
                 LastIndex=130,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SASKV",
            },
             new Pentamer
              {
                 FirstIndex=127,
                 LastIndex=131,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ASKVL",
            },
             new Pentamer
              {
                 FirstIndex=128,
                 LastIndex=132,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SKVLE",
            },
             new Pentamer
              {
                 FirstIndex=129,
                 LastIndex=133,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KVLEA",
            },
             new Pentamer
              {
                 FirstIndex=130,
                 LastIndex=134,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VLEAI",
            },
             new Pentamer
              {
                 FirstIndex=131,
                 LastIndex=135,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LEAIL",
            },
             new Pentamer
              {
                 FirstIndex=132,
                 LastIndex=136,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EAILP",
            },
             new Pentamer
              {
                 FirstIndex=133,
                 LastIndex=137,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AILPL",
            },
             new Pentamer
              {
                 FirstIndex=134,
                 LastIndex=138,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ILPLV",
            },
             new Pentamer
              {
                 FirstIndex=135,
                 LastIndex=139,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPLVQ",
            },
             new Pentamer
              {
                 FirstIndex=136,
                 LastIndex=140,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLVQN",
            },
             new Pentamer
              {
                 FirstIndex=137,
                 LastIndex=141,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LVQND",
            },
             new Pentamer
              {
                 FirstIndex=138,
                 LastIndex=142,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VQNDP",
            },
             new Pentamer
              {
                 FirstIndex=139,
                 LastIndex=143,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QNDPR",
            },
             new Pentamer
              {
                 FirstIndex=140,
                 LastIndex=144,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NDPRI",
            },
             new Pentamer
              {
                 FirstIndex=141,
                 LastIndex=145,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DPRIQ",
            },
             new Pentamer
              {
                 FirstIndex=142,
                 LastIndex=146,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PRIQH",
            },
             new Pentamer
              {
                 FirstIndex=143,
                 LastIndex=147,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RIQHS",
            },
             new Pentamer
              {
                 FirstIndex=144,
                 LastIndex=148,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IQHSS",
            },
             new Pentamer
              {
                 FirstIndex=145,
                 LastIndex=149,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QHSSA",
            },
             new Pentamer
              {
                 FirstIndex=146,
                 LastIndex=150,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HSSAL",
            },
             new Pentamer
              {
                 FirstIndex=147,
                 LastIndex=151,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSALS",
            },
             new Pentamer
              {
                 FirstIndex=148,
                 LastIndex=152,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SALSS",
            },
             new Pentamer
              {
                 FirstIndex=149,
                 LastIndex=153,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ALSSC",
            },
             new Pentamer
              {
                 FirstIndex=150,
                 LastIndex=154,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSSCY",
            },
             new Pentamer
              {
                 FirstIndex=151,
                 LastIndex=155,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSCYS",
            },
             new Pentamer
              {
                 FirstIndex=152,
                 LastIndex=156,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SCYSR",
            },
             new Pentamer
              {
                 FirstIndex=153,
                 LastIndex=157,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CYSRV",
            },
             new Pentamer
              {
                 FirstIndex=154,
                 LastIndex=158,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YSRVY",
            },
             new Pentamer
              {
                 FirstIndex=155,
                 LastIndex=159,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SRVYQ",
            },
             new Pentamer
              {
                 FirstIndex=156,
                 LastIndex=160,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RVYQS",
            },
             new Pentamer
              {
                 FirstIndex=157,
                 LastIndex=161,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VYQSL",
            },
             new Pentamer
              {
                 FirstIndex=158,
                 LastIndex=162,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YQSLA",
            },
             new Pentamer
              {
                 FirstIndex=159,
                 LastIndex=163,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QSLAN",
            },
             new Pentamer
              {
                 FirstIndex=160,
                 LastIndex=164,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SLANL",
            },
             new Pentamer
              {
                 FirstIndex=161,
                 LastIndex=165,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LANLI",
            },
             new Pentamer
              {
                 FirstIndex=162,
                 LastIndex=166,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ANLIR",
            },
             new Pentamer
              {
                 FirstIndex=163,
                 LastIndex=167,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NLIRW",
            },
             new Pentamer
              {
                 FirstIndex=164,
                 LastIndex=168,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LIRWS",
            },
             new Pentamer
              {
                 FirstIndex=165,
                 LastIndex=169,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IRWSD",
            },
             new Pentamer
              {
                 FirstIndex=166,
                 LastIndex=170,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RWSDQ",
            },
             new Pentamer
              {
                 FirstIndex=167,
                 LastIndex=171,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="WSDQV",
            },
             new Pentamer
              {
                 FirstIndex=168,
                 LastIndex=172,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SDQVM",
            },
             new Pentamer
              {
                 FirstIndex=169,
                 LastIndex=173,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DQVML",
            },
             new Pentamer
              {
                 FirstIndex=170,
                 LastIndex=174,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QVMLE",
            },
             new Pentamer
              {
                 FirstIndex=171,
                 LastIndex=175,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VMLEG",
            },
             new Pentamer
              {
                 FirstIndex=172,
                 LastIndex=176,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MLEGV",
            },
             new Pentamer
              {
                 FirstIndex=173,
                 LastIndex=177,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LEGVN",
            },
             new Pentamer
              {
                 FirstIndex=174,
                 LastIndex=178,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EGVNS",
            },
             new Pentamer
              {
                 FirstIndex=175,
                 LastIndex=179,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GVNSE",
            },
             new Pentamer
              {
                 FirstIndex=176,
                 LastIndex=180,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VNSED",
            },
             new Pentamer
              {
                 FirstIndex=177,
                 LastIndex=181,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NSEDK",
            },
             new Pentamer
              {
                 FirstIndex=178,
                 LastIndex=182,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SEDKE",
            },
             new Pentamer
              {
                 FirstIndex=179,
                 LastIndex=183,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EDKEM",
            },
             new Pentamer
              {
                 FirstIndex=180,
                 LastIndex=184,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DKEMV",
            },
             new Pentamer
              {
                 FirstIndex=181,
                 LastIndex=185,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KEMVT",
            },
             new Pentamer
              {
                 FirstIndex=182,
                 LastIndex=186,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EMVTT",
            },
             new Pentamer
              {
                 FirstIndex=183,
                 LastIndex=187,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MVTTV",
            },
             new Pentamer
              {
                 FirstIndex=184,
                 LastIndex=188,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VTTVK",
            },
             new Pentamer
              {
                 FirstIndex=185,
                 LastIndex=189,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TTVKG",
            },
             new Pentamer
              {
                 FirstIndex=186,
                 LastIndex=190,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TVKGV",
            },
             new Pentamer
              {
                 FirstIndex=187,
                 LastIndex=191,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VKGVI",
            },
             new Pentamer
              {
                 FirstIndex=188,
                 LastIndex=192,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KGVIK",
            },
             new Pentamer
              {
                 FirstIndex=189,
                 LastIndex=193,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GVIKA",
            },
             new Pentamer
              {
                 FirstIndex=190,
                 LastIndex=194,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VIKAV",
            },
             new Pentamer
              {
                 FirstIndex=191,
                 LastIndex=195,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IKAVL",
            },
             new Pentamer
              {
                 FirstIndex=192,
                 LastIndex=196,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KAVLD",
            },
             new Pentamer
              {
                 FirstIndex=193,
                 LastIndex=197,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AVLDG",
            },
             new Pentamer
              {
                 FirstIndex=194,
                 LastIndex=198,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VLDGV",
            },
             new Pentamer
              {
                 FirstIndex=195,
                 LastIndex=199,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LDGVK",
            },
             new Pentamer
              {
                 FirstIndex=196,
                 LastIndex=200,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DGVKE",
            },
             new Pentamer
              {
                 FirstIndex=197,
                 LastIndex=201,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GVKEL",
            },
             new Pentamer
              {
                 FirstIndex=198,
                 LastIndex=202,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VKELV",
            },
             new Pentamer
              {
                 FirstIndex=199,
                 LastIndex=203,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KELVR",
            },
             new Pentamer
              {
                 FirstIndex=200,
                 LastIndex=204,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELVRL",
            },
             new Pentamer
              {
                 FirstIndex=201,
                 LastIndex=205,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LVRLT",
            },
             new Pentamer
              {
                 FirstIndex=202,
                 LastIndex=206,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VRLTI",
            },
             new Pentamer
              {
                 FirstIndex=203,
                 LastIndex=207,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RLTIE",
            },
             new Pentamer
              {
                 FirstIndex=204,
                 LastIndex=208,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LTIEK",
            },
             new Pentamer
              {
                 FirstIndex=205,
                 LastIndex=209,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TIEKQ",
            },
             new Pentamer
              {
                 FirstIndex=206,
                 LastIndex=210,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IEKQG",
            },
             new Pentamer
              {
                 FirstIndex=207,
                 LastIndex=211,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKQGR",
            },
             new Pentamer
              {
                 FirstIndex=208,
                 LastIndex=212,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KQGRP",
            },
             new Pentamer
              {
                 FirstIndex=209,
                 LastIndex=213,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QGRPS",
            },
             new Pentamer
              {
                 FirstIndex=210,
                 LastIndex=214,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GRPSP",
            },
             new Pentamer
              {
                 FirstIndex=211,
                 LastIndex=215,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RPSPT",
            },
             new Pentamer
              {
                 FirstIndex=212,
                 LastIndex=216,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PSPTS",
            },
             new Pentamer
              {
                 FirstIndex=213,
                 LastIndex=217,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPTSP",
            },
             new Pentamer
              {
                 FirstIndex=214,
                 LastIndex=218,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PTSPV",
            },
             new Pentamer
              {
                 FirstIndex=215,
                 LastIndex=219,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TSPVK",
            },
             new Pentamer
              {
                 FirstIndex=216,
                 LastIndex=220,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPVKP",
            },
             new Pentamer
              {
                 FirstIndex=217,
                 LastIndex=221,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PVKPS",
            },
             new Pentamer
              {
                 FirstIndex=218,
                 LastIndex=222,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VKPSS",
            },
             new Pentamer
              {
                 FirstIndex=219,
                 LastIndex=223,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KPSSP",
            },
             new Pentamer
              {
                 FirstIndex=220,
                 LastIndex=224,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PSSPA",
            },
             new Pentamer
              {
                 FirstIndex=221,
                 LastIndex=225,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSPAS",
            },
             new Pentamer
              {
                 FirstIndex=222,
                 LastIndex=226,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPASK",
            },
             new Pentamer
              {
                 FirstIndex=223,
                 LastIndex=227,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PASKP",
            },
             new Pentamer
              {
                 FirstIndex=224,
                 LastIndex=228,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ASKPD",
            },
             new Pentamer
              {
                 FirstIndex=225,
                 LastIndex=229,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SKPDG",
            },
             new Pentamer
              {
                 FirstIndex=226,
                 LastIndex=230,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KPDGP",
            },
             new Pentamer
              {
                 FirstIndex=227,
                 LastIndex=231,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PDGPA",
            },
             new Pentamer
              {
                 FirstIndex=228,
                 LastIndex=232,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DGPAE",
            },
             new Pentamer
              {
                 FirstIndex=229,
                 LastIndex=233,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GPAEL",
            },
             new Pentamer
              {
                 FirstIndex=230,
                 LastIndex=234,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PAELP",
            },
             new Pentamer
              {
                 FirstIndex=231,
                 LastIndex=235,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AELPL",
            },
             new Pentamer
              {
                 FirstIndex=232,
                 LastIndex=236,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELPLT",
            },
             new Pentamer
              {
                 FirstIndex=233,
                 LastIndex=237,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPLTD",
            },
             new Pentamer
              {
                 FirstIndex=234,
                 LastIndex=238,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLTDR",
            },
             new Pentamer
              {
                 FirstIndex=235,
                 LastIndex=239,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LTDRE",
            },
             new Pentamer
              {
                 FirstIndex=236,
                 LastIndex=240,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TDREV",
            },
             new Pentamer
              {
                 FirstIndex=237,
                 LastIndex=241,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DREVE",
            },
             new Pentamer
              {
                 FirstIndex=238,
                 LastIndex=242,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="REVEI",
            },
             new Pentamer
              {
                 FirstIndex=239,
                 LastIndex=243,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EVEIL",
            },
             new Pentamer
              {
                 FirstIndex=240,
                 LastIndex=244,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VEILN",
            },
             new Pentamer
              {
                 FirstIndex=241,
                 LastIndex=245,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EILNK",
            },
             new Pentamer
              {
                 FirstIndex=242,
                 LastIndex=246,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ILNKT",
            },
             new Pentamer
              {
                 FirstIndex=243,
                 LastIndex=247,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LNKTT",
            },
             new Pentamer
              {
                 FirstIndex=244,
                 LastIndex=248,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NKTTG",
            },
             new Pentamer
              {
                 FirstIndex=245,
                 LastIndex=249,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KTTGM",
            },
             new Pentamer
              {
                 FirstIndex=246,
                 LastIndex=250,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TTGMS",
            },
             new Pentamer
              {
                 FirstIndex=247,
                 LastIndex=251,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TGMSQ",
            },
             new Pentamer
              {
                 FirstIndex=248,
                 LastIndex=252,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GMSQS",
            },
             new Pentamer
              {
                 FirstIndex=249,
                 LastIndex=253,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MSQST",
            },
             new Pentamer
              {
                 FirstIndex=250,
                 LastIndex=254,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SQSTE",
            },
             new Pentamer
              {
                 FirstIndex=251,
                 LastIndex=255,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QSTEL",
            },
             new Pentamer
              {
                 FirstIndex=252,
                 LastIndex=256,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="STELL",
            },
             new Pentamer
              {
                 FirstIndex=253,
                 LastIndex=257,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TELLP",
            },
             new Pentamer
              {
                 FirstIndex=254,
                 LastIndex=258,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELLPD",
            },
             new Pentamer
              {
                 FirstIndex=255,
                 LastIndex=259,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLPDA",
            },
             new Pentamer
              {
                 FirstIndex=256,
                 LastIndex=260,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPDAT",
            },
             new Pentamer
              {
                 FirstIndex=257,
                 LastIndex=261,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PDATD",
            },
             new Pentamer
              {
                 FirstIndex=258,
                 LastIndex=262,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DATDE",
            },
             new Pentamer
              {
                 FirstIndex=259,
                 LastIndex=263,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ATDEE",
            },
             new Pentamer
              {
                 FirstIndex=260,
                 LastIndex=264,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TDEEV",
            },
             new Pentamer
              {
                 FirstIndex=261,
                 LastIndex=265,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DEEVA",
            },
             new Pentamer
              {
                 FirstIndex=262,
                 LastIndex=266,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EEVAP",
            },
             new Pentamer
              {
                 FirstIndex=263,
                 LastIndex=267,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EVAPP",
            },
             new Pentamer
              {
                 FirstIndex=264,
                 LastIndex=268,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VAPPK",
            },
             new Pentamer
              {
                 FirstIndex=265,
                 LastIndex=269,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APPKP",
            },
             new Pentamer
              {
                 FirstIndex=266,
                 LastIndex=270,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPKPP",
            },
             new Pentamer
              {
                 FirstIndex=267,
                 LastIndex=271,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PKPPL",
            },
             new Pentamer
              {
                 FirstIndex=268,
                 LastIndex=272,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KPPLP",
            },
             new Pentamer
              {
                 FirstIndex=269,
                 LastIndex=273,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPLPG",
            },
             new Pentamer
              {
                 FirstIndex=270,
                 LastIndex=274,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLPGI",
            },
             new Pentamer
              {
                 FirstIndex=271,
                 LastIndex=275,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPGIR",
            },
             new Pentamer
              {
                 FirstIndex=272,
                 LastIndex=276,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PGIRV",
            },
             new Pentamer
              {
                 FirstIndex=273,
                 LastIndex=277,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GIRVV",
            },
             new Pentamer
              {
                 FirstIndex=274,
                 LastIndex=278,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IRVVD",
            },
             new Pentamer
              {
                 FirstIndex=275,
                 LastIndex=279,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RVVDN",
            },
             new Pentamer
              {
                 FirstIndex=276,
                 LastIndex=280,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VVDNS",
            },
             new Pentamer
              {
                 FirstIndex=277,
                 LastIndex=281,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VDNSP",
            },
             new Pentamer
              {
                 FirstIndex=278,
                 LastIndex=282,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DNSPP",
            },
             new Pentamer
              {
                 FirstIndex=279,
                 LastIndex=283,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NSPPP",
            },
             new Pentamer
              {
                 FirstIndex=280,
                 LastIndex=284,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPPPA",
            },
             new Pentamer
              {
                 FirstIndex=281,
                 LastIndex=285,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPPAL",
            },
             new Pentamer
              {
                 FirstIndex=282,
                 LastIndex=286,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPALP",
            },
             new Pentamer
              {
                 FirstIndex=283,
                 LastIndex=287,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PALPP",
            },
             new Pentamer
              {
                 FirstIndex=284,
                 LastIndex=288,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ALPPK",
            },
             new Pentamer
              {
                 FirstIndex=285,
                 LastIndex=289,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPPKK",
            },
             new Pentamer
              {
                 FirstIndex=286,
                 LastIndex=290,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPKKR",
            },
             new Pentamer
              {
                 FirstIndex=287,
                 LastIndex=291,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PKKRQ",
            },
             new Pentamer
              {
                 FirstIndex=288,
                 LastIndex=292,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KKRQS",
            },
             new Pentamer
              {
                 FirstIndex=289,
                 LastIndex=293,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KRQSA",
            },
             new Pentamer
              {
                 FirstIndex=290,
                 LastIndex=294,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RQSAP",
            },
             new Pentamer
              {
                 FirstIndex=291,
                 LastIndex=295,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QSAPS",
            },
             new Pentamer
              {
                 FirstIndex=292,
                 LastIndex=296,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SAPSP",
            },
             new Pentamer
              {
                 FirstIndex=293,
                 LastIndex=297,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APSPT",
            },
             new Pentamer
              {
                 FirstIndex=294,
                 LastIndex=298,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PSPTR",
            },
             new Pentamer
              {
                 FirstIndex=295,
                 LastIndex=299,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPTRV",
            },
             new Pentamer
              {
                 FirstIndex=296,
                 LastIndex=300,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PTRVA",
            },
             new Pentamer
              {
                 FirstIndex=297,
                 LastIndex=301,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TRVAV",
            },
             new Pentamer
              {
                 FirstIndex=298,
                 LastIndex=302,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RVAVV",
            },
             new Pentamer
              {
                 FirstIndex=299,
                 LastIndex=303,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VAVVA",
            },
             new Pentamer
              {
                 FirstIndex=300,
                 LastIndex=304,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AVVAP",
            },
             new Pentamer
              {
                 FirstIndex=301,
                 LastIndex=305,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VVAPM",
            },
             new Pentamer
              {
                 FirstIndex=302,
                 LastIndex=306,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VAPMS",
            },
             new Pentamer
              {
                 FirstIndex=303,
                 LastIndex=307,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APMSR",
            },
             new Pentamer
              {
                 FirstIndex=304,
                 LastIndex=308,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PMSRA",
            },
             new Pentamer
              {
                 FirstIndex=305,
                 LastIndex=309,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MSRAT",
            },
             new Pentamer
              {
                 FirstIndex=306,
                 LastIndex=310,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SRATS",
            },
             new Pentamer
              {
                 FirstIndex=307,
                 LastIndex=311,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RATSG",
            },
             new Pentamer
              {
                 FirstIndex=308,
                 LastIndex=312,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ATSGS",
            },
             new Pentamer
              {
                 FirstIndex=309,
                 LastIndex=313,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TSGSS",
            },
             new Pentamer
              {
                 FirstIndex=310,
                 LastIndex=314,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SGSSL",
            },
             new Pentamer
              {
                 FirstIndex=311,
                 LastIndex=315,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GSSLP",
            },
             new Pentamer
              {
                 FirstIndex=312,
                 LastIndex=316,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSLPV",
            },
             new Pentamer
              {
                 FirstIndex=313,
                 LastIndex=317,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SLPVG",
            },
             new Pentamer
              {
                 FirstIndex=314,
                 LastIndex=318,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPVGI",
            },
             new Pentamer
              {
                 FirstIndex=315,
                 LastIndex=319,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PVGIN",
            },
             new Pentamer
              {
                 FirstIndex=316,
                 LastIndex=320,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VGINR",
            },
             new Pentamer
              {
                 FirstIndex=317,
                 LastIndex=321,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GINRQ",
            },
             new Pentamer
              {
                 FirstIndex=318,
                 LastIndex=322,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="INRQD",
            },
             new Pentamer
              {
                 FirstIndex=319,
                 LastIndex=323,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NRQDF",
            },
             new Pentamer
              {
                 FirstIndex=320,
                 LastIndex=324,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RQDFD",
            },
             new Pentamer
              {
                 FirstIndex=321,
                 LastIndex=325,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QDFDV",
            },
             new Pentamer
              {
                 FirstIndex=322,
                 LastIndex=326,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DFDVD",
            },
             new Pentamer
              {
                 FirstIndex=323,
                 LastIndex=327,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FDVDC",
            },
             new Pentamer
              {
                 FirstIndex=324,
                 LastIndex=328,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DVDCY",
            },
             new Pentamer
              {
                 FirstIndex=325,
                 LastIndex=329,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VDCYA",
            },
             new Pentamer
              {
                 FirstIndex=326,
                 LastIndex=330,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DCYAQ",
            },
             new Pentamer
              {
                 FirstIndex=327,
                 LastIndex=331,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CYAQR",
            },
             new Pentamer
              {
                 FirstIndex=328,
                 LastIndex=332,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YAQRR",
            },
             new Pentamer
              {
                 FirstIndex=329,
                 LastIndex=333,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AQRRL",
            },
             new Pentamer
              {
                 FirstIndex=330,
                 LastIndex=334,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QRRLS",
            },
             new Pentamer
              {
                 FirstIndex=331,
                 LastIndex=335,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RRLSG",
            },
             new Pentamer
              {
                 FirstIndex=332,
                 LastIndex=336,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RLSGG",
            },
             new Pentamer
              {
                 FirstIndex=333,
                 LastIndex=337,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSGGS",
            },
             new Pentamer
              {
                 FirstIndex=334,
                 LastIndex=338,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SGGSH",
            },
             new Pentamer
              {
                 FirstIndex=335,
                 LastIndex=339,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GGSHS",
            },
             new Pentamer
              {
                 FirstIndex=336,
                 LastIndex=340,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GSHSY",
            },
             new Pentamer
              {
                 FirstIndex=337,
                 LastIndex=341,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SHSYG",
            },
             new Pentamer
              {
                 FirstIndex=338,
                 LastIndex=342,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HSYGG",
            },
             new Pentamer
              {
                 FirstIndex=339,
                 LastIndex=343,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SYGGE",
            },
             new Pentamer
              {
                 FirstIndex=340,
                 LastIndex=344,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YGGES",
            },
             new Pentamer
              {
                 FirstIndex=341,
                 LastIndex=345,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GGESP",
            },
             new Pentamer
              {
                 FirstIndex=342,
                 LastIndex=346,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GESPR",
            },
             new Pentamer
              {
                 FirstIndex=343,
                 LastIndex=347,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ESPRL",
            },
             new Pentamer
              {
                 FirstIndex=344,
                 LastIndex=348,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPRLS",
            },
             new Pentamer
              {
                 FirstIndex=345,
                 LastIndex=349,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PRLSP",
            },
             new Pentamer
              {
                 FirstIndex=346,
                 LastIndex=350,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RLSPC",
            },
             new Pentamer
              {
                 FirstIndex=347,
                 LastIndex=351,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSPCS",
            },
             new Pentamer
              {
                 FirstIndex=348,
                 LastIndex=352,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPCSS",
            },
             new Pentamer
              {
                 FirstIndex=349,
                 LastIndex=353,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PCSSI",
            },
             new Pentamer
              {
                 FirstIndex=350,
                 LastIndex=354,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CSSIG",
            },
             new Pentamer
              {
                 FirstIndex=351,
                 LastIndex=355,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSIGK",
            },
             new Pentamer
              {
                 FirstIndex=352,
                 LastIndex=356,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SIGKL",
            },
             new Pentamer
              {
                 FirstIndex=353,
                 LastIndex=357,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IGKLS",
            },
             new Pentamer
              {
                 FirstIndex=354,
                 LastIndex=358,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GKLSK",
            },
             new Pentamer
              {
                 FirstIndex=355,
                 LastIndex=359,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KLSKS",
            },
             new Pentamer
              {
                 FirstIndex=356,
                 LastIndex=360,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSKSD",
            },
             new Pentamer
              {
                 FirstIndex=357,
                 LastIndex=361,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SKSDE",
            },
             new Pentamer
              {
                 FirstIndex=358,
                 LastIndex=362,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KSDEQ",
            },
             new Pentamer
              {
                 FirstIndex=359,
                 LastIndex=363,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SDEQL",
            },
             new Pentamer
              {
                 FirstIndex=360,
                 LastIndex=364,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DEQLS",
            },
             new Pentamer
              {
                 FirstIndex=361,
                 LastIndex=365,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EQLSS",
            },
             new Pentamer
              {
                 FirstIndex=362,
                 LastIndex=366,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QLSSL",
            },
             new Pentamer
              {
                 FirstIndex=363,
                 LastIndex=367,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSSLD",
            },
             new Pentamer
              {
                 FirstIndex=364,
                 LastIndex=368,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSLDR",
            },
             new Pentamer
              {
                 FirstIndex=365,
                 LastIndex=369,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SLDRD",
            },
             new Pentamer
              {
                 FirstIndex=366,
                 LastIndex=370,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LDRDS",
            },
             new Pentamer
              {
                 FirstIndex=367,
                 LastIndex=371,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DRDSG",
            },
             new Pentamer
              {
                 FirstIndex=368,
                 LastIndex=372,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RDSGQ",
            },
             new Pentamer
              {
                 FirstIndex=369,
                 LastIndex=373,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DSGQC",
            },
             new Pentamer
              {
                 FirstIndex=370,
                 LastIndex=374,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SGQCS",
            },
             new Pentamer
              {
                 FirstIndex=371,
                 LastIndex=375,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GQCSR",
            },
             new Pentamer
              {
                 FirstIndex=372,
                 LastIndex=376,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QCSRN",
            },
             new Pentamer
              {
                 FirstIndex=373,
                 LastIndex=377,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CSRNT",
            },
             new Pentamer
              {
                 FirstIndex=374,
                 LastIndex=378,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SRNTS",
            },
             new Pentamer
              {
                 FirstIndex=375,
                 LastIndex=379,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RNTSC",
            },
             new Pentamer
              {
                 FirstIndex=376,
                 LastIndex=380,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NTSCE",
            },
             new Pentamer
              {
                 FirstIndex=377,
                 LastIndex=381,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TSCET",
            },
             new Pentamer
              {
                 FirstIndex=378,
                 LastIndex=382,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SCETL",
            },
             new Pentamer
              {
                 FirstIndex=379,
                 LastIndex=383,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CETLD",
            },
             new Pentamer
              {
                 FirstIndex=380,
                 LastIndex=384,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ETLDH",
            },
             new Pentamer
              {
                 FirstIndex=381,
                 LastIndex=385,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TLDHY",
            },
             new Pentamer
              {
                 FirstIndex=382,
                 LastIndex=386,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LDHYD",
            },
             new Pentamer
              {
                 FirstIndex=383,
                 LastIndex=387,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DHYDP",
            },
             new Pentamer
              {
                 FirstIndex=384,
                 LastIndex=388,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HYDPD",
            },
             new Pentamer
              {
                 FirstIndex=385,
                 LastIndex=389,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YDPDY",
            },
             new Pentamer
              {
                 FirstIndex=386,
                 LastIndex=390,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DPDYE",
            },
             new Pentamer
              {
                 FirstIndex=387,
                 LastIndex=391,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PDYEF",
            },
             new Pentamer
              {
                 FirstIndex=388,
                 LastIndex=392,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DYEFL",
            },
             new Pentamer
              {
                 FirstIndex=389,
                 LastIndex=393,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YEFLQ",
            },
             new Pentamer
              {
                 FirstIndex=390,
                 LastIndex=394,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EFLQQ",
            },
             new Pentamer
              {
                 FirstIndex=391,
                 LastIndex=395,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FLQQD",
            },
             new Pentamer
              {
                 FirstIndex=392,
                 LastIndex=396,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LQQDL",
            },
             new Pentamer
              {
                 FirstIndex=393,
                 LastIndex=397,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QQDLS",
            },
             new Pentamer
              {
                 FirstIndex=394,
                 LastIndex=398,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QDLSN",
            },
             new Pentamer
              {
                 FirstIndex=395,
                 LastIndex=399,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DLSNA",
            },
             new Pentamer
              {
                 FirstIndex=396,
                 LastIndex=400,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSNAD",
            },
             new Pentamer
              {
                 FirstIndex=397,
                 LastIndex=401,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SNADQ",
            },
             new Pentamer
              {
                 FirstIndex=398,
                 LastIndex=402,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NADQI",
            },
             new Pentamer
              {
                 FirstIndex=399,
                 LastIndex=403,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ADQIP",
            },
             new Pentamer
              {
                 FirstIndex=400,
                 LastIndex=404,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DQIPQ",
            },
             new Pentamer
              {
                 FirstIndex=401,
                 LastIndex=405,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QIPQQ",
            },
             new Pentamer
              {
                 FirstIndex=402,
                 LastIndex=406,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IPQQT",
            },
             new Pentamer
              {
                 FirstIndex=403,
                 LastIndex=407,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PQQTA",
            },
             new Pentamer
              {
                 FirstIndex=404,
                 LastIndex=408,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QQTAW",
            },
             new Pentamer
              {
                 FirstIndex=405,
                 LastIndex=409,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QTAWN",
            },
             new Pentamer
              {
                 FirstIndex=406,
                 LastIndex=410,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TAWNL",
            },
             new Pentamer
              {
                 FirstIndex=407,
                 LastIndex=411,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AWNLS",
            },
             new Pentamer
              {
                 FirstIndex=408,
                 LastIndex=412,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="WNLSP",
            },
             new Pentamer
              {
                 FirstIndex=409,
                 LastIndex=413,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NLSPL",
            },
             new Pentamer
              {
                 FirstIndex=410,
                 LastIndex=414,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSPLP",
            },
             new Pentamer
              {
                 FirstIndex=411,
                 LastIndex=415,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPLPE",
            },
             new Pentamer
              {
                 FirstIndex=412,
                 LastIndex=416,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLPES",
            },
             new Pentamer
              {
                 FirstIndex=413,
                 LastIndex=417,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPESL",
            },
             new Pentamer
              {
                 FirstIndex=414,
                 LastIndex=418,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PESLG",
            },
             new Pentamer
              {
                 FirstIndex=415,
                 LastIndex=419,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ESLGE",
            },
             new Pentamer
              {
                 FirstIndex=416,
                 LastIndex=420,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SLGES",
            },
             new Pentamer
              {
                 FirstIndex=417,
                 LastIndex=421,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LGESG",
            },
             new Pentamer
              {
                 FirstIndex=418,
                 LastIndex=422,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GESGS",
            },
             new Pentamer
              {
                 FirstIndex=419,
                 LastIndex=423,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ESGSP",
            },
             new Pentamer
              {
                 FirstIndex=420,
                 LastIndex=424,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SGSPF",
            },
             new Pentamer
              {
                 FirstIndex=421,
                 LastIndex=425,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GSPFL",
            },
             new Pentamer
              {
                 FirstIndex=422,
                 LastIndex=426,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPFLG",
            },
             new Pentamer
              {
                 FirstIndex=423,
                 LastIndex=427,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PFLGP",
            },
             new Pentamer
              {
                 FirstIndex=424,
                 LastIndex=428,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FLGPP",
            },
             new Pentamer
              {
                 FirstIndex=425,
                 LastIndex=429,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LGPPF",
            },
             new Pentamer
              {
                 FirstIndex=426,
                 LastIndex=430,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GPPFQ",
            },
             new Pentamer
              {
                 FirstIndex=427,
                 LastIndex=431,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPFQL",
            },
             new Pentamer
              {
                 FirstIndex=428,
                 LastIndex=432,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PFQLP",
            },
             new Pentamer
              {
                 FirstIndex=429,
                 LastIndex=433,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FQLPL",
            },
             new Pentamer
              {
                 FirstIndex=430,
                 LastIndex=434,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QLPLG",
            },
             new Pentamer
              {
                 FirstIndex=431,
                 LastIndex=435,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPLGG",
            },
             new Pentamer
              {
                 FirstIndex=432,
                 LastIndex=436,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLGGH",
            },
             new Pentamer
              {
                 FirstIndex=433,
                 LastIndex=437,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LGGHP",
            },
             new Pentamer
              {
                 FirstIndex=434,
                 LastIndex=438,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GGHPQ",
            },
             new Pentamer
              {
                 FirstIndex=435,
                 LastIndex=439,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GHPQP",
            },
             new Pentamer
              {
                 FirstIndex=436,
                 LastIndex=440,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HPQPD",
            },
             new Pentamer
              {
                 FirstIndex=437,
                 LastIndex=441,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PQPDG",
            },
             new Pentamer
              {
                 FirstIndex=438,
                 LastIndex=442,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QPDGP",
            },
             new Pentamer
              {
                 FirstIndex=439,
                 LastIndex=443,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PDGPL",
            },
             new Pentamer
              {
                 FirstIndex=440,
                 LastIndex=444,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DGPLA",
            },
             new Pentamer
              {
                 FirstIndex=441,
                 LastIndex=445,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GPLAP",
            },
             new Pentamer
              {
                 FirstIndex=442,
                 LastIndex=446,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLAPG",
            },
             new Pentamer
              {
                 FirstIndex=443,
                 LastIndex=447,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LAPGQ",
            },
             new Pentamer
              {
                 FirstIndex=444,
                 LastIndex=448,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APGQQ",
            },
             new Pentamer
              {
                 FirstIndex=445,
                 LastIndex=449,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PGQQT",
            },
             new Pentamer
              {
                 FirstIndex=446,
                 LastIndex=450,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GQQTD",
            },
             new Pentamer
              {
                 FirstIndex=447,
                 LastIndex=451,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QQTDT",
            },
             new Pentamer
              {
                 FirstIndex=448,
                 LastIndex=452,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QTDTP",
            },
             new Pentamer
              {
                 FirstIndex=449,
                 LastIndex=453,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TDTPP",
            },
             new Pentamer
              {
                 FirstIndex=450,
                 LastIndex=454,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DTPPA",
            },
             new Pentamer
              {
                 FirstIndex=451,
                 LastIndex=455,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TPPAL",
            },
             new Pentamer
              {
                 FirstIndex=452,
                 LastIndex=456,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPALP",
            },
             new Pentamer
              {
                 FirstIndex=453,
                 LastIndex=457,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PALPE",
            },
             new Pentamer
              {
                 FirstIndex=454,
                 LastIndex=458,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ALPEK",
            },
             new Pentamer
              {
                 FirstIndex=455,
                 LastIndex=459,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPEKK",
            },
             new Pentamer
              {
                 FirstIndex=456,
                 LastIndex=460,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PEKKR",
            },
             new Pentamer
              {
                 FirstIndex=457,
                 LastIndex=461,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKKRR",
            },
             new Pentamer
              {
                 FirstIndex=458,
                 LastIndex=462,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KKRRS",
            },
             new Pentamer
              {
                 FirstIndex=459,
                 LastIndex=463,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KRRSA",
            },
             new Pentamer
              {
                 FirstIndex=460,
                 LastIndex=464,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RRSAA",
            },
             new Pentamer
              {
                 FirstIndex=461,
                 LastIndex=465,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RSAAS",
            },
             new Pentamer
              {
                 FirstIndex=462,
                 LastIndex=466,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SAASQ",
            },
             new Pentamer
              {
                 FirstIndex=463,
                 LastIndex=467,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AASQT",
            },
             new Pentamer
              {
                 FirstIndex=464,
                 LastIndex=468,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ASQTA",
            },
             new Pentamer
              {
                 FirstIndex=465,
                 LastIndex=469,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SQTAD",
            },
             new Pentamer
              {
                 FirstIndex=466,
                 LastIndex=470,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QTADG",
            },
             new Pentamer
              {
                 FirstIndex=467,
                 LastIndex=471,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TADGS",
            },
             new Pentamer
              {
                 FirstIndex=468,
                 LastIndex=472,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ADGSG",
            },
             new Pentamer
              {
                 FirstIndex=469,
                 LastIndex=473,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DGSGC",
            },
             new Pentamer
              {
                 FirstIndex=470,
                 LastIndex=474,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GSGCR",
            },
             new Pentamer
              {
                 FirstIndex=471,
                 LastIndex=475,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SGCRV",
            },
             new Pentamer
              {
                 FirstIndex=472,
                 LastIndex=476,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GCRVS",
            },
             new Pentamer
              {
                 FirstIndex=473,
                 LastIndex=477,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CRVSY",
            },
             new Pentamer
              {
                 FirstIndex=474,
                 LastIndex=478,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RVSYE",
            },
             new Pentamer
              {
                 FirstIndex=475,
                 LastIndex=479,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VSYER",
            },
             new Pentamer
              {
                 FirstIndex=476,
                 LastIndex=480,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SYERH",
            },
             new Pentamer
              {
                 FirstIndex=477,
                 LastIndex=481,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YERHP",
            },
             new Pentamer
              {
                 FirstIndex=478,
                 LastIndex=482,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ERHPS",
            },
             new Pentamer
              {
                 FirstIndex=479,
                 LastIndex=483,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RHPSQ",
            },
             new Pentamer
              {
                 FirstIndex=480,
                 LastIndex=484,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HPSQY",
            },
             new Pentamer
              {
                 FirstIndex=481,
                 LastIndex=485,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PSQYD",
            },
             new Pentamer
              {
                 FirstIndex=482,
                 LastIndex=486,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SQYDN",
            },
             new Pentamer
              {
                 FirstIndex=483,
                 LastIndex=487,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QYDNI",
            },
             new Pentamer
              {
                 FirstIndex=484,
                 LastIndex=488,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YDNIS",
            },
             new Pentamer
              {
                 FirstIndex=485,
                 LastIndex=489,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DNISG",
            },
             new Pentamer
              {
                 FirstIndex=486,
                 LastIndex=490,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NISGE",
            },
             new Pentamer
              {
                 FirstIndex=487,
                 LastIndex=491,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ISGED",
            },
             new Pentamer
              {
                 FirstIndex=488,
                 LastIndex=492,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SGEDL",
            },
             new Pentamer
              {
                 FirstIndex=489,
                 LastIndex=493,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GEDLQ",
            },
             new Pentamer
              {
                 FirstIndex=490,
                 LastIndex=494,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EDLQS",
            },
             new Pentamer
              {
                 FirstIndex=491,
                 LastIndex=495,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DLQST",
            },
             new Pentamer
              {
                 FirstIndex=492,
                 LastIndex=496,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LQSTA",
            },
             new Pentamer
              {
                 FirstIndex=493,
                 LastIndex=497,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QSTAP",
            },
             new Pentamer
              {
                 FirstIndex=494,
                 LastIndex=498,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="STAPI",
            },
             new Pentamer
              {
                 FirstIndex=495,
                 LastIndex=499,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TAPIP",
            },
             new Pentamer
              {
                 FirstIndex=496,
                 LastIndex=500,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APIPS",
            },
             new Pentamer
              {
                 FirstIndex=497,
                 LastIndex=501,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PIPSV",
            },
             new Pentamer
              {
                 FirstIndex=498,
                 LastIndex=502,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IPSVP",
            },
             new Pentamer
              {
                 FirstIndex=499,
                 LastIndex=503,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PSVPY",
            },
             new Pentamer
              {
                 FirstIndex=500,
                 LastIndex=504,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SVPYA",
            },
             new Pentamer
              {
                 FirstIndex=501,
                 LastIndex=505,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VPYAP",
            },
             new Pentamer
              {
                 FirstIndex=502,
                 LastIndex=506,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PYAPF",
            },
             new Pentamer
              {
                 FirstIndex=503,
                 LastIndex=507,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YAPFA",
            },
             new Pentamer
              {
                 FirstIndex=504,
                 LastIndex=508,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APFAA",
            },
             new Pentamer
              {
                 FirstIndex=505,
                 LastIndex=509,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PFAAI",
            },
             new Pentamer
              {
                 FirstIndex=506,
                 LastIndex=510,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FAAIL",
            },
             new Pentamer
              {
                 FirstIndex=507,
                 LastIndex=511,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AAILP",
            },
             new Pentamer
              {
                 FirstIndex=508,
                 LastIndex=512,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AILPF",
            },
             new Pentamer
              {
                 FirstIndex=509,
                 LastIndex=513,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ILPFQ",
            },
             new Pentamer
              {
                 FirstIndex=510,
                 LastIndex=514,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPFQH",
            },
             new Pentamer
              {
                 FirstIndex=511,
                 LastIndex=515,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PFQHG",
            },
             new Pentamer
              {
                 FirstIndex=512,
                 LastIndex=516,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FQHGG",
            },
             new Pentamer
              {
                 FirstIndex=513,
                 LastIndex=517,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QHGGS",
            },
             new Pentamer
              {
                 FirstIndex=514,
                 LastIndex=518,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HGGSS",
            },
             new Pentamer
              {
                 FirstIndex=515,
                 LastIndex=519,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GGSSA",
            },
             new Pentamer
              {
                 FirstIndex=516,
                 LastIndex=520,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GSSAP",
            },
             new Pentamer
              {
                 FirstIndex=517,
                 LastIndex=521,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSAPV",
            },
             new Pentamer
              {
                 FirstIndex=518,
                 LastIndex=522,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SAPVE",
            },
             new Pentamer
              {
                 FirstIndex=519,
                 LastIndex=523,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APVEF",
            },
             new Pentamer
              {
                 FirstIndex=520,
                 LastIndex=524,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PVEFV",
            },
             new Pentamer
              {
                 FirstIndex=521,
                 LastIndex=525,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VEFVG",
            },
             new Pentamer
              {
                 FirstIndex=522,
                 LastIndex=526,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EFVGD",
            },
             new Pentamer
              {
                 FirstIndex=523,
                 LastIndex=527,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FVGDF",
            },
             new Pentamer
              {
                 FirstIndex=524,
                 LastIndex=528,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VGDFT",
            },
             new Pentamer
              {
                 FirstIndex=525,
                 LastIndex=529,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GDFTA",
            },
             new Pentamer
              {
                 FirstIndex=526,
                 LastIndex=530,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DFTAP",
            },
             new Pentamer
              {
                 FirstIndex=527,
                 LastIndex=531,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FTAPE",
            },
             new Pentamer
              {
                 FirstIndex=528,
                 LastIndex=532,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TAPES",
            },
             new Pentamer
              {
                 FirstIndex=529,
                 LastIndex=533,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APEST",
            },
             new Pentamer
              {
                 FirstIndex=530,
                 LastIndex=534,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PESTG",
            },
             new Pentamer
              {
                 FirstIndex=531,
                 LastIndex=535,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ESTGD",
            },
             new Pentamer
              {
                 FirstIndex=532,
                 LastIndex=536,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="STGDP",
            },
             new Pentamer
              {
                 FirstIndex=533,
                 LastIndex=537,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TGDPE",
            },
             new Pentamer
              {
                 FirstIndex=534,
                 LastIndex=538,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GDPEK",
            },
             new Pentamer
              {
                 FirstIndex=535,
                 LastIndex=539,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DPEKP",
            },
             new Pentamer
              {
                 FirstIndex=536,
                 LastIndex=540,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PEKPP",
            },
             new Pentamer
              {
                 FirstIndex=537,
                 LastIndex=541,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKPPP",
            },
             new Pentamer
              {
                 FirstIndex=538,
                 LastIndex=542,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KPPPL",
            },
             new Pentamer
              {
                 FirstIndex=539,
                 LastIndex=543,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPPLP",
            },
             new Pentamer
              {
                 FirstIndex=540,
                 LastIndex=544,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPLPE",
            },
             new Pentamer
              {
                 FirstIndex=541,
                 LastIndex=545,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLPEK",
            },
             new Pentamer
              {
                 FirstIndex=542,
                 LastIndex=546,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPEKK",
            },
             new Pentamer
              {
                 FirstIndex=543,
                 LastIndex=547,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PEKKN",
            },
             new Pentamer
              {
                 FirstIndex=544,
                 LastIndex=548,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKKNK",
            },
             new Pentamer
              {
                 FirstIndex=545,
                 LastIndex=549,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KKNKH",
            },
             new Pentamer
              {
                 FirstIndex=546,
                 LastIndex=550,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KNKHM",
            },
             new Pentamer
              {
                 FirstIndex=547,
                 LastIndex=551,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NKHML",
            },
             new Pentamer
              {
                 FirstIndex=548,
                 LastIndex=552,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KHMLA",
            },
             new Pentamer
              {
                 FirstIndex=549,
                 LastIndex=553,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HMLAY",
            },
             new Pentamer
              {
                 FirstIndex=550,
                 LastIndex=554,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MLAYM",
            },
             new Pentamer
              {
                 FirstIndex=551,
                 LastIndex=555,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LAYMQ",
            },
             new Pentamer
              {
                 FirstIndex=552,
                 LastIndex=556,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AYMQL",
            },
             new Pentamer
              {
                 FirstIndex=553,
                 LastIndex=557,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YMQLL",
            },
             new Pentamer
              {
                 FirstIndex=554,
                 LastIndex=558,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MQLLE",
            },
             new Pentamer
              {
                 FirstIndex=555,
                 LastIndex=559,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QLLED",
            },
             new Pentamer
              {
                 FirstIndex=556,
                 LastIndex=560,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLEDY",
            },
             new Pentamer
              {
                 FirstIndex=557,
                 LastIndex=561,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LEDYS",
            },
             new Pentamer
              {
                 FirstIndex=558,
                 LastIndex=562,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EDYSE",
            },
             new Pentamer
              {
                 FirstIndex=559,
                 LastIndex=563,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DYSEP",
            },
             new Pentamer
              {
                 FirstIndex=560,
                 LastIndex=564,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YSEPQ",
            },
             new Pentamer
              {
                 FirstIndex=561,
                 LastIndex=565,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SEPQP",
            },
             new Pentamer
              {
                 FirstIndex=562,
                 LastIndex=566,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EPQPS",
            },
             new Pentamer
              {
                 FirstIndex=563,
                 LastIndex=567,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PQPSM",
            },
             new Pentamer
              {
                 FirstIndex=564,
                 LastIndex=568,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QPSMF",
            },
             new Pentamer
              {
                 FirstIndex=565,
                 LastIndex=569,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PSMFY",
            },
             new Pentamer
              {
                 FirstIndex=566,
                 LastIndex=570,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SMFYQ",
            },
             new Pentamer
              {
                 FirstIndex=567,
                 LastIndex=571,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MFYQT",
            },
             new Pentamer
              {
                 FirstIndex=568,
                 LastIndex=572,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FYQTP",
            },
             new Pentamer
              {
                 FirstIndex=569,
                 LastIndex=573,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YQTPQ",
            },
             new Pentamer
              {
                 FirstIndex=570,
                 LastIndex=574,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QTPQN",
            },
             new Pentamer
              {
                 FirstIndex=571,
                 LastIndex=575,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TPQNE",
            },
             new Pentamer
              {
                 FirstIndex=572,
                 LastIndex=576,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PQNEH",
            },
             new Pentamer
              {
                 FirstIndex=573,
                 LastIndex=577,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QNEHI",
            },
             new Pentamer
              {
                 FirstIndex=574,
                 LastIndex=578,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NEHIY",
            },
             new Pentamer
              {
                 FirstIndex=575,
                 LastIndex=579,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EHIYQ",
            },
             new Pentamer
              {
                 FirstIndex=576,
                 LastIndex=580,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HIYQQ",
            },
             new Pentamer
              {
                 FirstIndex=577,
                 LastIndex=581,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IYQQK",
            },
             new Pentamer
              {
                 FirstIndex=578,
                 LastIndex=582,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YQQKN",
            },
             new Pentamer
              {
                 FirstIndex=579,
                 LastIndex=583,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QQKNK",
            },
             new Pentamer
              {
                 FirstIndex=580,
                 LastIndex=584,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QKNKL",
            },
             new Pentamer
              {
                 FirstIndex=581,
                 LastIndex=585,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KNKLL",
            },
             new Pentamer
              {
                 FirstIndex=582,
                 LastIndex=586,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NKLLM",
            },
             new Pentamer
              {
                 FirstIndex=583,
                 LastIndex=587,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KLLME",
            },
             new Pentamer
              {
                 FirstIndex=584,
                 LastIndex=588,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLMEV",
            },
             new Pentamer
              {
                 FirstIndex=585,
                 LastIndex=589,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LMEVY",
            },
             new Pentamer
              {
                 FirstIndex=586,
                 LastIndex=590,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MEVYG",
            },
             new Pentamer
              {
                 FirstIndex=587,
                 LastIndex=591,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EVYGF",
            },
             new Pentamer
              {
                 FirstIndex=588,
                 LastIndex=592,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VYGFS",
            },
             new Pentamer
              {
                 FirstIndex=589,
                 LastIndex=593,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YGFSD",
            },
             new Pentamer
              {
                 FirstIndex=590,
                 LastIndex=594,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GFSDS",
            },
             new Pentamer
              {
                 FirstIndex=591,
                 LastIndex=595,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FSDSF",
            },
             new Pentamer
              {
                 FirstIndex=592,
                 LastIndex=596,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SDSFS",
            },
             new Pentamer
              {
                 FirstIndex=593,
                 LastIndex=597,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DSFSG",
            },
             new Pentamer
              {
                 FirstIndex=594,
                 LastIndex=598,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SFSGV",
            },
             new Pentamer
              {
                 FirstIndex=595,
                 LastIndex=599,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FSGVD",
            },
             new Pentamer
              {
                 FirstIndex=596,
                 LastIndex=600,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SGVDS",
            },
             new Pentamer
              {
                 FirstIndex=597,
                 LastIndex=601,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GVDSV",
            },
             new Pentamer
              {
                 FirstIndex=598,
                 LastIndex=602,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VDSVQ",
            },
             new Pentamer
              {
                 FirstIndex=599,
                 LastIndex=603,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DSVQE",
            },
             new Pentamer
              {
                 FirstIndex=600,
                 LastIndex=604,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SVQEL",
            },
             new Pentamer
              {
                 FirstIndex=601,
                 LastIndex=605,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VQELA",
            },
             new Pentamer
              {
                 FirstIndex=602,
                 LastIndex=606,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QELAP",
            },
             new Pentamer
              {
                 FirstIndex=603,
                 LastIndex=607,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELAPP",
            },
             new Pentamer
              {
                 FirstIndex=604,
                 LastIndex=608,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LAPPP",
            },
             new Pentamer
              {
                 FirstIndex=605,
                 LastIndex=609,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APPPA",
            },
             new Pentamer
              {
                 FirstIndex=606,
                 LastIndex=610,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPPAL",
            },
             new Pentamer
              {
                 FirstIndex=607,
                 LastIndex=611,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPALP",
            },
             new Pentamer
              {
                 FirstIndex=608,
                 LastIndex=612,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PALPP",
            },
             new Pentamer
              {
                 FirstIndex=609,
                 LastIndex=613,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ALPPK",
            },
             new Pentamer
              {
                 FirstIndex=610,
                 LastIndex=614,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LPPKQ",
            },
             new Pentamer
              {
                 FirstIndex=611,
                 LastIndex=615,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPKQR",
            },
             new Pentamer
              {
                 FirstIndex=612,
                 LastIndex=616,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PKQRQ",
            },
             new Pentamer
              {
                 FirstIndex=613,
                 LastIndex=617,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KQRQL",
            },
             new Pentamer
              {
                 FirstIndex=614,
                 LastIndex=618,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QRQLE",
            },
             new Pentamer
              {
                 FirstIndex=615,
                 LastIndex=619,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RQLEP",
            },
             new Pentamer
              {
                 FirstIndex=616,
                 LastIndex=620,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QLEPP",
            },
             new Pentamer
              {
                 FirstIndex=617,
                 LastIndex=621,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LEPPA",
            },
             new Pentamer
              {
                 FirstIndex=618,
                 LastIndex=622,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EPPAG",
            },
             new Pentamer
              {
                 FirstIndex=619,
                 LastIndex=623,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPAGK",
            },
             new Pentamer
              {
                 FirstIndex=620,
                 LastIndex=624,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PAGKD",
            },
             new Pentamer
              {
                 FirstIndex=621,
                 LastIndex=625,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AGKDG",
            },
             new Pentamer
              {
                 FirstIndex=622,
                 LastIndex=626,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GKDGH",
            },
             new Pentamer
              {
                 FirstIndex=623,
                 LastIndex=627,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KDGHP",
            },
             new Pentamer
              {
                 FirstIndex=624,
                 LastIndex=628,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DGHPR",
            },
             new Pentamer
              {
                 FirstIndex=625,
                 LastIndex=629,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GHPRD",
            },
             new Pentamer
              {
                 FirstIndex=626,
                 LastIndex=630,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HPRDP",
            },
             new Pentamer
              {
                 FirstIndex=627,
                 LastIndex=631,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PRDPS",
            },
             new Pentamer
              {
                 FirstIndex=628,
                 LastIndex=632,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RDPSA",
            },
             new Pentamer
              {
                 FirstIndex=629,
                 LastIndex=633,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DPSAV",
            },
             new Pentamer
              {
                 FirstIndex=630,
                 LastIndex=634,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PSAVS",
            },
             new Pentamer
              {
                 FirstIndex=631,
                 LastIndex=635,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SAVSG",
            },
             new Pentamer
              {
                 FirstIndex=632,
                 LastIndex=636,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AVSGV",
            },
             new Pentamer
              {
                 FirstIndex=633,
                 LastIndex=637,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VSGVP",
            },
             new Pentamer
              {
                 FirstIndex=634,
                 LastIndex=638,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SGVPG",
            },
             new Pentamer
              {
                 FirstIndex=635,
                 LastIndex=639,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GVPGK",
            },
             new Pentamer
              {
                 FirstIndex=636,
                 LastIndex=640,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VPGKD",
            },
             new Pentamer
              {
                 FirstIndex=637,
                 LastIndex=641,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PGKDS",
            },
             new Pentamer
              {
                 FirstIndex=638,
                 LastIndex=642,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GKDSR",
            },
             new Pentamer
              {
                 FirstIndex=639,
                 LastIndex=643,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KDSRD",
            },
             new Pentamer
              {
                 FirstIndex=640,
                 LastIndex=644,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DSRDG",
            },
             new Pentamer
              {
                 FirstIndex=641,
                 LastIndex=645,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SRDGS",
            },
             new Pentamer
              {
                 FirstIndex=642,
                 LastIndex=646,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RDGSE",
            },
             new Pentamer
              {
                 FirstIndex=643,
                 LastIndex=647,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DGSER",
            },
             new Pentamer
              {
                 FirstIndex=644,
                 LastIndex=648,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GSERA",
            },
             new Pentamer
              {
                 FirstIndex=645,
                 LastIndex=649,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SERAP",
            },
             new Pentamer
              {
                 FirstIndex=646,
                 LastIndex=650,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ERAPK",
            },
             new Pentamer
              {
                 FirstIndex=647,
                 LastIndex=651,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RAPKS",
            },
             new Pentamer
              {
                 FirstIndex=648,
                 LastIndex=652,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APKSP",
            },
             new Pentamer
              {
                 FirstIndex=649,
                 LastIndex=653,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PKSPD",
            },
             new Pentamer
              {
                 FirstIndex=650,
                 LastIndex=654,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KSPDA",
            },
             new Pentamer
              {
                 FirstIndex=651,
                 LastIndex=655,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPDAL",
            },
             new Pentamer
              {
                 FirstIndex=652,
                 LastIndex=656,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PDALE",
            },
             new Pentamer
              {
                 FirstIndex=653,
                 LastIndex=657,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DALES",
            },
             new Pentamer
              {
                 FirstIndex=654,
                 LastIndex=658,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ALESA",
            },
             new Pentamer
              {
                 FirstIndex=655,
                 LastIndex=659,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LESAQ",
            },
             new Pentamer
              {
                 FirstIndex=656,
                 LastIndex=660,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ESAQS",
            },
             new Pentamer
              {
                 FirstIndex=657,
                 LastIndex=661,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SAQSE",
            },
             new Pentamer
              {
                 FirstIndex=658,
                 LastIndex=662,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AQSEE",
            },
             new Pentamer
              {
                 FirstIndex=659,
                 LastIndex=663,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QSEEE",
            },
             new Pentamer
              {
                 FirstIndex=660,
                 LastIndex=664,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SEEEV",
            },
             new Pentamer
              {
                 FirstIndex=661,
                 LastIndex=665,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EEEVD",
            },
             new Pentamer
              {
                 FirstIndex=662,
                 LastIndex=666,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EEVDE",
            },
             new Pentamer
              {
                 FirstIndex=663,
                 LastIndex=667,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EVDEL",
            },
             new Pentamer
              {
                 FirstIndex=664,
                 LastIndex=668,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VDELS",
            },
             new Pentamer
              {
                 FirstIndex=665,
                 LastIndex=669,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DELSL",
            },
             new Pentamer
              {
                 FirstIndex=666,
                 LastIndex=670,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELSLI",
            },
             new Pentamer
              {
                 FirstIndex=667,
                 LastIndex=671,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSLID",
            },
             new Pentamer
              {
                 FirstIndex=668,
                 LastIndex=672,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SLIDH",
            },
             new Pentamer
              {
                 FirstIndex=669,
                 LastIndex=673,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LIDHN",
            },
             new Pentamer
              {
                 FirstIndex=670,
                 LastIndex=674,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IDHNE",
            },
             new Pentamer
              {
                 FirstIndex=671,
                 LastIndex=675,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DHNEI",
            },
             new Pentamer
              {
                 FirstIndex=672,
                 LastIndex=676,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HNEIM",
            },
             new Pentamer
              {
                 FirstIndex=673,
                 LastIndex=677,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NEIMS",
            },
             new Pentamer
              {
                 FirstIndex=674,
                 LastIndex=678,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EIMSR",
            },
             new Pentamer
              {
                 FirstIndex=675,
                 LastIndex=679,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IMSRL",
            },
             new Pentamer
              {
                 FirstIndex=676,
                 LastIndex=680,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MSRLT",
            },
             new Pentamer
              {
                 FirstIndex=677,
                 LastIndex=681,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SRLTL",
            },
             new Pentamer
              {
                 FirstIndex=678,
                 LastIndex=682,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RLTLK",
            },
             new Pentamer
              {
                 FirstIndex=679,
                 LastIndex=683,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LTLKQ",
            },
             new Pentamer
              {
                 FirstIndex=680,
                 LastIndex=684,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TLKQE",
            },
             new Pentamer
              {
                 FirstIndex=681,
                 LastIndex=685,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LKQEG",
            },
             new Pentamer
              {
                 FirstIndex=682,
                 LastIndex=686,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KQEGD",
            },
             new Pentamer
              {
                 FirstIndex=683,
                 LastIndex=687,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QEGDD",
            },
             new Pentamer
              {
                 FirstIndex=684,
                 LastIndex=688,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EGDDG",
            },
             new Pentamer
              {
                 FirstIndex=685,
                 LastIndex=689,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GDDGP",
            },
             new Pentamer
              {
                 FirstIndex=686,
                 LastIndex=690,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DDGPD",
            },
             new Pentamer
              {
                 FirstIndex=687,
                 LastIndex=691,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DGPDV",
            },
             new Pentamer
              {
                 FirstIndex=688,
                 LastIndex=692,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GPDVR",
            },
             new Pentamer
              {
                 FirstIndex=689,
                 LastIndex=693,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PDVRG",
            },
             new Pentamer
              {
                 FirstIndex=690,
                 LastIndex=694,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DVRGG",
            },
             new Pentamer
              {
                 FirstIndex=691,
                 LastIndex=695,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VRGGS",
            },
             new Pentamer
              {
                 FirstIndex=692,
                 LastIndex=696,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RGGSG",
            },
             new Pentamer
              {
                 FirstIndex=693,
                 LastIndex=697,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GGSGD",
            },
             new Pentamer
              {
                 FirstIndex=694,
                 LastIndex=698,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GSGDI",
            },
             new Pentamer
              {
                 FirstIndex=695,
                 LastIndex=699,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SGDIL",
            },
             new Pentamer
              {
                 FirstIndex=696,
                 LastIndex=700,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GDILL",
            },
             new Pentamer
              {
                 FirstIndex=697,
                 LastIndex=701,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DILLV",
            },
             new Pentamer
              {
                 FirstIndex=698,
                 LastIndex=702,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ILLVH",
            },
             new Pentamer
              {
                 FirstIndex=699,
                 LastIndex=703,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLVHA",
            },
             new Pentamer
              {
                 FirstIndex=700,
                 LastIndex=704,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LVHAT",
            },
             new Pentamer
              {
                 FirstIndex=701,
                 LastIndex=705,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VHATE",
            },
             new Pentamer
              {
                 FirstIndex=702,
                 LastIndex=706,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HATET",
            },
             new Pentamer
              {
                 FirstIndex=703,
                 LastIndex=707,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ATETD",
            },
             new Pentamer
              {
                 FirstIndex=704,
                 LastIndex=708,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TETDR",
            },
             new Pentamer
              {
                 FirstIndex=705,
                 LastIndex=709,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ETDRK",
            },
             new Pentamer
              {
                 FirstIndex=706,
                 LastIndex=710,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TDRKD",
            },
             new Pentamer
              {
                 FirstIndex=707,
                 LastIndex=711,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DRKDL",
            },
             new Pentamer
              {
                 FirstIndex=708,
                 LastIndex=712,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RKDLV",
            },
             new Pentamer
              {
                 FirstIndex=709,
                 LastIndex=713,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KDLVL",
            },
             new Pentamer
              {
                 FirstIndex=710,
                 LastIndex=714,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DLVLY",
            },
             new Pentamer
              {
                 FirstIndex=711,
                 LastIndex=715,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LVLYC",
            },
             new Pentamer
              {
                 FirstIndex=712,
                 LastIndex=716,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VLYCE",
            },
             new Pentamer
              {
                 FirstIndex=713,
                 LastIndex=717,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LYCEA",
            },
             new Pentamer
              {
                 FirstIndex=714,
                 LastIndex=718,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YCEAF",
            },
             new Pentamer
              {
                 FirstIndex=715,
                 LastIndex=719,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CEAFL",
            },
             new Pentamer
              {
                 FirstIndex=716,
                 LastIndex=720,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EAFLT",
            },
             new Pentamer
              {
                 FirstIndex=717,
                 LastIndex=721,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AFLTT",
            },
             new Pentamer
              {
                 FirstIndex=718,
                 LastIndex=722,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FLTTY",
            },
             new Pentamer
              {
                 FirstIndex=719,
                 LastIndex=723,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LTTYR",
            },
             new Pentamer
              {
                 FirstIndex=720,
                 LastIndex=724,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TTYRT",
            },
             new Pentamer
              {
                 FirstIndex=721,
                 LastIndex=725,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TYRTF",
            },
             new Pentamer
              {
                 FirstIndex=722,
                 LastIndex=726,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YRTFI",
            },
             new Pentamer
              {
                 FirstIndex=723,
                 LastIndex=727,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RTFIS",
            },
             new Pentamer
              {
                 FirstIndex=724,
                 LastIndex=728,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TFISP",
            },
             new Pentamer
              {
                 FirstIndex=725,
                 LastIndex=729,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FISPE",
            },
             new Pentamer
              {
                 FirstIndex=726,
                 LastIndex=730,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ISPEE",
            },
             new Pentamer
              {
                 FirstIndex=727,
                 LastIndex=731,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPEEL",
            },
             new Pentamer
              {
                 FirstIndex=728,
                 LastIndex=732,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PEELI",
            },
             new Pentamer
              {
                 FirstIndex=729,
                 LastIndex=733,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EELIK",
            },
             new Pentamer
              {
                 FirstIndex=730,
                 LastIndex=734,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELIKK",
            },
             new Pentamer
              {
                 FirstIndex=731,
                 LastIndex=735,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LIKKL",
            },
             new Pentamer
              {
                 FirstIndex=732,
                 LastIndex=736,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IKKLQ",
            },
             new Pentamer
              {
                 FirstIndex=733,
                 LastIndex=737,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KKLQY",
            },
             new Pentamer
              {
                 FirstIndex=734,
                 LastIndex=738,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KLQYR",
            },
             new Pentamer
              {
                 FirstIndex=735,
                 LastIndex=739,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LQYRY",
            },
             new Pentamer
              {
                 FirstIndex=736,
                 LastIndex=740,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QYRYE",
            },
             new Pentamer
              {
                 FirstIndex=737,
                 LastIndex=741,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YRYEK",
            },
             new Pentamer
              {
                 FirstIndex=738,
                 LastIndex=742,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RYEKF",
            },
             new Pentamer
              {
                 FirstIndex=739,
                 LastIndex=743,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YEKFS",
            },
             new Pentamer
              {
                 FirstIndex=740,
                 LastIndex=744,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKFSP",
            },
             new Pentamer
              {
                 FirstIndex=741,
                 LastIndex=745,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KFSPF",
            },
             new Pentamer
              {
                 FirstIndex=742,
                 LastIndex=746,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FSPFA",
            },
             new Pentamer
              {
                 FirstIndex=743,
                 LastIndex=747,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPFAD",
            },
             new Pentamer
              {
                 FirstIndex=744,
                 LastIndex=748,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PFADT",
            },
             new Pentamer
              {
                 FirstIndex=745,
                 LastIndex=749,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FADTF",
            },
             new Pentamer
              {
                 FirstIndex=746,
                 LastIndex=750,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ADTFK",
            },
             new Pentamer
              {
                 FirstIndex=747,
                 LastIndex=751,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DTFKK",
            },
             new Pentamer
              {
                 FirstIndex=748,
                 LastIndex=752,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TFKKR",
            },
             new Pentamer
              {
                 FirstIndex=749,
                 LastIndex=753,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FKKRV",
            },
             new Pentamer
              {
                 FirstIndex=750,
                 LastIndex=754,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KKRVS",
            },
             new Pentamer
              {
                 FirstIndex=751,
                 LastIndex=755,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KRVSK",
            },
             new Pentamer
              {
                 FirstIndex=752,
                 LastIndex=756,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RVSKN",
            },
             new Pentamer
              {
                 FirstIndex=753,
                 LastIndex=757,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VSKNT",
            },
             new Pentamer
              {
                 FirstIndex=754,
                 LastIndex=758,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SKNTF",
            },
             new Pentamer
              {
                 FirstIndex=755,
                 LastIndex=759,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KNTFF",
            },
             new Pentamer
              {
                 FirstIndex=756,
                 LastIndex=760,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NTFFV",
            },
             new Pentamer
              {
                 FirstIndex=757,
                 LastIndex=761,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TFFVL",
            },
             new Pentamer
              {
                 FirstIndex=758,
                 LastIndex=762,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FFVLV",
            },
             new Pentamer
              {
                 FirstIndex=759,
                 LastIndex=763,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FVLVR",
            },
             new Pentamer
              {
                 FirstIndex=760,
                 LastIndex=764,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VLVRV",
            },
             new Pentamer
              {
                 FirstIndex=761,
                 LastIndex=765,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LVRVV",
            },
             new Pentamer
              {
                 FirstIndex=762,
                 LastIndex=766,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VRVVD",
            },
             new Pentamer
              {
                 FirstIndex=763,
                 LastIndex=767,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RVVDE",
            },
             new Pentamer
              {
                 FirstIndex=764,
                 LastIndex=768,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VVDEL",
            },
             new Pentamer
              {
                 FirstIndex=765,
                 LastIndex=769,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VDELC",
            },
             new Pentamer
              {
                 FirstIndex=766,
                 LastIndex=770,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DELCL",
            },
             new Pentamer
              {
                 FirstIndex=767,
                 LastIndex=771,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELCLV",
            },
             new Pentamer
              {
                 FirstIndex=768,
                 LastIndex=772,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LCLVE",
            },
             new Pentamer
              {
                 FirstIndex=769,
                 LastIndex=773,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CLVEL",
            },
             new Pentamer
              {
                 FirstIndex=770,
                 LastIndex=774,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LVELT",
            },
             new Pentamer
              {
                 FirstIndex=771,
                 LastIndex=775,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VELTE",
            },
             new Pentamer
              {
                 FirstIndex=772,
                 LastIndex=776,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELTEE",
            },
             new Pentamer
              {
                 FirstIndex=773,
                 LastIndex=777,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LTEEI",
            },
             new Pentamer
              {
                 FirstIndex=774,
                 LastIndex=778,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TEEIL",
            },
             new Pentamer
              {
                 FirstIndex=775,
                 LastIndex=779,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EEILK",
            },
             new Pentamer
              {
                 FirstIndex=776,
                 LastIndex=780,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EILKL",
            },
             new Pentamer
              {
                 FirstIndex=777,
                 LastIndex=781,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ILKLL",
            },
             new Pentamer
              {
                 FirstIndex=778,
                 LastIndex=782,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LKLLM",
            },
             new Pentamer
              {
                 FirstIndex=779,
                 LastIndex=783,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KLLME",
            },
             new Pentamer
              {
                 FirstIndex=780,
                 LastIndex=784,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLMEL",
            },
             new Pentamer
              {
                 FirstIndex=781,
                 LastIndex=785,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LMELV",
            },
             new Pentamer
              {
                 FirstIndex=782,
                 LastIndex=786,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MELVF",
            },
             new Pentamer
              {
                 FirstIndex=783,
                 LastIndex=787,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELVFR",
            },
             new Pentamer
              {
                 FirstIndex=784,
                 LastIndex=788,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LVFRL",
            },
             new Pentamer
              {
                 FirstIndex=785,
                 LastIndex=789,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VFRLV",
            },
             new Pentamer
              {
                 FirstIndex=786,
                 LastIndex=790,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FRLVC",
            },
             new Pentamer
              {
                 FirstIndex=787,
                 LastIndex=791,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RLVCN",
            },
             new Pentamer
              {
                 FirstIndex=788,
                 LastIndex=792,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LVCNG",
            },
             new Pentamer
              {
                 FirstIndex=789,
                 LastIndex=793,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VCNGE",
            },
             new Pentamer
              {
                 FirstIndex=790,
                 LastIndex=794,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CNGEL",
            },
             new Pentamer
              {
                 FirstIndex=791,
                 LastIndex=795,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NGELS",
            },
             new Pentamer
              {
                 FirstIndex=792,
                 LastIndex=796,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GELSL",
            },
             new Pentamer
              {
                 FirstIndex=793,
                 LastIndex=797,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELSLA",
            },
             new Pentamer
              {
                 FirstIndex=794,
                 LastIndex=798,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSLAR",
            },
             new Pentamer
              {
                 FirstIndex=795,
                 LastIndex=799,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SLARV",
            },
             new Pentamer
              {
                 FirstIndex=796,
                 LastIndex=800,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LARVL",
            },
             new Pentamer
              {
                 FirstIndex=797,
                 LastIndex=801,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ARVLR",
            },
             new Pentamer
              {
                 FirstIndex=798,
                 LastIndex=802,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RVLRK",
            },
             new Pentamer
              {
                 FirstIndex=799,
                 LastIndex=803,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VLRKN",
            },
             new Pentamer
              {
                 FirstIndex=800,
                 LastIndex=804,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LRKNI",
            },
             new Pentamer
              {
                 FirstIndex=801,
                 LastIndex=805,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RKNIL",
            },
             new Pentamer
              {
                 FirstIndex=802,
                 LastIndex=806,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KNILD",
            },
             new Pentamer
              {
                 FirstIndex=803,
                 LastIndex=807,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NILDK",
            },
             new Pentamer
              {
                 FirstIndex=804,
                 LastIndex=808,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ILDKV",
            },
             new Pentamer
              {
                 FirstIndex=805,
                 LastIndex=809,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LDKVD",
            },
             new Pentamer
              {
                 FirstIndex=806,
                 LastIndex=810,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DKVDQ",
            },
             new Pentamer
              {
                 FirstIndex=807,
                 LastIndex=811,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KVDQK",
            },
             new Pentamer
              {
                 FirstIndex=808,
                 LastIndex=812,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VDQKK",
            },
             new Pentamer
              {
                 FirstIndex=809,
                 LastIndex=813,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DQKKL",
            },
             new Pentamer
              {
                 FirstIndex=810,
                 LastIndex=814,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QKKLL",
            },
             new Pentamer
              {
                 FirstIndex=811,
                 LastIndex=815,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KKLLR",
            },
             new Pentamer
              {
                 FirstIndex=812,
                 LastIndex=816,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KLLRC",
            },
             new Pentamer
              {
                 FirstIndex=813,
                 LastIndex=817,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLRCA",
            },
             new Pentamer
              {
                 FirstIndex=814,
                 LastIndex=818,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LRCAT",
            },
             new Pentamer
              {
                 FirstIndex=815,
                 LastIndex=819,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RCATS",
            },
             new Pentamer
              {
                 FirstIndex=816,
                 LastIndex=820,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CATSS",
            },
             new Pentamer
              {
                 FirstIndex=817,
                 LastIndex=821,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ATSSQ",
            },
             new Pentamer
              {
                 FirstIndex=818,
                 LastIndex=822,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TSSQP",
            },
             new Pentamer
              {
                 FirstIndex=819,
                 LastIndex=823,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSQPL",
            },
             new Pentamer
              {
                 FirstIndex=820,
                 LastIndex=824,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SQPLA",
            },
             new Pentamer
              {
                 FirstIndex=821,
                 LastIndex=825,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QPLAA",
            },
             new Pentamer
              {
                 FirstIndex=822,
                 LastIndex=826,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PLAAR",
            },
             new Pentamer
              {
                 FirstIndex=823,
                 LastIndex=827,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LAARG",
            },
             new Pentamer
              {
                 FirstIndex=824,
                 LastIndex=828,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AARGV",
            },
             new Pentamer
              {
                 FirstIndex=825,
                 LastIndex=829,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ARGVA",
            },
             new Pentamer
              {
                 FirstIndex=826,
                 LastIndex=830,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RGVAA",
            },
             new Pentamer
              {
                 FirstIndex=827,
                 LastIndex=831,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GVAAR",
            },
             new Pentamer
              {
                 FirstIndex=828,
                 LastIndex=832,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VAARP",
            },
             new Pentamer
              {
                 FirstIndex=829,
                 LastIndex=833,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AARPG",
            },
             new Pentamer
              {
                 FirstIndex=830,
                 LastIndex=834,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ARPGT",
            },
             new Pentamer
              {
                 FirstIndex=831,
                 LastIndex=835,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RPGTL",
            },
             new Pentamer
              {
                 FirstIndex=832,
                 LastIndex=836,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PGTLH",
            },
             new Pentamer
              {
                 FirstIndex=833,
                 LastIndex=837,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GTLHD",
            },
             new Pentamer
              {
                 FirstIndex=834,
                 LastIndex=838,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TLHDF",
            },
             new Pentamer
              {
                 FirstIndex=835,
                 LastIndex=839,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LHDFH",
            },
             new Pentamer
              {
                 FirstIndex=836,
                 LastIndex=840,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HDFHS",
            },
             new Pentamer
              {
                 FirstIndex=837,
                 LastIndex=841,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DFHSH",
            },
             new Pentamer
              {
                 FirstIndex=838,
                 LastIndex=842,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FHSHE",
            },
             new Pentamer
              {
                 FirstIndex=839,
                 LastIndex=843,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HSHEI",
            },
             new Pentamer
              {
                 FirstIndex=840,
                 LastIndex=844,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SHEIA",
            },
             new Pentamer
              {
                 FirstIndex=841,
                 LastIndex=845,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HEIAE",
            },
             new Pentamer
              {
                 FirstIndex=842,
                 LastIndex=846,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EIAEQ",
            },
             new Pentamer
              {
                 FirstIndex=843,
                 LastIndex=847,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IAEQL",
            },
             new Pentamer
              {
                 FirstIndex=844,
                 LastIndex=848,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AEQLT",
            },
             new Pentamer
              {
                 FirstIndex=845,
                 LastIndex=849,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EQLTL",
            },
             new Pentamer
              {
                 FirstIndex=846,
                 LastIndex=850,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QLTLL",
            },
             new Pentamer
              {
                 FirstIndex=847,
                 LastIndex=851,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LTLLD",
            },
             new Pentamer
              {
                 FirstIndex=848,
                 LastIndex=852,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TLLDA",
            },
             new Pentamer
              {
                 FirstIndex=849,
                 LastIndex=853,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLDAE",
            },
             new Pentamer
              {
                 FirstIndex=850,
                 LastIndex=854,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LDAEL",
            },
             new Pentamer
              {
                 FirstIndex=851,
                 LastIndex=855,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DAELF",
            },
             new Pentamer
              {
                 FirstIndex=852,
                 LastIndex=856,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AELFY",
            },
             new Pentamer
              {
                 FirstIndex=853,
                 LastIndex=857,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELFYK",
            },
             new Pentamer
              {
                 FirstIndex=854,
                 LastIndex=858,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LFYKI",
            },
             new Pentamer
              {
                 FirstIndex=855,
                 LastIndex=859,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FYKIE",
            },
             new Pentamer
              {
                 FirstIndex=856,
                 LastIndex=860,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YKIEI",
            },
             new Pentamer
              {
                 FirstIndex=857,
                 LastIndex=861,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KIEIP",
            },
             new Pentamer
              {
                 FirstIndex=858,
                 LastIndex=862,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IEIPE",
            },
             new Pentamer
              {
                 FirstIndex=859,
                 LastIndex=863,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EIPEV",
            },
             new Pentamer
              {
                 FirstIndex=860,
                 LastIndex=864,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IPEVL",
            },
             new Pentamer
              {
                 FirstIndex=861,
                 LastIndex=865,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PEVLL",
            },
             new Pentamer
              {
                 FirstIndex=862,
                 LastIndex=866,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EVLLW",
            },
             new Pentamer
              {
                 FirstIndex=863,
                 LastIndex=867,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VLLWA",
            },
             new Pentamer
              {
                 FirstIndex=864,
                 LastIndex=868,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLWAK",
            },
             new Pentamer
              {
                 FirstIndex=865,
                 LastIndex=869,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LWAKE",
            },
             new Pentamer
              {
                 FirstIndex=866,
                 LastIndex=870,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="WAKEQ",
            },
             new Pentamer
              {
                 FirstIndex=867,
                 LastIndex=871,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AKEQN",
            },
             new Pentamer
              {
                 FirstIndex=868,
                 LastIndex=872,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KEQNE",
            },
             new Pentamer
              {
                 FirstIndex=869,
                 LastIndex=873,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EQNEE",
            },
             new Pentamer
              {
                 FirstIndex=870,
                 LastIndex=874,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QNEEK",
            },
             new Pentamer
              {
                 FirstIndex=871,
                 LastIndex=875,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NEEKS",
            },
             new Pentamer
              {
                 FirstIndex=872,
                 LastIndex=876,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EEKSP",
            },
             new Pentamer
              {
                 FirstIndex=873,
                 LastIndex=877,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKSPN",
            },
             new Pentamer
              {
                 FirstIndex=874,
                 LastIndex=878,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KSPNL",
            },
             new Pentamer
              {
                 FirstIndex=875,
                 LastIndex=879,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SPNLT",
            },
             new Pentamer
              {
                 FirstIndex=876,
                 LastIndex=880,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PNLTQ",
            },
             new Pentamer
              {
                 FirstIndex=877,
                 LastIndex=881,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NLTQF",
            },
             new Pentamer
              {
                 FirstIndex=878,
                 LastIndex=882,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LTQFT",
            },
             new Pentamer
              {
                 FirstIndex=879,
                 LastIndex=883,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TQFTE",
            },
             new Pentamer
              {
                 FirstIndex=880,
                 LastIndex=884,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QFTEH",
            },
             new Pentamer
              {
                 FirstIndex=881,
                 LastIndex=885,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FTEHF",
            },
             new Pentamer
              {
                 FirstIndex=882,
                 LastIndex=886,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TEHFN",
            },
             new Pentamer
              {
                 FirstIndex=883,
                 LastIndex=887,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EHFNN",
            },
             new Pentamer
              {
                 FirstIndex=884,
                 LastIndex=888,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HFNNM",
            },
             new Pentamer
              {
                 FirstIndex=885,
                 LastIndex=889,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FNNMS",
            },
             new Pentamer
              {
                 FirstIndex=886,
                 LastIndex=890,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NNMSY",
            },
             new Pentamer
              {
                 FirstIndex=887,
                 LastIndex=891,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NMSYW",
            },
             new Pentamer
              {
                 FirstIndex=888,
                 LastIndex=892,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MSYWV",
            },
             new Pentamer
              {
                 FirstIndex=889,
                 LastIndex=893,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SYWVR",
            },
             new Pentamer
              {
                 FirstIndex=890,
                 LastIndex=894,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YWVRS",
            },
             new Pentamer
              {
                 FirstIndex=891,
                 LastIndex=895,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="WVRSI",
            },
             new Pentamer
              {
                 FirstIndex=892,
                 LastIndex=896,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VRSII",
            },
             new Pentamer
              {
                 FirstIndex=893,
                 LastIndex=897,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RSIIM",
            },
             new Pentamer
              {
                 FirstIndex=894,
                 LastIndex=898,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SIIML",
            },
             new Pentamer
              {
                 FirstIndex=895,
                 LastIndex=899,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IIMLQ",
            },
             new Pentamer
              {
                 FirstIndex=896,
                 LastIndex=900,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IMLQE",
            },
             new Pentamer
              {
                 FirstIndex=897,
                 LastIndex=901,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MLQEK",
            },
             new Pentamer
              {
                 FirstIndex=898,
                 LastIndex=902,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LQEKA",
            },
             new Pentamer
              {
                 FirstIndex=899,
                 LastIndex=903,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QEKAQ",
            },
             new Pentamer
              {
                 FirstIndex=900,
                 LastIndex=904,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EKAQD",
            },
             new Pentamer
              {
                 FirstIndex=901,
                 LastIndex=905,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KAQDR",
            },
             new Pentamer
              {
                 FirstIndex=902,
                 LastIndex=906,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AQDRE",
            },
             new Pentamer
              {
                 FirstIndex=903,
                 LastIndex=907,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QDRER",
            },
             new Pentamer
              {
                 FirstIndex=904,
                 LastIndex=908,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DRERL",
            },
             new Pentamer
              {
                 FirstIndex=905,
                 LastIndex=909,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RERLL",
            },
             new Pentamer
              {
                 FirstIndex=906,
                 LastIndex=910,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ERLLL",
            },
             new Pentamer
              {
                 FirstIndex=907,
                 LastIndex=911,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RLLLK",
            },
             new Pentamer
              {
                 FirstIndex=908,
                 LastIndex=912,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLLKF",
            },
             new Pentamer
              {
                 FirstIndex=909,
                 LastIndex=913,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LLKFI",
            },
             new Pentamer
              {
                 FirstIndex=910,
                 LastIndex=914,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LKFIK",
            },
             new Pentamer
              {
                 FirstIndex=911,
                 LastIndex=915,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KFIKI",
            },
             new Pentamer
              {
                 FirstIndex=912,
                 LastIndex=916,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FIKIM",
            },
             new Pentamer
              {
                 FirstIndex=913,
                 LastIndex=917,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IKIMK",
            },
             new Pentamer
              {
                 FirstIndex=914,
                 LastIndex=918,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KIMKH",
            },
             new Pentamer
              {
                 FirstIndex=915,
                 LastIndex=919,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IMKHL",
            },
             new Pentamer
              {
                 FirstIndex=916,
                 LastIndex=920,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MKHLR",
            },
             new Pentamer
              {
                 FirstIndex=917,
                 LastIndex=921,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KHLRK",
            },
             new Pentamer
              {
                 FirstIndex=918,
                 LastIndex=922,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HLRKL",
            },
             new Pentamer
              {
                 FirstIndex=919,
                 LastIndex=923,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LRKLN",
            },
             new Pentamer
              {
                 FirstIndex=920,
                 LastIndex=924,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RKLNN",
            },
             new Pentamer
              {
                 FirstIndex=921,
                 LastIndex=925,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KLNNF",
            },
             new Pentamer
              {
                 FirstIndex=922,
                 LastIndex=926,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LNNFN",
            },
             new Pentamer
              {
                 FirstIndex=923,
                 LastIndex=927,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NNFNS",
            },
             new Pentamer
              {
                 FirstIndex=924,
                 LastIndex=928,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NFNSY",
            },
             new Pentamer
              {
                 FirstIndex=925,
                 LastIndex=929,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FNSYL",
            },
             new Pentamer
              {
                 FirstIndex=926,
                 LastIndex=930,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NSYLA",
            },
             new Pentamer
              {
                 FirstIndex=927,
                 LastIndex=931,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SYLAI",
            },
             new Pentamer
              {
                 FirstIndex=928,
                 LastIndex=932,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YLAIL",
            },
             new Pentamer
              {
                 FirstIndex=929,
                 LastIndex=933,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LAILS",
            },
             new Pentamer
              {
                 FirstIndex=930,
                 LastIndex=934,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AILSA",
            },
             new Pentamer
              {
                 FirstIndex=931,
                 LastIndex=935,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ILSAL",
            },
             new Pentamer
              {
                 FirstIndex=932,
                 LastIndex=936,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSALD",
            },
             new Pentamer
              {
                 FirstIndex=933,
                 LastIndex=937,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SALDS",
            },
             new Pentamer
              {
                 FirstIndex=934,
                 LastIndex=938,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ALDSA",
            },
             new Pentamer
              {
                 FirstIndex=935,
                 LastIndex=939,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LDSAP",
            },
             new Pentamer
              {
                 FirstIndex=936,
                 LastIndex=940,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DSAPI",
            },
             new Pentamer
              {
                 FirstIndex=937,
                 LastIndex=941,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SAPIR",
            },
             new Pentamer
              {
                 FirstIndex=938,
                 LastIndex=942,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="APIRR",
            },
             new Pentamer
              {
                 FirstIndex=939,
                 LastIndex=943,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PIRRL",
            },
             new Pentamer
              {
                 FirstIndex=940,
                 LastIndex=944,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IRRLE",
            },
             new Pentamer
              {
                 FirstIndex=941,
                 LastIndex=945,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RRLEW",
            },
             new Pentamer
              {
                 FirstIndex=942,
                 LastIndex=946,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RLEWQ",
            },
             new Pentamer
              {
                 FirstIndex=943,
                 LastIndex=947,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LEWQK",
            },
             new Pentamer
              {
                 FirstIndex=944,
                 LastIndex=948,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EWQKQ",
            },
             new Pentamer
              {
                 FirstIndex=945,
                 LastIndex=949,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="WQKQT",
            },
             new Pentamer
              {
                 FirstIndex=946,
                 LastIndex=950,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QKQTS",
            },
             new Pentamer
              {
                 FirstIndex=947,
                 LastIndex=951,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KQTSE",
            },
             new Pentamer
              {
                 FirstIndex=948,
                 LastIndex=952,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QTSEG",
            },
             new Pentamer
              {
                 FirstIndex=949,
                 LastIndex=953,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TSEGL",
            },
             new Pentamer
              {
                 FirstIndex=950,
                 LastIndex=954,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SEGLA",
            },
             new Pentamer
              {
                 FirstIndex=951,
                 LastIndex=955,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EGLAE",
            },
             new Pentamer
              {
                 FirstIndex=952,
                 LastIndex=956,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GLAEY",
            },
             new Pentamer
              {
                 FirstIndex=953,
                 LastIndex=957,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LAEYC",
            },
             new Pentamer
              {
                 FirstIndex=954,
                 LastIndex=958,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AEYCT",
            },
             new Pentamer
              {
                 FirstIndex=955,
                 LastIndex=959,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EYCTL",
            },
             new Pentamer
              {
                 FirstIndex=956,
                 LastIndex=960,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YCTLI",
            },
             new Pentamer
              {
                 FirstIndex=957,
                 LastIndex=961,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CTLID",
            },
             new Pentamer
              {
                 FirstIndex=958,
                 LastIndex=962,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TLIDS",
            },
             new Pentamer
              {
                 FirstIndex=959,
                 LastIndex=963,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LIDSS",
            },
             new Pentamer
              {
                 FirstIndex=960,
                 LastIndex=964,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IDSSS",
            },
             new Pentamer
              {
                 FirstIndex=961,
                 LastIndex=965,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DSSSS",
            },
             new Pentamer
              {
                 FirstIndex=962,
                 LastIndex=966,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSSSF",
            },
             new Pentamer
              {
                 FirstIndex=963,
                 LastIndex=967,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSSFR",
            },
             new Pentamer
              {
                 FirstIndex=964,
                 LastIndex=968,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SSFRA",
            },
             new Pentamer
              {
                 FirstIndex=965,
                 LastIndex=969,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SFRAY",
            },
             new Pentamer
              {
                 FirstIndex=966,
                 LastIndex=970,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FRAYR",
            },
             new Pentamer
              {
                 FirstIndex=967,
                 LastIndex=971,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RAYRA",
            },
             new Pentamer
              {
                 FirstIndex=968,
                 LastIndex=972,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AYRAA",
            },
             new Pentamer
              {
                 FirstIndex=969,
                 LastIndex=973,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YRAAL",
            },
             new Pentamer
              {
                 FirstIndex=970,
                 LastIndex=974,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RAALS",
            },
             new Pentamer
              {
                 FirstIndex=971,
                 LastIndex=975,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AALSE",
            },
             new Pentamer
              {
                 FirstIndex=972,
                 LastIndex=976,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ALSEV",
            },
             new Pentamer
              {
                 FirstIndex=973,
                 LastIndex=977,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSEVE",
            },
             new Pentamer
              {
                 FirstIndex=974,
                 LastIndex=978,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SEVEP",
            },
             new Pentamer
              {
                 FirstIndex=975,
                 LastIndex=979,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EVEPP",
            },
             new Pentamer
              {
                 FirstIndex=976,
                 LastIndex=980,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VEPPC",
            },
             new Pentamer
              {
                 FirstIndex=977,
                 LastIndex=981,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EPPCI",
            },
             new Pentamer
              {
                 FirstIndex=978,
                 LastIndex=982,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PPCIP",
            },
             new Pentamer
              {
                 FirstIndex=979,
                 LastIndex=983,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PCIPY",
            },
             new Pentamer
              {
                 FirstIndex=980,
                 LastIndex=984,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CIPYL",
            },
             new Pentamer
              {
                 FirstIndex=981,
                 LastIndex=985,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IPYLG",
            },
             new Pentamer
              {
                 FirstIndex=982,
                 LastIndex=986,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PYLGL",
            },
             new Pentamer
              {
                 FirstIndex=983,
                 LastIndex=987,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YLGLI",
            },
             new Pentamer
              {
                 FirstIndex=984,
                 LastIndex=988,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LGLIL",
            },
             new Pentamer
              {
                 FirstIndex=985,
                 LastIndex=989,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GLILQ",
            },
             new Pentamer
              {
                 FirstIndex=986,
                 LastIndex=990,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LILQD",
            },
             new Pentamer
              {
                 FirstIndex=987,
                 LastIndex=991,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ILQDL",
            },
             new Pentamer
              {
                 FirstIndex=988,
                 LastIndex=992,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LQDLT",
            },
             new Pentamer
              {
                 FirstIndex=989,
                 LastIndex=993,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QDLTF",
            },
             new Pentamer
              {
                 FirstIndex=990,
                 LastIndex=994,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DLTFV",
            },
             new Pentamer
              {
                 FirstIndex=991,
                 LastIndex=995,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LTFVH",
            },
             new Pentamer
              {
                 FirstIndex=992,
                 LastIndex=996,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TFVHL",
            },
             new Pentamer
              {
                 FirstIndex=993,
                 LastIndex=997,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FVHLG",
            },
             new Pentamer
              {
                 FirstIndex=994,
                 LastIndex=998,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VHLGN",
            },
             new Pentamer
              {
                 FirstIndex=995,
                 LastIndex=999,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HLGNP",
            },
             new Pentamer
              {
                 FirstIndex=996,
                 LastIndex=1000,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LGNPD",
            },
             new Pentamer
              {
                 FirstIndex=997,
                 LastIndex=1001,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GNPDY",
            },
             new Pentamer
              {
                 FirstIndex=998,
                 LastIndex=1002,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NPDYI",
            },
             new Pentamer
              {
                 FirstIndex=999,
                 LastIndex=1003,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PDYID",
            },
             new Pentamer
              {
                 FirstIndex=1000,
                 LastIndex=1004,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DYIDG",
            },
             new Pentamer
              {
                 FirstIndex=1001,
                 LastIndex=1005,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YIDGK",
            },
             new Pentamer
              {
                 FirstIndex=1002,
                 LastIndex=1006,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IDGKV",
            },
             new Pentamer
              {
                 FirstIndex=1003,
                 LastIndex=1007,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DGKVN",
            },
             new Pentamer
              {
                 FirstIndex=1004,
                 LastIndex=1008,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="GKVNF",
            },
             new Pentamer
              {
                 FirstIndex=1005,
                 LastIndex=1009,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KVNFS",
            },
             new Pentamer
              {
                 FirstIndex=1006,
                 LastIndex=1010,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="VNFSK",
            },
             new Pentamer
              {
                 FirstIndex=1007,
                 LastIndex=1011,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NFSKR",
            },
             new Pentamer
              {
                 FirstIndex=1008,
                 LastIndex=1012,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FSKRW",
            },
             new Pentamer
              {
                 FirstIndex=1009,
                 LastIndex=1013,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SKRWQ",
            },
             new Pentamer
              {
                 FirstIndex=1010,
                 LastIndex=1014,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KRWQQ",
            },
             new Pentamer
              {
                 FirstIndex=1011,
                 LastIndex=1015,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RWQQF",
            },
             new Pentamer
              {
                 FirstIndex=1012,
                 LastIndex=1016,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="WQQFN",
            },
             new Pentamer
              {
                 FirstIndex=1013,
                 LastIndex=1017,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QQFNI",
            },
             new Pentamer
              {
                 FirstIndex=1014,
                 LastIndex=1018,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QFNIL",
            },
             new Pentamer
              {
                 FirstIndex=1015,
                 LastIndex=1019,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FNILD",
            },
             new Pentamer
              {
                 FirstIndex=1016,
                 LastIndex=1020,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NILDS",
            },
             new Pentamer
              {
                 FirstIndex=1017,
                 LastIndex=1021,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ILDSM",
            },
             new Pentamer
              {
                 FirstIndex=1018,
                 LastIndex=1022,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LDSMR",
            },
             new Pentamer
              {
                 FirstIndex=1019,
                 LastIndex=1023,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DSMRC",
            },
             new Pentamer
              {
                 FirstIndex=1020,
                 LastIndex=1024,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SMRCF",
            },
             new Pentamer
              {
                 FirstIndex=1021,
                 LastIndex=1025,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MRCFQ",
            },
             new Pentamer
              {
                 FirstIndex=1022,
                 LastIndex=1026,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RCFQQ",
            },
             new Pentamer
              {
                 FirstIndex=1023,
                 LastIndex=1027,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="CFQQA",
            },
             new Pentamer
              {
                 FirstIndex=1024,
                 LastIndex=1028,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FQQAH",
            },
             new Pentamer
              {
                 FirstIndex=1025,
                 LastIndex=1029,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QQAHY",
            },
             new Pentamer
              {
                 FirstIndex=1026,
                 LastIndex=1030,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="QAHYD",
            },
             new Pentamer
              {
                 FirstIndex=1027,
                 LastIndex=1031,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AHYDM",
            },
             new Pentamer
              {
                 FirstIndex=1028,
                 LastIndex=1032,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HYDMR",
            },
             new Pentamer
              {
                 FirstIndex=1029,
                 LastIndex=1033,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="YDMRR",
            },
             new Pentamer
              {
                 FirstIndex=1030,
                 LastIndex=1034,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DMRRN",
            },
             new Pentamer
              {
                 FirstIndex=1031,
                 LastIndex=1035,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="MRRND",
            },
             new Pentamer
              {
                 FirstIndex=1032,
                 LastIndex=1036,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RRNDD",
            },
             new Pentamer
              {
                 FirstIndex=1033,
                 LastIndex=1037,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RNDDI",
            },
             new Pentamer
              {
                 FirstIndex=1034,
                 LastIndex=1038,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NDDII",
            },
             new Pentamer
              {
                 FirstIndex=1035,
                 LastIndex=1039,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DDIIN",
            },
             new Pentamer
              {
                 FirstIndex=1036,
                 LastIndex=1040,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DIINF",
            },
             new Pentamer
              {
                 FirstIndex=1037,
                 LastIndex=1041,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IINFF",
            },
             new Pentamer
              {
                 FirstIndex=1038,
                 LastIndex=1042,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="INFFN",
            },
             new Pentamer
              {
                 FirstIndex=1039,
                 LastIndex=1043,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NFFND",
            },
             new Pentamer
              {
                 FirstIndex=1040,
                 LastIndex=1044,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FFNDF",
            },
             new Pentamer
              {
                 FirstIndex=1041,
                 LastIndex=1045,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FNDFS",
            },
             new Pentamer
              {
                 FirstIndex=1042,
                 LastIndex=1046,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NDFSD",
            },
             new Pentamer
              {
                 FirstIndex=1043,
                 LastIndex=1047,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DFSDH",
            },
             new Pentamer
              {
                 FirstIndex=1044,
                 LastIndex=1048,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="FSDHL",
            },
             new Pentamer
              {
                 FirstIndex=1045,
                 LastIndex=1049,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SDHLA",
            },
             new Pentamer
              {
                 FirstIndex=1046,
                 LastIndex=1050,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DHLAE",
            },
             new Pentamer
              {
                 FirstIndex=1047,
                 LastIndex=1051,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="HLAEE",
            },
             new Pentamer
              {
                 FirstIndex=1048,
                 LastIndex=1052,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LAEEA",
            },
             new Pentamer
              {
                 FirstIndex=1049,
                 LastIndex=1053,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="AEEAL",
            },
             new Pentamer
              {
                 FirstIndex=1050,
                 LastIndex=1054,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EEALW",
            },
             new Pentamer
              {
                 FirstIndex=1051,
                 LastIndex=1055,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="EALWE",
            },
             new Pentamer
              {
                 FirstIndex=1052,
                 LastIndex=1056,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ALWEL",
            },
             new Pentamer
              {
                 FirstIndex=1053,
                 LastIndex=1057,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LWELS",
            },
             new Pentamer
              {
                 FirstIndex=1054,
                 LastIndex=1058,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="WELSL",
            },
             new Pentamer
              {
                 FirstIndex=1055,
                 LastIndex=1059,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ELSLK",
            },
             new Pentamer
              {
                 FirstIndex=1056,
                 LastIndex=1060,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LSLKI",
            },
             new Pentamer
              {
                 FirstIndex=1057,
                 LastIndex=1061,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="SLKIK",
            },
             new Pentamer
              {
                 FirstIndex=1058,
                 LastIndex=1062,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="LKIKP",
            },
             new Pentamer
              {
                 FirstIndex=1059,
                 LastIndex=1063,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KIKPR",
            },
             new Pentamer
              {
                 FirstIndex=1060,
                 LastIndex=1064,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="IKPRN",
            },
             new Pentamer
              {
                 FirstIndex=1061,
                 LastIndex=1065,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KPRNI",
            },
             new Pentamer
              {
                 FirstIndex=1062,
                 LastIndex=1066,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="PRNIT",
            },
             new Pentamer
              {
                 FirstIndex=1063,
                 LastIndex=1067,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RNITR",
            },
             new Pentamer
              {
                 FirstIndex=1064,
                 LastIndex=1068,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="NITRR",
            },
             new Pentamer
              {
                 FirstIndex=1065,
                 LastIndex=1069,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="ITRRK",
            },
             new Pentamer
              {
                 FirstIndex=1066,
                 LastIndex=1070,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TRRKT",
            },
             new Pentamer
              {
                 FirstIndex=1067,
                 LastIndex=1071,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RRKTD",
            },
             new Pentamer
              {
                 FirstIndex=1068,
                 LastIndex=1072,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="RKTDR",
            },
             new Pentamer
              {
                 FirstIndex=1069,
                 LastIndex=1073,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="KTDRE",
            },
             new Pentamer
              {
                 FirstIndex=1070,
                 LastIndex=1074,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="TDREE",
            },
             new Pentamer
              {
                 FirstIndex=1071,
                 LastIndex=1075,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="DREEK",
            },
             new Pentamer
              {
                 FirstIndex=1072,
                 LastIndex=1076,
                 ProteinName =  "RPGF1_HUMAN " ,
                 ProteinGI = "13905",
                 Sequence ="REEKT",
            },
              new Pentamer
              {
                 FirstIndex=0,
                 LastIndex=4,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MTDTV",
                 },
             new Pentamer
              {
                 FirstIndex=1,
                 LastIndex=5,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TDTVF",
                 },
             new Pentamer
              {
                 FirstIndex=2,
                 LastIndex=6,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DTVFS",
                 },
             new Pentamer
              {
                 FirstIndex=3,
                 LastIndex=7,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TVFSN",
                 },
             new Pentamer
              {
                 FirstIndex=4,
                 LastIndex=8,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VFSNS",
                 },
             new Pentamer
              {
                 FirstIndex=5,
                 LastIndex=9,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FSNSS",
                 },
             new Pentamer
              {
                 FirstIndex=6,
                 LastIndex=10,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SNSSN",
                 },
             new Pentamer
              {
                 FirstIndex=7,
                 LastIndex=11,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NSSNR",
                 },
             new Pentamer
              {
                 FirstIndex=8,
                 LastIndex=12,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SSNRW",
                 },
             new Pentamer
              {
                 FirstIndex=9,
                 LastIndex=13,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SNRWM",
                 },
             new Pentamer
              {
                 FirstIndex=10,
                 LastIndex=14,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NRWMY",
                 },
             new Pentamer
              {
                 FirstIndex=11,
                 LastIndex=15,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RWMYP",
                 },
             new Pentamer
              {
                 FirstIndex=12,
                 LastIndex=16,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WMYPS",
                 },
             new Pentamer
              {
                 FirstIndex=13,
                 LastIndex=17,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MYPSD",
                 },
             new Pentamer
              {
                 FirstIndex=14,
                 LastIndex=18,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YPSDR",
                 },
             new Pentamer
              {
                 FirstIndex=15,
                 LastIndex=19,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PSDRP",
                 },
             new Pentamer
              {
                 FirstIndex=16,
                 LastIndex=20,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SDRPL",
                 },
             new Pentamer
              {
                 FirstIndex=17,
                 LastIndex=21,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DRPLQ",
                 },
             new Pentamer
              {
                 FirstIndex=18,
                 LastIndex=22,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RPLQS",
                 },
             new Pentamer
              {
                 FirstIndex=19,
                 LastIndex=23,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PLQSN",
                 },
             new Pentamer
              {
                 FirstIndex=20,
                 LastIndex=24,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LQSND",
                 },
             new Pentamer
              {
                 FirstIndex=21,
                 LastIndex=25,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QSNDK",
                 },
             new Pentamer
              {
                 FirstIndex=22,
                 LastIndex=26,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SNDKE",
                 },
             new Pentamer
              {
                 FirstIndex=23,
                 LastIndex=27,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NDKEQ",
                 },
             new Pentamer
              {
                 FirstIndex=24,
                 LastIndex=28,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DKEQL",
                 },
             new Pentamer
              {
                 FirstIndex=25,
                 LastIndex=29,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KEQLQ",
                 },
             new Pentamer
              {
                 FirstIndex=26,
                 LastIndex=30,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EQLQA",
                 },
             new Pentamer
              {
                 FirstIndex=27,
                 LastIndex=31,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QLQAG",
                 },
             new Pentamer
              {
                 FirstIndex=28,
                 LastIndex=32,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LQAGW",
                 },
             new Pentamer
              {
                 FirstIndex=29,
                 LastIndex=33,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QAGWS",
                 },
             new Pentamer
              {
                 FirstIndex=30,
                 LastIndex=34,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AGWSV",
                 },
             new Pentamer
              {
                 FirstIndex=31,
                 LastIndex=35,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GWSVH",
                 },
             new Pentamer
              {
                 FirstIndex=32,
                 LastIndex=36,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WSVHP",
                 },
             new Pentamer
              {
                 FirstIndex=33,
                 LastIndex=37,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SVHPG",
                 },
             new Pentamer
              {
                 FirstIndex=34,
                 LastIndex=38,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VHPGG",
                 },
             new Pentamer
              {
                 FirstIndex=35,
                 LastIndex=39,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HPGGQ",
                 },
             new Pentamer
              {
                 FirstIndex=36,
                 LastIndex=40,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGGQP",
                 },
             new Pentamer
              {
                 FirstIndex=37,
                 LastIndex=41,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GGQPD",
                 },
             new Pentamer
              {
                 FirstIndex=38,
                 LastIndex=42,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GQPDR",
                 },
             new Pentamer
              {
                 FirstIndex=39,
                 LastIndex=43,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QPDRQ",
                 },
             new Pentamer
              {
                 FirstIndex=40,
                 LastIndex=44,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PDRQR",
                 },
             new Pentamer
              {
                 FirstIndex=41,
                 LastIndex=45,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DRQRK",
                 },
             new Pentamer
              {
                 FirstIndex=42,
                 LastIndex=46,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RQRKQ",
                 },
             new Pentamer
              {
                 FirstIndex=43,
                 LastIndex=47,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QRKQE",
                 },
             new Pentamer
              {
                 FirstIndex=44,
                 LastIndex=48,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RKQEE",
                 },
             new Pentamer
              {
                 FirstIndex=45,
                 LastIndex=49,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KQEEL",
                 },
             new Pentamer
              {
                 FirstIndex=46,
                 LastIndex=50,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QEELT",
                 },
             new Pentamer
              {
                 FirstIndex=47,
                 LastIndex=51,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EELTD",
                 },
             new Pentamer
              {
                 FirstIndex=48,
                 LastIndex=52,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ELTDE",
                 },
             new Pentamer
              {
                 FirstIndex=49,
                 LastIndex=53,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LTDEE",
                 },
             new Pentamer
              {
                 FirstIndex=50,
                 LastIndex=54,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TDEEK",
                 },
             new Pentamer
              {
                 FirstIndex=51,
                 LastIndex=55,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DEEKE",
                 },
             new Pentamer
              {
                 FirstIndex=52,
                 LastIndex=56,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEKEI",
                 },
             new Pentamer
              {
                 FirstIndex=53,
                 LastIndex=57,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EKEII",
                 },
             new Pentamer
              {
                 FirstIndex=54,
                 LastIndex=58,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KEIIN",
                 },
             new Pentamer
              {
                 FirstIndex=55,
                 LastIndex=59,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EIINR",
                 },
             new Pentamer
              {
                 FirstIndex=56,
                 LastIndex=60,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IINRV",
                 },
             new Pentamer
              {
                 FirstIndex=57,
                 LastIndex=61,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="INRVI",
                 },
             new Pentamer
              {
                 FirstIndex=58,
                 LastIndex=62,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NRVIA",
                 },
             new Pentamer
              {
                 FirstIndex=59,
                 LastIndex=63,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RVIAR",
                 },
             new Pentamer
              {
                 FirstIndex=60,
                 LastIndex=64,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VIARA",
                 },
             new Pentamer
              {
                 FirstIndex=61,
                 LastIndex=65,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IARAE",
                 },
             new Pentamer
              {
                 FirstIndex=62,
                 LastIndex=66,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ARAEK",
                 },
             new Pentamer
              {
                 FirstIndex=63,
                 LastIndex=67,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RAEKM",
                 },
             new Pentamer
              {
                 FirstIndex=64,
                 LastIndex=68,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AEKME",
                 },
             new Pentamer
              {
                 FirstIndex=65,
                 LastIndex=69,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EKMEE",
                 },
             new Pentamer
              {
                 FirstIndex=66,
                 LastIndex=70,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KMEEM",
                 },
             new Pentamer
              {
                 FirstIndex=67,
                 LastIndex=71,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MEEME",
                 },
             new Pentamer
              {
                 FirstIndex=68,
                 LastIndex=72,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEMEQ",
                 },
             new Pentamer
              {
                 FirstIndex=69,
                 LastIndex=73,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EMEQE",
                 },
             new Pentamer
              {
                 FirstIndex=70,
                 LastIndex=74,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MEQER",
                 },
             new Pentamer
              {
                 FirstIndex=71,
                 LastIndex=75,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EQERI",
                 },
             new Pentamer
              {
                 FirstIndex=72,
                 LastIndex=76,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QERIG",
                 },
             new Pentamer
              {
                 FirstIndex=73,
                 LastIndex=77,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ERIGR",
                 },
             new Pentamer
              {
                 FirstIndex=74,
                 LastIndex=78,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RIGRL",
                 },
             new Pentamer
              {
                 FirstIndex=75,
                 LastIndex=79,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IGRLV",
                 },
             new Pentamer
              {
                 FirstIndex=76,
                 LastIndex=80,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GRLVD",
                 },
             new Pentamer
              {
                 FirstIndex=77,
                 LastIndex=81,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RLVDR",
                 },
             new Pentamer
              {
                 FirstIndex=78,
                 LastIndex=82,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LVDRL",
                 },
             new Pentamer
              {
                 FirstIndex=79,
                 LastIndex=83,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VDRLE",
                 },
             new Pentamer
              {
                 FirstIndex=80,
                 LastIndex=84,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DRLEN",
                 },
             new Pentamer
              {
                 FirstIndex=81,
                 LastIndex=85,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RLENM",
                 },
             new Pentamer
              {
                 FirstIndex=82,
                 LastIndex=86,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LENMR",
                 },
             new Pentamer
              {
                 FirstIndex=83,
                 LastIndex=87,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ENMRK",
                 },
             new Pentamer
              {
                 FirstIndex=84,
                 LastIndex=88,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NMRKN",
                 },
             new Pentamer
              {
                 FirstIndex=85,
                 LastIndex=89,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MRKNV",
                 },
             new Pentamer
              {
                 FirstIndex=86,
                 LastIndex=90,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RKNVA",
                 },
             new Pentamer
              {
                 FirstIndex=87,
                 LastIndex=91,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KNVAG",
                 },
             new Pentamer
              {
                 FirstIndex=88,
                 LastIndex=92,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NVAGD",
                 },
             new Pentamer
              {
                 FirstIndex=89,
                 LastIndex=93,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VAGDG",
                 },
             new Pentamer
              {
                 FirstIndex=90,
                 LastIndex=94,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AGDGV",
                 },
             new Pentamer
              {
                 FirstIndex=91,
                 LastIndex=95,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GDGVN",
                 },
             new Pentamer
              {
                 FirstIndex=92,
                 LastIndex=96,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DGVNR",
                 },
             new Pentamer
              {
                 FirstIndex=93,
                 LastIndex=97,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GVNRC",
                 },
             new Pentamer
              {
                 FirstIndex=94,
                 LastIndex=98,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VNRCI",
                 },
             new Pentamer
              {
                 FirstIndex=95,
                 LastIndex=99,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NRCIL",
                 },
             new Pentamer
              {
                 FirstIndex=96,
                 LastIndex=100,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RCILC",
                 },
             new Pentamer
              {
                 FirstIndex=97,
                 LastIndex=101,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CILCG",
                 },
             new Pentamer
              {
                 FirstIndex=98,
                 LastIndex=102,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ILCGE",
                 },
             new Pentamer
              {
                 FirstIndex=99,
                 LastIndex=103,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LCGEQ",
                 },
             new Pentamer
              {
                 FirstIndex=100,
                 LastIndex=104,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CGEQL",
                 },
             new Pentamer
              {
                 FirstIndex=101,
                 LastIndex=105,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GEQLG",
                 },
             new Pentamer
              {
                 FirstIndex=102,
                 LastIndex=106,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EQLGM",
                 },
             new Pentamer
              {
                 FirstIndex=103,
                 LastIndex=107,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QLGML",
                 },
             new Pentamer
              {
                 FirstIndex=104,
                 LastIndex=108,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LGMLG",
                 },
             new Pentamer
              {
                 FirstIndex=105,
                 LastIndex=109,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GMLGS",
                 },
             new Pentamer
              {
                 FirstIndex=106,
                 LastIndex=110,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MLGSA",
                 },
             new Pentamer
              {
                 FirstIndex=107,
                 LastIndex=111,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LGSAC",
                 },
             new Pentamer
              {
                 FirstIndex=108,
                 LastIndex=112,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GSACV",
                 },
             new Pentamer
              {
                 FirstIndex=109,
                 LastIndex=113,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SACVV",
                 },
             new Pentamer
              {
                 FirstIndex=110,
                 LastIndex=114,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ACVVC",
                 },
             new Pentamer
              {
                 FirstIndex=111,
                 LastIndex=115,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CVVCE",
                 },
             new Pentamer
              {
                 FirstIndex=112,
                 LastIndex=116,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VVCED",
                 },
             new Pentamer
              {
                 FirstIndex=113,
                 LastIndex=117,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VCEDC",
                 },
             new Pentamer
              {
                 FirstIndex=114,
                 LastIndex=118,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CEDCK",
                 },
             new Pentamer
              {
                 FirstIndex=115,
                 LastIndex=119,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EDCKK",
                 },
             new Pentamer
              {
                 FirstIndex=116,
                 LastIndex=120,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DCKKN",
                 },
             new Pentamer
              {
                 FirstIndex=117,
                 LastIndex=121,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CKKNV",
                 },
             new Pentamer
              {
                 FirstIndex=118,
                 LastIndex=122,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KKNVC",
                 },
             new Pentamer
              {
                 FirstIndex=119,
                 LastIndex=123,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KNVCT",
                 },
             new Pentamer
              {
                 FirstIndex=120,
                 LastIndex=124,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NVCTK",
                 },
             new Pentamer
              {
                 FirstIndex=121,
                 LastIndex=125,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VCTKC",
                 },
             new Pentamer
              {
                 FirstIndex=122,
                 LastIndex=126,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CTKCG",
                 },
             new Pentamer
              {
                 FirstIndex=123,
                 LastIndex=127,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TKCGV",
                 },
             new Pentamer
              {
                 FirstIndex=124,
                 LastIndex=128,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KCGVE",
                 },
             new Pentamer
              {
                 FirstIndex=125,
                 LastIndex=129,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CGVET",
                 },
             new Pentamer
              {
                 FirstIndex=126,
                 LastIndex=130,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GVETN",
                 },
             new Pentamer
              {
                 FirstIndex=127,
                 LastIndex=131,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VETNN",
                 },
             new Pentamer
              {
                 FirstIndex=128,
                 LastIndex=132,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ETNNR",
                 },
             new Pentamer
              {
                 FirstIndex=129,
                 LastIndex=133,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TNNRL",
                 },
             new Pentamer
              {
                 FirstIndex=130,
                 LastIndex=134,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NNRLH",
                 },
             new Pentamer
              {
                 FirstIndex=131,
                 LastIndex=135,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NRLHS",
                 },
             new Pentamer
              {
                 FirstIndex=132,
                 LastIndex=136,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RLHSV",
                 },
             new Pentamer
              {
                 FirstIndex=133,
                 LastIndex=137,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LHSVW",
                 },
             new Pentamer
              {
                 FirstIndex=134,
                 LastIndex=138,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HSVWL",
                 },
             new Pentamer
              {
                 FirstIndex=135,
                 LastIndex=139,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SVWLC",
                 },
             new Pentamer
              {
                 FirstIndex=136,
                 LastIndex=140,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VWLCK",
                 },
             new Pentamer
              {
                 FirstIndex=137,
                 LastIndex=141,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WLCKI",
                 },
             new Pentamer
              {
                 FirstIndex=138,
                 LastIndex=142,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LCKIC",
                 },
             new Pentamer
              {
                 FirstIndex=139,
                 LastIndex=143,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CKICI",
                 },
             new Pentamer
              {
                 FirstIndex=140,
                 LastIndex=144,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KICIE",
                 },
             new Pentamer
              {
                 FirstIndex=141,
                 LastIndex=145,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ICIEQ",
                 },
             new Pentamer
              {
                 FirstIndex=142,
                 LastIndex=146,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CIEQR",
                 },
             new Pentamer
              {
                 FirstIndex=143,
                 LastIndex=147,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IEQRE",
                 },
             new Pentamer
              {
                 FirstIndex=144,
                 LastIndex=148,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EQREV",
                 },
             new Pentamer
              {
                 FirstIndex=145,
                 LastIndex=149,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QREVW",
                 },
             new Pentamer
              {
                 FirstIndex=146,
                 LastIndex=150,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="REVWK",
                 },
             new Pentamer
              {
                 FirstIndex=147,
                 LastIndex=151,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EVWKR",
                 },
             new Pentamer
              {
                 FirstIndex=148,
                 LastIndex=152,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VWKRS",
                 },
             new Pentamer
              {
                 FirstIndex=149,
                 LastIndex=153,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WKRSG",
                 },
             new Pentamer
              {
                 FirstIndex=150,
                 LastIndex=154,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KRSGA",
                 },
             new Pentamer
              {
                 FirstIndex=151,
                 LastIndex=155,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RSGAW",
                 },
             new Pentamer
              {
                 FirstIndex=152,
                 LastIndex=156,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SGAWF",
                 },
             new Pentamer
              {
                 FirstIndex=153,
                 LastIndex=157,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GAWFF",
                 },
             new Pentamer
              {
                 FirstIndex=154,
                 LastIndex=158,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AWFFK",
                 },
             new Pentamer
              {
                 FirstIndex=155,
                 LastIndex=159,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WFFKG",
                 },
             new Pentamer
              {
                 FirstIndex=156,
                 LastIndex=160,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FFKGF",
                 },
             new Pentamer
              {
                 FirstIndex=157,
                 LastIndex=161,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FKGFP",
                 },
             new Pentamer
              {
                 FirstIndex=158,
                 LastIndex=162,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KGFPK",
                 },
             new Pentamer
              {
                 FirstIndex=159,
                 LastIndex=163,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GFPKQ",
                 },
             new Pentamer
              {
                 FirstIndex=160,
                 LastIndex=164,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FPKQV",
                 },
             new Pentamer
              {
                 FirstIndex=161,
                 LastIndex=165,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PKQVL",
                 },
             new Pentamer
              {
                 FirstIndex=162,
                 LastIndex=166,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KQVLP",
                 },
             new Pentamer
              {
                 FirstIndex=163,
                 LastIndex=167,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QVLPQ",
                 },
             new Pentamer
              {
                 FirstIndex=164,
                 LastIndex=168,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VLPQP",
                 },
             new Pentamer
              {
                 FirstIndex=165,
                 LastIndex=169,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LPQPM",
                 },
             new Pentamer
              {
                 FirstIndex=166,
                 LastIndex=170,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PQPMP",
                 },
             new Pentamer
              {
                 FirstIndex=167,
                 LastIndex=171,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QPMPI",
                 },
             new Pentamer
              {
                 FirstIndex=168,
                 LastIndex=172,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PMPIK",
                 },
             new Pentamer
              {
                 FirstIndex=169,
                 LastIndex=173,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MPIKK",
                 },
             new Pentamer
              {
                 FirstIndex=170,
                 LastIndex=174,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PIKKT",
                 },
             new Pentamer
              {
                 FirstIndex=171,
                 LastIndex=175,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IKKTK",
                 },
             new Pentamer
              {
                 FirstIndex=172,
                 LastIndex=176,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KKTKP",
                 },
             new Pentamer
              {
                 FirstIndex=173,
                 LastIndex=177,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KTKPQ",
                 },
             new Pentamer
              {
                 FirstIndex=174,
                 LastIndex=178,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TKPQQ",
                 },
             new Pentamer
              {
                 FirstIndex=175,
                 LastIndex=179,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KPQQP",
                 },
             new Pentamer
              {
                 FirstIndex=176,
                 LastIndex=180,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PQQPV",
                 },
             new Pentamer
              {
                 FirstIndex=177,
                 LastIndex=181,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QQPVS",
                 },
             new Pentamer
              {
                 FirstIndex=178,
                 LastIndex=182,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QPVSE",
                 },
             new Pentamer
              {
                 FirstIndex=179,
                 LastIndex=183,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PVSEP",
                 },
             new Pentamer
              {
                 FirstIndex=180,
                 LastIndex=184,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VSEPA",
                 },
             new Pentamer
              {
                 FirstIndex=181,
                 LastIndex=185,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SEPAA",
                 },
             new Pentamer
              {
                 FirstIndex=182,
                 LastIndex=186,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EPAAP",
                 },
             new Pentamer
              {
                 FirstIndex=183,
                 LastIndex=187,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PAAPE",
                 },
             new Pentamer
              {
                 FirstIndex=184,
                 LastIndex=188,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AAPEQ",
                 },
             new Pentamer
              {
                 FirstIndex=185,
                 LastIndex=189,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="APEQP",
                 },
             new Pentamer
              {
                 FirstIndex=186,
                 LastIndex=190,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PEQPA",
                 },
             new Pentamer
              {
                 FirstIndex=187,
                 LastIndex=191,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EQPAP",
                 },
             new Pentamer
              {
                 FirstIndex=188,
                 LastIndex=192,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QPAPE",
                 },
             new Pentamer
              {
                 FirstIndex=189,
                 LastIndex=193,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PAPEP",
                 },
             new Pentamer
              {
                 FirstIndex=190,
                 LastIndex=194,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="APEPK",
                 },
             new Pentamer
              {
                 FirstIndex=191,
                 LastIndex=195,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PEPKH",
                 },
             new Pentamer
              {
                 FirstIndex=192,
                 LastIndex=196,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EPKHP",
                 },
             new Pentamer
              {
                 FirstIndex=193,
                 LastIndex=197,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PKHPA",
                 },
             new Pentamer
              {
                 FirstIndex=194,
                 LastIndex=198,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KHPAR",
                 },
             new Pentamer
              {
                 FirstIndex=195,
                 LastIndex=199,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HPARA",
                 },
             new Pentamer
              {
                 FirstIndex=196,
                 LastIndex=200,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PARAP",
                 },
             new Pentamer
              {
                 FirstIndex=197,
                 LastIndex=201,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ARAPA",
                 },
             new Pentamer
              {
                 FirstIndex=198,
                 LastIndex=202,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RAPAR",
                 },
             new Pentamer
              {
                 FirstIndex=199,
                 LastIndex=203,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="APARG",
                 },
             new Pentamer
              {
                 FirstIndex=200,
                 LastIndex=204,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PARGD",
                 },
             new Pentamer
              {
                 FirstIndex=201,
                 LastIndex=205,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ARGDS",
                 },
             new Pentamer
              {
                 FirstIndex=202,
                 LastIndex=206,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RGDSE",
                 },
             new Pentamer
              {
                 FirstIndex=203,
                 LastIndex=207,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GDSED",
                 },
             new Pentamer
              {
                 FirstIndex=204,
                 LastIndex=208,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DSEDR",
                 },
             new Pentamer
              {
                 FirstIndex=205,
                 LastIndex=209,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SEDRR",
                 },
             new Pentamer
              {
                 FirstIndex=206,
                 LastIndex=210,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EDRRG",
                 },
             new Pentamer
              {
                 FirstIndex=207,
                 LastIndex=211,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DRRGP",
                 },
             new Pentamer
              {
                 FirstIndex=208,
                 LastIndex=212,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RRGPG",
                 },
             new Pentamer
              {
                 FirstIndex=209,
                 LastIndex=213,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RGPGQ",
                 },
             new Pentamer
              {
                 FirstIndex=210,
                 LastIndex=214,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GPGQK",
                 },
             new Pentamer
              {
                 FirstIndex=211,
                 LastIndex=215,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGQKT",
                 },
             new Pentamer
              {
                 FirstIndex=212,
                 LastIndex=216,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GQKTG",
                 },
             new Pentamer
              {
                 FirstIndex=213,
                 LastIndex=217,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QKTGP",
                 },
             new Pentamer
              {
                 FirstIndex=214,
                 LastIndex=218,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KTGPD",
                 },
             new Pentamer
              {
                 FirstIndex=215,
                 LastIndex=219,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TGPDP",
                 },
             new Pentamer
              {
                 FirstIndex=216,
                 LastIndex=220,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GPDPA",
                 },
             new Pentamer
              {
                 FirstIndex=217,
                 LastIndex=221,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PDPAS",
                 },
             new Pentamer
              {
                 FirstIndex=218,
                 LastIndex=222,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DPASA",
                 },
             new Pentamer
              {
                 FirstIndex=219,
                 LastIndex=223,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PASAP",
                 },
             new Pentamer
              {
                 FirstIndex=220,
                 LastIndex=224,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ASAPG",
                 },
             new Pentamer
              {
                 FirstIndex=221,
                 LastIndex=225,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SAPGR",
                 },
             new Pentamer
              {
                 FirstIndex=222,
                 LastIndex=226,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="APGRG",
                 },
             new Pentamer
              {
                 FirstIndex=223,
                 LastIndex=227,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGRGN",
                 },
             new Pentamer
              {
                 FirstIndex=224,
                 LastIndex=228,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GRGNY",
                 },
             new Pentamer
              {
                 FirstIndex=225,
                 LastIndex=229,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RGNYG",
                 },
             new Pentamer
              {
                 FirstIndex=226,
                 LastIndex=230,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GNYGP",
                 },
             new Pentamer
              {
                 FirstIndex=227,
                 LastIndex=231,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NYGPP",
                 },
             new Pentamer
              {
                 FirstIndex=228,
                 LastIndex=232,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YGPPV",
                 },
             new Pentamer
              {
                 FirstIndex=229,
                 LastIndex=233,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GPPVR",
                 },
             new Pentamer
              {
                 FirstIndex=230,
                 LastIndex=234,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PPVRR",
                 },
             new Pentamer
              {
                 FirstIndex=231,
                 LastIndex=235,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PVRRA",
                 },
             new Pentamer
              {
                 FirstIndex=232,
                 LastIndex=236,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VRRAS",
                 },
             new Pentamer
              {
                 FirstIndex=233,
                 LastIndex=237,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RRASE",
                 },
             new Pentamer
              {
                 FirstIndex=234,
                 LastIndex=238,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RASEA",
                 },
             new Pentamer
              {
                 FirstIndex=235,
                 LastIndex=239,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ASEAR",
                 },
             new Pentamer
              {
                 FirstIndex=236,
                 LastIndex=240,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SEARM",
                 },
             new Pentamer
              {
                 FirstIndex=237,
                 LastIndex=241,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EARMS",
                 },
             new Pentamer
              {
                 FirstIndex=238,
                 LastIndex=242,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ARMSS",
                 },
             new Pentamer
              {
                 FirstIndex=239,
                 LastIndex=243,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RMSSS",
                 },
             new Pentamer
              {
                 FirstIndex=240,
                 LastIndex=244,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MSSSS",
                 },
             new Pentamer
              {
                 FirstIndex=241,
                 LastIndex=245,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SSSSR",
                 },
             new Pentamer
              {
                 FirstIndex=242,
                 LastIndex=246,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SSSRD",
                 },
             new Pentamer
              {
                 FirstIndex=243,
                 LastIndex=247,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SSRDS",
                 },
             new Pentamer
              {
                 FirstIndex=244,
                 LastIndex=248,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SRDSE",
                 },
             new Pentamer
              {
                 FirstIndex=245,
                 LastIndex=249,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RDSES",
                 },
             new Pentamer
              {
                 FirstIndex=246,
                 LastIndex=250,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DSESW",
                 },
             new Pentamer
              {
                 FirstIndex=247,
                 LastIndex=251,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SESWD",
                 },
             new Pentamer
              {
                 FirstIndex=248,
                 LastIndex=252,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ESWDH",
                 },
             new Pentamer
              {
                 FirstIndex=249,
                 LastIndex=253,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SWDHS",
                 },
             new Pentamer
              {
                 FirstIndex=250,
                 LastIndex=254,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WDHSG",
                 },
             new Pentamer
              {
                 FirstIndex=251,
                 LastIndex=255,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DHSGG",
                 },
             new Pentamer
              {
                 FirstIndex=252,
                 LastIndex=256,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HSGGA",
                 },
             new Pentamer
              {
                 FirstIndex=253,
                 LastIndex=257,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SGGAG",
                 },
             new Pentamer
              {
                 FirstIndex=254,
                 LastIndex=258,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GGAGD",
                 },
             new Pentamer
              {
                 FirstIndex=255,
                 LastIndex=259,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GAGDS",
                 },
             new Pentamer
              {
                 FirstIndex=256,
                 LastIndex=260,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AGDSS",
                 },
             new Pentamer
              {
                 FirstIndex=257,
                 LastIndex=261,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GDSSR",
                 },
             new Pentamer
              {
                 FirstIndex=258,
                 LastIndex=262,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DSSRS",
                 },
             new Pentamer
              {
                 FirstIndex=259,
                 LastIndex=263,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SSRSP",
                 },
             new Pentamer
              {
                 FirstIndex=260,
                 LastIndex=264,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SRSPA",
                 },
             new Pentamer
              {
                 FirstIndex=261,
                 LastIndex=265,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RSPAG",
                 },
             new Pentamer
              {
                 FirstIndex=262,
                 LastIndex=266,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SPAGL",
                 },
             new Pentamer
              {
                 FirstIndex=263,
                 LastIndex=267,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PAGLR",
                 },
             new Pentamer
              {
                 FirstIndex=264,
                 LastIndex=268,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AGLRR",
                 },
             new Pentamer
              {
                 FirstIndex=265,
                 LastIndex=269,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GLRRA",
                 },
             new Pentamer
              {
                 FirstIndex=266,
                 LastIndex=270,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LRRAN",
                 },
             new Pentamer
              {
                 FirstIndex=267,
                 LastIndex=271,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RRANS",
                 },
             new Pentamer
              {
                 FirstIndex=268,
                 LastIndex=272,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RANSV",
                 },
             new Pentamer
              {
                 FirstIndex=269,
                 LastIndex=273,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ANSVQ",
                 },
             new Pentamer
              {
                 FirstIndex=270,
                 LastIndex=274,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NSVQA",
                 },
             new Pentamer
              {
                 FirstIndex=271,
                 LastIndex=275,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SVQAS",
                 },
             new Pentamer
              {
                 FirstIndex=272,
                 LastIndex=276,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VQASR",
                 },
             new Pentamer
              {
                 FirstIndex=273,
                 LastIndex=277,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QASRP",
                 },
             new Pentamer
              {
                 FirstIndex=274,
                 LastIndex=278,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ASRPA",
                 },
             new Pentamer
              {
                 FirstIndex=275,
                 LastIndex=279,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SRPAP",
                 },
             new Pentamer
              {
                 FirstIndex=276,
                 LastIndex=280,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RPAPG",
                 },
             new Pentamer
              {
                 FirstIndex=277,
                 LastIndex=281,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PAPGS",
                 },
             new Pentamer
              {
                 FirstIndex=278,
                 LastIndex=282,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="APGSV",
                 },
             new Pentamer
              {
                 FirstIndex=279,
                 LastIndex=283,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGSVQ",
                 },
             new Pentamer
              {
                 FirstIndex=280,
                 LastIndex=284,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GSVQS",
                 },
             new Pentamer
              {
                 FirstIndex=281,
                 LastIndex=285,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SVQSP",
                 },
             new Pentamer
              {
                 FirstIndex=282,
                 LastIndex=286,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VQSPA",
                 },
             new Pentamer
              {
                 FirstIndex=283,
                 LastIndex=287,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QSPAP",
                 },
             new Pentamer
              {
                 FirstIndex=284,
                 LastIndex=288,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SPAPP",
                 },
             new Pentamer
              {
                 FirstIndex=285,
                 LastIndex=289,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PAPPQ",
                 },
             new Pentamer
              {
                 FirstIndex=286,
                 LastIndex=290,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="APPQP",
                 },
             new Pentamer
              {
                 FirstIndex=287,
                 LastIndex=291,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PPQPG",
                 },
             new Pentamer
              {
                 FirstIndex=288,
                 LastIndex=292,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PQPGQ",
                 },
             new Pentamer
              {
                 FirstIndex=289,
                 LastIndex=293,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QPGQP",
                 },
             new Pentamer
              {
                 FirstIndex=290,
                 LastIndex=294,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGQPG",
                 },
             new Pentamer
              {
                 FirstIndex=291,
                 LastIndex=295,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GQPGT",
                 },
             new Pentamer
              {
                 FirstIndex=292,
                 LastIndex=296,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QPGTP",
                 },
             new Pentamer
              {
                 FirstIndex=293,
                 LastIndex=297,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGTPG",
                 },
             new Pentamer
              {
                 FirstIndex=294,
                 LastIndex=298,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GTPGG",
                 },
             new Pentamer
              {
                 FirstIndex=295,
                 LastIndex=299,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TPGGS",
                 },
             new Pentamer
              {
                 FirstIndex=296,
                 LastIndex=300,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGGSR",
                 },
             new Pentamer
              {
                 FirstIndex=297,
                 LastIndex=301,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GGSRP",
                 },
             new Pentamer
              {
                 FirstIndex=298,
                 LastIndex=302,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GSRPG",
                 },
             new Pentamer
              {
                 FirstIndex=299,
                 LastIndex=303,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SRPGP",
                 },
             new Pentamer
              {
                 FirstIndex=300,
                 LastIndex=304,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RPGPG",
                 },
             new Pentamer
              {
                 FirstIndex=301,
                 LastIndex=305,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGPGP",
                 },
             new Pentamer
              {
                 FirstIndex=302,
                 LastIndex=306,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GPGPA",
                 },
             new Pentamer
              {
                 FirstIndex=303,
                 LastIndex=307,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGPAG",
                 },
             new Pentamer
              {
                 FirstIndex=304,
                 LastIndex=308,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GPAGR",
                 },
             new Pentamer
              {
                 FirstIndex=305,
                 LastIndex=309,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PAGRF",
                 },
             new Pentamer
              {
                 FirstIndex=306,
                 LastIndex=310,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AGRFP",
                 },
             new Pentamer
              {
                 FirstIndex=307,
                 LastIndex=311,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GRFPD",
                 },
             new Pentamer
              {
                 FirstIndex=308,
                 LastIndex=312,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RFPDQ",
                 },
             new Pentamer
              {
                 FirstIndex=309,
                 LastIndex=313,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FPDQK",
                 },
             new Pentamer
              {
                 FirstIndex=310,
                 LastIndex=314,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PDQKP",
                 },
             new Pentamer
              {
                 FirstIndex=311,
                 LastIndex=315,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DQKPE",
                 },
             new Pentamer
              {
                 FirstIndex=312,
                 LastIndex=316,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QKPEV",
                 },
             new Pentamer
              {
                 FirstIndex=313,
                 LastIndex=317,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KPEVA",
                 },
             new Pentamer
              {
                 FirstIndex=314,
                 LastIndex=318,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PEVAP",
                 },
             new Pentamer
              {
                 FirstIndex=315,
                 LastIndex=319,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EVAPS",
                 },
             new Pentamer
              {
                 FirstIndex=316,
                 LastIndex=320,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VAPSD",
                 },
             new Pentamer
              {
                 FirstIndex=317,
                 LastIndex=321,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="APSDP",
                 },
             new Pentamer
              {
                 FirstIndex=318,
                 LastIndex=322,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PSDPG",
                 },
             new Pentamer
              {
                 FirstIndex=319,
                 LastIndex=323,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SDPGT",
                 },
             new Pentamer
              {
                 FirstIndex=320,
                 LastIndex=324,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DPGTT",
                 },
             new Pentamer
              {
                 FirstIndex=321,
                 LastIndex=325,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGTTA",
                 },
             new Pentamer
              {
                 FirstIndex=322,
                 LastIndex=326,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GTTAP",
                 },
             new Pentamer
              {
                 FirstIndex=323,
                 LastIndex=327,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TTAPP",
                 },
             new Pentamer
              {
                 FirstIndex=324,
                 LastIndex=328,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TAPPR",
                 },
             new Pentamer
              {
                 FirstIndex=325,
                 LastIndex=329,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="APPRE",
                 },
             new Pentamer
              {
                 FirstIndex=326,
                 LastIndex=330,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PPREE",
                 },
             new Pentamer
              {
                 FirstIndex=327,
                 LastIndex=331,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PREER",
                 },
             new Pentamer
              {
                 FirstIndex=328,
                 LastIndex=332,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="REERT",
                 },
             new Pentamer
              {
                 FirstIndex=329,
                 LastIndex=333,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EERTG",
                 },
             new Pentamer
              {
                 FirstIndex=330,
                 LastIndex=334,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ERTGG",
                 },
             new Pentamer
              {
                 FirstIndex=331,
                 LastIndex=335,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RTGGV",
                 },
             new Pentamer
              {
                 FirstIndex=332,
                 LastIndex=336,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TGGVG",
                 },
             new Pentamer
              {
                 FirstIndex=333,
                 LastIndex=337,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GGVGG",
                 },
             new Pentamer
              {
                 FirstIndex=334,
                 LastIndex=338,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GVGGY",
                 },
             new Pentamer
              {
                 FirstIndex=335,
                 LastIndex=339,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VGGYP",
                 },
             new Pentamer
              {
                 FirstIndex=336,
                 LastIndex=340,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GGYPA",
                 },
             new Pentamer
              {
                 FirstIndex=337,
                 LastIndex=341,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GYPAV",
                 },
             new Pentamer
              {
                 FirstIndex=338,
                 LastIndex=342,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YPAVG",
                 },
             new Pentamer
              {
                 FirstIndex=339,
                 LastIndex=343,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PAVGA",
                 },
             new Pentamer
              {
                 FirstIndex=340,
                 LastIndex=344,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AVGAR",
                 },
             new Pentamer
              {
                 FirstIndex=341,
                 LastIndex=345,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VGARE",
                 },
             new Pentamer
              {
                 FirstIndex=342,
                 LastIndex=346,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GARED",
                 },
             new Pentamer
              {
                 FirstIndex=343,
                 LastIndex=347,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AREDR",
                 },
             new Pentamer
              {
                 FirstIndex=344,
                 LastIndex=348,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="REDRM",
                 },
             new Pentamer
              {
                 FirstIndex=345,
                 LastIndex=349,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EDRMS",
                 },
             new Pentamer
              {
                 FirstIndex=346,
                 LastIndex=350,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DRMSH",
                 },
             new Pentamer
              {
                 FirstIndex=347,
                 LastIndex=351,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RMSHP",
                 },
             new Pentamer
              {
                 FirstIndex=348,
                 LastIndex=352,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MSHPS",
                 },
             new Pentamer
              {
                 FirstIndex=349,
                 LastIndex=353,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SHPSG",
                 },
             new Pentamer
              {
                 FirstIndex=350,
                 LastIndex=354,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HPSGP",
                 },
             new Pentamer
              {
                 FirstIndex=351,
                 LastIndex=355,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PSGPY",
                 },
             new Pentamer
              {
                 FirstIndex=352,
                 LastIndex=356,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SGPYS",
                 },
             new Pentamer
              {
                 FirstIndex=353,
                 LastIndex=357,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GPYSQ",
                 },
             new Pentamer
              {
                 FirstIndex=354,
                 LastIndex=358,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PYSQA",
                 },
             new Pentamer
              {
                 FirstIndex=355,
                 LastIndex=359,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YSQAS",
                 },
             new Pentamer
              {
                 FirstIndex=356,
                 LastIndex=360,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SQASA",
                 },
             new Pentamer
              {
                 FirstIndex=357,
                 LastIndex=361,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QASAA",
                 },
             new Pentamer
              {
                 FirstIndex=358,
                 LastIndex=362,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ASAAA",
                 },
             new Pentamer
              {
                 FirstIndex=359,
                 LastIndex=363,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SAAAP",
                 },
             new Pentamer
              {
                 FirstIndex=360,
                 LastIndex=364,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AAAPQ",
                 },
             new Pentamer
              {
                 FirstIndex=361,
                 LastIndex=365,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AAPQP",
                 },
             new Pentamer
              {
                 FirstIndex=362,
                 LastIndex=366,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="APQPA",
                 },
             new Pentamer
              {
                 FirstIndex=363,
                 LastIndex=367,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PQPAA",
                 },
             new Pentamer
              {
                 FirstIndex=364,
                 LastIndex=368,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QPAAA",
                 },
             new Pentamer
              {
                 FirstIndex=365,
                 LastIndex=369,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PAAAR",
                 },
             new Pentamer
              {
                 FirstIndex=366,
                 LastIndex=370,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AAARQ",
                 },
             new Pentamer
              {
                 FirstIndex=367,
                 LastIndex=371,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AARQP",
                 },
             new Pentamer
              {
                 FirstIndex=368,
                 LastIndex=372,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ARQPP",
                 },
             new Pentamer
              {
                 FirstIndex=369,
                 LastIndex=373,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RQPPP",
                 },
             new Pentamer
              {
                 FirstIndex=370,
                 LastIndex=374,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QPPPP",
                 },
             new Pentamer
              {
                 FirstIndex=371,
                 LastIndex=375,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PPPPE",
                 },
             new Pentamer
              {
                 FirstIndex=372,
                 LastIndex=376,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PPPEE",
                 },
             new Pentamer
              {
                 FirstIndex=373,
                 LastIndex=377,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PPEEE",
                 },
             new Pentamer
              {
                 FirstIndex=374,
                 LastIndex=378,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PEEEE",
                 },
             new Pentamer
              {
                 FirstIndex=375,
                 LastIndex=379,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEEEE",
                 },
             new Pentamer
              {
                 FirstIndex=376,
                 LastIndex=380,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEEEE",
                 },
             new Pentamer
              {
                 FirstIndex=377,
                 LastIndex=381,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEEEA",
                 },
             new Pentamer
              {
                 FirstIndex=378,
                 LastIndex=382,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEEAN",
                 },
             new Pentamer
              {
                 FirstIndex=379,
                 LastIndex=383,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEANS",
                 },
             new Pentamer
              {
                 FirstIndex=380,
                 LastIndex=384,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EANSY",
                 },
             new Pentamer
              {
                 FirstIndex=381,
                 LastIndex=385,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ANSYD",
                 },
             new Pentamer
              {
                 FirstIndex=382,
                 LastIndex=386,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NSYDS",
                 },
             new Pentamer
              {
                 FirstIndex=383,
                 LastIndex=387,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SYDSD",
                 },
             new Pentamer
              {
                 FirstIndex=384,
                 LastIndex=388,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YDSDE",
                 },
             new Pentamer
              {
                 FirstIndex=385,
                 LastIndex=389,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DSDEA",
                 },
             new Pentamer
              {
                 FirstIndex=386,
                 LastIndex=390,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SDEAT",
                 },
             new Pentamer
              {
                 FirstIndex=387,
                 LastIndex=391,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DEATT",
                 },
             new Pentamer
              {
                 FirstIndex=388,
                 LastIndex=392,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EATTL",
                 },
             new Pentamer
              {
                 FirstIndex=389,
                 LastIndex=393,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ATTLG",
                 },
             new Pentamer
              {
                 FirstIndex=390,
                 LastIndex=394,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TTLGA",
                 },
             new Pentamer
              {
                 FirstIndex=391,
                 LastIndex=395,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TLGAL",
                 },
             new Pentamer
              {
                 FirstIndex=392,
                 LastIndex=396,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LGALE",
                 },
             new Pentamer
              {
                 FirstIndex=393,
                 LastIndex=397,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GALEF",
                 },
             new Pentamer
              {
                 FirstIndex=394,
                 LastIndex=398,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ALEFS",
                 },
             new Pentamer
              {
                 FirstIndex=395,
                 LastIndex=399,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LEFSL",
                 },
             new Pentamer
              {
                 FirstIndex=396,
                 LastIndex=400,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EFSLL",
                 },
             new Pentamer
              {
                 FirstIndex=397,
                 LastIndex=401,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FSLLY",
                 },
             new Pentamer
              {
                 FirstIndex=398,
                 LastIndex=402,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SLLYD",
                 },
             new Pentamer
              {
                 FirstIndex=399,
                 LastIndex=403,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LLYDQ",
                 },
             new Pentamer
              {
                 FirstIndex=400,
                 LastIndex=404,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LYDQD",
                 },
             new Pentamer
              {
                 FirstIndex=401,
                 LastIndex=405,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YDQDN",
                 },
             new Pentamer
              {
                 FirstIndex=402,
                 LastIndex=406,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DQDNS",
                 },
             new Pentamer
              {
                 FirstIndex=403,
                 LastIndex=407,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QDNSS",
                 },
             new Pentamer
              {
                 FirstIndex=404,
                 LastIndex=408,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DNSSL",
                 },
             new Pentamer
              {
                 FirstIndex=405,
                 LastIndex=409,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NSSLQ",
                 },
             new Pentamer
              {
                 FirstIndex=406,
                 LastIndex=410,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SSLQC",
                 },
             new Pentamer
              {
                 FirstIndex=407,
                 LastIndex=411,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SLQCT",
                 },
             new Pentamer
              {
                 FirstIndex=408,
                 LastIndex=412,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LQCTI",
                 },
             new Pentamer
              {
                 FirstIndex=409,
                 LastIndex=413,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QCTII",
                 },
             new Pentamer
              {
                 FirstIndex=410,
                 LastIndex=414,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CTIIK",
                 },
             new Pentamer
              {
                 FirstIndex=411,
                 LastIndex=415,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TIIKA",
                 },
             new Pentamer
              {
                 FirstIndex=412,
                 LastIndex=416,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IIKAK",
                 },
             new Pentamer
              {
                 FirstIndex=413,
                 LastIndex=417,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IKAKG",
                 },
             new Pentamer
              {
                 FirstIndex=414,
                 LastIndex=418,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KAKGL",
                 },
             new Pentamer
              {
                 FirstIndex=415,
                 LastIndex=419,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AKGLK",
                 },
             new Pentamer
              {
                 FirstIndex=416,
                 LastIndex=420,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KGLKP",
                 },
             new Pentamer
              {
                 FirstIndex=417,
                 LastIndex=421,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GLKPM",
                 },
             new Pentamer
              {
                 FirstIndex=418,
                 LastIndex=422,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LKPMD",
                 },
             new Pentamer
              {
                 FirstIndex=419,
                 LastIndex=423,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KPMDS",
                 },
             new Pentamer
              {
                 FirstIndex=420,
                 LastIndex=424,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PMDSN",
                 },
             new Pentamer
              {
                 FirstIndex=421,
                 LastIndex=425,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MDSNG",
                 },
             new Pentamer
              {
                 FirstIndex=422,
                 LastIndex=426,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DSNGL",
                 },
             new Pentamer
              {
                 FirstIndex=423,
                 LastIndex=427,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SNGLA",
                 },
             new Pentamer
              {
                 FirstIndex=424,
                 LastIndex=428,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NGLAD",
                 },
             new Pentamer
              {
                 FirstIndex=425,
                 LastIndex=429,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GLADP",
                 },
             new Pentamer
              {
                 FirstIndex=426,
                 LastIndex=430,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LADPY",
                 },
             new Pentamer
              {
                 FirstIndex=427,
                 LastIndex=431,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ADPYV",
                 },
             new Pentamer
              {
                 FirstIndex=428,
                 LastIndex=432,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DPYVK",
                 },
             new Pentamer
              {
                 FirstIndex=429,
                 LastIndex=433,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PYVKL",
                 },
             new Pentamer
              {
                 FirstIndex=430,
                 LastIndex=434,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YVKLH",
                 },
             new Pentamer
              {
                 FirstIndex=431,
                 LastIndex=435,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VKLHL",
                 },
             new Pentamer
              {
                 FirstIndex=432,
                 LastIndex=436,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KLHLL",
                 },
             new Pentamer
              {
                 FirstIndex=433,
                 LastIndex=437,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LHLLP",
                 },
             new Pentamer
              {
                 FirstIndex=434,
                 LastIndex=438,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HLLPG",
                 },
             new Pentamer
              {
                 FirstIndex=435,
                 LastIndex=439,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LLPGA",
                 },
             new Pentamer
              {
                 FirstIndex=436,
                 LastIndex=440,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LPGAS",
                 },
             new Pentamer
              {
                 FirstIndex=437,
                 LastIndex=441,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PGASK",
                 },
             new Pentamer
              {
                 FirstIndex=438,
                 LastIndex=442,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GASKS",
                 },
             new Pentamer
              {
                 FirstIndex=439,
                 LastIndex=443,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ASKSN",
                 },
             new Pentamer
              {
                 FirstIndex=440,
                 LastIndex=444,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SKSNK",
                 },
             new Pentamer
              {
                 FirstIndex=441,
                 LastIndex=445,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KSNKL",
                 },
             new Pentamer
              {
                 FirstIndex=442,
                 LastIndex=446,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SNKLR",
                 },
             new Pentamer
              {
                 FirstIndex=443,
                 LastIndex=447,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NKLRT",
                 },
             new Pentamer
              {
                 FirstIndex=444,
                 LastIndex=448,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KLRTK",
                 },
             new Pentamer
              {
                 FirstIndex=445,
                 LastIndex=449,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LRTKT",
                 },
             new Pentamer
              {
                 FirstIndex=446,
                 LastIndex=450,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RTKTL",
                 },
             new Pentamer
              {
                 FirstIndex=447,
                 LastIndex=451,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TKTLR",
                 },
             new Pentamer
              {
                 FirstIndex=448,
                 LastIndex=452,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KTLRN",
                 },
             new Pentamer
              {
                 FirstIndex=449,
                 LastIndex=453,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TLRNT",
                 },
             new Pentamer
              {
                 FirstIndex=450,
                 LastIndex=454,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LRNTR",
                 },
             new Pentamer
              {
                 FirstIndex=451,
                 LastIndex=455,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RNTRN",
                 },
             new Pentamer
              {
                 FirstIndex=452,
                 LastIndex=456,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NTRNP",
                 },
             new Pentamer
              {
                 FirstIndex=453,
                 LastIndex=457,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TRNPI",
                 },
             new Pentamer
              {
                 FirstIndex=454,
                 LastIndex=458,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RNPIW",
                 },
             new Pentamer
              {
                 FirstIndex=455,
                 LastIndex=459,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NPIWN",
                 },
             new Pentamer
              {
                 FirstIndex=456,
                 LastIndex=460,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PIWNE",
                 },
             new Pentamer
              {
                 FirstIndex=457,
                 LastIndex=461,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IWNET",
                 },
             new Pentamer
              {
                 FirstIndex=458,
                 LastIndex=462,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WNETL",
                 },
             new Pentamer
              {
                 FirstIndex=459,
                 LastIndex=463,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NETLV",
                 },
             new Pentamer
              {
                 FirstIndex=460,
                 LastIndex=464,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ETLVY",
                 },
             new Pentamer
              {
                 FirstIndex=461,
                 LastIndex=465,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TLVYH",
                 },
             new Pentamer
              {
                 FirstIndex=462,
                 LastIndex=466,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LVYHG",
                 },
             new Pentamer
              {
                 FirstIndex=463,
                 LastIndex=467,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VYHGI",
                 },
             new Pentamer
              {
                 FirstIndex=464,
                 LastIndex=468,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YHGIT",
                 },
             new Pentamer
              {
                 FirstIndex=465,
                 LastIndex=469,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HGITD",
                 },
             new Pentamer
              {
                 FirstIndex=466,
                 LastIndex=470,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GITDE",
                 },
             new Pentamer
              {
                 FirstIndex=467,
                 LastIndex=471,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ITDED",
                 },
             new Pentamer
              {
                 FirstIndex=468,
                 LastIndex=472,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TDEDM",
                 },
             new Pentamer
              {
                 FirstIndex=469,
                 LastIndex=473,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DEDMQ",
                 },
             new Pentamer
              {
                 FirstIndex=470,
                 LastIndex=474,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EDMQR",
                 },
             new Pentamer
              {
                 FirstIndex=471,
                 LastIndex=475,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DMQRK",
                 },
             new Pentamer
              {
                 FirstIndex=472,
                 LastIndex=476,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MQRKT",
                 },
             new Pentamer
              {
                 FirstIndex=473,
                 LastIndex=477,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QRKTL",
                 },
             new Pentamer
              {
                 FirstIndex=474,
                 LastIndex=478,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RKTLR",
                 },
             new Pentamer
              {
                 FirstIndex=475,
                 LastIndex=479,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KTLRI",
                 },
             new Pentamer
              {
                 FirstIndex=476,
                 LastIndex=480,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TLRIS",
                 },
             new Pentamer
              {
                 FirstIndex=477,
                 LastIndex=481,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LRISV",
                 },
             new Pentamer
              {
                 FirstIndex=478,
                 LastIndex=482,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RISVC",
                 },
             new Pentamer
              {
                 FirstIndex=479,
                 LastIndex=483,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ISVCD",
                 },
             new Pentamer
              {
                 FirstIndex=480,
                 LastIndex=484,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SVCDE",
                 },
             new Pentamer
              {
                 FirstIndex=481,
                 LastIndex=485,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VCDED",
                 },
             new Pentamer
              {
                 FirstIndex=482,
                 LastIndex=486,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CDEDK",
                 },
             new Pentamer
              {
                 FirstIndex=483,
                 LastIndex=487,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DEDKF",
                 },
             new Pentamer
              {
                 FirstIndex=484,
                 LastIndex=488,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EDKFG",
                 },
             new Pentamer
              {
                 FirstIndex=485,
                 LastIndex=489,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DKFGH",
                 },
             new Pentamer
              {
                 FirstIndex=486,
                 LastIndex=490,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KFGHN",
                 },
             new Pentamer
              {
                 FirstIndex=487,
                 LastIndex=491,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FGHNE",
                 },
             new Pentamer
              {
                 FirstIndex=488,
                 LastIndex=492,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GHNEF",
                 },
             new Pentamer
              {
                 FirstIndex=489,
                 LastIndex=493,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HNEFI",
                 },
             new Pentamer
              {
                 FirstIndex=490,
                 LastIndex=494,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NEFIG",
                 },
             new Pentamer
              {
                 FirstIndex=491,
                 LastIndex=495,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EFIGE",
                 },
             new Pentamer
              {
                 FirstIndex=492,
                 LastIndex=496,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FIGET",
                 },
             new Pentamer
              {
                 FirstIndex=493,
                 LastIndex=497,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IGETR",
                 },
             new Pentamer
              {
                 FirstIndex=494,
                 LastIndex=498,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GETRF",
                 },
             new Pentamer
              {
                 FirstIndex=495,
                 LastIndex=499,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ETRFS",
                 },
             new Pentamer
              {
                 FirstIndex=496,
                 LastIndex=500,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TRFSL",
                 },
             new Pentamer
              {
                 FirstIndex=497,
                 LastIndex=501,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RFSLK",
                 },
             new Pentamer
              {
                 FirstIndex=498,
                 LastIndex=502,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FSLKK",
                 },
             new Pentamer
              {
                 FirstIndex=499,
                 LastIndex=503,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SLKKL",
                 },
             new Pentamer
              {
                 FirstIndex=500,
                 LastIndex=504,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LKKLK",
                 },
             new Pentamer
              {
                 FirstIndex=501,
                 LastIndex=505,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KKLKP",
                 },
             new Pentamer
              {
                 FirstIndex=502,
                 LastIndex=506,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KLKPN",
                 },
             new Pentamer
              {
                 FirstIndex=503,
                 LastIndex=507,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LKPNQ",
                 },
             new Pentamer
              {
                 FirstIndex=504,
                 LastIndex=508,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KPNQR",
                 },
             new Pentamer
              {
                 FirstIndex=505,
                 LastIndex=509,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PNQRK",
                 },
             new Pentamer
              {
                 FirstIndex=506,
                 LastIndex=510,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NQRKN",
                 },
             new Pentamer
              {
                 FirstIndex=507,
                 LastIndex=511,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QRKNF",
                 },
             new Pentamer
              {
                 FirstIndex=508,
                 LastIndex=512,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RKNFN",
                 },
             new Pentamer
              {
                 FirstIndex=509,
                 LastIndex=513,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KNFNI",
                 },
             new Pentamer
              {
                 FirstIndex=510,
                 LastIndex=514,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NFNIC",
                 },
             new Pentamer
              {
                 FirstIndex=511,
                 LastIndex=515,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FNICL",
                 },
             new Pentamer
              {
                 FirstIndex=512,
                 LastIndex=516,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NICLE",
                 },
             new Pentamer
              {
                 FirstIndex=513,
                 LastIndex=517,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ICLER",
                 },
             new Pentamer
              {
                 FirstIndex=514,
                 LastIndex=518,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CLERV",
                 },
             new Pentamer
              {
                 FirstIndex=515,
                 LastIndex=519,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LERVI",
                 },
             new Pentamer
              {
                 FirstIndex=516,
                 LastIndex=520,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ERVIP",
                 },
             new Pentamer
              {
                 FirstIndex=517,
                 LastIndex=521,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RVIPM",
                 },
             new Pentamer
              {
                 FirstIndex=518,
                 LastIndex=522,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VIPMK",
                 },
             new Pentamer
              {
                 FirstIndex=519,
                 LastIndex=523,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IPMKR",
                 },
             new Pentamer
              {
                 FirstIndex=520,
                 LastIndex=524,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PMKRA",
                 },
             new Pentamer
              {
                 FirstIndex=521,
                 LastIndex=525,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MKRAG",
                 },
             new Pentamer
              {
                 FirstIndex=522,
                 LastIndex=526,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KRAGT",
                 },
             new Pentamer
              {
                 FirstIndex=523,
                 LastIndex=527,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RAGTT",
                 },
             new Pentamer
              {
                 FirstIndex=524,
                 LastIndex=528,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AGTTG",
                 },
             new Pentamer
              {
                 FirstIndex=525,
                 LastIndex=529,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GTTGS",
                 },
             new Pentamer
              {
                 FirstIndex=526,
                 LastIndex=530,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TTGSA",
                 },
             new Pentamer
              {
                 FirstIndex=527,
                 LastIndex=531,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TGSAR",
                 },
             new Pentamer
              {
                 FirstIndex=528,
                 LastIndex=532,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GSARG",
                 },
             new Pentamer
              {
                 FirstIndex=529,
                 LastIndex=533,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SARGM",
                 },
             new Pentamer
              {
                 FirstIndex=530,
                 LastIndex=534,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ARGMA",
                 },
             new Pentamer
              {
                 FirstIndex=531,
                 LastIndex=535,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RGMAL",
                 },
             new Pentamer
              {
                 FirstIndex=532,
                 LastIndex=536,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GMALY",
                 },
             new Pentamer
              {
                 FirstIndex=533,
                 LastIndex=537,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MALYE",
                 },
             new Pentamer
              {
                 FirstIndex=534,
                 LastIndex=538,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ALYEE",
                 },
             new Pentamer
              {
                 FirstIndex=535,
                 LastIndex=539,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LYEEE",
                 },
             new Pentamer
              {
                 FirstIndex=536,
                 LastIndex=540,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YEEEQ",
                 },
             new Pentamer
              {
                 FirstIndex=537,
                 LastIndex=541,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEEQV",
                 },
             new Pentamer
              {
                 FirstIndex=538,
                 LastIndex=542,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEQVE",
                 },
             new Pentamer
              {
                 FirstIndex=539,
                 LastIndex=543,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EQVER",
                 },
             new Pentamer
              {
                 FirstIndex=540,
                 LastIndex=544,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QVERV",
                 },
             new Pentamer
              {
                 FirstIndex=541,
                 LastIndex=545,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VERVG",
                 },
             new Pentamer
              {
                 FirstIndex=542,
                 LastIndex=546,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ERVGD",
                 },
             new Pentamer
              {
                 FirstIndex=543,
                 LastIndex=547,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RVGDI",
                 },
             new Pentamer
              {
                 FirstIndex=544,
                 LastIndex=548,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VGDIE",
                 },
             new Pentamer
              {
                 FirstIndex=545,
                 LastIndex=549,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GDIEE",
                 },
             new Pentamer
              {
                 FirstIndex=546,
                 LastIndex=550,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DIEER",
                 },
             new Pentamer
              {
                 FirstIndex=547,
                 LastIndex=551,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IEERG",
                 },
             new Pentamer
              {
                 FirstIndex=548,
                 LastIndex=552,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EERGK",
                 },
             new Pentamer
              {
                 FirstIndex=549,
                 LastIndex=553,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ERGKI",
                 },
             new Pentamer
              {
                 FirstIndex=550,
                 LastIndex=554,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RGKIL",
                 },
             new Pentamer
              {
                 FirstIndex=551,
                 LastIndex=555,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GKILV",
                 },
             new Pentamer
              {
                 FirstIndex=552,
                 LastIndex=556,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KILVS",
                 },
             new Pentamer
              {
                 FirstIndex=553,
                 LastIndex=557,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ILVSL",
                 },
             new Pentamer
              {
                 FirstIndex=554,
                 LastIndex=558,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LVSLM",
                 },
             new Pentamer
              {
                 FirstIndex=555,
                 LastIndex=559,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VSLMY",
                 },
             new Pentamer
              {
                 FirstIndex=556,
                 LastIndex=560,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SLMYS",
                 },
             new Pentamer
              {
                 FirstIndex=557,
                 LastIndex=561,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LMYST",
                 },
             new Pentamer
              {
                 FirstIndex=558,
                 LastIndex=562,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MYSTQ",
                 },
             new Pentamer
              {
                 FirstIndex=559,
                 LastIndex=563,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YSTQQ",
                 },
             new Pentamer
              {
                 FirstIndex=560,
                 LastIndex=564,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="STQQG",
                 },
             new Pentamer
              {
                 FirstIndex=561,
                 LastIndex=565,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TQQGG",
                 },
             new Pentamer
              {
                 FirstIndex=562,
                 LastIndex=566,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QQGGL",
                 },
             new Pentamer
              {
                 FirstIndex=563,
                 LastIndex=567,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QGGLI",
                 },
             new Pentamer
              {
                 FirstIndex=564,
                 LastIndex=568,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GGLIV",
                 },
             new Pentamer
              {
                 FirstIndex=565,
                 LastIndex=569,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GLIVG",
                 },
             new Pentamer
              {
                 FirstIndex=566,
                 LastIndex=570,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LIVGI",
                 },
             new Pentamer
              {
                 FirstIndex=567,
                 LastIndex=571,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IVGII",
                 },
             new Pentamer
              {
                 FirstIndex=568,
                 LastIndex=572,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VGIIR",
                 },
             new Pentamer
              {
                 FirstIndex=569,
                 LastIndex=573,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GIIRC",
                 },
             new Pentamer
              {
                 FirstIndex=570,
                 LastIndex=574,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IIRCV",
                 },
             new Pentamer
              {
                 FirstIndex=571,
                 LastIndex=575,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IRCVH",
                 },
             new Pentamer
              {
                 FirstIndex=572,
                 LastIndex=576,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RCVHL",
                 },
             new Pentamer
              {
                 FirstIndex=573,
                 LastIndex=577,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CVHLA",
                 },
             new Pentamer
              {
                 FirstIndex=574,
                 LastIndex=578,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VHLAA",
                 },
             new Pentamer
              {
                 FirstIndex=575,
                 LastIndex=579,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HLAAM",
                 },
             new Pentamer
              {
                 FirstIndex=576,
                 LastIndex=580,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LAAMD",
                 },
             new Pentamer
              {
                 FirstIndex=577,
                 LastIndex=581,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AAMDA",
                 },
             new Pentamer
              {
                 FirstIndex=578,
                 LastIndex=582,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AMDAN",
                 },
             new Pentamer
              {
                 FirstIndex=579,
                 LastIndex=583,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MDANG",
                 },
             new Pentamer
              {
                 FirstIndex=580,
                 LastIndex=584,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DANGY",
                 },
             new Pentamer
              {
                 FirstIndex=581,
                 LastIndex=585,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ANGYS",
                 },
             new Pentamer
              {
                 FirstIndex=582,
                 LastIndex=586,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NGYSD",
                 },
             new Pentamer
              {
                 FirstIndex=583,
                 LastIndex=587,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GYSDP",
                 },
             new Pentamer
              {
                 FirstIndex=584,
                 LastIndex=588,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YSDPF",
                 },
             new Pentamer
              {
                 FirstIndex=585,
                 LastIndex=589,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SDPFV",
                 },
             new Pentamer
              {
                 FirstIndex=586,
                 LastIndex=590,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DPFVK",
                 },
             new Pentamer
              {
                 FirstIndex=587,
                 LastIndex=591,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PFVKL",
                 },
             new Pentamer
              {
                 FirstIndex=588,
                 LastIndex=592,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FVKLW",
                 },
             new Pentamer
              {
                 FirstIndex=589,
                 LastIndex=593,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VKLWL",
                 },
             new Pentamer
              {
                 FirstIndex=590,
                 LastIndex=594,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KLWLK",
                 },
             new Pentamer
              {
                 FirstIndex=591,
                 LastIndex=595,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LWLKP",
                 },
             new Pentamer
              {
                 FirstIndex=592,
                 LastIndex=596,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WLKPD",
                 },
             new Pentamer
              {
                 FirstIndex=593,
                 LastIndex=597,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LKPDM",
                 },
             new Pentamer
              {
                 FirstIndex=594,
                 LastIndex=598,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KPDMG",
                 },
             new Pentamer
              {
                 FirstIndex=595,
                 LastIndex=599,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PDMGK",
                 },
             new Pentamer
              {
                 FirstIndex=596,
                 LastIndex=600,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DMGKK",
                 },
             new Pentamer
              {
                 FirstIndex=597,
                 LastIndex=601,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="MGKKA",
                 },
             new Pentamer
              {
                 FirstIndex=598,
                 LastIndex=602,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GKKAK",
                 },
             new Pentamer
              {
                 FirstIndex=599,
                 LastIndex=603,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KKAKH",
                 },
             new Pentamer
              {
                 FirstIndex=600,
                 LastIndex=604,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KAKHK",
                 },
             new Pentamer
              {
                 FirstIndex=601,
                 LastIndex=605,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AKHKT",
                 },
             new Pentamer
              {
                 FirstIndex=602,
                 LastIndex=606,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KHKTQ",
                 },
             new Pentamer
              {
                 FirstIndex=603,
                 LastIndex=607,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HKTQI",
                 },
             new Pentamer
              {
                 FirstIndex=604,
                 LastIndex=608,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KTQIK",
                 },
             new Pentamer
              {
                 FirstIndex=605,
                 LastIndex=609,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TQIKK",
                 },
             new Pentamer
              {
                 FirstIndex=606,
                 LastIndex=610,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QIKKK",
                 },
             new Pentamer
              {
                 FirstIndex=607,
                 LastIndex=611,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IKKKT",
                 },
             new Pentamer
              {
                 FirstIndex=608,
                 LastIndex=612,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KKKTL",
                 },
             new Pentamer
              {
                 FirstIndex=609,
                 LastIndex=613,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KKTLN",
                 },
             new Pentamer
              {
                 FirstIndex=610,
                 LastIndex=614,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KTLNP",
                 },
             new Pentamer
              {
                 FirstIndex=611,
                 LastIndex=615,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="TLNPE",
                 },
             new Pentamer
              {
                 FirstIndex=612,
                 LastIndex=616,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LNPEF",
                 },
             new Pentamer
              {
                 FirstIndex=613,
                 LastIndex=617,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NPEFN",
                 },
             new Pentamer
              {
                 FirstIndex=614,
                 LastIndex=618,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="PEFNE",
                 },
             new Pentamer
              {
                 FirstIndex=615,
                 LastIndex=619,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EFNEE",
                 },
             new Pentamer
              {
                 FirstIndex=616,
                 LastIndex=620,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FNEEF",
                 },
             new Pentamer
              {
                 FirstIndex=617,
                 LastIndex=621,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NEEFF",
                 },
             new Pentamer
              {
                 FirstIndex=618,
                 LastIndex=622,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EEFFY",
                 },
             new Pentamer
              {
                 FirstIndex=619,
                 LastIndex=623,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="EFFYD",
                 },
             new Pentamer
              {
                 FirstIndex=620,
                 LastIndex=624,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FFYDI",
                 },
             new Pentamer
              {
                 FirstIndex=621,
                 LastIndex=625,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="FYDIK",
                 },
             new Pentamer
              {
                 FirstIndex=622,
                 LastIndex=626,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YDIKH",
                 },
             new Pentamer
              {
                 FirstIndex=623,
                 LastIndex=627,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DIKHS",
                 },
             new Pentamer
              {
                 FirstIndex=624,
                 LastIndex=628,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IKHSD",
                 },
             new Pentamer
              {
                 FirstIndex=625,
                 LastIndex=629,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KHSDL",
                 },
             new Pentamer
              {
                 FirstIndex=626,
                 LastIndex=630,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HSDLA",
                 },
             new Pentamer
              {
                 FirstIndex=627,
                 LastIndex=631,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SDLAK",
                 },
             new Pentamer
              {
                 FirstIndex=628,
                 LastIndex=632,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DLAKK",
                 },
             new Pentamer
              {
                 FirstIndex=629,
                 LastIndex=633,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LAKKS",
                 },
             new Pentamer
              {
                 FirstIndex=630,
                 LastIndex=634,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AKKSL",
                 },
             new Pentamer
              {
                 FirstIndex=631,
                 LastIndex=635,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KKSLD",
                 },
             new Pentamer
              {
                 FirstIndex=632,
                 LastIndex=636,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KSLDI",
                 },
             new Pentamer
              {
                 FirstIndex=633,
                 LastIndex=637,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SLDIS",
                 },
             new Pentamer
              {
                 FirstIndex=634,
                 LastIndex=638,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LDISV",
                 },
             new Pentamer
              {
                 FirstIndex=635,
                 LastIndex=639,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DISVW",
                 },
             new Pentamer
              {
                 FirstIndex=636,
                 LastIndex=640,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ISVWD",
                 },
             new Pentamer
              {
                 FirstIndex=637,
                 LastIndex=641,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SVWDY",
                 },
             new Pentamer
              {
                 FirstIndex=638,
                 LastIndex=642,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="VWDYD",
                 },
             new Pentamer
              {
                 FirstIndex=639,
                 LastIndex=643,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WDYDI",
                 },
             new Pentamer
              {
                 FirstIndex=640,
                 LastIndex=644,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DYDIG",
                 },
             new Pentamer
              {
                 FirstIndex=641,
                 LastIndex=645,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YDIGK",
                 },
             new Pentamer
              {
                 FirstIndex=642,
                 LastIndex=646,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DIGKS",
                 },
             new Pentamer
              {
                 FirstIndex=643,
                 LastIndex=647,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IGKSN",
                 },
             new Pentamer
              {
                 FirstIndex=644,
                 LastIndex=648,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GKSND",
                 },
             new Pentamer
              {
                 FirstIndex=645,
                 LastIndex=649,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KSNDY",
                 },
             new Pentamer
              {
                 FirstIndex=646,
                 LastIndex=650,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SNDYI",
                 },
             new Pentamer
              {
                 FirstIndex=647,
                 LastIndex=651,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NDYIG",
                 },
             new Pentamer
              {
                 FirstIndex=648,
                 LastIndex=652,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DYIGG",
                 },
             new Pentamer
              {
                 FirstIndex=649,
                 LastIndex=653,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YIGGC",
                 },
             new Pentamer
              {
                 FirstIndex=650,
                 LastIndex=654,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IGGCQ",
                 },
             new Pentamer
              {
                 FirstIndex=651,
                 LastIndex=655,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GGCQL",
                 },
             new Pentamer
              {
                 FirstIndex=652,
                 LastIndex=656,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GCQLG",
                 },
             new Pentamer
              {
                 FirstIndex=653,
                 LastIndex=657,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CQLGI",
                 },
             new Pentamer
              {
                 FirstIndex=654,
                 LastIndex=658,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QLGIS",
                 },
             new Pentamer
              {
                 FirstIndex=655,
                 LastIndex=659,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LGISA",
                 },
             new Pentamer
              {
                 FirstIndex=656,
                 LastIndex=660,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GISAK",
                 },
             new Pentamer
              {
                 FirstIndex=657,
                 LastIndex=661,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ISAKG",
                 },
             new Pentamer
              {
                 FirstIndex=658,
                 LastIndex=662,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="SAKGE",
                 },
             new Pentamer
              {
                 FirstIndex=659,
                 LastIndex=663,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="AKGER",
                 },
             new Pentamer
              {
                 FirstIndex=660,
                 LastIndex=664,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KGERL",
                 },
             new Pentamer
              {
                 FirstIndex=661,
                 LastIndex=665,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="GERLK",
                 },
             new Pentamer
              {
                 FirstIndex=662,
                 LastIndex=666,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ERLKH",
                 },
             new Pentamer
              {
                 FirstIndex=663,
                 LastIndex=667,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RLKHW",
                 },
             new Pentamer
              {
                 FirstIndex=664,
                 LastIndex=668,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LKHWY",
                 },
             new Pentamer
              {
                 FirstIndex=665,
                 LastIndex=669,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KHWYE",
                 },
             new Pentamer
              {
                 FirstIndex=666,
                 LastIndex=670,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HWYEC",
                 },
             new Pentamer
              {
                 FirstIndex=667,
                 LastIndex=671,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WYECL",
                 },
             new Pentamer
              {
                 FirstIndex=668,
                 LastIndex=672,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="YECLK",
                 },
             new Pentamer
              {
                 FirstIndex=669,
                 LastIndex=673,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ECLKN",
                 },
             new Pentamer
              {
                 FirstIndex=670,
                 LastIndex=674,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="CLKNK",
                 },
             new Pentamer
              {
                 FirstIndex=671,
                 LastIndex=675,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LKNKD",
                 },
             new Pentamer
              {
                 FirstIndex=672,
                 LastIndex=676,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KNKDK",
                 },
             new Pentamer
              {
                 FirstIndex=673,
                 LastIndex=677,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NKDKK",
                 },
             new Pentamer
              {
                 FirstIndex=674,
                 LastIndex=678,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KDKKI",
                 },
             new Pentamer
              {
                 FirstIndex=675,
                 LastIndex=679,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="DKKIE",
                 },
             new Pentamer
              {
                 FirstIndex=676,
                 LastIndex=680,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KKIER",
                 },
             new Pentamer
              {
                 FirstIndex=677,
                 LastIndex=681,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="KIERW",
                 },
             new Pentamer
              {
                 FirstIndex=678,
                 LastIndex=682,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="IERWH",
                 },
             new Pentamer
              {
                 FirstIndex=679,
                 LastIndex=683,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ERWHQ",
                 },
             new Pentamer
              {
                 FirstIndex=680,
                 LastIndex=684,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="RWHQL",
                 },
             new Pentamer
              {
                 FirstIndex=681,
                 LastIndex=685,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="WHQLQ",
                 },
             new Pentamer
              {
                 FirstIndex=682,
                 LastIndex=686,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HQLQN",
                 },
             new Pentamer
              {
                 FirstIndex=683,
                 LastIndex=687,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QLQNE",
                 },
             new Pentamer
              {
                 FirstIndex=684,
                 LastIndex=688,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="LQNEN",
                 },
             new Pentamer
              {
                 FirstIndex=685,
                 LastIndex=689,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="QNENH",
                 },
             new Pentamer
              {
                 FirstIndex=686,
                 LastIndex=690,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NENHV",
                 },
             new Pentamer
              {
                 FirstIndex=687,
                 LastIndex=691,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="ENHVS",
                 },
             new Pentamer
              {
                 FirstIndex=688,
                 LastIndex=692,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="NHVSS",
                 },
             new Pentamer
              {
                 FirstIndex=689,
                 LastIndex=693,
                 ProteinName =  "RP3A_HUMAN" , ProteinGI = "9Y2J0", 
                 Sequence ="HVSSD",
                 },

                //----------------------------------------
                new Pentamer
                {
                    FirstIndex = 0,
                    LastIndex = 4,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "MKGLY",
                },
                new Pentamer
                {
                    FirstIndex = 1,
                    LastIndex = 5,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KGLYF",
                },
                new Pentamer
                {
                    FirstIndex = 2,
                    LastIndex = 6,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GLYFQ",
                },
                new Pentamer
                {
                    FirstIndex = 3,
                    LastIndex = 7,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LYFQQ",
                },
                new Pentamer
                {
                    FirstIndex = 4,
                    LastIndex = 8,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "YFQQS",
                },
                new Pentamer
                {
                    FirstIndex = 5,
                    LastIndex = 9,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FQQSS",
                },
                new Pentamer
                {
                    FirstIndex = 6,
                    LastIndex = 10,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QQSST",
                },
                new Pentamer
                {
                    FirstIndex = 7,
                    LastIndex = 11,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QSSTD",
                },
                new Pentamer
                {
                    FirstIndex = 8,
                    LastIndex = 12,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SSTDE",
                },
                new Pentamer
                {
                    FirstIndex = 9,
                    LastIndex = 13,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "STDEE",
                },
                new Pentamer
                {
                    FirstIndex = 10,
                    LastIndex = 14,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TDEEI",
                },
                new Pentamer
                {
                    FirstIndex = 11,
                    LastIndex = 15,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DEEIT",
                },
                new Pentamer
                {
                    FirstIndex = 12,
                    LastIndex = 16,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EEITF",
                },
                new Pentamer
                {
                    FirstIndex = 13,
                    LastIndex = 17,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EITFV",
                },
                new Pentamer
                {
                    FirstIndex = 14,
                    LastIndex = 18,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ITFVF",
                },
                new Pentamer
                {
                    FirstIndex = 15,
                    LastIndex = 19,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TFVFQ",
                },
                new Pentamer
                {
                    FirstIndex = 16,
                    LastIndex = 20,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FVFQE",
                },
                new Pentamer
                {
                    FirstIndex = 17,
                    LastIndex = 21,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VFQEK",
                },
                new Pentamer
                {
                    FirstIndex = 18,
                    LastIndex = 22,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FQEKE",
                },
                new Pentamer
                {
                    FirstIndex = 19,
                    LastIndex = 23,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QEKED",
                },
                new Pentamer
                {
                    FirstIndex = 20,
                    LastIndex = 24,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EKEDL",
                },
                new Pentamer
                {
                    FirstIndex = 21,
                    LastIndex = 25,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KEDLP",
                },
                new Pentamer
                {
                    FirstIndex = 22,
                    LastIndex = 26,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EDLPV",
                },
                new Pentamer
                {
                    FirstIndex = 23,
                    LastIndex = 27,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DLPVT",
                },
                new Pentamer
                {
                    FirstIndex = 24,
                    LastIndex = 28,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LPVTE",
                },
                new Pentamer
                {
                    FirstIndex = 25,
                    LastIndex = 29,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PVTED",
                },
                new Pentamer
                {
                    FirstIndex = 26,
                    LastIndex = 30,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VTEDN",
                },
                new Pentamer
                {
                    FirstIndex = 27,
                    LastIndex = 31,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TEDNF",
                },
                new Pentamer
                {
                    FirstIndex = 28,
                    LastIndex = 32,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EDNFV",
                },
                new Pentamer
                {
                    FirstIndex = 29,
                    LastIndex = 33,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DNFVK",
                },
                new Pentamer
                {
                    FirstIndex = 30,
                    LastIndex = 34,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "NFVKL",
                },
                new Pentamer
                {
                    FirstIndex = 31,
                    LastIndex = 35,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FVKLQ",
                },
                new Pentamer
                {
                    FirstIndex = 32,
                    LastIndex = 36,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VKLQV",
                },
                new Pentamer
                {
                    FirstIndex = 33,
                    LastIndex = 37,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KLQVK",
                },
                new Pentamer
                {
                    FirstIndex = 34,
                    LastIndex = 38,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LQVKA",
                },
                new Pentamer
                {
                    FirstIndex = 35,
                    LastIndex = 39,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QVKAC",
                },
                new Pentamer
                {
                    FirstIndex = 36,
                    LastIndex = 40,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VKACA",
                },
                new Pentamer
                {
                    FirstIndex = 37,
                    LastIndex = 41,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KACAL",
                },
                new Pentamer
                {
                    FirstIndex = 38,
                    LastIndex = 42,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ACALS",
                },
                new Pentamer
                {
                    FirstIndex = 39,
                    LastIndex = 43,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "CALSQ",
                },
                new Pentamer
                {
                    FirstIndex = 40,
                    LastIndex = 44,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ALSQI",
                },
                new Pentamer
                {
                    FirstIndex = 41,
                    LastIndex = 45,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LSQIN",
                },
                new Pentamer
                {
                    FirstIndex = 42,
                    LastIndex = 46,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SQINT",
                },
                new Pentamer
                {
                    FirstIndex = 43,
                    LastIndex = 47,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QINTK",
                },
                new Pentamer
                {
                    FirstIndex = 44,
                    LastIndex = 48,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "INTKL",
                },
                new Pentamer
                {
                    FirstIndex = 45,
                    LastIndex = 49,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "NTKLL",
                },
                new Pentamer
                {
                    FirstIndex = 46,
                    LastIndex = 50,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TKLLA",
                },
                new Pentamer
                {
                    FirstIndex = 47,
                    LastIndex = 51,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KLLAE",
                },
                new Pentamer
                {
                    FirstIndex = 48,
                    LastIndex = 52,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LLAEM",
                },
                new Pentamer
                {
                    FirstIndex = 49,
                    LastIndex = 53,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LAEMK",
                },
                new Pentamer
                {
                    FirstIndex = 50,
                    LastIndex = 54,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AEMKM",
                },
                new Pentamer
                {
                    FirstIndex = 51,
                    LastIndex = 55,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EMKMK",
                },
                new Pentamer
                {
                    FirstIndex = 52,
                    LastIndex = 56,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "MKMKK",
                },
                new Pentamer
                {
                    FirstIndex = 53,
                    LastIndex = 57,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KMKKD",
                },
                new Pentamer
                {
                    FirstIndex = 54,
                    LastIndex = 58,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "MKKDL",
                },
                new Pentamer
                {
                    FirstIndex = 55,
                    LastIndex = 59,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KKDLF",
                },
                new Pentamer
                {
                    FirstIndex = 56,
                    LastIndex = 60,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KDLFP",
                },
                new Pentamer
                {
                    FirstIndex = 57,
                    LastIndex = 61,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DLFPV",
                },
                new Pentamer
                {
                    FirstIndex = 58,
                    LastIndex = 62,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LFPVG",
                },
                new Pentamer
                {
                    FirstIndex = 59,
                    LastIndex = 63,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FPVGR",
                },
                new Pentamer
                {
                    FirstIndex = 60,
                    LastIndex = 64,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PVGRE",
                },
                new Pentamer
                {
                    FirstIndex = 61,
                    LastIndex = 65,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VGREI",
                },
                new Pentamer
                {
                    FirstIndex = 62,
                    LastIndex = 66,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GREIA",
                },
                new Pentamer
                {
                    FirstIndex = 63,
                    LastIndex = 67,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "REIAG",
                },
                new Pentamer
                {
                    FirstIndex = 64,
                    LastIndex = 68,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EIAGI",
                },
                new Pentamer
                {
                    FirstIndex = 65,
                    LastIndex = 69,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IAGIV",
                },
                new Pentamer
                {
                    FirstIndex = 66,
                    LastIndex = 70,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AGIVL",
                },
                new Pentamer
                {
                    FirstIndex = 67,
                    LastIndex = 71,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GIVLD",
                },
                new Pentamer
                {
                    FirstIndex = 68,
                    LastIndex = 72,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IVLDV",
                },
                new Pentamer
                {
                    FirstIndex = 69,
                    LastIndex = 73,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VLDVG",
                },
                new Pentamer
                {
                    FirstIndex = 70,
                    LastIndex = 74,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LDVGS",
                },
                new Pentamer
                {
                    FirstIndex = 71,
                    LastIndex = 75,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DVGSK",
                },
                new Pentamer
                {
                    FirstIndex = 72,
                    LastIndex = 76,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VGSKV",
                },
                new Pentamer
                {
                    FirstIndex = 73,
                    LastIndex = 77,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GSKVS",
                },
                new Pentamer
                {
                    FirstIndex = 74,
                    LastIndex = 78,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SKVSF",
                },
                new Pentamer
                {
                    FirstIndex = 75,
                    LastIndex = 79,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KVSFF",
                },
                new Pentamer
                {
                    FirstIndex = 76,
                    LastIndex = 80,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VSFFQ",
                },
                new Pentamer
                {
                    FirstIndex = 77,
                    LastIndex = 81,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SFFQP",
                },
                new Pentamer
                {
                    FirstIndex = 78,
                    LastIndex = 82,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FFQPD",
                },
                new Pentamer
                {
                    FirstIndex = 79,
                    LastIndex = 83,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FQPDD",
                },
                new Pentamer
                {
                    FirstIndex = 80,
                    LastIndex = 84,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QPDDE",
                },
                new Pentamer
                {
                    FirstIndex = 81,
                    LastIndex = 85,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PDDEV",
                },
                new Pentamer
                {
                    FirstIndex = 82,
                    LastIndex = 86,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DDEVV",
                },
                new Pentamer
                {
                    FirstIndex = 83,
                    LastIndex = 87,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DEVVG",
                },
                new Pentamer
                {
                    FirstIndex = 84,
                    LastIndex = 88,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EVVGI",
                },
                new Pentamer
                {
                    FirstIndex = 85,
                    LastIndex = 89,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VVGIL",
                },
                new Pentamer
                {
                    FirstIndex = 86,
                    LastIndex = 90,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VGILP",
                },
                new Pentamer
                {
                    FirstIndex = 87,
                    LastIndex = 91,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GILPL",
                },
                new Pentamer
                {
                    FirstIndex = 88,
                    LastIndex = 92,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ILPLD",
                },
                new Pentamer
                {
                    FirstIndex = 89,
                    LastIndex = 93,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LPLDS",
                },
                new Pentamer
                {
                    FirstIndex = 90,
                    LastIndex = 94,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PLDSE",
                },
                new Pentamer
                {
                    FirstIndex = 91,
                    LastIndex = 95,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LDSED",
                },
                new Pentamer
                {
                    FirstIndex = 92,
                    LastIndex = 96,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DSEDP",
                },
                new Pentamer
                {
                    FirstIndex = 93,
                    LastIndex = 97,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SEDPG",
                },
                new Pentamer
                {
                    FirstIndex = 94,
                    LastIndex = 98,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EDPGL",
                },
                new Pentamer
                {
                    FirstIndex = 95,
                    LastIndex = 99,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DPGLC",
                },
                new Pentamer
                {
                    FirstIndex = 96,
                    LastIndex = 100,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PGLCE",
                },
                new Pentamer
                {
                    FirstIndex = 97,
                    LastIndex = 101,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GLCEV",
                },
                new Pentamer
                {
                    FirstIndex = 98,
                    LastIndex = 102,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LCEVV",
                },
                new Pentamer
                {
                    FirstIndex = 99,
                    LastIndex = 103,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "CEVVR",
                },
                new Pentamer
                {
                    FirstIndex = 100,
                    LastIndex = 104,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EVVRV",
                },
                new Pentamer
                {
                    FirstIndex = 101,
                    LastIndex = 105,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VVRVH",
                },
                new Pentamer
                {
                    FirstIndex = 102,
                    LastIndex = 106,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VRVHE",
                },
                new Pentamer
                {
                    FirstIndex = 103,
                    LastIndex = 107,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RVHEH",
                },
                new Pentamer
                {
                    FirstIndex = 104,
                    LastIndex = 108,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VHEHY",
                },
                new Pentamer
                {
                    FirstIndex = 105,
                    LastIndex = 109,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HEHYL",
                },
                new Pentamer
                {
                    FirstIndex = 106,
                    LastIndex = 110,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EHYLV",
                },
                new Pentamer
                {
                    FirstIndex = 107,
                    LastIndex = 111,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HYLVH",
                },
                new Pentamer
                {
                    FirstIndex = 108,
                    LastIndex = 112,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "YLVHK",
                },
                new Pentamer
                {
                    FirstIndex = 109,
                    LastIndex = 113,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LVHKP",
                },
                new Pentamer
                {
                    FirstIndex = 110,
                    LastIndex = 114,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VHKPE",
                },
                new Pentamer
                {
                    FirstIndex = 111,
                    LastIndex = 115,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HKPEK",
                },
                new Pentamer
                {
                    FirstIndex = 112,
                    LastIndex = 116,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KPEKV",
                },
                new Pentamer
                {
                    FirstIndex = 113,
                    LastIndex = 117,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PEKVT",
                },
                new Pentamer
                {
                    FirstIndex = 114,
                    LastIndex = 118,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EKVTW",
                },
                new Pentamer
                {
                    FirstIndex = 115,
                    LastIndex = 119,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KVTWT",
                },
                new Pentamer
                {
                    FirstIndex = 116,
                    LastIndex = 120,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VTWTE",
                },
                new Pentamer
                {
                    FirstIndex = 117,
                    LastIndex = 121,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TWTEA",
                },
                new Pentamer
                {
                    FirstIndex = 118,
                    LastIndex = 122,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "WTEAA",
                },
                new Pentamer
                {
                    FirstIndex = 119,
                    LastIndex = 123,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TEAAG",
                },
                new Pentamer
                {
                    FirstIndex = 120,
                    LastIndex = 124,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EAAGS",
                },
                new Pentamer
                {
                    FirstIndex = 121,
                    LastIndex = 125,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AAGSI",
                },
                new Pentamer
                {
                    FirstIndex = 122,
                    LastIndex = 126,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AGSIR",
                },
                new Pentamer
                {
                    FirstIndex = 123,
                    LastIndex = 127,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GSIRD",
                },
                new Pentamer
                {
                    FirstIndex = 124,
                    LastIndex = 128,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SIRDG",
                },
                new Pentamer
                {
                    FirstIndex = 125,
                    LastIndex = 129,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IRDGV",
                },
                new Pentamer
                {
                    FirstIndex = 126,
                    LastIndex = 130,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RDGVR",
                },
                new Pentamer
                {
                    FirstIndex = 127,
                    LastIndex = 131,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DGVRA",
                },
                new Pentamer
                {
                    FirstIndex = 128,
                    LastIndex = 132,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GVRAY",
                },
                new Pentamer
                {
                    FirstIndex = 129,
                    LastIndex = 133,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VRAYT",
                },
                new Pentamer
                {
                    FirstIndex = 130,
                    LastIndex = 134,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RAYTA",
                },
                new Pentamer
                {
                    FirstIndex = 131,
                    LastIndex = 135,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AYTAL",
                },
                new Pentamer
                {
                    FirstIndex = 132,
                    LastIndex = 136,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "YTALH",
                },
                new Pentamer
                {
                    FirstIndex = 133,
                    LastIndex = 137,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TALHY",
                },
                new Pentamer
                {
                    FirstIndex = 134,
                    LastIndex = 138,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ALHYL",
                },
                new Pentamer
                {
                    FirstIndex = 135,
                    LastIndex = 139,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LHYLS",
                },
                new Pentamer
                {
                    FirstIndex = 136,
                    LastIndex = 140,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HYLSH",
                },
                new Pentamer
                {
                    FirstIndex = 137,
                    LastIndex = 141,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "YLSHL",
                },
                new Pentamer
                {
                    FirstIndex = 138,
                    LastIndex = 142,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LSHLS",
                },
                new Pentamer
                {
                    FirstIndex = 139,
                    LastIndex = 143,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SHLSP",
                },
                new Pentamer
                {
                    FirstIndex = 140,
                    LastIndex = 144,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HLSPG",
                },
                new Pentamer
                {
                    FirstIndex = 141,
                    LastIndex = 145,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LSPGK",
                },
                new Pentamer
                {
                    FirstIndex = 142,
                    LastIndex = 146,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SPGKS",
                },
                new Pentamer
                {
                    FirstIndex = 143,
                    LastIndex = 147,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PGKSV",
                },
                new Pentamer
                {
                    FirstIndex = 144,
                    LastIndex = 148,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GKSVL",
                },
                new Pentamer
                {
                    FirstIndex = 145,
                    LastIndex = 149,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KSVLI",
                },
                new Pentamer
                {
                    FirstIndex = 146,
                    LastIndex = 150,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SVLIM",
                },
                new Pentamer
                {
                    FirstIndex = 147,
                    LastIndex = 151,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VLIMD",
                },
                new Pentamer
                {
                    FirstIndex = 148,
                    LastIndex = 152,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LIMDG",
                },
                new Pentamer
                {
                    FirstIndex = 149,
                    LastIndex = 153,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IMDGA",
                },
                new Pentamer
                {
                    FirstIndex = 150,
                    LastIndex = 154,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "MDGAS",
                },
                new Pentamer
                {
                    FirstIndex = 151,
                    LastIndex = 155,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DGASA",
                },
                new Pentamer
                {
                    FirstIndex = 152,
                    LastIndex = 156,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GASAF",
                },
                new Pentamer
                {
                    FirstIndex = 153,
                    LastIndex = 157,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ASAFG",
                },
                new Pentamer
                {
                    FirstIndex = 154,
                    LastIndex = 158,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SAFGT",
                },
                new Pentamer
                {
                    FirstIndex = 155,
                    LastIndex = 159,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AFGTI",
                },
                new Pentamer
                {
                    FirstIndex = 156,
                    LastIndex = 160,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FGTIA",
                },
                new Pentamer
                {
                    FirstIndex = 157,
                    LastIndex = 161,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GTIAI",
                },
                new Pentamer
                {
                    FirstIndex = 158,
                    LastIndex = 162,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TIAIQ",
                },
                new Pentamer
                {
                    FirstIndex = 159,
                    LastIndex = 163,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IAIQL",
                },
                new Pentamer
                {
                    FirstIndex = 160,
                    LastIndex = 164,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AIQLA",
                },
                new Pentamer
                {
                    FirstIndex = 161,
                    LastIndex = 165,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IQLAH",
                },
                new Pentamer
                {
                    FirstIndex = 162,
                    LastIndex = 166,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QLAHH",
                },
                new Pentamer
                {
                    FirstIndex = 163,
                    LastIndex = 167,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LAHHR",
                },
                new Pentamer
                {
                    FirstIndex = 164,
                    LastIndex = 168,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AHHRG",
                },
                new Pentamer
                {
                    FirstIndex = 165,
                    LastIndex = 169,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HHRGA",
                },
                new Pentamer
                {
                    FirstIndex = 166,
                    LastIndex = 170,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HRGAK",
                },
                new Pentamer
                {
                    FirstIndex = 167,
                    LastIndex = 171,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RGAKV",
                },
                new Pentamer
                {
                    FirstIndex = 168,
                    LastIndex = 172,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GAKVI",
                },
                new Pentamer
                {
                    FirstIndex = 169,
                    LastIndex = 173,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AKVIS",
                },
                new Pentamer
                {
                    FirstIndex = 170,
                    LastIndex = 174,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KVIST",
                },
                new Pentamer
                {
                    FirstIndex = 171,
                    LastIndex = 175,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VISTA",
                },
                new Pentamer
                {
                    FirstIndex = 172,
                    LastIndex = 176,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ISTAC",
                },
                new Pentamer
                {
                    FirstIndex = 173,
                    LastIndex = 177,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "STACS",
                },
                new Pentamer
                {
                    FirstIndex = 174,
                    LastIndex = 178,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TACSL",
                },
                new Pentamer
                {
                    FirstIndex = 175,
                    LastIndex = 179,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ACSLE",
                },
                new Pentamer
                {
                    FirstIndex = 176,
                    LastIndex = 180,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "CSLED",
                },
                new Pentamer
                {
                    FirstIndex = 177,
                    LastIndex = 181,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SLEDK",
                },
                new Pentamer
                {
                    FirstIndex = 178,
                    LastIndex = 182,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LEDKQ",
                },
                new Pentamer
                {
                    FirstIndex = 179,
                    LastIndex = 183,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EDKQC",
                },
                new Pentamer
                {
                    FirstIndex = 180,
                    LastIndex = 184,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DKQCL",
                },
                new Pentamer
                {
                    FirstIndex = 181,
                    LastIndex = 185,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KQCLE",
                },
                new Pentamer
                {
                    FirstIndex = 182,
                    LastIndex = 186,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QCLER",
                },
                new Pentamer
                {
                    FirstIndex = 183,
                    LastIndex = 187,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "CLERF",
                },
                new Pentamer
                {
                    FirstIndex = 184,
                    LastIndex = 188,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LERFR",
                },
                new Pentamer
                {
                    FirstIndex = 185,
                    LastIndex = 189,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ERFRP",
                },
                new Pentamer
                {
                    FirstIndex = 186,
                    LastIndex = 190,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RFRPP",
                },
                new Pentamer
                {
                    FirstIndex = 187,
                    LastIndex = 191,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FRPPI",
                },
                new Pentamer
                {
                    FirstIndex = 188,
                    LastIndex = 192,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RPPIA",
                },
                new Pentamer
                {
                    FirstIndex = 189,
                    LastIndex = 193,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PPIAR",
                },
                new Pentamer
                {
                    FirstIndex = 190,
                    LastIndex = 194,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PIARV",
                },
                new Pentamer
                {
                    FirstIndex = 191,
                    LastIndex = 195,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IARVI",
                },
                new Pentamer
                {
                    FirstIndex = 192,
                    LastIndex = 196,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ARVID",
                },
                new Pentamer
                {
                    FirstIndex = 193,
                    LastIndex = 197,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RVIDV",
                },
                new Pentamer
                {
                    FirstIndex = 194,
                    LastIndex = 198,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VIDVS",
                },
                new Pentamer
                {
                    FirstIndex = 195,
                    LastIndex = 199,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IDVSN",
                },
                new Pentamer
                {
                    FirstIndex = 196,
                    LastIndex = 200,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DVSNG",
                },
                new Pentamer
                {
                    FirstIndex = 197,
                    LastIndex = 201,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VSNGK",
                },
                new Pentamer
                {
                    FirstIndex = 198,
                    LastIndex = 202,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SNGKV",
                },
                new Pentamer
                {
                    FirstIndex = 199,
                    LastIndex = 203,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "NGKVH",
                },
                new Pentamer
                {
                    FirstIndex = 200,
                    LastIndex = 204,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GKVHV",
                },
                new Pentamer
                {
                    FirstIndex = 201,
                    LastIndex = 205,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KVHVA",
                },
                new Pentamer
                {
                    FirstIndex = 202,
                    LastIndex = 206,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VHVAE",
                },
                new Pentamer
                {
                    FirstIndex = 203,
                    LastIndex = 207,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HVAES",
                },
                new Pentamer
                {
                    FirstIndex = 204,
                    LastIndex = 208,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VAESC",
                },
                new Pentamer
                {
                    FirstIndex = 205,
                    LastIndex = 209,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AESCL",
                },
                new Pentamer
                {
                    FirstIndex = 206,
                    LastIndex = 210,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ESCLE",
                },
                new Pentamer
                {
                    FirstIndex = 207,
                    LastIndex = 211,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SCLEE",
                },
                new Pentamer
                {
                    FirstIndex = 208,
                    LastIndex = 212,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "CLEET",
                },
                new Pentamer
                {
                    FirstIndex = 209,
                    LastIndex = 213,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LEETG",
                },
                new Pentamer
                {
                    FirstIndex = 210,
                    LastIndex = 214,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EETGG",
                },
                new Pentamer
                {
                    FirstIndex = 211,
                    LastIndex = 215,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ETGGL",
                },
                new Pentamer
                {
                    FirstIndex = 212,
                    LastIndex = 216,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TGGLG",
                },
                new Pentamer
                {
                    FirstIndex = 213,
                    LastIndex = 217,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GGLGV",
                },
                new Pentamer
                {
                    FirstIndex = 214,
                    LastIndex = 218,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GLGVD",
                },
                new Pentamer
                {
                    FirstIndex = 215,
                    LastIndex = 219,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LGVDI",
                },
                new Pentamer
                {
                    FirstIndex = 216,
                    LastIndex = 220,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GVDIV",
                },
                new Pentamer
                {
                    FirstIndex = 217,
                    LastIndex = 221,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VDIVL",
                },
                new Pentamer
                {
                    FirstIndex = 218,
                    LastIndex = 222,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DIVLD",
                },
                new Pentamer
                {
                    FirstIndex = 219,
                    LastIndex = 223,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IVLDA",
                },
                new Pentamer
                {
                    FirstIndex = 220,
                    LastIndex = 224,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VLDAG",
                },
                new Pentamer
                {
                    FirstIndex = 221,
                    LastIndex = 225,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LDAGV",
                },
                new Pentamer
                {
                    FirstIndex = 222,
                    LastIndex = 226,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DAGVR",
                },
                new Pentamer
                {
                    FirstIndex = 223,
                    LastIndex = 227,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AGVRL",
                },
                new Pentamer
                {
                    FirstIndex = 224,
                    LastIndex = 228,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GVRLY",
                },
                new Pentamer
                {
                    FirstIndex = 225,
                    LastIndex = 229,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VRLYS",
                },
                new Pentamer
                {
                    FirstIndex = 226,
                    LastIndex = 230,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RLYSK",
                },
                new Pentamer
                {
                    FirstIndex = 227,
                    LastIndex = 231,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LYSKD",
                },
                new Pentamer
                {
                    FirstIndex = 228,
                    LastIndex = 232,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "YSKDD",
                },
                new Pentamer
                {
                    FirstIndex = 229,
                    LastIndex = 233,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SKDDE",
                },
                new Pentamer
                {
                    FirstIndex = 230,
                    LastIndex = 234,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KDDEP",
                },
                new Pentamer
                {
                    FirstIndex = 231,
                    LastIndex = 235,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DDEPA",
                },
                new Pentamer
                {
                    FirstIndex = 232,
                    LastIndex = 236,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DEPAV",
                },
                new Pentamer
                {
                    FirstIndex = 233,
                    LastIndex = 237,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EPAVK",
                },
                new Pentamer
                {
                    FirstIndex = 234,
                    LastIndex = 238,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PAVKL",
                },
                new Pentamer
                {
                    FirstIndex = 235,
                    LastIndex = 239,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AVKLQ",
                },
                new Pentamer
                {
                    FirstIndex = 236,
                    LastIndex = 240,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VKLQL",
                },
                new Pentamer
                {
                    FirstIndex = 237,
                    LastIndex = 241,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KLQLL",
                },
                new Pentamer
                {
                    FirstIndex = 238,
                    LastIndex = 242,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LQLLP",
                },
                new Pentamer
                {
                    FirstIndex = 239,
                    LastIndex = 243,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QLLPH",
                },
                new Pentamer
                {
                    FirstIndex = 240,
                    LastIndex = 244,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LLPHK",
                },
                new Pentamer
                {
                    FirstIndex = 241,
                    LastIndex = 245,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LPHKH",
                },
                new Pentamer
                {
                    FirstIndex = 242,
                    LastIndex = 246,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PHKHD",
                },
                new Pentamer
                {
                    FirstIndex = 243,
                    LastIndex = 247,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HKHDI",
                },
                new Pentamer
                {
                    FirstIndex = 244,
                    LastIndex = 248,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KHDII",
                },
                new Pentamer
                {
                    FirstIndex = 245,
                    LastIndex = 249,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HDIIT",
                },
                new Pentamer
                {
                    FirstIndex = 246,
                    LastIndex = 250,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DIITL",
                },
                new Pentamer
                {
                    FirstIndex = 247,
                    LastIndex = 251,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IITLL",
                },
                new Pentamer
                {
                    FirstIndex = 248,
                    LastIndex = 252,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ITLLG",
                },
                new Pentamer
                {
                    FirstIndex = 249,
                    LastIndex = 253,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TLLGV",
                },
                new Pentamer
                {
                    FirstIndex = 250,
                    LastIndex = 254,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LLGVG",
                },
                new Pentamer
                {
                    FirstIndex = 251,
                    LastIndex = 255,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LGVGG",
                },
                new Pentamer
                {
                    FirstIndex = 252,
                    LastIndex = 256,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GVGGH",
                },
                new Pentamer
                {
                    FirstIndex = 253,
                    LastIndex = 257,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VGGHW",
                },
                new Pentamer
                {
                    FirstIndex = 254,
                    LastIndex = 258,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GGHWV",
                },
                new Pentamer
                {
                    FirstIndex = 255,
                    LastIndex = 259,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GHWVT",
                },
                new Pentamer
                {
                    FirstIndex = 256,
                    LastIndex = 260,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HWVTT",
                },
                new Pentamer
                {
                    FirstIndex = 257,
                    LastIndex = 261,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "WVTTE",
                },
                new Pentamer
                {
                    FirstIndex = 258,
                    LastIndex = 262,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VTTEE",
                },
                new Pentamer
                {
                    FirstIndex = 259,
                    LastIndex = 263,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TTEEN",
                },
                new Pentamer
                {
                    FirstIndex = 260,
                    LastIndex = 264,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TEENL",
                },
                new Pentamer
                {
                    FirstIndex = 261,
                    LastIndex = 265,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EENLQ",
                },
                new Pentamer
                {
                    FirstIndex = 262,
                    LastIndex = 266,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ENLQL",
                },
                new Pentamer
                {
                    FirstIndex = 263,
                    LastIndex = 267,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "NLQLD",
                },
                new Pentamer
                {
                    FirstIndex = 264,
                    LastIndex = 268,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LQLDP",
                },
                new Pentamer
                {
                    FirstIndex = 265,
                    LastIndex = 269,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QLDPP",
                },
                new Pentamer
                {
                    FirstIndex = 266,
                    LastIndex = 270,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LDPPD",
                },
                new Pentamer
                {
                    FirstIndex = 267,
                    LastIndex = 271,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DPPDS",
                },
                new Pentamer
                {
                    FirstIndex = 268,
                    LastIndex = 272,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PPDSH",
                },
                new Pentamer
                {
                    FirstIndex = 269,
                    LastIndex = 273,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PDSHC",
                },
                new Pentamer
                {
                    FirstIndex = 270,
                    LastIndex = 274,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DSHCL",
                },
                new Pentamer
                {
                    FirstIndex = 271,
                    LastIndex = 275,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SHCLF",
                },
                new Pentamer
                {
                    FirstIndex = 272,
                    LastIndex = 276,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "HCLFL",
                },
                new Pentamer
                {
                    FirstIndex = 273,
                    LastIndex = 277,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "CLFLK",
                },
                new Pentamer
                {
                    FirstIndex = 274,
                    LastIndex = 278,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LFLKG",
                },
                new Pentamer
                {
                    FirstIndex = 275,
                    LastIndex = 279,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FLKGA",
                },
                new Pentamer
                {
                    FirstIndex = 276,
                    LastIndex = 280,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LKGAT",
                },
                new Pentamer
                {
                    FirstIndex = 277,
                    LastIndex = 281,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KGATL",
                },
                new Pentamer
                {
                    FirstIndex = 278,
                    LastIndex = 282,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GATLA",
                },
                new Pentamer
                {
                    FirstIndex = 279,
                    LastIndex = 283,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ATLAF",
                },
                new Pentamer
                {
                    FirstIndex = 280,
                    LastIndex = 284,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TLAFL",
                },
                new Pentamer
                {
                    FirstIndex = 281,
                    LastIndex = 285,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LAFLN",
                },
                new Pentamer
                {
                    FirstIndex = 282,
                    LastIndex = 286,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AFLND",
                },
                new Pentamer
                {
                    FirstIndex = 283,
                    LastIndex = 287,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FLNDE",
                },
                new Pentamer
                {
                    FirstIndex = 284,
                    LastIndex = 288,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LNDEV",
                },
                new Pentamer
                {
                    FirstIndex = 285,
                    LastIndex = 289,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "NDEVW",
                },
                new Pentamer
                {
                    FirstIndex = 286,
                    LastIndex = 290,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DEVWN",
                },
                new Pentamer
                {
                    FirstIndex = 287,
                    LastIndex = 291,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EVWNL",
                },
                new Pentamer
                {
                    FirstIndex = 288,
                    LastIndex = 292,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VWNLS",
                },
                new Pentamer
                {
                    FirstIndex = 289,
                    LastIndex = 293,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "WNLSN",
                },
                new Pentamer
                {
                    FirstIndex = 290,
                    LastIndex = 294,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "NLSNV",
                },
                new Pentamer
                {
                    FirstIndex = 291,
                    LastIndex = 295,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LSNVQ",
                },
                new Pentamer
                {
                    FirstIndex = 292,
                    LastIndex = 296,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SNVQQ",
                },
                new Pentamer
                {
                    FirstIndex = 293,
                    LastIndex = 297,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "NVQQG",
                },
                new Pentamer
                {
                    FirstIndex = 294,
                    LastIndex = 298,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VQQGK",
                },
                new Pentamer
                {
                    FirstIndex = 295,
                    LastIndex = 299,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QQGKY",
                },
                new Pentamer
                {
                    FirstIndex = 296,
                    LastIndex = 300,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QGKYL",
                },
                new Pentamer
                {
                    FirstIndex = 297,
                    LastIndex = 301,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GKYLC",
                },
                new Pentamer
                {
                    FirstIndex = 298,
                    LastIndex = 302,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KYLCI",
                },
                new Pentamer
                {
                    FirstIndex = 299,
                    LastIndex = 303,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "YLCIL",
                },
                new Pentamer
                {
                    FirstIndex = 300,
                    LastIndex = 304,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LCILK",
                },
                new Pentamer
                {
                    FirstIndex = 301,
                    LastIndex = 305,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "CILKD",
                },
                new Pentamer
                {
                    FirstIndex = 302,
                    LastIndex = 306,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "ILKDV",
                },
                new Pentamer
                {
                    FirstIndex = 303,
                    LastIndex = 307,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LKDVM",
                },
                new Pentamer
                {
                    FirstIndex = 304,
                    LastIndex = 308,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KDVME",
                },
                new Pentamer
                {
                    FirstIndex = 305,
                    LastIndex = 309,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DVMEK",
                },
                new Pentamer
                {
                    FirstIndex = 306,
                    LastIndex = 310,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VMEKL",
                },
                new Pentamer
                {
                    FirstIndex = 307,
                    LastIndex = 311,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "MEKLS",
                },
                new Pentamer
                {
                    FirstIndex = 308,
                    LastIndex = 312,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EKLST",
                },
                new Pentamer
                {
                    FirstIndex = 309,
                    LastIndex = 313,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KLSTG",
                },
                new Pentamer
                {
                    FirstIndex = 310,
                    LastIndex = 314,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LSTGV",
                },
                new Pentamer
                {
                    FirstIndex = 311,
                    LastIndex = 315,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "STGVF",
                },
                new Pentamer
                {
                    FirstIndex = 312,
                    LastIndex = 316,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "TGVFR",
                },
                new Pentamer
                {
                    FirstIndex = 313,
                    LastIndex = 317,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GVFRP",
                },
                new Pentamer
                {
                    FirstIndex = 314,
                    LastIndex = 318,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VFRPQ",
                },
                new Pentamer
                {
                    FirstIndex = 315,
                    LastIndex = 319,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "FRPQL",
                },
                new Pentamer
                {
                    FirstIndex = 316,
                    LastIndex = 320,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RPQLD",
                },
                new Pentamer
                {
                    FirstIndex = 317,
                    LastIndex = 321,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PQLDE",
                },
                new Pentamer
                {
                    FirstIndex = 318,
                    LastIndex = 322,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QLDEP",
                },
                new Pentamer
                {
                    FirstIndex = 319,
                    LastIndex = 323,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LDEPI",
                },
                new Pentamer
                {
                    FirstIndex = 320,
                    LastIndex = 324,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "DEPIP",
                },
                new Pentamer
                {
                    FirstIndex = 321,
                    LastIndex = 325,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EPIPL",
                },
                new Pentamer
                {
                    FirstIndex = 322,
                    LastIndex = 326,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PIPLY",
                },
                new Pentamer
                {
                    FirstIndex = 323,
                    LastIndex = 327,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "IPLYE",
                },
                new Pentamer
                {
                    FirstIndex = 324,
                    LastIndex = 328,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "PLYEA",
                },
                new Pentamer
                {
                    FirstIndex = 325,
                    LastIndex = 329,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "LYEAK",
                },
                new Pentamer
                {
                    FirstIndex = 326,
                    LastIndex = 330,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "YEAKV",
                },
                new Pentamer
                {
                    FirstIndex = 327,
                    LastIndex = 331,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EAKVS",
                },
                new Pentamer
                {
                    FirstIndex = 328,
                    LastIndex = 332,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AKVSM",
                },
                new Pentamer
                {
                    FirstIndex = 329,
                    LastIndex = 333,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KVSME",
                },
                new Pentamer
                {
                    FirstIndex = 330,
                    LastIndex = 334,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VSMEA",
                },
                new Pentamer
                {
                    FirstIndex = 331,
                    LastIndex = 335,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "SMEAV",
                },
                new Pentamer
                {
                    FirstIndex = 332,
                    LastIndex = 336,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "MEAVQ",
                },
                new Pentamer
                {
                    FirstIndex = 333,
                    LastIndex = 337,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "EAVQK",
                },
                new Pentamer
                {
                    FirstIndex = 334,
                    LastIndex = 338,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "AVQKN",
                },
                new Pentamer
                {
                    FirstIndex = 335,
                    LastIndex = 339,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "VQKNQ",
                },
                new Pentamer
                {
                    FirstIndex = 336,
                    LastIndex = 340,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QKNQG",
                },
                new Pentamer
                {
                    FirstIndex = 337,
                    LastIndex = 341,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KNQGR",
                },
                new Pentamer
                {
                    FirstIndex = 338,
                    LastIndex = 342,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "NQGRK",
                },
                new Pentamer
                {
                    FirstIndex = 339,
                    LastIndex = 343,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QGRKK",
                },
                new Pentamer
                {
                    FirstIndex = 340,
                    LastIndex = 344,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "GRKKQ",
                },
                new Pentamer
                {
                    FirstIndex = 341,
                    LastIndex = 345,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "RKKQV",
                },
                new Pentamer
                {
                    FirstIndex = 342,
                    LastIndex = 346,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KKQVV",
                },
                new Pentamer
                {
                    FirstIndex = 343,
                    LastIndex = 347,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "KQVVQ",
                },
                new Pentamer
                {
                    FirstIndex = 344,
                    LastIndex = 348,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = "95825",
                    Sequence = "QVVQF",
                },



            };

            ListOfVS = new List<VirtualSequence>
            {

                new VirtualSequence
                {
                     Sequence="MTDTV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TDTVF",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DTVFS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TVFSN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VFSNS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="FSNSS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SNSSN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NSSNR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SSNRW",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SNRWM",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NRWMY",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RWMYP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="WMYPS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="MYPSD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="YPSDR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PSDRP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SDRPL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DRPLQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RPLQS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PLQSN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LQSND",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QSNDK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SNDKE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NDKEQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DKEQL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KEQLQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EQLQA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QLQAG",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LQAGW",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QAGWS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="AGWSV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="GWSVH",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="WSVHP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SVHPG",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VHPGG",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="HPGGQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PGGQP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="GGQPD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="GQPDR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QPDRQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PDRQR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DRQRK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RQRKQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QRKQE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RKQEE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KQEEL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QEELT",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EELTD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ELTDE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LTDEE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TDEEK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DEEKE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EEKEI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EKEII",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KEIIN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EIINR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="IINRV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="INRVI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NRVIA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RVIAR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VIARA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="IARAE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ARAEK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RAEKM",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="AEKME",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EKMEE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KMEEM",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="MEEME",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EEMEQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EMEQE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="MEQER",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EQERI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QERIG",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ERIGR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RIGRL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="IGRLV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="GRLVD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RLVDR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LVDRL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VDRLE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DRLEN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RLENM",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LENMR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ENMRK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NMRKN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="MRKNV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RKNVA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KNVAG",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NVAGD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VAGDG",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="AGDGV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="GDGVN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DGVNR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="GVNRC",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VNRCI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NRCIL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RCILC",
                     Size=5,
                         },
            new VirtualSequence
            {
                 Sequence="CILCG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILCGE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LCGEQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CGEQL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GEQLG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EQLGM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QLGML",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LGMLG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GMLGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MLGSA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LGSAC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSACV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SACVV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ACVVC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CVVCE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VVCED",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VCEDC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CEDCK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EDCKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DCKKN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CKKNV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKNVC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KNVCT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NVCTK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VCTKC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CTKCG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TKCGV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KCGVE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CGVET",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GVETN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VETNN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ETNNR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TNNRL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NNRLH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NRLHS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RLHSV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LHSVW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HSVWL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SVWLC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VWLCK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WLCKI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LCKIC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CKICI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KICIE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ICIEQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CIEQR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IEQRE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EQREV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QREVW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="REVWK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EVWKR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VWKRS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WKRSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KRSGA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RSGAW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGAWF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GAWFF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AWFFK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WFFKG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FFKGF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FKGFP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KGFPK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GFPKQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FPKQV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PKQVL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KQVLP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QVLPQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VLPQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPQPM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PQPMP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPMPI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PMPIK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MPIKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PIKKT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IKKTK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKTKP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KTKPQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TKPQQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KPQQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PQQPV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QQPVS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPVSE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PVSEP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VSEPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SEPAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EPAAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAAPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AAPEQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APEQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEQPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EQPAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPAPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAPEP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APEPK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEPKH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EPKHP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PKHPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KHPAR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HPARA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PARAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ARAPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RAPAR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APARG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PARGD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ARGDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RGDSE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GDSED",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSEDR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SEDRR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EDRRG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DRRGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RRGPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RGPGQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPGQK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGQKT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GQKTG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QKTGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KTGPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TGPDP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPDPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDPAS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DPASA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PASAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ASAPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SAPGR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APGRG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGRGN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GRGNY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RGNYG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GNYGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NYGPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YGPPV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPPVR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPVRR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PVRRA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VRRAS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RRASE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RASEA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ASEAR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SEARM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EARMS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ARMSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RMSSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MSSSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSSSR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSSRD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSRDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SRDSE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RDSES",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSESW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SESWD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ESWDH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SWDHS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WDHSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DHSGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HSGGA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGGAG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGAGD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GAGDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AGDSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GDSSR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSSRS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSRSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SRSPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RSPAG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPAGL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAGLR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AGLRR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GLRRA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LRRAN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RRANS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RANSV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ANSVQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NSVQA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SVQAS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VQASR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QASRP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ASRPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SRPAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RPAPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAPGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APGSV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGSVQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSVQS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SVQSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VQSPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QSPAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPAPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAPPQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APPQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPQPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PQPGQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPGQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGQPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GQPGT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPGTP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGTPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GTPGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TPGGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGGSR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGSRP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSRPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SRPGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RPGPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGPGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPGPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGPAG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPAGR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAGRF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AGRFP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GRFPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RFPDQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FPDQK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDQKP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DQKPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QKPEV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KPEVA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEVAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EVAPS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VAPSD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APSDP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PSDPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SDPGT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DPGTT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGTTA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GTTAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TTAPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TAPPR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APPRE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPREE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PREER",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="REERT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EERTG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ERTGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RTGGV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TGGVG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGVGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GVGGY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VGGYP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGYPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GYPAV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YPAVG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAVGA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AVGAR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VGARE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GARED",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AREDR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="REDRM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EDRMS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DRMSH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RMSHP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MSHPS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SHPSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HPSGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PSGPY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGPYS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPYSQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PYSQA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YSQAS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SQASA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QASAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ASAAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SAAAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AAAPQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AAPQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APQPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PQPAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPAAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAAAR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AAARQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AARQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ARQPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RQPPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPPPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPPPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPPEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPEEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEEEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEEEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEEEA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEEAN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEANS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EANSY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ANSYD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NSYDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SYDSD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YDSDE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSDEA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SDEAT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DEATT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EATTL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ATTLG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TTLGA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLGAL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LGALE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GALEF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ALEFS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LEFSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EFSLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FSLLY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLLYD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLYDQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LYDQD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YDQDN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DQDNS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QDNSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DNSSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NSSLQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSLQC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLQCT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LQCTI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QCTII",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CTIIK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TIIKA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IIKAK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IKAKG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KAKGL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AKGLK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KGLKP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GLKPM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LKPMD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KPMDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PMDSN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MDSNG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSNGL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SNGLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NGLAD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GLADP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LADPY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ADPYV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DPYVK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PYVKL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YVKLH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VKLHL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KLHLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LHLLP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HLLPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLPGA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPGAS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGASK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GASKS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ASKSN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SKSNK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KSNKL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SNKLR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NKLRT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KLRTK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LRTKT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RTKTL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TKTLR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KTLRN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLRNT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LRNTR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RNTRN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NTRNP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TRNPI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RNPIW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NPIWN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PIWNE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IWNET",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WNETL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NETLV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ETLVY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLVYH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVYHG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VYHGI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YHGIT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HGITD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GITDE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ITDED",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TDEDM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DEDMQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EDMQR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DMQRK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MQRKT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QRKTL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RKTLR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KTLRI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLRIS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LRISV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RISVC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ISVCD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SVCDE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VCDED",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CDEDK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DEDKF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EDKFG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DKFGH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KFGHN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FGHNE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GHNEF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HNEFI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NEFIG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EFIGE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FIGET",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IGETR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GETRF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ETRFS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TRFSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RFSLK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FSLKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLKKL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LKKLK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKLKP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KLKPN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LKPNQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KPNQR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PNQRK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NQRKN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QRKNF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RKNFN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KNFNI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NFNIC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FNICL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NICLE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ICLER",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CLERV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LERVI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ERVIP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RVIPM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VIPMK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IPMKR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PMKRA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MKRAG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KRAGT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RAGTT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AGTTG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GTTGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TTGSA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TGSAR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSARG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SARGM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ARGMA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RGMAL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GMALY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MALYE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ALYEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LYEEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YEEEQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEEQV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEQVE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EQVER",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QVERV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VERVG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ERVGD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RVGDI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VGDIE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GDIEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DIEER",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IEERG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EERGK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ERGKI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RGKIL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GKILV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KILVS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILVSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVSLM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VSLMY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLMYS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LMYST",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MYSTQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YSTQQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="STQQG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TQQGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QQGGL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QGGLI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGLIV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GLIVG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LIVGI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IVGII",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VGIIR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GIIRC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IIRCV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IRCVH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RCVHL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CVHLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VHLAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HLAAM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LAAMD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AAMDA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AMDAN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MDANG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DANGY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ANGYS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NGYSD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GYSDP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YSDPF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SDPFV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DPFVK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PFVKL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FVKLW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VKLWL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KLWLK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LWLKP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WLKPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LKPDM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KPDMG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDMGK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DMGKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MGKKA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GKKAK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKAKH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KAKHK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AKHKT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KHKTQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HKTQI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KTQIK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TQIKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QIKKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IKKKT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKKTL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKTLN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KTLNP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLNPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LNPEF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NPEFN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEFNE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EFNEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FNEEF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NEEFF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEFFY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EFFYD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FFYDI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FYDIK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YDIKH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DIKHS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IKHSD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KHSDL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HSDLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SDLAK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DLAKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LAKKS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AKKSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKSLD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KSLDI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLDIS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LDISV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DISVW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ISVWD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SVWDY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VWDYD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WDYDI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DYDIG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YDIGK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DIGKS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IGKSN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GKSND",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KSNDY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SNDYI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NDYIG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DYIGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YIGGC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IGGCQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGCQL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GCQLG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CQLGI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QLGIS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LGISA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GISAK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ISAKG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SAKGE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AKGER",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KGERL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GERLK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ERLKH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RLKHW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LKHWY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KHWYE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HWYEC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WYECL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YECLK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ECLKN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CLKNK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LKNKD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KNKDK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NKDKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KDKKI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DKKIE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKIER",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KIERW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IERWH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ERWHQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RWHQL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WHQLQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HQLQN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QLQNE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LQNEN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QNENH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NENHV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ENHVS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NHVSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HVSSD",
                 Size=5,
                     },

                new VirtualSequence
                {
                     Sequence="MKGLY",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KGLYF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GLYFQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LYFQQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="YFQQS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FQQSS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QQSST",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QSSTD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SSTDE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="STDEE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TDEEI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DEEIT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EEITF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EITFV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ITFVF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TFVFQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FVFQE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VFQEK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FQEKE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QEKED",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EKEDL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KEDLP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EDLPV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DLPVT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LPVTE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PVTED",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VTEDN",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TEDNF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EDNFV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DNFVK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="NFVKL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FVKLQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VKLQV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KLQVK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LQVKA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QVKAC",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VKACA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KACAL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ACALS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="CALSQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ALSQI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LSQIN",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SQINT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QINTK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="INTKL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="NTKLL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TKLLA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KLLAE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LLAEM",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LAEMK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AEMKM",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EMKMK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="MKMKK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KMKKD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="MKKDL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KKDLF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KDLFP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DLFPV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LFPVG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FPVGR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PVGRE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VGREI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GREIA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="REIAG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EIAGI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IAGIV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AGIVL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GIVLD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IVLDV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VLDVG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LDVGS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DVGSK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VGSKV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GSKVS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SKVSF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KVSFF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VSFFQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SFFQP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FFQPD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FQPDD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QPDDE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PDDEV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DDEVV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DEVVG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EVVGI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VVGIL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VGILP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GILPL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ILPLD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LPLDS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PLDSE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LDSED",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DSEDP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SEDPG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EDPGL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DPGLC",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PGLCE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GLCEV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LCEVV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="CEVVR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EVVRV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VVRVH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VRVHE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RVHEH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VHEHY",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HEHYL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EHYLV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HYLVH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="YLVHK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LVHKP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VHKPE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HKPEK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KPEKV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PEKVT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EKVTW",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KVTWT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VTWTE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TWTEA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="WTEAA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TEAAG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EAAGS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AAGSI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AGSIR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GSIRD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SIRDG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IRDGV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RDGVR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DGVRA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GVRAY",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VRAYT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RAYTA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AYTAL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="YTALH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TALHY",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ALHYL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LHYLS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HYLSH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="YLSHL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LSHLS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SHLSP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HLSPG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LSPGK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SPGKS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PGKSV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GKSVL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KSVLI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SVLIM",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VLIMD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LIMDG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IMDGA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="MDGAS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DGASA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GASAF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ASAFG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SAFGT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AFGTI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FGTIA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GTIAI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TIAIQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IAIQL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AIQLA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IQLAH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QLAHH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LAHHR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AHHRG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HHRGA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HRGAK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RGAKV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GAKVI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AKVIS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KVIST",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VISTA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ISTAC",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="STACS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TACSL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ACSLE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="CSLED",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SLEDK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LEDKQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EDKQC",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DKQCL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KQCLE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QCLER",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="CLERF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LERFR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ERFRP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RFRPP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FRPPI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RPPIA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PPIAR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PIARV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IARVI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ARVID",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RVIDV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VIDVS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IDVSN",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DVSNG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VSNGK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SNGKV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="NGKVH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GKVHV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KVHVA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VHVAE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HVAES",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VAESC",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AESCL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ESCLE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SCLEE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="CLEET",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LEETG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EETGG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ETGGL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TGGLG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GGLGV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GLGVD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LGVDI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GVDIV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VDIVL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DIVLD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IVLDA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VLDAG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LDAGV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DAGVR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AGVRL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GVRLY",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VRLYS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RLYSK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LYSKD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="YSKDD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SKDDE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KDDEP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DDEPA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DEPAV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EPAVK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PAVKL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AVKLQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VKLQL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KLQLL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LQLLP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QLLPH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LLPHK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LPHKH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PHKHD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HKHDI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KHDII",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HDIIT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DIITL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IITLL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ITLLG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TLLGV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LLGVG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LGVGG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GVGGH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VGGHW",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GGHWV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GHWVT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HWVTT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="WVTTE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VTTEE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TTEEN",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TEENL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EENLQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ENLQL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="NLQLD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LQLDP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QLDPP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LDPPD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DPPDS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PPDSH",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PDSHC",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DSHCL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SHCLF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="HCLFL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="CLFLK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LFLKG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FLKGA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LKGAT",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KGATL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GATLA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ATLAF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TLAFL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LAFLN",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AFLND",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FLNDE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LNDEV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="NDEVW",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DEVWN",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EVWNL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VWNLS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="WNLSN",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="NLSNV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LSNVQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SNVQQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="NVQQG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VQQGK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QQGKY",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QGKYL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GKYLC",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KYLCI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="YLCIL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LCILK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="CILKD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="ILKDV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LKDVM",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KDVME",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DVMEK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VMEKL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="MEKLS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EKLST",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KLSTG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LSTGV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="STGVF",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="TGVFR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GVFRP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VFRPQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="FRPQL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RPQLD",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PQLDE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QLDEP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LDEPI",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="DEPIP",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EPIPL",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PIPLY",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="IPLYE",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="PLYEA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="LYEAK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="YEAKV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EAKVS",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AKVSM",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KVSME",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VSMEA",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="SMEAV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="MEAVQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="EAVQK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="AVQKN",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="VQKNQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QKNQG",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KNQGR",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="NQGRK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QGRKK",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="GRKKQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="RKKQV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KKQVV",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="KQVVQ",
                     Size=5,
                },
                new VirtualSequence
                {
                     Sequence="QVVQF",
                     Size=5,
                },
                //-------


                new VirtualSequence
                {
                     Sequence="MDTDS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DTDSQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TDSQR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DSQRS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SQRSH",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QRSHL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RSHLS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SHLSS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="HLSSF",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LSSFT",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SSFTM",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SFTMK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="FTMKL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TMKLM",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="MKLMD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KLMDK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LMDKF",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="MDKFH",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DKFHS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KFHSP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="FHSPK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="HSPKI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SPKIK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PKIKR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KIKRT",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="IKRTP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KRTPS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RTPSK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TPSKK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PSKKG",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SKKGK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KKGKP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KGKPA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="GKPAE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KPAEV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PAEVS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="AEVSV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EVSVK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VSVKI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SVKIP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VKIPE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KIPEK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="IPEKP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PEKPV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EKPVN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KPVNK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PVNKE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VNKEA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NKEAT",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KEATD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EATDR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ATDRF",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TDRFL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DRFLP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RFLPE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="FLPEG",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LPEGY",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PEGYP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EGYPL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="GYPLP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="YPLPL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PLPLD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LPLDL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PLDLE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LDLEQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DLEQQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LEQQA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EQQAV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QQAVE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QAVEF",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="AVEFM",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VEFMS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EFMST",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="FMSTS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="MSTSA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="STSAV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TSAVA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SAVAS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="AVASR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VASRS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ASRSQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SRSQR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RSQRQ",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SQRQK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QRQKN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RQKNL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="QKNLS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KNLSW",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NLSWL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LSWLE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SWLEE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="WLEEK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LEEKE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EEKEK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EKEKE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KEKEV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EKEVV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KEVVS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EVVSA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VVSAL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VSALR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SALRY",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ALRYF",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LRYFK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RYFKT",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="YFKTI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="FKTIV",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KTIVD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TIVDK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="IVDKM",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="VDKMA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DKMAI",
                     Size=5,
                         },
            new VirtualSequence
            {
                 Sequence="KMAID",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MAIDK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AIDKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IDKKV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DKKVL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKVLE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KVLEM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VLEML",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LEMLP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EMLPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MLPGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPGSA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGSAS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSASK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SASKV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ASKVL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SKVLE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KVLEA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VLEAI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LEAIL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EAILP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AILPL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILPLV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPLVQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PLVQN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVQND",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VQNDP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QNDPR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NDPRI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DPRIQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PRIQH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RIQHS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IQHSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QHSSA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HSSAL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSALS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SALSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ALSSC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSSCY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSCYS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SCYSR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CYSRV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YSRVY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SRVYQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RVYQS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VYQSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YQSLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QSLAN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLANL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LANLI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ANLIR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NLIRW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LIRWS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IRWSD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RWSDQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WSDQV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SDQVM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DQVML",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QVMLE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VMLEG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MLEGV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LEGVN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EGVNS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GVNSE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VNSED",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NSEDK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SEDKE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EDKEM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DKEMV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KEMVT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EMVTT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MVTTV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VTTVK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TTVKG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TVKGV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VKGVI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KGVIK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GVIKA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VIKAV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IKAVL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KAVLD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AVLDG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VLDGV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LDGVK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DGVKE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GVKEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VKELV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KELVR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELVRL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVRLT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VRLTI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RLTIE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LTIEK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TIEKQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IEKQG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EKQGR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KQGRP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QGRPS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GRPSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RPSPT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PSPTS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPTSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PTSPV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TSPVK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPVKP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PVKPS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VKPSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KPSSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PSSPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSPAS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPASK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PASKP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ASKPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SKPDG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KPDGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDGPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DGPAE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPAEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAELP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AELPL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELPLT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPLTD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PLTDR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LTDRE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TDREV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DREVE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="REVEI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EVEIL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VEILN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EILNK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILNKT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LNKTT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NKTTG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KTTGM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TTGMS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TGMSQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GMSQS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MSQST",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SQSTE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QSTEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="STELL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TELLP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELLPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLPDA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPDAT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDATD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DATDE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ATDEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TDEEV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DEEVA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEVAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EVAPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VAPPK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APPKP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPKPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PKPPL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KPPLP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPLPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PLPGI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPGIR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGIRV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GIRVV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IRVVD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RVVDN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VVDNS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VDNSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DNSPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NSPPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPPPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPPAL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPALP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PALPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ALPPK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPPKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPKKR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PKKRQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKRQS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KRQSA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RQSAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QSAPS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SAPSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APSPT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PSPTR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPTRV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PTRVA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TRVAV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RVAVV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VAVVA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AVVAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VVAPM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VAPMS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APMSR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PMSRA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MSRAT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SRATS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RATSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ATSGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TSGSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGSSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSSLP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSLPV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLPVG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPVGI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PVGIN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VGINR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GINRQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="INRQD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NRQDF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RQDFD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QDFDV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DFDVD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FDVDC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DVDCY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VDCYA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DCYAQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CYAQR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YAQRR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AQRRL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QRRLS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RRLSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RLSGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSGGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGGSH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGSHS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSHSY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SHSYG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HSYGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SYGGE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YGGES",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGESP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GESPR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ESPRL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPRLS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PRLSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RLSPC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSPCS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPCSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PCSSI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CSSIG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSIGK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SIGKL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IGKLS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GKLSK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KLSKS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSKSD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SKSDE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KSDEQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SDEQL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DEQLS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EQLSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QLSSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSSLD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSLDR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLDRD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LDRDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DRDSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RDSGQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSGQC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGQCS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GQCSR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QCSRN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CSRNT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SRNTS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RNTSC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NTSCE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TSCET",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SCETL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CETLD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ETLDH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLDHY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LDHYD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DHYDP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HYDPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YDPDY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DPDYE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDYEF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DYEFL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YEFLQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EFLQQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FLQQD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LQQDL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QQDLS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QDLSN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DLSNA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSNAD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SNADQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NADQI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ADQIP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DQIPQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QIPQQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IPQQT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PQQTA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QQTAW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QTAWN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TAWNL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AWNLS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WNLSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NLSPL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSPLP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPLPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PLPES",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPESL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PESLG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ESLGE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLGES",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LGESG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GESGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ESGSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGSPF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSPFL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPFLG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PFLGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FLGPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LGPPF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPPFQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPFQL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PFQLP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FQLPL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QLPLG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPLGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PLGGH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LGGHP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGHPQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GHPQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HPQPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PQPDG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPDGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDGPL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DGPLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPLAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PLAPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LAPGQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APGQQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGQQT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GQQTD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QQTDT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QTDTP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TDTPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DTPPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TPPAL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PALPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ALPEK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPEKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEKKR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EKKRR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKRRS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KRRSA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RRSAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RSAAS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SAASQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AASQT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ASQTA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SQTAD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QTADG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TADGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ADGSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DGSGC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSGCR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGCRV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GCRVS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CRVSY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RVSYE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VSYER",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SYERH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YERHP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ERHPS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RHPSQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HPSQY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PSQYD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SQYDN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QYDNI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YDNIS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DNISG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NISGE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ISGED",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGEDL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GEDLQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EDLQS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DLQST",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LQSTA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QSTAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="STAPI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TAPIP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APIPS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PIPSV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IPSVP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PSVPY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SVPYA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VPYAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PYAPF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YAPFA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APFAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PFAAI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FAAIL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AAILP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AILPF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILPFQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPFQH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PFQHG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FQHGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QHGGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HGGSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGSSA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSSAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSAPV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SAPVE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APVEF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PVEFV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VEFVG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EFVGD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FVGDF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VGDFT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GDFTA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DFTAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FTAPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TAPES",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APEST",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PESTG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ESTGD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="STGDP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TGDPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GDPEK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DPEKP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEKPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EKPPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KPPPL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPPLP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPLPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PLPEK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEKKN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EKKNK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKNKH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KNKHM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NKHML",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KHMLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HMLAY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MLAYM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LAYMQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AYMQL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YMQLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MQLLE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QLLED",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLEDY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LEDYS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EDYSE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DYSEP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YSEPQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SEPQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EPQPS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PQPSM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPSMF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PSMFY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SMFYQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MFYQT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FYQTP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YQTPQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QTPQN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TPQNE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PQNEH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QNEHI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NEHIY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EHIYQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HIYQQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IYQQK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YQQKN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QQKNK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QKNKL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KNKLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NKLLM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KLLME",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLMEV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LMEVY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MEVYG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EVYGF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VYGFS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YGFSD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GFSDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FSDSF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SDSFS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSFSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SFSGV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FSGVD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGVDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GVDSV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VDSVQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSVQE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SVQEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VQELA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QELAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELAPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LAPPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APPPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LPPKQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPKQR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PKQRQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KQRQL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QRQLE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RQLEP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QLEPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LEPPA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EPPAG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPAGK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PAGKD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AGKDG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GKDGH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KDGHP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DGHPR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GHPRD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HPRDP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PRDPS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RDPSA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DPSAV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PSAVS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SAVSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AVSGV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VSGVP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGVPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GVPGK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VPGKD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGKDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GKDSR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KDSRD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSRDG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SRDGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RDGSE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DGSER",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSERA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SERAP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ERAPK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RAPKS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="APKSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PKSPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KSPDA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPDAL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDALE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DALES",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ALESA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LESAQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ESAQS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SAQSE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AQSEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QSEEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SEEEV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEEVD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEVDE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EVDEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VDELS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DELSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELSLI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSLID",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLIDH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LIDHN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IDHNE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DHNEI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HNEIM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NEIMS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EIMSR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IMSRL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MSRLT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SRLTL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RLTLK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LTLKQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLKQE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LKQEG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KQEGD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QEGDD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EGDDG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GDDGP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DDGPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DGPDV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GPDVR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDVRG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DVRGG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VRGGS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RGGSG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GGSGD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GSGDI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SGDIL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GDILL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DILLV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILLVH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLVHA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVHAT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VHATE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HATET",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ATETD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TETDR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ETDRK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TDRKD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DRKDL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RKDLV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KDLVL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DLVLY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVLYC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VLYCE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LYCEA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YCEAF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CEAFL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EAFLT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AFLTT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FLTTY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LTTYR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TTYRT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TYRTF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YRTFI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RTFIS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TFISP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FISPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ISPEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPEEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEELI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EELIK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELIKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LIKKL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IKKLQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKLQY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KLQYR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LQYRY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QYRYE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YRYEK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RYEKF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YEKFS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EKFSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KFSPF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FSPFA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPFAD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PFADT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FADTF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ADTFK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DTFKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TFKKR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FKKRV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKRVS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KRVSK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RVSKN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VSKNT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SKNTF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KNTFF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NTFFV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TFFVL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FFVLV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FVLVR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VLVRV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVRVV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VRVVD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RVVDE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VVDEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VDELC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DELCL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELCLV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LCLVE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CLVEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVELT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VELTE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELTEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LTEEI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TEEIL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEILK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EILKL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILKLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LKLLM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLMEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LMELV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MELVF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELVFR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVFRL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VFRLV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FRLVC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RLVCN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LVCNG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VCNGE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CNGEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NGELS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GELSL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELSLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSLAR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SLARV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LARVL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ARVLR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RVLRK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VLRKN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LRKNI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RKNIL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KNILD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NILDK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILDKV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LDKVD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DKVDQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KVDQK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VDQKK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DQKKL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QKKLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KKLLR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KLLRC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLRCA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LRCAT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RCATS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CATSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ATSSQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TSSQP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSQPL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SQPLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QPLAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PLAAR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LAARG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AARGV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ARGVA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RGVAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GVAAR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VAARP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AARPG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ARPGT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RPGTL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PGTLH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GTLHD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLHDF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LHDFH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HDFHS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DFHSH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FHSHE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HSHEI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SHEIA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HEIAE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EIAEQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IAEQL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AEQLT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EQLTL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QLTLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LTLLD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLLDA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLDAE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LDAEL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DAELF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AELFY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ELFYK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LFYKI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FYKIE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YKIEI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KIEIP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IEIPE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EIPEV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IPEVL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PEVLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EVLLW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VLLWA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLWAK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LWAKE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WAKEQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AKEQN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KEQNE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EQNEE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QNEEK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NEEKS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EEKSP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EKSPN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KSPNL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SPNLT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PNLTQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NLTQF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LTQFT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TQFTE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QFTEH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FTEHF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TEHFN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EHFNN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HFNNM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FNNMS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NNMSY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NMSYW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MSYWV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SYWVR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YWVRS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WVRSI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VRSII",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RSIIM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SIIML",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IIMLQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IMLQE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MLQEK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LQEKA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QEKAQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EKAQD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KAQDR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AQDRE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QDRER",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DRERL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RERLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ERLLL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RLLLK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLLKF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LLKFI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LKFIK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KFIKI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FIKIM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IKIMK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KIMKH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IMKHL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MKHLR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KHLRK",
                 Size=5,
                     },
                new VirtualSequence
                {
                 Sequence="HLRKL",
                 Size=5,
                     },
                new VirtualSequence
                {
                     Sequence="LRKLN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RKLNN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KLNNF",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LNNFN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NNFNS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NFNSY",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="FNSYL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NSYLA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SYLAI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="YLAIL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LAILS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="AILSA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ILSAL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LSALD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SALDS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ALDSA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LDSAP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DSAPI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SAPIR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="APIRR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PIRRL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="IRRLE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RRLEW",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RLEWQ",
                     Size=5,
                         },
            new VirtualSequence
            {
                 Sequence="LEWQK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EWQKQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WQKQT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QKQTS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KQTSE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QTSEG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TSEGL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SEGLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EGLAE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GLAEY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LAEYC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AEYCT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EYCTL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YCTLI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CTLID",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TLIDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LIDSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IDSSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSSSS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSSSF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSSFR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SSFRA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SFRAY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FRAYR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RAYRA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AYRAA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YRAAL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RAALS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AALSE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ALSEV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LSEVE",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SEVEP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EVEPP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VEPPC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="EPPCI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PPCIP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PCIPY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CIPYL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IPYLG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PYLGL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YLGLI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LGLIL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GLILQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LILQD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILQDL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LQDLT",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QDLTF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DLTFV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LTFVH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="TFVHL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FVHLG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VHLGN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HLGNP",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LGNPD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GNPDY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NPDYI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="PDYID",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DYIDG",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YIDGK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IDGKV",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DGKVN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="GKVNF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KVNFS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="VNFSK",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NFSKR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FSKRW",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SKRWQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="KRWQQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RWQQF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="WQQFN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QQFNI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QFNIL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FNILD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NILDS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="ILDSM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="LDSMR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DSMRC",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SMRCF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MRCFQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RCFQQ",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="CFQQA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FQQAH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QQAHY",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="QAHYD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="AHYDM",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="HYDMR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="YDMRR",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DMRRN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="MRRND",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RRNDD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="RNDDI",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NDDII",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DDIIN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DIINF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="IINFF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="INFFN",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NFFND",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FFNDF",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FNDFS",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="NDFSD",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DFSDH",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="FSDHL",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="SDHLA",
                 Size=5,
                     },
            new VirtualSequence
            {
                 Sequence="DHLAE",
                 Size=5,
                     },
                new VirtualSequence
                {
                     Sequence="HLAEE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LAEEA",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="AEEAL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EEALW",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="EALWE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ALWEL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LWELS",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="WELSL",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ELSLK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LSLKI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="SLKIK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="LKIKP",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KIKPR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="IKPRN",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KPRNI",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="PRNIT",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RNITR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="NITRR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="ITRRK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TRRKT",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RRKTD",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="RKTDR",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="KTDRE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="TDREE",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="DREEK",
                     Size=5,
                         },
                new VirtualSequence
                {
                     Sequence="REEKT",
                     Size=5,
                },

            };

            ListOfProteins = new List<Protein>
            {
                 new Protein
                 {
                   ProteinName = "QORL1_HUMAN",
                   ProteinGI = "95825",
                   Sequence ="MKGLYFQQSSTDEEITFVFQEKEDLPVTEDNFVKLQVKACALSQINTKLLAEMKMKKDLFPVGREIAGIVLDVGSKVSFFQPDDEVVGILPLDSEDPGLCEVVRVHEHYLVHKPEKVTWTEAAGSIRDGVRAYTALHYLSHLSPGKSVLIMDGASAFGTIAIQLAHHRGAKVISTACSLEDKQCLERFRPPIARVIDVSNGKVHVAESCLEETGGLGVDIVLDAGVRLYSKDDEPAVKLQLLPHKHDIITLLGVGGHWVTTEENLQLDPPDSHCLFLKGATLAFLNDEVWNLSNVQQGKYLCILKDVMEKLSTGVFRPQLDEPIPLYEAKVSMEAVQKNQGRKKQVVQF"
                 },
                 new Protein
                 {
                   ProteinName = "RP3A_HUMAN",
                   ProteinGI = "9Y2J0",
                   Sequence ="MTDTVFSNSSNRWMYPSDRPLQSNDKEQLQAGWSVHPGGQPDRQRKQEELTDEEKEIINRVIARAEKMEEMEQERIGRLVDRLENMRKNVAGDGVNRCILCGEQLGMLGSACVVCEDCKKNVCTKCGVETNNRLHSVWLCKICIEQREVWKRSGAWFFKGFPKQVLPQPMPIKKTKPQQPVSEPAAPEQPAPEPKHPARAPARGDSEDRRGPGQKTGPDPASAPGRGNYGPPVRRASEARMSSSSRDSESWDHSGGAGDSSRSPAGLRRANSVQASRPAPGSVQSPAPPQPGQPGTPGGSRPGPGPAGRFPDQKPEVAPSDPGTTAPPREERTGGVGGYPAVGAREDRMSHPSGPYSQASAAAPQPAAARQPPPPEEEEEEANSYDSDEATTLGALEFSLLYDQDNSSLQCTIIKAKGLKPMDSNGLADPYVKLHLLPGASKSNKLRTKTLRNTRNPIWNETLVYHGITDEDMQRKTLRISVCDEDKFGHNEFIGETRFSLKKLKPNQRKNFNICLERVIPMKRAGTTGSARGMALYEEEQVERVGDIEERGKILVSLMYSTQQGGLIVGIIRCVHLAAMDANGYSDPFVKLWLKPDMGKKAKHKTQIKKKTLNPEFNEEFFYDIKHSDLAKKSLDISVWDYDIGKSNDYIGGCQLGISAKGERLKHWYECLKNKDKKIERWHQLQNENHVSSD"
                 },
             };
        }
    }
}