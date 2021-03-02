using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DO;
namespace DS
{
    public static class DataSource
    {



        public static List<Pentamer> ListOfPentamers;
        public static List<Protein> ListOfProteins;
        public static List<VirtualSequence> ListOfVS;



        static DataSource()
        {
            InitAllLists();
        }
        static void InitAllLists()
        {
            ListOfPentamers = new List<Pentamer>
            {
              new Pentamer
              {
                 FirstIndex=0,
                 LastIndex=4,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MTDTV",
                 },
             new Pentamer
              {
                 FirstIndex=1,
                 LastIndex=5,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TDTVF",
                 },
             new Pentamer
              {
                 FirstIndex=2,
                 LastIndex=6,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DTVFS",
                 },
             new Pentamer
              {
                 FirstIndex=3,
                 LastIndex=7,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TVFSN",
                 },
             new Pentamer
              {
                 FirstIndex=4,
                 LastIndex=8,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VFSNS",
                 },
             new Pentamer
              {
                 FirstIndex=5,
                 LastIndex=9,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FSNSS",
                 },
             new Pentamer
              {
                 FirstIndex=6,
                 LastIndex=10,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SNSSN",
                 },
             new Pentamer
              {
                 FirstIndex=7,
                 LastIndex=11,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NSSNR",
                 },
             new Pentamer
              {
                 FirstIndex=8,
                 LastIndex=12,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SSNRW",
                 },
             new Pentamer
              {
                 FirstIndex=9,
                 LastIndex=13,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SNRWM",
                 },
             new Pentamer
              {
                 FirstIndex=10,
                 LastIndex=14,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NRWMY",
                 },
             new Pentamer
              {
                 FirstIndex=11,
                 LastIndex=15,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RWMYP",
                 },
             new Pentamer
              {
                 FirstIndex=12,
                 LastIndex=16,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WMYPS",
                 },
             new Pentamer
              {
                 FirstIndex=13,
                 LastIndex=17,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MYPSD",
                 },
             new Pentamer
              {
                 FirstIndex=14,
                 LastIndex=18,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YPSDR",
                 },
             new Pentamer
              {
                 FirstIndex=15,
                 LastIndex=19,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PSDRP",
                 },
             new Pentamer
              {
                 FirstIndex=16,
                 LastIndex=20,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SDRPL",
                 },
             new Pentamer
              {
                 FirstIndex=17,
                 LastIndex=21,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DRPLQ",
                 },
             new Pentamer
              {
                 FirstIndex=18,
                 LastIndex=22,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RPLQS",
                 },
             new Pentamer
              {
                 FirstIndex=19,
                 LastIndex=23,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PLQSN",
                 },
             new Pentamer
              {
                 FirstIndex=20,
                 LastIndex=24,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LQSND",
                 },
             new Pentamer
              {
                 FirstIndex=21,
                 LastIndex=25,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QSNDK",
                 },
             new Pentamer
              {
                 FirstIndex=22,
                 LastIndex=26,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SNDKE",
                 },
             new Pentamer
              {
                 FirstIndex=23,
                 LastIndex=27,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NDKEQ",
                 },
             new Pentamer
              {
                 FirstIndex=24,
                 LastIndex=28,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DKEQL",
                 },
             new Pentamer
              {
                 FirstIndex=25,
                 LastIndex=29,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KEQLQ",
                 },
             new Pentamer
              {
                 FirstIndex=26,
                 LastIndex=30,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EQLQA",
                 },
             new Pentamer
              {
                 FirstIndex=27,
                 LastIndex=31,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QLQAG",
                 },
             new Pentamer
              {
                 FirstIndex=28,
                 LastIndex=32,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LQAGW",
                 },
             new Pentamer
              {
                 FirstIndex=29,
                 LastIndex=33,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QAGWS",
                 },
             new Pentamer
              {
                 FirstIndex=30,
                 LastIndex=34,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AGWSV",
                 },
             new Pentamer
              {
                 FirstIndex=31,
                 LastIndex=35,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GWSVH",
                 },
             new Pentamer
              {
                 FirstIndex=32,
                 LastIndex=36,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WSVHP",
                 },
             new Pentamer
              {
                 FirstIndex=33,
                 LastIndex=37,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SVHPG",
                 },
             new Pentamer
              {
                 FirstIndex=34,
                 LastIndex=38,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VHPGG",
                 },
             new Pentamer
              {
                 FirstIndex=35,
                 LastIndex=39,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HPGGQ",
                 },
             new Pentamer
              {
                 FirstIndex=36,
                 LastIndex=40,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGGQP",
                 },
             new Pentamer
              {
                 FirstIndex=37,
                 LastIndex=41,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GGQPD",
                 },
             new Pentamer
              {
                 FirstIndex=38,
                 LastIndex=42,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GQPDR",
                 },
             new Pentamer
              {
                 FirstIndex=39,
                 LastIndex=43,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QPDRQ",
                 },
             new Pentamer
              {
                 FirstIndex=40,
                 LastIndex=44,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PDRQR",
                 },
             new Pentamer
              {
                 FirstIndex=41,
                 LastIndex=45,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DRQRK",
                 },
             new Pentamer
              {
                 FirstIndex=42,
                 LastIndex=46,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RQRKQ",
                 },
             new Pentamer
              {
                 FirstIndex=43,
                 LastIndex=47,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QRKQE",
                 },
             new Pentamer
              {
                 FirstIndex=44,
                 LastIndex=48,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RKQEE",
                 },
             new Pentamer
              {
                 FirstIndex=45,
                 LastIndex=49,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KQEEL",
                 },
             new Pentamer
              {
                 FirstIndex=46,
                 LastIndex=50,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QEELT",
                 },
             new Pentamer
              {
                 FirstIndex=47,
                 LastIndex=51,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EELTD",
                 },
             new Pentamer
              {
                 FirstIndex=48,
                 LastIndex=52,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ELTDE",
                 },
             new Pentamer
              {
                 FirstIndex=49,
                 LastIndex=53,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LTDEE",
                 },
             new Pentamer
              {
                 FirstIndex=50,
                 LastIndex=54,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TDEEK",
                 },
             new Pentamer
              {
                 FirstIndex=51,
                 LastIndex=55,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DEEKE",
                 },
             new Pentamer
              {
                 FirstIndex=52,
                 LastIndex=56,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEKEI",
                 },
             new Pentamer
              {
                 FirstIndex=53,
                 LastIndex=57,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EKEII",
                 },
             new Pentamer
              {
                 FirstIndex=54,
                 LastIndex=58,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KEIIN",
                 },
             new Pentamer
              {
                 FirstIndex=55,
                 LastIndex=59,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EIINR",
                 },
             new Pentamer
              {
                 FirstIndex=56,
                 LastIndex=60,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IINRV",
                 },
             new Pentamer
              {
                 FirstIndex=57,
                 LastIndex=61,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="INRVI",
                 },
             new Pentamer
              {
                 FirstIndex=58,
                 LastIndex=62,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NRVIA",
                 },
             new Pentamer
              {
                 FirstIndex=59,
                 LastIndex=63,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RVIAR",
                 },
             new Pentamer
              {
                 FirstIndex=60,
                 LastIndex=64,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VIARA",
                 },
             new Pentamer
              {
                 FirstIndex=61,
                 LastIndex=65,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IARAE",
                 },
             new Pentamer
              {
                 FirstIndex=62,
                 LastIndex=66,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ARAEK",
                 },
             new Pentamer
              {
                 FirstIndex=63,
                 LastIndex=67,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RAEKM",
                 },
             new Pentamer
              {
                 FirstIndex=64,
                 LastIndex=68,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AEKME",
                 },
             new Pentamer
              {
                 FirstIndex=65,
                 LastIndex=69,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EKMEE",
                 },
             new Pentamer
              {
                 FirstIndex=66,
                 LastIndex=70,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KMEEM",
                 },
             new Pentamer
              {
                 FirstIndex=67,
                 LastIndex=71,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MEEME",
                 },
             new Pentamer
              {
                 FirstIndex=68,
                 LastIndex=72,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEMEQ",
                 },
             new Pentamer
              {
                 FirstIndex=69,
                 LastIndex=73,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EMEQE",
                 },
             new Pentamer
              {
                 FirstIndex=70,
                 LastIndex=74,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MEQER",
                 },
             new Pentamer
              {
                 FirstIndex=71,
                 LastIndex=75,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EQERI",
                 },
             new Pentamer
              {
                 FirstIndex=72,
                 LastIndex=76,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QERIG",
                 },
             new Pentamer
              {
                 FirstIndex=73,
                 LastIndex=77,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ERIGR",
                 },
             new Pentamer
              {
                 FirstIndex=74,
                 LastIndex=78,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RIGRL",
                 },
             new Pentamer
              {
                 FirstIndex=75,
                 LastIndex=79,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IGRLV",
                 },
             new Pentamer
              {
                 FirstIndex=76,
                 LastIndex=80,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GRLVD",
                 },
             new Pentamer
              {
                 FirstIndex=77,
                 LastIndex=81,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RLVDR",
                 },
             new Pentamer
              {
                 FirstIndex=78,
                 LastIndex=82,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LVDRL",
                 },
             new Pentamer
              {
                 FirstIndex=79,
                 LastIndex=83,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VDRLE",
                 },
             new Pentamer
              {
                 FirstIndex=80,
                 LastIndex=84,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DRLEN",
                 },
             new Pentamer
              {
                 FirstIndex=81,
                 LastIndex=85,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RLENM",
                 },
             new Pentamer
              {
                 FirstIndex=82,
                 LastIndex=86,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LENMR",
                 },
             new Pentamer
              {
                 FirstIndex=83,
                 LastIndex=87,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ENMRK",
                 },
             new Pentamer
              {
                 FirstIndex=84,
                 LastIndex=88,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NMRKN",
                 },
             new Pentamer
              {
                 FirstIndex=85,
                 LastIndex=89,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MRKNV",
                 },
             new Pentamer
              {
                 FirstIndex=86,
                 LastIndex=90,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RKNVA",
                 },
             new Pentamer
              {
                 FirstIndex=87,
                 LastIndex=91,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KNVAG",
                 },
             new Pentamer
              {
                 FirstIndex=88,
                 LastIndex=92,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NVAGD",
                 },
             new Pentamer
              {
                 FirstIndex=89,
                 LastIndex=93,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VAGDG",
                 },
             new Pentamer
              {
                 FirstIndex=90,
                 LastIndex=94,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AGDGV",
                 },
             new Pentamer
              {
                 FirstIndex=91,
                 LastIndex=95,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GDGVN",
                 },
             new Pentamer
              {
                 FirstIndex=92,
                 LastIndex=96,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DGVNR",
                 },
             new Pentamer
              {
                 FirstIndex=93,
                 LastIndex=97,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GVNRC",
                 },
             new Pentamer
              {
                 FirstIndex=94,
                 LastIndex=98,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VNRCI",
                 },
             new Pentamer
              {
                 FirstIndex=95,
                 LastIndex=99,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NRCIL",
                 },
             new Pentamer
              {
                 FirstIndex=96,
                 LastIndex=100,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RCILC",
                 },
             new Pentamer
              {
                 FirstIndex=97,
                 LastIndex=101,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CILCG",
                 },
             new Pentamer
              {
                 FirstIndex=98,
                 LastIndex=102,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ILCGE",
                 },
             new Pentamer
              {
                 FirstIndex=99,
                 LastIndex=103,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LCGEQ",
                 },
             new Pentamer
              {
                 FirstIndex=100,
                 LastIndex=104,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CGEQL",
                 },
             new Pentamer
              {
                 FirstIndex=101,
                 LastIndex=105,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GEQLG",
                 },
             new Pentamer
              {
                 FirstIndex=102,
                 LastIndex=106,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EQLGM",
                 },
             new Pentamer
              {
                 FirstIndex=103,
                 LastIndex=107,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QLGML",
                 },
             new Pentamer
              {
                 FirstIndex=104,
                 LastIndex=108,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LGMLG",
                 },
             new Pentamer
              {
                 FirstIndex=105,
                 LastIndex=109,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GMLGS",
                 },
             new Pentamer
              {
                 FirstIndex=106,
                 LastIndex=110,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MLGSA",
                 },
             new Pentamer
              {
                 FirstIndex=107,
                 LastIndex=111,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LGSAC",
                 },
             new Pentamer
              {
                 FirstIndex=108,
                 LastIndex=112,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GSACV",
                 },
             new Pentamer
              {
                 FirstIndex=109,
                 LastIndex=113,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SACVV",
                 },
             new Pentamer
              {
                 FirstIndex=110,
                 LastIndex=114,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ACVVC",
                 },
             new Pentamer
              {
                 FirstIndex=111,
                 LastIndex=115,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CVVCE",
                 },
             new Pentamer
              {
                 FirstIndex=112,
                 LastIndex=116,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VVCED",
                 },
             new Pentamer
              {
                 FirstIndex=113,
                 LastIndex=117,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VCEDC",
                 },
             new Pentamer
              {
                 FirstIndex=114,
                 LastIndex=118,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CEDCK",
                 },
             new Pentamer
              {
                 FirstIndex=115,
                 LastIndex=119,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EDCKK",
                 },
             new Pentamer
              {
                 FirstIndex=116,
                 LastIndex=120,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DCKKN",
                 },
             new Pentamer
              {
                 FirstIndex=117,
                 LastIndex=121,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CKKNV",
                 },
             new Pentamer
              {
                 FirstIndex=118,
                 LastIndex=122,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KKNVC",
                 },
             new Pentamer
              {
                 FirstIndex=119,
                 LastIndex=123,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KNVCT",
                 },
             new Pentamer
              {
                 FirstIndex=120,
                 LastIndex=124,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NVCTK",
                 },
             new Pentamer
              {
                 FirstIndex=121,
                 LastIndex=125,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VCTKC",
                 },
             new Pentamer
              {
                 FirstIndex=122,
                 LastIndex=126,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CTKCG",
                 },
             new Pentamer
              {
                 FirstIndex=123,
                 LastIndex=127,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TKCGV",
                 },
             new Pentamer
              {
                 FirstIndex=124,
                 LastIndex=128,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KCGVE",
                 },
             new Pentamer
              {
                 FirstIndex=125,
                 LastIndex=129,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CGVET",
                 },
             new Pentamer
              {
                 FirstIndex=126,
                 LastIndex=130,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GVETN",
                 },
             new Pentamer
              {
                 FirstIndex=127,
                 LastIndex=131,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VETNN",
                 },
             new Pentamer
              {
                 FirstIndex=128,
                 LastIndex=132,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ETNNR",
                 },
             new Pentamer
              {
                 FirstIndex=129,
                 LastIndex=133,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TNNRL",
                 },
             new Pentamer
              {
                 FirstIndex=130,
                 LastIndex=134,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NNRLH",
                 },
             new Pentamer
              {
                 FirstIndex=131,
                 LastIndex=135,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NRLHS",
                 },
             new Pentamer
              {
                 FirstIndex=132,
                 LastIndex=136,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RLHSV",
                 },
             new Pentamer
              {
                 FirstIndex=133,
                 LastIndex=137,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LHSVW",
                 },
             new Pentamer
              {
                 FirstIndex=134,
                 LastIndex=138,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HSVWL",
                 },
             new Pentamer
              {
                 FirstIndex=135,
                 LastIndex=139,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SVWLC",
                 },
             new Pentamer
              {
                 FirstIndex=136,
                 LastIndex=140,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VWLCK",
                 },
             new Pentamer
              {
                 FirstIndex=137,
                 LastIndex=141,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WLCKI",
                 },
             new Pentamer
              {
                 FirstIndex=138,
                 LastIndex=142,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LCKIC",
                 },
             new Pentamer
              {
                 FirstIndex=139,
                 LastIndex=143,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CKICI",
                 },
             new Pentamer
              {
                 FirstIndex=140,
                 LastIndex=144,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KICIE",
                 },
             new Pentamer
              {
                 FirstIndex=141,
                 LastIndex=145,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ICIEQ",
                 },
             new Pentamer
              {
                 FirstIndex=142,
                 LastIndex=146,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CIEQR",
                 },
             new Pentamer
              {
                 FirstIndex=143,
                 LastIndex=147,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IEQRE",
                 },
             new Pentamer
              {
                 FirstIndex=144,
                 LastIndex=148,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EQREV",
                 },
             new Pentamer
              {
                 FirstIndex=145,
                 LastIndex=149,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QREVW",
                 },
             new Pentamer
              {
                 FirstIndex=146,
                 LastIndex=150,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="REVWK",
                 },
             new Pentamer
              {
                 FirstIndex=147,
                 LastIndex=151,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EVWKR",
                 },
             new Pentamer
              {
                 FirstIndex=148,
                 LastIndex=152,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VWKRS",
                 },
             new Pentamer
              {
                 FirstIndex=149,
                 LastIndex=153,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WKRSG",
                 },
             new Pentamer
              {
                 FirstIndex=150,
                 LastIndex=154,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KRSGA",
                 },
             new Pentamer
              {
                 FirstIndex=151,
                 LastIndex=155,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RSGAW",
                 },
             new Pentamer
              {
                 FirstIndex=152,
                 LastIndex=156,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SGAWF",
                 },
             new Pentamer
              {
                 FirstIndex=153,
                 LastIndex=157,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GAWFF",
                 },
             new Pentamer
              {
                 FirstIndex=154,
                 LastIndex=158,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AWFFK",
                 },
             new Pentamer
              {
                 FirstIndex=155,
                 LastIndex=159,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WFFKG",
                 },
             new Pentamer
              {
                 FirstIndex=156,
                 LastIndex=160,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FFKGF",
                 },
             new Pentamer
              {
                 FirstIndex=157,
                 LastIndex=161,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FKGFP",
                 },
             new Pentamer
              {
                 FirstIndex=158,
                 LastIndex=162,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KGFPK",
                 },
             new Pentamer
              {
                 FirstIndex=159,
                 LastIndex=163,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GFPKQ",
                 },
             new Pentamer
              {
                 FirstIndex=160,
                 LastIndex=164,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FPKQV",
                 },
             new Pentamer
              {
                 FirstIndex=161,
                 LastIndex=165,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PKQVL",
                 },
             new Pentamer
              {
                 FirstIndex=162,
                 LastIndex=166,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KQVLP",
                 },
             new Pentamer
              {
                 FirstIndex=163,
                 LastIndex=167,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QVLPQ",
                 },
             new Pentamer
              {
                 FirstIndex=164,
                 LastIndex=168,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VLPQP",
                 },
             new Pentamer
              {
                 FirstIndex=165,
                 LastIndex=169,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LPQPM",
                 },
             new Pentamer
              {
                 FirstIndex=166,
                 LastIndex=170,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PQPMP",
                 },
             new Pentamer
              {
                 FirstIndex=167,
                 LastIndex=171,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QPMPI",
                 },
             new Pentamer
              {
                 FirstIndex=168,
                 LastIndex=172,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PMPIK",
                 },
             new Pentamer
              {
                 FirstIndex=169,
                 LastIndex=173,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MPIKK",
                 },
             new Pentamer
              {
                 FirstIndex=170,
                 LastIndex=174,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PIKKT",
                 },
             new Pentamer
              {
                 FirstIndex=171,
                 LastIndex=175,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IKKTK",
                 },
             new Pentamer
              {
                 FirstIndex=172,
                 LastIndex=176,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KKTKP",
                 },
             new Pentamer
              {
                 FirstIndex=173,
                 LastIndex=177,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KTKPQ",
                 },
             new Pentamer
              {
                 FirstIndex=174,
                 LastIndex=178,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TKPQQ",
                 },
             new Pentamer
              {
                 FirstIndex=175,
                 LastIndex=179,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KPQQP",
                 },
             new Pentamer
              {
                 FirstIndex=176,
                 LastIndex=180,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PQQPV",
                 },
             new Pentamer
              {
                 FirstIndex=177,
                 LastIndex=181,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QQPVS",
                 },
             new Pentamer
              {
                 FirstIndex=178,
                 LastIndex=182,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QPVSE",
                 },
             new Pentamer
              {
                 FirstIndex=179,
                 LastIndex=183,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PVSEP",
                 },
             new Pentamer
              {
                 FirstIndex=180,
                 LastIndex=184,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VSEPA",
                 },
             new Pentamer
              {
                 FirstIndex=181,
                 LastIndex=185,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SEPAA",
                 },
             new Pentamer
              {
                 FirstIndex=182,
                 LastIndex=186,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EPAAP",
                 },
             new Pentamer
              {
                 FirstIndex=183,
                 LastIndex=187,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PAAPE",
                 },
             new Pentamer
              {
                 FirstIndex=184,
                 LastIndex=188,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AAPEQ",
                 },
             new Pentamer
              {
                 FirstIndex=185,
                 LastIndex=189,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="APEQP",
                 },
             new Pentamer
              {
                 FirstIndex=186,
                 LastIndex=190,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PEQPA",
                 },
             new Pentamer
              {
                 FirstIndex=187,
                 LastIndex=191,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EQPAP",
                 },
             new Pentamer
              {
                 FirstIndex=188,
                 LastIndex=192,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QPAPE",
                 },
             new Pentamer
              {
                 FirstIndex=189,
                 LastIndex=193,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PAPEP",
                 },
             new Pentamer
              {
                 FirstIndex=190,
                 LastIndex=194,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="APEPK",
                 },
             new Pentamer
              {
                 FirstIndex=191,
                 LastIndex=195,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PEPKH",
                 },
             new Pentamer
              {
                 FirstIndex=192,
                 LastIndex=196,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EPKHP",
                 },
             new Pentamer
              {
                 FirstIndex=193,
                 LastIndex=197,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PKHPA",
                 },
             new Pentamer
              {
                 FirstIndex=194,
                 LastIndex=198,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KHPAR",
                 },
             new Pentamer
              {
                 FirstIndex=195,
                 LastIndex=199,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HPARA",
                 },
             new Pentamer
              {
                 FirstIndex=196,
                 LastIndex=200,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PARAP",
                 },
             new Pentamer
              {
                 FirstIndex=197,
                 LastIndex=201,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ARAPA",
                 },
             new Pentamer
              {
                 FirstIndex=198,
                 LastIndex=202,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RAPAR",
                 },
             new Pentamer
              {
                 FirstIndex=199,
                 LastIndex=203,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="APARG",
                 },
             new Pentamer
              {
                 FirstIndex=200,
                 LastIndex=204,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PARGD",
                 },
             new Pentamer
              {
                 FirstIndex=201,
                 LastIndex=205,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ARGDS",
                 },
             new Pentamer
              {
                 FirstIndex=202,
                 LastIndex=206,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RGDSE",
                 },
             new Pentamer
              {
                 FirstIndex=203,
                 LastIndex=207,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GDSED",
                 },
             new Pentamer
              {
                 FirstIndex=204,
                 LastIndex=208,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DSEDR",
                 },
             new Pentamer
              {
                 FirstIndex=205,
                 LastIndex=209,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SEDRR",
                 },
             new Pentamer
              {
                 FirstIndex=206,
                 LastIndex=210,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EDRRG",
                 },
             new Pentamer
              {
                 FirstIndex=207,
                 LastIndex=211,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DRRGP",
                 },
             new Pentamer
              {
                 FirstIndex=208,
                 LastIndex=212,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RRGPG",
                 },
             new Pentamer
              {
                 FirstIndex=209,
                 LastIndex=213,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RGPGQ",
                 },
             new Pentamer
              {
                 FirstIndex=210,
                 LastIndex=214,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GPGQK",
                 },
             new Pentamer
              {
                 FirstIndex=211,
                 LastIndex=215,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGQKT",
                 },
             new Pentamer
              {
                 FirstIndex=212,
                 LastIndex=216,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GQKTG",
                 },
             new Pentamer
              {
                 FirstIndex=213,
                 LastIndex=217,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QKTGP",
                 },
             new Pentamer
              {
                 FirstIndex=214,
                 LastIndex=218,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KTGPD",
                 },
             new Pentamer
              {
                 FirstIndex=215,
                 LastIndex=219,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TGPDP",
                 },
             new Pentamer
              {
                 FirstIndex=216,
                 LastIndex=220,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GPDPA",
                 },
             new Pentamer
              {
                 FirstIndex=217,
                 LastIndex=221,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PDPAS",
                 },
             new Pentamer
              {
                 FirstIndex=218,
                 LastIndex=222,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DPASA",
                 },
             new Pentamer
              {
                 FirstIndex=219,
                 LastIndex=223,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PASAP",
                 },
             new Pentamer
              {
                 FirstIndex=220,
                 LastIndex=224,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ASAPG",
                 },
             new Pentamer
              {
                 FirstIndex=221,
                 LastIndex=225,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SAPGR",
                 },
             new Pentamer
              {
                 FirstIndex=222,
                 LastIndex=226,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="APGRG",
                 },
             new Pentamer
              {
                 FirstIndex=223,
                 LastIndex=227,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGRGN",
                 },
             new Pentamer
              {
                 FirstIndex=224,
                 LastIndex=228,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GRGNY",
                 },
             new Pentamer
              {
                 FirstIndex=225,
                 LastIndex=229,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RGNYG",
                 },
             new Pentamer
              {
                 FirstIndex=226,
                 LastIndex=230,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GNYGP",
                 },
             new Pentamer
              {
                 FirstIndex=227,
                 LastIndex=231,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NYGPP",
                 },
             new Pentamer
              {
                 FirstIndex=228,
                 LastIndex=232,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YGPPV",
                 },
             new Pentamer
              {
                 FirstIndex=229,
                 LastIndex=233,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GPPVR",
                 },
             new Pentamer
              {
                 FirstIndex=230,
                 LastIndex=234,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PPVRR",
                 },
             new Pentamer
              {
                 FirstIndex=231,
                 LastIndex=235,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PVRRA",
                 },
             new Pentamer
              {
                 FirstIndex=232,
                 LastIndex=236,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VRRAS",
                 },
             new Pentamer
              {
                 FirstIndex=233,
                 LastIndex=237,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RRASE",
                 },
             new Pentamer
              {
                 FirstIndex=234,
                 LastIndex=238,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RASEA",
                 },
             new Pentamer
              {
                 FirstIndex=235,
                 LastIndex=239,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ASEAR",
                 },
             new Pentamer
              {
                 FirstIndex=236,
                 LastIndex=240,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SEARM",
                 },
             new Pentamer
              {
                 FirstIndex=237,
                 LastIndex=241,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EARMS",
                 },
             new Pentamer
              {
                 FirstIndex=238,
                 LastIndex=242,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ARMSS",
                 },
             new Pentamer
              {
                 FirstIndex=239,
                 LastIndex=243,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RMSSS",
                 },
             new Pentamer
              {
                 FirstIndex=240,
                 LastIndex=244,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MSSSS",
                 },
             new Pentamer
              {
                 FirstIndex=241,
                 LastIndex=245,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SSSSR",
                 },
             new Pentamer
              {
                 FirstIndex=242,
                 LastIndex=246,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SSSRD",
                 },
             new Pentamer
              {
                 FirstIndex=243,
                 LastIndex=247,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SSRDS",
                 },
             new Pentamer
              {
                 FirstIndex=244,
                 LastIndex=248,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SRDSE",
                 },
             new Pentamer
              {
                 FirstIndex=245,
                 LastIndex=249,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RDSES",
                 },
             new Pentamer
              {
                 FirstIndex=246,
                 LastIndex=250,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DSESW",
                 },
             new Pentamer
              {
                 FirstIndex=247,
                 LastIndex=251,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SESWD",
                 },
             new Pentamer
              {
                 FirstIndex=248,
                 LastIndex=252,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ESWDH",
                 },
             new Pentamer
              {
                 FirstIndex=249,
                 LastIndex=253,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SWDHS",
                 },
             new Pentamer
              {
                 FirstIndex=250,
                 LastIndex=254,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WDHSG",
                 },
             new Pentamer
              {
                 FirstIndex=251,
                 LastIndex=255,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DHSGG",
                 },
             new Pentamer
              {
                 FirstIndex=252,
                 LastIndex=256,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HSGGA",
                 },
             new Pentamer
              {
                 FirstIndex=253,
                 LastIndex=257,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SGGAG",
                 },
             new Pentamer
              {
                 FirstIndex=254,
                 LastIndex=258,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GGAGD",
                 },
             new Pentamer
              {
                 FirstIndex=255,
                 LastIndex=259,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GAGDS",
                 },
             new Pentamer
              {
                 FirstIndex=256,
                 LastIndex=260,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AGDSS",
                 },
             new Pentamer
              {
                 FirstIndex=257,
                 LastIndex=261,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GDSSR",
                 },
             new Pentamer
              {
                 FirstIndex=258,
                 LastIndex=262,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DSSRS",
                 },
             new Pentamer
              {
                 FirstIndex=259,
                 LastIndex=263,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SSRSP",
                 },
             new Pentamer
              {
                 FirstIndex=260,
                 LastIndex=264,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SRSPA",
                 },
             new Pentamer
              {
                 FirstIndex=261,
                 LastIndex=265,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RSPAG",
                 },
             new Pentamer
              {
                 FirstIndex=262,
                 LastIndex=266,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SPAGL",
                 },
             new Pentamer
              {
                 FirstIndex=263,
                 LastIndex=267,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PAGLR",
                 },
             new Pentamer
              {
                 FirstIndex=264,
                 LastIndex=268,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AGLRR",
                 },
             new Pentamer
              {
                 FirstIndex=265,
                 LastIndex=269,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GLRRA",
                 },
             new Pentamer
              {
                 FirstIndex=266,
                 LastIndex=270,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LRRAN",
                 },
             new Pentamer
              {
                 FirstIndex=267,
                 LastIndex=271,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RRANS",
                 },
             new Pentamer
              {
                 FirstIndex=268,
                 LastIndex=272,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RANSV",
                 },
             new Pentamer
              {
                 FirstIndex=269,
                 LastIndex=273,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ANSVQ",
                 },
             new Pentamer
              {
                 FirstIndex=270,
                 LastIndex=274,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NSVQA",
                 },
             new Pentamer
              {
                 FirstIndex=271,
                 LastIndex=275,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SVQAS",
                 },
             new Pentamer
              {
                 FirstIndex=272,
                 LastIndex=276,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VQASR",
                 },
             new Pentamer
              {
                 FirstIndex=273,
                 LastIndex=277,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QASRP",
                 },
             new Pentamer
              {
                 FirstIndex=274,
                 LastIndex=278,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ASRPA",
                 },
             new Pentamer
              {
                 FirstIndex=275,
                 LastIndex=279,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SRPAP",
                 },
             new Pentamer
              {
                 FirstIndex=276,
                 LastIndex=280,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RPAPG",
                 },
             new Pentamer
              {
                 FirstIndex=277,
                 LastIndex=281,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PAPGS",
                 },
             new Pentamer
              {
                 FirstIndex=278,
                 LastIndex=282,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="APGSV",
                 },
             new Pentamer
              {
                 FirstIndex=279,
                 LastIndex=283,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGSVQ",
                 },
             new Pentamer
              {
                 FirstIndex=280,
                 LastIndex=284,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GSVQS",
                 },
             new Pentamer
              {
                 FirstIndex=281,
                 LastIndex=285,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SVQSP",
                 },
             new Pentamer
              {
                 FirstIndex=282,
                 LastIndex=286,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VQSPA",
                 },
             new Pentamer
              {
                 FirstIndex=283,
                 LastIndex=287,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QSPAP",
                 },
             new Pentamer
              {
                 FirstIndex=284,
                 LastIndex=288,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SPAPP",
                 },
             new Pentamer
              {
                 FirstIndex=285,
                 LastIndex=289,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PAPPQ",
                 },
             new Pentamer
              {
                 FirstIndex=286,
                 LastIndex=290,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="APPQP",
                 },
             new Pentamer
              {
                 FirstIndex=287,
                 LastIndex=291,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PPQPG",
                 },
             new Pentamer
              {
                 FirstIndex=288,
                 LastIndex=292,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PQPGQ",
                 },
             new Pentamer
              {
                 FirstIndex=289,
                 LastIndex=293,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QPGQP",
                 },
             new Pentamer
              {
                 FirstIndex=290,
                 LastIndex=294,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGQPG",
                 },
             new Pentamer
              {
                 FirstIndex=291,
                 LastIndex=295,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GQPGT",
                 },
             new Pentamer
              {
                 FirstIndex=292,
                 LastIndex=296,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QPGTP",
                 },
             new Pentamer
              {
                 FirstIndex=293,
                 LastIndex=297,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGTPG",
                 },
             new Pentamer
              {
                 FirstIndex=294,
                 LastIndex=298,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GTPGG",
                 },
             new Pentamer
              {
                 FirstIndex=295,
                 LastIndex=299,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TPGGS",
                 },
             new Pentamer
              {
                 FirstIndex=296,
                 LastIndex=300,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGGSR",
                 },
             new Pentamer
              {
                 FirstIndex=297,
                 LastIndex=301,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GGSRP",
                 },
             new Pentamer
              {
                 FirstIndex=298,
                 LastIndex=302,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GSRPG",
                 },
             new Pentamer
              {
                 FirstIndex=299,
                 LastIndex=303,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SRPGP",
                 },
             new Pentamer
              {
                 FirstIndex=300,
                 LastIndex=304,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RPGPG",
                 },
             new Pentamer
              {
                 FirstIndex=301,
                 LastIndex=305,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGPGP",
                 },
             new Pentamer
              {
                 FirstIndex=302,
                 LastIndex=306,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GPGPA",
                 },
             new Pentamer
              {
                 FirstIndex=303,
                 LastIndex=307,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGPAG",
                 },
             new Pentamer
              {
                 FirstIndex=304,
                 LastIndex=308,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GPAGR",
                 },
             new Pentamer
              {
                 FirstIndex=305,
                 LastIndex=309,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PAGRF",
                 },
             new Pentamer
              {
                 FirstIndex=306,
                 LastIndex=310,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AGRFP",
                 },
             new Pentamer
              {
                 FirstIndex=307,
                 LastIndex=311,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GRFPD",
                 },
             new Pentamer
              {
                 FirstIndex=308,
                 LastIndex=312,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RFPDQ",
                 },
             new Pentamer
              {
                 FirstIndex=309,
                 LastIndex=313,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FPDQK",
                 },
             new Pentamer
              {
                 FirstIndex=310,
                 LastIndex=314,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PDQKP",
                 },
             new Pentamer
              {
                 FirstIndex=311,
                 LastIndex=315,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DQKPE",
                 },
             new Pentamer
              {
                 FirstIndex=312,
                 LastIndex=316,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QKPEV",
                 },
             new Pentamer
              {
                 FirstIndex=313,
                 LastIndex=317,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KPEVA",
                 },
             new Pentamer
              {
                 FirstIndex=314,
                 LastIndex=318,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PEVAP",
                 },
             new Pentamer
              {
                 FirstIndex=315,
                 LastIndex=319,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EVAPS",
                 },
             new Pentamer
              {
                 FirstIndex=316,
                 LastIndex=320,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VAPSD",
                 },
             new Pentamer
              {
                 FirstIndex=317,
                 LastIndex=321,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="APSDP",
                 },
             new Pentamer
              {
                 FirstIndex=318,
                 LastIndex=322,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PSDPG",
                 },
             new Pentamer
              {
                 FirstIndex=319,
                 LastIndex=323,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SDPGT",
                 },
             new Pentamer
              {
                 FirstIndex=320,
                 LastIndex=324,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DPGTT",
                 },
             new Pentamer
              {
                 FirstIndex=321,
                 LastIndex=325,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGTTA",
                 },
             new Pentamer
              {
                 FirstIndex=322,
                 LastIndex=326,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GTTAP",
                 },
             new Pentamer
              {
                 FirstIndex=323,
                 LastIndex=327,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TTAPP",
                 },
             new Pentamer
              {
                 FirstIndex=324,
                 LastIndex=328,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TAPPR",
                 },
             new Pentamer
              {
                 FirstIndex=325,
                 LastIndex=329,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="APPRE",
                 },
             new Pentamer
              {
                 FirstIndex=326,
                 LastIndex=330,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PPREE",
                 },
             new Pentamer
              {
                 FirstIndex=327,
                 LastIndex=331,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PREER",
                 },
             new Pentamer
              {
                 FirstIndex=328,
                 LastIndex=332,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="REERT",
                 },
             new Pentamer
              {
                 FirstIndex=329,
                 LastIndex=333,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EERTG",
                 },
             new Pentamer
              {
                 FirstIndex=330,
                 LastIndex=334,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ERTGG",
                 },
             new Pentamer
              {
                 FirstIndex=331,
                 LastIndex=335,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RTGGV",
                 },
             new Pentamer
              {
                 FirstIndex=332,
                 LastIndex=336,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TGGVG",
                 },
             new Pentamer
              {
                 FirstIndex=333,
                 LastIndex=337,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GGVGG",
                 },
             new Pentamer
              {
                 FirstIndex=334,
                 LastIndex=338,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GVGGY",
                 },
             new Pentamer
              {
                 FirstIndex=335,
                 LastIndex=339,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VGGYP",
                 },
             new Pentamer
              {
                 FirstIndex=336,
                 LastIndex=340,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GGYPA",
                 },
             new Pentamer
              {
                 FirstIndex=337,
                 LastIndex=341,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GYPAV",
                 },
             new Pentamer
              {
                 FirstIndex=338,
                 LastIndex=342,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YPAVG",
                 },
             new Pentamer
              {
                 FirstIndex=339,
                 LastIndex=343,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PAVGA",
                 },
             new Pentamer
              {
                 FirstIndex=340,
                 LastIndex=344,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AVGAR",
                 },
             new Pentamer
              {
                 FirstIndex=341,
                 LastIndex=345,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VGARE",
                 },
             new Pentamer
              {
                 FirstIndex=342,
                 LastIndex=346,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GARED",
                 },
             new Pentamer
              {
                 FirstIndex=343,
                 LastIndex=347,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AREDR",
                 },
             new Pentamer
              {
                 FirstIndex=344,
                 LastIndex=348,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="REDRM",
                 },
             new Pentamer
              {
                 FirstIndex=345,
                 LastIndex=349,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EDRMS",
                 },
             new Pentamer
              {
                 FirstIndex=346,
                 LastIndex=350,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DRMSH",
                 },
             new Pentamer
              {
                 FirstIndex=347,
                 LastIndex=351,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RMSHP",
                 },
             new Pentamer
              {
                 FirstIndex=348,
                 LastIndex=352,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MSHPS",
                 },
             new Pentamer
              {
                 FirstIndex=349,
                 LastIndex=353,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SHPSG",
                 },
             new Pentamer
              {
                 FirstIndex=350,
                 LastIndex=354,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HPSGP",
                 },
             new Pentamer
              {
                 FirstIndex=351,
                 LastIndex=355,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PSGPY",
                 },
             new Pentamer
              {
                 FirstIndex=352,
                 LastIndex=356,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SGPYS",
                 },
             new Pentamer
              {
                 FirstIndex=353,
                 LastIndex=357,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GPYSQ",
                 },
             new Pentamer
              {
                 FirstIndex=354,
                 LastIndex=358,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PYSQA",
                 },
             new Pentamer
              {
                 FirstIndex=355,
                 LastIndex=359,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YSQAS",
                 },
             new Pentamer
              {
                 FirstIndex=356,
                 LastIndex=360,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SQASA",
                 },
             new Pentamer
              {
                 FirstIndex=357,
                 LastIndex=361,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QASAA",
                 },
             new Pentamer
              {
                 FirstIndex=358,
                 LastIndex=362,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ASAAA",
                 },
             new Pentamer
              {
                 FirstIndex=359,
                 LastIndex=363,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SAAAP",
                 },
             new Pentamer
              {
                 FirstIndex=360,
                 LastIndex=364,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AAAPQ",
                 },
             new Pentamer
              {
                 FirstIndex=361,
                 LastIndex=365,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AAPQP",
                 },
             new Pentamer
              {
                 FirstIndex=362,
                 LastIndex=366,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="APQPA",
                 },
             new Pentamer
              {
                 FirstIndex=363,
                 LastIndex=367,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PQPAA",
                 },
             new Pentamer
              {
                 FirstIndex=364,
                 LastIndex=368,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QPAAA",
                 },
             new Pentamer
              {
                 FirstIndex=365,
                 LastIndex=369,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PAAAR",
                 },
             new Pentamer
              {
                 FirstIndex=366,
                 LastIndex=370,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AAARQ",
                 },
             new Pentamer
              {
                 FirstIndex=367,
                 LastIndex=371,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AARQP",
                 },
             new Pentamer
              {
                 FirstIndex=368,
                 LastIndex=372,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ARQPP",
                 },
             new Pentamer
              {
                 FirstIndex=369,
                 LastIndex=373,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RQPPP",
                 },
             new Pentamer
              {
                 FirstIndex=370,
                 LastIndex=374,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QPPPP",
                 },
             new Pentamer
              {
                 FirstIndex=371,
                 LastIndex=375,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PPPPE",
                 },
             new Pentamer
              {
                 FirstIndex=372,
                 LastIndex=376,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PPPEE",
                 },
             new Pentamer
              {
                 FirstIndex=373,
                 LastIndex=377,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PPEEE",
                 },
             new Pentamer
              {
                 FirstIndex=374,
                 LastIndex=378,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PEEEE",
                 },
             new Pentamer
              {
                 FirstIndex=375,
                 LastIndex=379,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEEEE",
                 },
             new Pentamer
              {
                 FirstIndex=376,
                 LastIndex=380,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEEEE",
                 },
             new Pentamer
              {
                 FirstIndex=377,
                 LastIndex=381,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEEEA",
                 },
             new Pentamer
              {
                 FirstIndex=378,
                 LastIndex=382,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEEAN",
                 },
             new Pentamer
              {
                 FirstIndex=379,
                 LastIndex=383,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEANS",
                 },
             new Pentamer
              {
                 FirstIndex=380,
                 LastIndex=384,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EANSY",
                 },
             new Pentamer
              {
                 FirstIndex=381,
                 LastIndex=385,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ANSYD",
                 },
             new Pentamer
              {
                 FirstIndex=382,
                 LastIndex=386,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NSYDS",
                 },
             new Pentamer
              {
                 FirstIndex=383,
                 LastIndex=387,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SYDSD",
                 },
             new Pentamer
              {
                 FirstIndex=384,
                 LastIndex=388,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YDSDE",
                 },
             new Pentamer
              {
                 FirstIndex=385,
                 LastIndex=389,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DSDEA",
                 },
             new Pentamer
              {
                 FirstIndex=386,
                 LastIndex=390,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SDEAT",
                 },
             new Pentamer
              {
                 FirstIndex=387,
                 LastIndex=391,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DEATT",
                 },
             new Pentamer
              {
                 FirstIndex=388,
                 LastIndex=392,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EATTL",
                 },
             new Pentamer
              {
                 FirstIndex=389,
                 LastIndex=393,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ATTLG",
                 },
             new Pentamer
              {
                 FirstIndex=390,
                 LastIndex=394,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TTLGA",
                 },
             new Pentamer
              {
                 FirstIndex=391,
                 LastIndex=395,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TLGAL",
                 },
             new Pentamer
              {
                 FirstIndex=392,
                 LastIndex=396,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LGALE",
                 },
             new Pentamer
              {
                 FirstIndex=393,
                 LastIndex=397,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GALEF",
                 },
             new Pentamer
              {
                 FirstIndex=394,
                 LastIndex=398,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ALEFS",
                 },
             new Pentamer
              {
                 FirstIndex=395,
                 LastIndex=399,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LEFSL",
                 },
             new Pentamer
              {
                 FirstIndex=396,
                 LastIndex=400,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EFSLL",
                 },
             new Pentamer
              {
                 FirstIndex=397,
                 LastIndex=401,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FSLLY",
                 },
             new Pentamer
              {
                 FirstIndex=398,
                 LastIndex=402,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SLLYD",
                 },
             new Pentamer
              {
                 FirstIndex=399,
                 LastIndex=403,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LLYDQ",
                 },
             new Pentamer
              {
                 FirstIndex=400,
                 LastIndex=404,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LYDQD",
                 },
             new Pentamer
              {
                 FirstIndex=401,
                 LastIndex=405,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YDQDN",
                 },
             new Pentamer
              {
                 FirstIndex=402,
                 LastIndex=406,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DQDNS",
                 },
             new Pentamer
              {
                 FirstIndex=403,
                 LastIndex=407,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QDNSS",
                 },
             new Pentamer
              {
                 FirstIndex=404,
                 LastIndex=408,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DNSSL",
                 },
             new Pentamer
              {
                 FirstIndex=405,
                 LastIndex=409,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NSSLQ",
                 },
             new Pentamer
              {
                 FirstIndex=406,
                 LastIndex=410,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SSLQC",
                 },
             new Pentamer
              {
                 FirstIndex=407,
                 LastIndex=411,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SLQCT",
                 },
             new Pentamer
              {
                 FirstIndex=408,
                 LastIndex=412,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LQCTI",
                 },
             new Pentamer
              {
                 FirstIndex=409,
                 LastIndex=413,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QCTII",
                 },
             new Pentamer
              {
                 FirstIndex=410,
                 LastIndex=414,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CTIIK",
                 },
             new Pentamer
              {
                 FirstIndex=411,
                 LastIndex=415,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TIIKA",
                 },
             new Pentamer
              {
                 FirstIndex=412,
                 LastIndex=416,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IIKAK",
                 },
             new Pentamer
              {
                 FirstIndex=413,
                 LastIndex=417,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IKAKG",
                 },
             new Pentamer
              {
                 FirstIndex=414,
                 LastIndex=418,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KAKGL",
                 },
             new Pentamer
              {
                 FirstIndex=415,
                 LastIndex=419,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AKGLK",
                 },
             new Pentamer
              {
                 FirstIndex=416,
                 LastIndex=420,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KGLKP",
                 },
             new Pentamer
              {
                 FirstIndex=417,
                 LastIndex=421,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GLKPM",
                 },
             new Pentamer
              {
                 FirstIndex=418,
                 LastIndex=422,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LKPMD",
                 },
             new Pentamer
              {
                 FirstIndex=419,
                 LastIndex=423,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KPMDS",
                 },
             new Pentamer
              {
                 FirstIndex=420,
                 LastIndex=424,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PMDSN",
                 },
             new Pentamer
              {
                 FirstIndex=421,
                 LastIndex=425,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MDSNG",
                 },
             new Pentamer
              {
                 FirstIndex=422,
                 LastIndex=426,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DSNGL",
                 },
             new Pentamer
              {
                 FirstIndex=423,
                 LastIndex=427,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SNGLA",
                 },
             new Pentamer
              {
                 FirstIndex=424,
                 LastIndex=428,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NGLAD",
                 },
             new Pentamer
              {
                 FirstIndex=425,
                 LastIndex=429,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GLADP",
                 },
             new Pentamer
              {
                 FirstIndex=426,
                 LastIndex=430,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LADPY",
                 },
             new Pentamer
              {
                 FirstIndex=427,
                 LastIndex=431,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ADPYV",
                 },
             new Pentamer
              {
                 FirstIndex=428,
                 LastIndex=432,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DPYVK",
                 },
             new Pentamer
              {
                 FirstIndex=429,
                 LastIndex=433,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PYVKL",
                 },
             new Pentamer
              {
                 FirstIndex=430,
                 LastIndex=434,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YVKLH",
                 },
             new Pentamer
              {
                 FirstIndex=431,
                 LastIndex=435,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VKLHL",
                 },
             new Pentamer
              {
                 FirstIndex=432,
                 LastIndex=436,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KLHLL",
                 },
             new Pentamer
              {
                 FirstIndex=433,
                 LastIndex=437,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LHLLP",
                 },
             new Pentamer
              {
                 FirstIndex=434,
                 LastIndex=438,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HLLPG",
                 },
             new Pentamer
              {
                 FirstIndex=435,
                 LastIndex=439,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LLPGA",
                 },
             new Pentamer
              {
                 FirstIndex=436,
                 LastIndex=440,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LPGAS",
                 },
             new Pentamer
              {
                 FirstIndex=437,
                 LastIndex=441,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PGASK",
                 },
             new Pentamer
              {
                 FirstIndex=438,
                 LastIndex=442,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GASKS",
                 },
             new Pentamer
              {
                 FirstIndex=439,
                 LastIndex=443,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ASKSN",
                 },
             new Pentamer
              {
                 FirstIndex=440,
                 LastIndex=444,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SKSNK",
                 },
             new Pentamer
              {
                 FirstIndex=441,
                 LastIndex=445,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KSNKL",
                 },
             new Pentamer
              {
                 FirstIndex=442,
                 LastIndex=446,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SNKLR",
                 },
             new Pentamer
              {
                 FirstIndex=443,
                 LastIndex=447,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NKLRT",
                 },
             new Pentamer
              {
                 FirstIndex=444,
                 LastIndex=448,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KLRTK",
                 },
             new Pentamer
              {
                 FirstIndex=445,
                 LastIndex=449,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LRTKT",
                 },
             new Pentamer
              {
                 FirstIndex=446,
                 LastIndex=450,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RTKTL",
                 },
             new Pentamer
              {
                 FirstIndex=447,
                 LastIndex=451,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TKTLR",
                 },
             new Pentamer
              {
                 FirstIndex=448,
                 LastIndex=452,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KTLRN",
                 },
             new Pentamer
              {
                 FirstIndex=449,
                 LastIndex=453,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TLRNT",
                 },
             new Pentamer
              {
                 FirstIndex=450,
                 LastIndex=454,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LRNTR",
                 },
             new Pentamer
              {
                 FirstIndex=451,
                 LastIndex=455,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RNTRN",
                 },
             new Pentamer
              {
                 FirstIndex=452,
                 LastIndex=456,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NTRNP",
                 },
             new Pentamer
              {
                 FirstIndex=453,
                 LastIndex=457,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TRNPI",
                 },
             new Pentamer
              {
                 FirstIndex=454,
                 LastIndex=458,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RNPIW",
                 },
             new Pentamer
              {
                 FirstIndex=455,
                 LastIndex=459,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NPIWN",
                 },
             new Pentamer
              {
                 FirstIndex=456,
                 LastIndex=460,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PIWNE",
                 },
             new Pentamer
              {
                 FirstIndex=457,
                 LastIndex=461,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IWNET",
                 },
             new Pentamer
              {
                 FirstIndex=458,
                 LastIndex=462,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WNETL",
                 },
             new Pentamer
              {
                 FirstIndex=459,
                 LastIndex=463,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NETLV",
                 },
             new Pentamer
              {
                 FirstIndex=460,
                 LastIndex=464,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ETLVY",
                 },
             new Pentamer
              {
                 FirstIndex=461,
                 LastIndex=465,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TLVYH",
                 },
             new Pentamer
              {
                 FirstIndex=462,
                 LastIndex=466,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LVYHG",
                 },
             new Pentamer
              {
                 FirstIndex=463,
                 LastIndex=467,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VYHGI",
                 },
             new Pentamer
              {
                 FirstIndex=464,
                 LastIndex=468,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YHGIT",
                 },
             new Pentamer
              {
                 FirstIndex=465,
                 LastIndex=469,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HGITD",
                 },
             new Pentamer
              {
                 FirstIndex=466,
                 LastIndex=470,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GITDE",
                 },
             new Pentamer
              {
                 FirstIndex=467,
                 LastIndex=471,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ITDED",
                 },
             new Pentamer
              {
                 FirstIndex=468,
                 LastIndex=472,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TDEDM",
                 },
             new Pentamer
              {
                 FirstIndex=469,
                 LastIndex=473,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DEDMQ",
                 },
             new Pentamer
              {
                 FirstIndex=470,
                 LastIndex=474,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EDMQR",
                 },
             new Pentamer
              {
                 FirstIndex=471,
                 LastIndex=475,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DMQRK",
                 },
             new Pentamer
              {
                 FirstIndex=472,
                 LastIndex=476,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MQRKT",
                 },
             new Pentamer
              {
                 FirstIndex=473,
                 LastIndex=477,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QRKTL",
                 },
             new Pentamer
              {
                 FirstIndex=474,
                 LastIndex=478,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RKTLR",
                 },
             new Pentamer
              {
                 FirstIndex=475,
                 LastIndex=479,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KTLRI",
                 },
             new Pentamer
              {
                 FirstIndex=476,
                 LastIndex=480,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TLRIS",
                 },
             new Pentamer
              {
                 FirstIndex=477,
                 LastIndex=481,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LRISV",
                 },
             new Pentamer
              {
                 FirstIndex=478,
                 LastIndex=482,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RISVC",
                 },
             new Pentamer
              {
                 FirstIndex=479,
                 LastIndex=483,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ISVCD",
                 },
             new Pentamer
              {
                 FirstIndex=480,
                 LastIndex=484,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SVCDE",
                 },
             new Pentamer
              {
                 FirstIndex=481,
                 LastIndex=485,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VCDED",
                 },
             new Pentamer
              {
                 FirstIndex=482,
                 LastIndex=486,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CDEDK",
                 },
             new Pentamer
              {
                 FirstIndex=483,
                 LastIndex=487,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DEDKF",
                 },
             new Pentamer
              {
                 FirstIndex=484,
                 LastIndex=488,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EDKFG",
                 },
             new Pentamer
              {
                 FirstIndex=485,
                 LastIndex=489,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DKFGH",
                 },
             new Pentamer
              {
                 FirstIndex=486,
                 LastIndex=490,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KFGHN",
                 },
             new Pentamer
              {
                 FirstIndex=487,
                 LastIndex=491,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FGHNE",
                 },
             new Pentamer
              {
                 FirstIndex=488,
                 LastIndex=492,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GHNEF",
                 },
             new Pentamer
              {
                 FirstIndex=489,
                 LastIndex=493,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HNEFI",
                 },
             new Pentamer
              {
                 FirstIndex=490,
                 LastIndex=494,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NEFIG",
                 },
             new Pentamer
              {
                 FirstIndex=491,
                 LastIndex=495,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EFIGE",
                 },
             new Pentamer
              {
                 FirstIndex=492,
                 LastIndex=496,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FIGET",
                 },
             new Pentamer
              {
                 FirstIndex=493,
                 LastIndex=497,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IGETR",
                 },
             new Pentamer
              {
                 FirstIndex=494,
                 LastIndex=498,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GETRF",
                 },
             new Pentamer
              {
                 FirstIndex=495,
                 LastIndex=499,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ETRFS",
                 },
             new Pentamer
              {
                 FirstIndex=496,
                 LastIndex=500,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TRFSL",
                 },
             new Pentamer
              {
                 FirstIndex=497,
                 LastIndex=501,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RFSLK",
                 },
             new Pentamer
              {
                 FirstIndex=498,
                 LastIndex=502,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FSLKK",
                 },
             new Pentamer
              {
                 FirstIndex=499,
                 LastIndex=503,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SLKKL",
                 },
             new Pentamer
              {
                 FirstIndex=500,
                 LastIndex=504,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LKKLK",
                 },
             new Pentamer
              {
                 FirstIndex=501,
                 LastIndex=505,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KKLKP",
                 },
             new Pentamer
              {
                 FirstIndex=502,
                 LastIndex=506,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KLKPN",
                 },
             new Pentamer
              {
                 FirstIndex=503,
                 LastIndex=507,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LKPNQ",
                 },
             new Pentamer
              {
                 FirstIndex=504,
                 LastIndex=508,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KPNQR",
                 },
             new Pentamer
              {
                 FirstIndex=505,
                 LastIndex=509,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PNQRK",
                 },
             new Pentamer
              {
                 FirstIndex=506,
                 LastIndex=510,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NQRKN",
                 },
             new Pentamer
              {
                 FirstIndex=507,
                 LastIndex=511,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QRKNF",
                 },
             new Pentamer
              {
                 FirstIndex=508,
                 LastIndex=512,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RKNFN",
                 },
             new Pentamer
              {
                 FirstIndex=509,
                 LastIndex=513,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KNFNI",
                 },
             new Pentamer
              {
                 FirstIndex=510,
                 LastIndex=514,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NFNIC",
                 },
             new Pentamer
              {
                 FirstIndex=511,
                 LastIndex=515,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FNICL",
                 },
             new Pentamer
              {
                 FirstIndex=512,
                 LastIndex=516,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NICLE",
                 },
             new Pentamer
              {
                 FirstIndex=513,
                 LastIndex=517,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ICLER",
                 },
             new Pentamer
              {
                 FirstIndex=514,
                 LastIndex=518,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CLERV",
                 },
             new Pentamer
              {
                 FirstIndex=515,
                 LastIndex=519,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LERVI",
                 },
             new Pentamer
              {
                 FirstIndex=516,
                 LastIndex=520,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ERVIP",
                 },
             new Pentamer
              {
                 FirstIndex=517,
                 LastIndex=521,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RVIPM",
                 },
             new Pentamer
              {
                 FirstIndex=518,
                 LastIndex=522,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VIPMK",
                 },
             new Pentamer
              {
                 FirstIndex=519,
                 LastIndex=523,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IPMKR",
                 },
             new Pentamer
              {
                 FirstIndex=520,
                 LastIndex=524,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PMKRA",
                 },
             new Pentamer
              {
                 FirstIndex=521,
                 LastIndex=525,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MKRAG",
                 },
             new Pentamer
              {
                 FirstIndex=522,
                 LastIndex=526,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KRAGT",
                 },
             new Pentamer
              {
                 FirstIndex=523,
                 LastIndex=527,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RAGTT",
                 },
             new Pentamer
              {
                 FirstIndex=524,
                 LastIndex=528,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AGTTG",
                 },
             new Pentamer
              {
                 FirstIndex=525,
                 LastIndex=529,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GTTGS",
                 },
             new Pentamer
              {
                 FirstIndex=526,
                 LastIndex=530,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TTGSA",
                 },
             new Pentamer
              {
                 FirstIndex=527,
                 LastIndex=531,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TGSAR",
                 },
             new Pentamer
              {
                 FirstIndex=528,
                 LastIndex=532,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GSARG",
                 },
             new Pentamer
              {
                 FirstIndex=529,
                 LastIndex=533,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SARGM",
                 },
             new Pentamer
              {
                 FirstIndex=530,
                 LastIndex=534,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ARGMA",
                 },
             new Pentamer
              {
                 FirstIndex=531,
                 LastIndex=535,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RGMAL",
                 },
             new Pentamer
              {
                 FirstIndex=532,
                 LastIndex=536,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GMALY",
                 },
             new Pentamer
              {
                 FirstIndex=533,
                 LastIndex=537,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MALYE",
                 },
             new Pentamer
              {
                 FirstIndex=534,
                 LastIndex=538,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ALYEE",
                 },
             new Pentamer
              {
                 FirstIndex=535,
                 LastIndex=539,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LYEEE",
                 },
             new Pentamer
              {
                 FirstIndex=536,
                 LastIndex=540,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YEEEQ",
                 },
             new Pentamer
              {
                 FirstIndex=537,
                 LastIndex=541,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEEQV",
                 },
             new Pentamer
              {
                 FirstIndex=538,
                 LastIndex=542,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEQVE",
                 },
             new Pentamer
              {
                 FirstIndex=539,
                 LastIndex=543,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EQVER",
                 },
             new Pentamer
              {
                 FirstIndex=540,
                 LastIndex=544,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QVERV",
                 },
             new Pentamer
              {
                 FirstIndex=541,
                 LastIndex=545,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VERVG",
                 },
             new Pentamer
              {
                 FirstIndex=542,
                 LastIndex=546,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ERVGD",
                 },
             new Pentamer
              {
                 FirstIndex=543,
                 LastIndex=547,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RVGDI",
                 },
             new Pentamer
              {
                 FirstIndex=544,
                 LastIndex=548,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VGDIE",
                 },
             new Pentamer
              {
                 FirstIndex=545,
                 LastIndex=549,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GDIEE",
                 },
             new Pentamer
              {
                 FirstIndex=546,
                 LastIndex=550,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DIEER",
                 },
             new Pentamer
              {
                 FirstIndex=547,
                 LastIndex=551,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IEERG",
                 },
             new Pentamer
              {
                 FirstIndex=548,
                 LastIndex=552,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EERGK",
                 },
             new Pentamer
              {
                 FirstIndex=549,
                 LastIndex=553,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ERGKI",
                 },
             new Pentamer
              {
                 FirstIndex=550,
                 LastIndex=554,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RGKIL",
                 },
             new Pentamer
              {
                 FirstIndex=551,
                 LastIndex=555,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GKILV",
                 },
             new Pentamer
              {
                 FirstIndex=552,
                 LastIndex=556,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KILVS",
                 },
             new Pentamer
              {
                 FirstIndex=553,
                 LastIndex=557,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ILVSL",
                 },
             new Pentamer
              {
                 FirstIndex=554,
                 LastIndex=558,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LVSLM",
                 },
             new Pentamer
              {
                 FirstIndex=555,
                 LastIndex=559,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VSLMY",
                 },
             new Pentamer
              {
                 FirstIndex=556,
                 LastIndex=560,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SLMYS",
                 },
             new Pentamer
              {
                 FirstIndex=557,
                 LastIndex=561,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LMYST",
                 },
             new Pentamer
              {
                 FirstIndex=558,
                 LastIndex=562,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MYSTQ",
                 },
             new Pentamer
              {
                 FirstIndex=559,
                 LastIndex=563,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YSTQQ",
                 },
             new Pentamer
              {
                 FirstIndex=560,
                 LastIndex=564,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="STQQG",
                 },
             new Pentamer
              {
                 FirstIndex=561,
                 LastIndex=565,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TQQGG",
                 },
             new Pentamer
              {
                 FirstIndex=562,
                 LastIndex=566,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QQGGL",
                 },
             new Pentamer
              {
                 FirstIndex=563,
                 LastIndex=567,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QGGLI",
                 },
             new Pentamer
              {
                 FirstIndex=564,
                 LastIndex=568,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GGLIV",
                 },
             new Pentamer
              {
                 FirstIndex=565,
                 LastIndex=569,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GLIVG",
                 },
             new Pentamer
              {
                 FirstIndex=566,
                 LastIndex=570,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LIVGI",
                 },
             new Pentamer
              {
                 FirstIndex=567,
                 LastIndex=571,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IVGII",
                 },
             new Pentamer
              {
                 FirstIndex=568,
                 LastIndex=572,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VGIIR",
                 },
             new Pentamer
              {
                 FirstIndex=569,
                 LastIndex=573,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GIIRC",
                 },
             new Pentamer
              {
                 FirstIndex=570,
                 LastIndex=574,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IIRCV",
                 },
             new Pentamer
              {
                 FirstIndex=571,
                 LastIndex=575,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IRCVH",
                 },
             new Pentamer
              {
                 FirstIndex=572,
                 LastIndex=576,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RCVHL",
                 },
             new Pentamer
              {
                 FirstIndex=573,
                 LastIndex=577,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CVHLA",
                 },
             new Pentamer
              {
                 FirstIndex=574,
                 LastIndex=578,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VHLAA",
                 },
             new Pentamer
              {
                 FirstIndex=575,
                 LastIndex=579,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HLAAM",
                 },
             new Pentamer
              {
                 FirstIndex=576,
                 LastIndex=580,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LAAMD",
                 },
             new Pentamer
              {
                 FirstIndex=577,
                 LastIndex=581,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AAMDA",
                 },
             new Pentamer
              {
                 FirstIndex=578,
                 LastIndex=582,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AMDAN",
                 },
             new Pentamer
              {
                 FirstIndex=579,
                 LastIndex=583,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MDANG",
                 },
             new Pentamer
              {
                 FirstIndex=580,
                 LastIndex=584,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DANGY",
                 },
             new Pentamer
              {
                 FirstIndex=581,
                 LastIndex=585,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ANGYS",
                 },
             new Pentamer
              {
                 FirstIndex=582,
                 LastIndex=586,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NGYSD",
                 },
             new Pentamer
              {
                 FirstIndex=583,
                 LastIndex=587,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GYSDP",
                 },
             new Pentamer
              {
                 FirstIndex=584,
                 LastIndex=588,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YSDPF",
                 },
             new Pentamer
              {
                 FirstIndex=585,
                 LastIndex=589,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SDPFV",
                 },
             new Pentamer
              {
                 FirstIndex=586,
                 LastIndex=590,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DPFVK",
                 },
             new Pentamer
              {
                 FirstIndex=587,
                 LastIndex=591,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PFVKL",
                 },
             new Pentamer
              {
                 FirstIndex=588,
                 LastIndex=592,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FVKLW",
                 },
             new Pentamer
              {
                 FirstIndex=589,
                 LastIndex=593,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VKLWL",
                 },
             new Pentamer
              {
                 FirstIndex=590,
                 LastIndex=594,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KLWLK",
                 },
             new Pentamer
              {
                 FirstIndex=591,
                 LastIndex=595,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LWLKP",
                 },
             new Pentamer
              {
                 FirstIndex=592,
                 LastIndex=596,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WLKPD",
                 },
             new Pentamer
              {
                 FirstIndex=593,
                 LastIndex=597,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LKPDM",
                 },
             new Pentamer
              {
                 FirstIndex=594,
                 LastIndex=598,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KPDMG",
                 },
             new Pentamer
              {
                 FirstIndex=595,
                 LastIndex=599,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PDMGK",
                 },
             new Pentamer
              {
                 FirstIndex=596,
                 LastIndex=600,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DMGKK",
                 },
             new Pentamer
              {
                 FirstIndex=597,
                 LastIndex=601,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="MGKKA",
                 },
             new Pentamer
              {
                 FirstIndex=598,
                 LastIndex=602,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GKKAK",
                 },
             new Pentamer
              {
                 FirstIndex=599,
                 LastIndex=603,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KKAKH",
                 },
             new Pentamer
              {
                 FirstIndex=600,
                 LastIndex=604,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KAKHK",
                 },
             new Pentamer
              {
                 FirstIndex=601,
                 LastIndex=605,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AKHKT",
                 },
             new Pentamer
              {
                 FirstIndex=602,
                 LastIndex=606,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KHKTQ",
                 },
             new Pentamer
              {
                 FirstIndex=603,
                 LastIndex=607,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HKTQI",
                 },
             new Pentamer
              {
                 FirstIndex=604,
                 LastIndex=608,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KTQIK",
                 },
             new Pentamer
              {
                 FirstIndex=605,
                 LastIndex=609,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TQIKK",
                 },
             new Pentamer
              {
                 FirstIndex=606,
                 LastIndex=610,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QIKKK",
                 },
             new Pentamer
              {
                 FirstIndex=607,
                 LastIndex=611,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IKKKT",
                 },
             new Pentamer
              {
                 FirstIndex=608,
                 LastIndex=612,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KKKTL",
                 },
             new Pentamer
              {
                 FirstIndex=609,
                 LastIndex=613,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KKTLN",
                 },
             new Pentamer
              {
                 FirstIndex=610,
                 LastIndex=614,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KTLNP",
                 },
             new Pentamer
              {
                 FirstIndex=611,
                 LastIndex=615,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="TLNPE",
                 },
             new Pentamer
              {
                 FirstIndex=612,
                 LastIndex=616,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LNPEF",
                 },
             new Pentamer
              {
                 FirstIndex=613,
                 LastIndex=617,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NPEFN",
                 },
             new Pentamer
              {
                 FirstIndex=614,
                 LastIndex=618,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="PEFNE",
                 },
             new Pentamer
              {
                 FirstIndex=615,
                 LastIndex=619,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EFNEE",
                 },
             new Pentamer
              {
                 FirstIndex=616,
                 LastIndex=620,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FNEEF",
                 },
             new Pentamer
              {
                 FirstIndex=617,
                 LastIndex=621,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NEEFF",
                 },
             new Pentamer
              {
                 FirstIndex=618,
                 LastIndex=622,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EEFFY",
                 },
             new Pentamer
              {
                 FirstIndex=619,
                 LastIndex=623,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="EFFYD",
                 },
             new Pentamer
              {
                 FirstIndex=620,
                 LastIndex=624,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FFYDI",
                 },
             new Pentamer
              {
                 FirstIndex=621,
                 LastIndex=625,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="FYDIK",
                 },
             new Pentamer
              {
                 FirstIndex=622,
                 LastIndex=626,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YDIKH",
                 },
             new Pentamer
              {
                 FirstIndex=623,
                 LastIndex=627,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DIKHS",
                 },
             new Pentamer
              {
                 FirstIndex=624,
                 LastIndex=628,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IKHSD",
                 },
             new Pentamer
              {
                 FirstIndex=625,
                 LastIndex=629,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KHSDL",
                 },
             new Pentamer
              {
                 FirstIndex=626,
                 LastIndex=630,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HSDLA",
                 },
             new Pentamer
              {
                 FirstIndex=627,
                 LastIndex=631,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SDLAK",
                 },
             new Pentamer
              {
                 FirstIndex=628,
                 LastIndex=632,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DLAKK",
                 },
             new Pentamer
              {
                 FirstIndex=629,
                 LastIndex=633,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LAKKS",
                 },
             new Pentamer
              {
                 FirstIndex=630,
                 LastIndex=634,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AKKSL",
                 },
             new Pentamer
              {
                 FirstIndex=631,
                 LastIndex=635,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KKSLD",
                 },
             new Pentamer
              {
                 FirstIndex=632,
                 LastIndex=636,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KSLDI",
                 },
             new Pentamer
              {
                 FirstIndex=633,
                 LastIndex=637,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SLDIS",
                 },
             new Pentamer
              {
                 FirstIndex=634,
                 LastIndex=638,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LDISV",
                 },
             new Pentamer
              {
                 FirstIndex=635,
                 LastIndex=639,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DISVW",
                 },
             new Pentamer
              {
                 FirstIndex=636,
                 LastIndex=640,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ISVWD",
                 },
             new Pentamer
              {
                 FirstIndex=637,
                 LastIndex=641,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SVWDY",
                 },
             new Pentamer
              {
                 FirstIndex=638,
                 LastIndex=642,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="VWDYD",
                 },
             new Pentamer
              {
                 FirstIndex=639,
                 LastIndex=643,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WDYDI",
                 },
             new Pentamer
              {
                 FirstIndex=640,
                 LastIndex=644,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DYDIG",
                 },
             new Pentamer
              {
                 FirstIndex=641,
                 LastIndex=645,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YDIGK",
                 },
             new Pentamer
              {
                 FirstIndex=642,
                 LastIndex=646,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DIGKS",
                 },
             new Pentamer
              {
                 FirstIndex=643,
                 LastIndex=647,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IGKSN",
                 },
             new Pentamer
              {
                 FirstIndex=644,
                 LastIndex=648,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GKSND",
                 },
             new Pentamer
              {
                 FirstIndex=645,
                 LastIndex=649,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KSNDY",
                 },
             new Pentamer
              {
                 FirstIndex=646,
                 LastIndex=650,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SNDYI",
                 },
             new Pentamer
              {
                 FirstIndex=647,
                 LastIndex=651,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NDYIG",
                 },
             new Pentamer
              {
                 FirstIndex=648,
                 LastIndex=652,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DYIGG",
                 },
             new Pentamer
              {
                 FirstIndex=649,
                 LastIndex=653,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YIGGC",
                 },
             new Pentamer
              {
                 FirstIndex=650,
                 LastIndex=654,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IGGCQ",
                 },
             new Pentamer
              {
                 FirstIndex=651,
                 LastIndex=655,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GGCQL",
                 },
             new Pentamer
              {
                 FirstIndex=652,
                 LastIndex=656,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GCQLG",
                 },
             new Pentamer
              {
                 FirstIndex=653,
                 LastIndex=657,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CQLGI",
                 },
             new Pentamer
              {
                 FirstIndex=654,
                 LastIndex=658,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QLGIS",
                 },
             new Pentamer
              {
                 FirstIndex=655,
                 LastIndex=659,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LGISA",
                 },
             new Pentamer
              {
                 FirstIndex=656,
                 LastIndex=660,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GISAK",
                 },
             new Pentamer
              {
                 FirstIndex=657,
                 LastIndex=661,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ISAKG",
                 },
             new Pentamer
              {
                 FirstIndex=658,
                 LastIndex=662,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="SAKGE",
                 },
             new Pentamer
              {
                 FirstIndex=659,
                 LastIndex=663,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="AKGER",
                 },
             new Pentamer
              {
                 FirstIndex=660,
                 LastIndex=664,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KGERL",
                 },
             new Pentamer
              {
                 FirstIndex=661,
                 LastIndex=665,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="GERLK",
                 },
             new Pentamer
              {
                 FirstIndex=662,
                 LastIndex=666,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ERLKH",
                 },
             new Pentamer
              {
                 FirstIndex=663,
                 LastIndex=667,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RLKHW",
                 },
             new Pentamer
              {
                 FirstIndex=664,
                 LastIndex=668,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LKHWY",
                 },
             new Pentamer
              {
                 FirstIndex=665,
                 LastIndex=669,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KHWYE",
                 },
             new Pentamer
              {
                 FirstIndex=666,
                 LastIndex=670,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HWYEC",
                 },
             new Pentamer
              {
                 FirstIndex=667,
                 LastIndex=671,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WYECL",
                 },
             new Pentamer
              {
                 FirstIndex=668,
                 LastIndex=672,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="YECLK",
                 },
             new Pentamer
              {
                 FirstIndex=669,
                 LastIndex=673,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ECLKN",
                 },
             new Pentamer
              {
                 FirstIndex=670,
                 LastIndex=674,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="CLKNK",
                 },
             new Pentamer
              {
                 FirstIndex=671,
                 LastIndex=675,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LKNKD",
                 },
             new Pentamer
              {
                 FirstIndex=672,
                 LastIndex=676,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KNKDK",
                 },
             new Pentamer
              {
                 FirstIndex=673,
                 LastIndex=677,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NKDKK",
                 },
             new Pentamer
              {
                 FirstIndex=674,
                 LastIndex=678,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KDKKI",
                 },
             new Pentamer
              {
                 FirstIndex=675,
                 LastIndex=679,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="DKKIE",
                 },
             new Pentamer
              {
                 FirstIndex=676,
                 LastIndex=680,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KKIER",
                 },
             new Pentamer
              {
                 FirstIndex=677,
                 LastIndex=681,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="KIERW",
                 },
             new Pentamer
              {
                 FirstIndex=678,
                 LastIndex=682,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="IERWH",
                 },
             new Pentamer
              {
                 FirstIndex=679,
                 LastIndex=683,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ERWHQ",
                 },
             new Pentamer
              {
                 FirstIndex=680,
                 LastIndex=684,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="RWHQL",
                 },
             new Pentamer
              {
                 FirstIndex=681,
                 LastIndex=685,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="WHQLQ",
                 },
             new Pentamer
              {
                 FirstIndex=682,
                 LastIndex=686,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HQLQN",
                 },
             new Pentamer
              {
                 FirstIndex=683,
                 LastIndex=687,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QLQNE",
                 },
             new Pentamer
              {
                 FirstIndex=684,
                 LastIndex=688,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="LQNEN",
                 },
             new Pentamer
              {
                 FirstIndex=685,
                 LastIndex=689,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="QNENH",
                 },
             new Pentamer
              {
                 FirstIndex=686,
                 LastIndex=690,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NENHV",
                 },
             new Pentamer
              {
                 FirstIndex=687,
                 LastIndex=691,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="ENHVS",
                 },
             new Pentamer
              {
                 FirstIndex=688,
                 LastIndex=692,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="NHVSS",
                 },
             new Pentamer
              {
                 FirstIndex=689,
                 LastIndex=693,
                 ProteinName =  "RP3A_HUMAN" ,
                 Sequence ="HVSSD",
                 },

                //----------------------------------------
                new Pentamer
                {
                    FirstIndex = 0,
                    LastIndex = 4,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "MKGLY",
                },
                new Pentamer
                {
                    FirstIndex = 1,
                    LastIndex = 5,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KGLYF",
                },
                new Pentamer
                {
                    FirstIndex = 2,
                    LastIndex = 6,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GLYFQ",
                },
                new Pentamer
                {
                    FirstIndex = 3,
                    LastIndex = 7,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LYFQQ",
                },
                new Pentamer
                {
                    FirstIndex = 4,
                    LastIndex = 8,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "YFQQS",
                },
                new Pentamer
                {
                    FirstIndex = 5,
                    LastIndex = 9,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FQQSS",
                },
                new Pentamer
                {
                    FirstIndex = 6,
                    LastIndex = 10,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QQSST",
                },
                new Pentamer
                {
                    FirstIndex = 7,
                    LastIndex = 11,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QSSTD",
                },
                new Pentamer
                {
                    FirstIndex = 8,
                    LastIndex = 12,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SSTDE",
                },
                new Pentamer
                {
                    FirstIndex = 9,
                    LastIndex = 13,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "STDEE",
                },
                new Pentamer
                {
                    FirstIndex = 10,
                    LastIndex = 14,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TDEEI",
                },
                new Pentamer
                {
                    FirstIndex = 11,
                    LastIndex = 15,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DEEIT",
                },
                new Pentamer
                {
                    FirstIndex = 12,
                    LastIndex = 16,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EEITF",
                },
                new Pentamer
                {
                    FirstIndex = 13,
                    LastIndex = 17,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EITFV",
                },
                new Pentamer
                {
                    FirstIndex = 14,
                    LastIndex = 18,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ITFVF",
                },
                new Pentamer
                {
                    FirstIndex = 15,
                    LastIndex = 19,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TFVFQ",
                },
                new Pentamer
                {
                    FirstIndex = 16,
                    LastIndex = 20,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FVFQE",
                },
                new Pentamer
                {
                    FirstIndex = 17,
                    LastIndex = 21,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VFQEK",
                },
                new Pentamer
                {
                    FirstIndex = 18,
                    LastIndex = 22,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FQEKE",
                },
                new Pentamer
                {
                    FirstIndex = 19,
                    LastIndex = 23,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QEKED",
                },
                new Pentamer
                {
                    FirstIndex = 20,
                    LastIndex = 24,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EKEDL",
                },
                new Pentamer
                {
                    FirstIndex = 21,
                    LastIndex = 25,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KEDLP",
                },
                new Pentamer
                {
                    FirstIndex = 22,
                    LastIndex = 26,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EDLPV",
                },
                new Pentamer
                {
                    FirstIndex = 23,
                    LastIndex = 27,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DLPVT",
                },
                new Pentamer
                {
                    FirstIndex = 24,
                    LastIndex = 28,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LPVTE",
                },
                new Pentamer
                {
                    FirstIndex = 25,
                    LastIndex = 29,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PVTED",
                },
                new Pentamer
                {
                    FirstIndex = 26,
                    LastIndex = 30,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VTEDN",
                },
                new Pentamer
                {
                    FirstIndex = 27,
                    LastIndex = 31,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TEDNF",
                },
                new Pentamer
                {
                    FirstIndex = 28,
                    LastIndex = 32,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EDNFV",
                },
                new Pentamer
                {
                    FirstIndex = 29,
                    LastIndex = 33,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DNFVK",
                },
                new Pentamer
                {
                    FirstIndex = 30,
                    LastIndex = 34,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "NFVKL",
                },
                new Pentamer
                {
                    FirstIndex = 31,
                    LastIndex = 35,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FVKLQ",
                },
                new Pentamer
                {
                    FirstIndex = 32,
                    LastIndex = 36,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VKLQV",
                },
                new Pentamer
                {
                    FirstIndex = 33,
                    LastIndex = 37,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KLQVK",
                },
                new Pentamer
                {
                    FirstIndex = 34,
                    LastIndex = 38,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LQVKA",
                },
                new Pentamer
                {
                    FirstIndex = 35,
                    LastIndex = 39,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QVKAC",
                },
                new Pentamer
                {
                    FirstIndex = 36,
                    LastIndex = 40,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VKACA",
                },
                new Pentamer
                {
                    FirstIndex = 37,
                    LastIndex = 41,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KACAL",
                },
                new Pentamer
                {
                    FirstIndex = 38,
                    LastIndex = 42,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ACALS",
                },
                new Pentamer
                {
                    FirstIndex = 39,
                    LastIndex = 43,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "CALSQ",
                },
                new Pentamer
                {
                    FirstIndex = 40,
                    LastIndex = 44,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ALSQI",
                },
                new Pentamer
                {
                    FirstIndex = 41,
                    LastIndex = 45,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LSQIN",
                },
                new Pentamer
                {
                    FirstIndex = 42,
                    LastIndex = 46,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SQINT",
                },
                new Pentamer
                {
                    FirstIndex = 43,
                    LastIndex = 47,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QINTK",
                },
                new Pentamer
                {
                    FirstIndex = 44,
                    LastIndex = 48,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "INTKL",
                },
                new Pentamer
                {
                    FirstIndex = 45,
                    LastIndex = 49,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "NTKLL",
                },
                new Pentamer
                {
                    FirstIndex = 46,
                    LastIndex = 50,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TKLLA",
                },
                new Pentamer
                {
                    FirstIndex = 47,
                    LastIndex = 51,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KLLAE",
                },
                new Pentamer
                {
                    FirstIndex = 48,
                    LastIndex = 52,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LLAEM",
                },
                new Pentamer
                {
                    FirstIndex = 49,
                    LastIndex = 53,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LAEMK",
                },
                new Pentamer
                {
                    FirstIndex = 50,
                    LastIndex = 54,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AEMKM",
                },
                new Pentamer
                {
                    FirstIndex = 51,
                    LastIndex = 55,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EMKMK",
                },
                new Pentamer
                {
                    FirstIndex = 52,
                    LastIndex = 56,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "MKMKK",
                },
                new Pentamer
                {
                    FirstIndex = 53,
                    LastIndex = 57,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KMKKD",
                },
                new Pentamer
                {
                    FirstIndex = 54,
                    LastIndex = 58,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "MKKDL",
                },
                new Pentamer
                {
                    FirstIndex = 55,
                    LastIndex = 59,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KKDLF",
                },
                new Pentamer
                {
                    FirstIndex = 56,
                    LastIndex = 60,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KDLFP",
                },
                new Pentamer
                {
                    FirstIndex = 57,
                    LastIndex = 61,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DLFPV",
                },
                new Pentamer
                {
                    FirstIndex = 58,
                    LastIndex = 62,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LFPVG",
                },
                new Pentamer
                {
                    FirstIndex = 59,
                    LastIndex = 63,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FPVGR",
                },
                new Pentamer
                {
                    FirstIndex = 60,
                    LastIndex = 64,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PVGRE",
                },
                new Pentamer
                {
                    FirstIndex = 61,
                    LastIndex = 65,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VGREI",
                },
                new Pentamer
                {
                    FirstIndex = 62,
                    LastIndex = 66,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GREIA",
                },
                new Pentamer
                {
                    FirstIndex = 63,
                    LastIndex = 67,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "REIAG",
                },
                new Pentamer
                {
                    FirstIndex = 64,
                    LastIndex = 68,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EIAGI",
                },
                new Pentamer
                {
                    FirstIndex = 65,
                    LastIndex = 69,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IAGIV",
                },
                new Pentamer
                {
                    FirstIndex = 66,
                    LastIndex = 70,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AGIVL",
                },
                new Pentamer
                {
                    FirstIndex = 67,
                    LastIndex = 71,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GIVLD",
                },
                new Pentamer
                {
                    FirstIndex = 68,
                    LastIndex = 72,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IVLDV",
                },
                new Pentamer
                {
                    FirstIndex = 69,
                    LastIndex = 73,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VLDVG",
                },
                new Pentamer
                {
                    FirstIndex = 70,
                    LastIndex = 74,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LDVGS",
                },
                new Pentamer
                {
                    FirstIndex = 71,
                    LastIndex = 75,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DVGSK",
                },
                new Pentamer
                {
                    FirstIndex = 72,
                    LastIndex = 76,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VGSKV",
                },
                new Pentamer
                {
                    FirstIndex = 73,
                    LastIndex = 77,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GSKVS",
                },
                new Pentamer
                {
                    FirstIndex = 74,
                    LastIndex = 78,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SKVSF",
                },
                new Pentamer
                {
                    FirstIndex = 75,
                    LastIndex = 79,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KVSFF",
                },
                new Pentamer
                {
                    FirstIndex = 76,
                    LastIndex = 80,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VSFFQ",
                },
                new Pentamer
                {
                    FirstIndex = 77,
                    LastIndex = 81,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SFFQP",
                },
                new Pentamer
                {
                    FirstIndex = 78,
                    LastIndex = 82,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FFQPD",
                },
                new Pentamer
                {
                    FirstIndex = 79,
                    LastIndex = 83,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FQPDD",
                },
                new Pentamer
                {
                    FirstIndex = 80,
                    LastIndex = 84,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QPDDE",
                },
                new Pentamer
                {
                    FirstIndex = 81,
                    LastIndex = 85,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PDDEV",
                },
                new Pentamer
                {
                    FirstIndex = 82,
                    LastIndex = 86,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DDEVV",
                },
                new Pentamer
                {
                    FirstIndex = 83,
                    LastIndex = 87,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DEVVG",
                },
                new Pentamer
                {
                    FirstIndex = 84,
                    LastIndex = 88,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EVVGI",
                },
                new Pentamer
                {
                    FirstIndex = 85,
                    LastIndex = 89,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VVGIL",
                },
                new Pentamer
                {
                    FirstIndex = 86,
                    LastIndex = 90,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VGILP",
                },
                new Pentamer
                {
                    FirstIndex = 87,
                    LastIndex = 91,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GILPL",
                },
                new Pentamer
                {
                    FirstIndex = 88,
                    LastIndex = 92,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ILPLD",
                },
                new Pentamer
                {
                    FirstIndex = 89,
                    LastIndex = 93,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LPLDS",
                },
                new Pentamer
                {
                    FirstIndex = 90,
                    LastIndex = 94,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PLDSE",
                },
                new Pentamer
                {
                    FirstIndex = 91,
                    LastIndex = 95,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LDSED",
                },
                new Pentamer
                {
                    FirstIndex = 92,
                    LastIndex = 96,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DSEDP",
                },
                new Pentamer
                {
                    FirstIndex = 93,
                    LastIndex = 97,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SEDPG",
                },
                new Pentamer
                {
                    FirstIndex = 94,
                    LastIndex = 98,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EDPGL",
                },
                new Pentamer
                {
                    FirstIndex = 95,
                    LastIndex = 99,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DPGLC",
                },
                new Pentamer
                {
                    FirstIndex = 96,
                    LastIndex = 100,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PGLCE",
                },
                new Pentamer
                {
                    FirstIndex = 97,
                    LastIndex = 101,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GLCEV",
                },
                new Pentamer
                {
                    FirstIndex = 98,
                    LastIndex = 102,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LCEVV",
                },
                new Pentamer
                {
                    FirstIndex = 99,
                    LastIndex = 103,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "CEVVR",
                },
                new Pentamer
                {
                    FirstIndex = 100,
                    LastIndex = 104,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EVVRV",
                },
                new Pentamer
                {
                    FirstIndex = 101,
                    LastIndex = 105,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VVRVH",
                },
                new Pentamer
                {
                    FirstIndex = 102,
                    LastIndex = 106,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VRVHE",
                },
                new Pentamer
                {
                    FirstIndex = 103,
                    LastIndex = 107,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RVHEH",
                },
                new Pentamer
                {
                    FirstIndex = 104,
                    LastIndex = 108,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VHEHY",
                },
                new Pentamer
                {
                    FirstIndex = 105,
                    LastIndex = 109,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HEHYL",
                },
                new Pentamer
                {
                    FirstIndex = 106,
                    LastIndex = 110,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EHYLV",
                },
                new Pentamer
                {
                    FirstIndex = 107,
                    LastIndex = 111,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HYLVH",
                },
                new Pentamer
                {
                    FirstIndex = 108,
                    LastIndex = 112,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "YLVHK",
                },
                new Pentamer
                {
                    FirstIndex = 109,
                    LastIndex = 113,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LVHKP",
                },
                new Pentamer
                {
                    FirstIndex = 110,
                    LastIndex = 114,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VHKPE",
                },
                new Pentamer
                {
                    FirstIndex = 111,
                    LastIndex = 115,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HKPEK",
                },
                new Pentamer
                {
                    FirstIndex = 112,
                    LastIndex = 116,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KPEKV",
                },
                new Pentamer
                {
                    FirstIndex = 113,
                    LastIndex = 117,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PEKVT",
                },
                new Pentamer
                {
                    FirstIndex = 114,
                    LastIndex = 118,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EKVTW",
                },
                new Pentamer
                {
                    FirstIndex = 115,
                    LastIndex = 119,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KVTWT",
                },
                new Pentamer
                {
                    FirstIndex = 116,
                    LastIndex = 120,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VTWTE",
                },
                new Pentamer
                {
                    FirstIndex = 117,
                    LastIndex = 121,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TWTEA",
                },
                new Pentamer
                {
                    FirstIndex = 118,
                    LastIndex = 122,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "WTEAA",
                },
                new Pentamer
                {
                    FirstIndex = 119,
                    LastIndex = 123,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TEAAG",
                },
                new Pentamer
                {
                    FirstIndex = 120,
                    LastIndex = 124,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EAAGS",
                },
                new Pentamer
                {
                    FirstIndex = 121,
                    LastIndex = 125,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AAGSI",
                },
                new Pentamer
                {
                    FirstIndex = 122,
                    LastIndex = 126,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AGSIR",
                },
                new Pentamer
                {
                    FirstIndex = 123,
                    LastIndex = 127,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GSIRD",
                },
                new Pentamer
                {
                    FirstIndex = 124,
                    LastIndex = 128,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SIRDG",
                },
                new Pentamer
                {
                    FirstIndex = 125,
                    LastIndex = 129,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IRDGV",
                },
                new Pentamer
                {
                    FirstIndex = 126,
                    LastIndex = 130,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RDGVR",
                },
                new Pentamer
                {
                    FirstIndex = 127,
                    LastIndex = 131,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DGVRA",
                },
                new Pentamer
                {
                    FirstIndex = 128,
                    LastIndex = 132,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GVRAY",
                },
                new Pentamer
                {
                    FirstIndex = 129,
                    LastIndex = 133,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VRAYT",
                },
                new Pentamer
                {
                    FirstIndex = 130,
                    LastIndex = 134,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RAYTA",
                },
                new Pentamer
                {
                    FirstIndex = 131,
                    LastIndex = 135,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AYTAL",
                },
                new Pentamer
                {
                    FirstIndex = 132,
                    LastIndex = 136,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "YTALH",
                },
                new Pentamer
                {
                    FirstIndex = 133,
                    LastIndex = 137,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TALHY",
                },
                new Pentamer
                {
                    FirstIndex = 134,
                    LastIndex = 138,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ALHYL",
                },
                new Pentamer
                {
                    FirstIndex = 135,
                    LastIndex = 139,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LHYLS",
                },
                new Pentamer
                {
                    FirstIndex = 136,
                    LastIndex = 140,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HYLSH",
                },
                new Pentamer
                {
                    FirstIndex = 137,
                    LastIndex = 141,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "YLSHL",
                },
                new Pentamer
                {
                    FirstIndex = 138,
                    LastIndex = 142,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LSHLS",
                },
                new Pentamer
                {
                    FirstIndex = 139,
                    LastIndex = 143,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SHLSP",
                },
                new Pentamer
                {
                    FirstIndex = 140,
                    LastIndex = 144,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HLSPG",
                },
                new Pentamer
                {
                    FirstIndex = 141,
                    LastIndex = 145,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LSPGK",
                },
                new Pentamer
                {
                    FirstIndex = 142,
                    LastIndex = 146,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SPGKS",
                },
                new Pentamer
                {
                    FirstIndex = 143,
                    LastIndex = 147,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PGKSV",
                },
                new Pentamer
                {
                    FirstIndex = 144,
                    LastIndex = 148,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GKSVL",
                },
                new Pentamer
                {
                    FirstIndex = 145,
                    LastIndex = 149,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KSVLI",
                },
                new Pentamer
                {
                    FirstIndex = 146,
                    LastIndex = 150,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SVLIM",
                },
                new Pentamer
                {
                    FirstIndex = 147,
                    LastIndex = 151,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VLIMD",
                },
                new Pentamer
                {
                    FirstIndex = 148,
                    LastIndex = 152,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LIMDG",
                },
                new Pentamer
                {
                    FirstIndex = 149,
                    LastIndex = 153,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IMDGA",
                },
                new Pentamer
                {
                    FirstIndex = 150,
                    LastIndex = 154,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "MDGAS",
                },
                new Pentamer
                {
                    FirstIndex = 151,
                    LastIndex = 155,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DGASA",
                },
                new Pentamer
                {
                    FirstIndex = 152,
                    LastIndex = 156,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GASAF",
                },
                new Pentamer
                {
                    FirstIndex = 153,
                    LastIndex = 157,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ASAFG",
                },
                new Pentamer
                {
                    FirstIndex = 154,
                    LastIndex = 158,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SAFGT",
                },
                new Pentamer
                {
                    FirstIndex = 155,
                    LastIndex = 159,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AFGTI",
                },
                new Pentamer
                {
                    FirstIndex = 156,
                    LastIndex = 160,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FGTIA",
                },
                new Pentamer
                {
                    FirstIndex = 157,
                    LastIndex = 161,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GTIAI",
                },
                new Pentamer
                {
                    FirstIndex = 158,
                    LastIndex = 162,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TIAIQ",
                },
                new Pentamer
                {
                    FirstIndex = 159,
                    LastIndex = 163,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IAIQL",
                },
                new Pentamer
                {
                    FirstIndex = 160,
                    LastIndex = 164,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AIQLA",
                },
                new Pentamer
                {
                    FirstIndex = 161,
                    LastIndex = 165,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IQLAH",
                },
                new Pentamer
                {
                    FirstIndex = 162,
                    LastIndex = 166,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QLAHH",
                },
                new Pentamer
                {
                    FirstIndex = 163,
                    LastIndex = 167,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LAHHR",
                },
                new Pentamer
                {
                    FirstIndex = 164,
                    LastIndex = 168,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AHHRG",
                },
                new Pentamer
                {
                    FirstIndex = 165,
                    LastIndex = 169,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HHRGA",
                },
                new Pentamer
                {
                    FirstIndex = 166,
                    LastIndex = 170,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HRGAK",
                },
                new Pentamer
                {
                    FirstIndex = 167,
                    LastIndex = 171,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RGAKV",
                },
                new Pentamer
                {
                    FirstIndex = 168,
                    LastIndex = 172,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GAKVI",
                },
                new Pentamer
                {
                    FirstIndex = 169,
                    LastIndex = 173,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AKVIS",
                },
                new Pentamer
                {
                    FirstIndex = 170,
                    LastIndex = 174,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KVIST",
                },
                new Pentamer
                {
                    FirstIndex = 171,
                    LastIndex = 175,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VISTA",
                },
                new Pentamer
                {
                    FirstIndex = 172,
                    LastIndex = 176,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ISTAC",
                },
                new Pentamer
                {
                    FirstIndex = 173,
                    LastIndex = 177,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "STACS",
                },
                new Pentamer
                {
                    FirstIndex = 174,
                    LastIndex = 178,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TACSL",
                },
                new Pentamer
                {
                    FirstIndex = 175,
                    LastIndex = 179,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ACSLE",
                },
                new Pentamer
                {
                    FirstIndex = 176,
                    LastIndex = 180,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "CSLED",
                },
                new Pentamer
                {
                    FirstIndex = 177,
                    LastIndex = 181,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SLEDK",
                },
                new Pentamer
                {
                    FirstIndex = 178,
                    LastIndex = 182,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LEDKQ",
                },
                new Pentamer
                {
                    FirstIndex = 179,
                    LastIndex = 183,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EDKQC",
                },
                new Pentamer
                {
                    FirstIndex = 180,
                    LastIndex = 184,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DKQCL",
                },
                new Pentamer
                {
                    FirstIndex = 181,
                    LastIndex = 185,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KQCLE",
                },
                new Pentamer
                {
                    FirstIndex = 182,
                    LastIndex = 186,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QCLER",
                },
                new Pentamer
                {
                    FirstIndex = 183,
                    LastIndex = 187,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "CLERF",
                },
                new Pentamer
                {
                    FirstIndex = 184,
                    LastIndex = 188,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LERFR",
                },
                new Pentamer
                {
                    FirstIndex = 185,
                    LastIndex = 189,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ERFRP",
                },
                new Pentamer
                {
                    FirstIndex = 186,
                    LastIndex = 190,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RFRPP",
                },
                new Pentamer
                {
                    FirstIndex = 187,
                    LastIndex = 191,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FRPPI",
                },
                new Pentamer
                {
                    FirstIndex = 188,
                    LastIndex = 192,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RPPIA",
                },
                new Pentamer
                {
                    FirstIndex = 189,
                    LastIndex = 193,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PPIAR",
                },
                new Pentamer
                {
                    FirstIndex = 190,
                    LastIndex = 194,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PIARV",
                },
                new Pentamer
                {
                    FirstIndex = 191,
                    LastIndex = 195,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IARVI",
                },
                new Pentamer
                {
                    FirstIndex = 192,
                    LastIndex = 196,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ARVID",
                },
                new Pentamer
                {
                    FirstIndex = 193,
                    LastIndex = 197,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RVIDV",
                },
                new Pentamer
                {
                    FirstIndex = 194,
                    LastIndex = 198,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VIDVS",
                },
                new Pentamer
                {
                    FirstIndex = 195,
                    LastIndex = 199,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IDVSN",
                },
                new Pentamer
                {
                    FirstIndex = 196,
                    LastIndex = 200,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DVSNG",
                },
                new Pentamer
                {
                    FirstIndex = 197,
                    LastIndex = 201,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VSNGK",
                },
                new Pentamer
                {
                    FirstIndex = 198,
                    LastIndex = 202,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SNGKV",
                },
                new Pentamer
                {
                    FirstIndex = 199,
                    LastIndex = 203,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "NGKVH",
                },
                new Pentamer
                {
                    FirstIndex = 200,
                    LastIndex = 204,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GKVHV",
                },
                new Pentamer
                {
                    FirstIndex = 201,
                    LastIndex = 205,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KVHVA",
                },
                new Pentamer
                {
                    FirstIndex = 202,
                    LastIndex = 206,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VHVAE",
                },
                new Pentamer
                {
                    FirstIndex = 203,
                    LastIndex = 207,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HVAES",
                },
                new Pentamer
                {
                    FirstIndex = 204,
                    LastIndex = 208,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VAESC",
                },
                new Pentamer
                {
                    FirstIndex = 205,
                    LastIndex = 209,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AESCL",
                },
                new Pentamer
                {
                    FirstIndex = 206,
                    LastIndex = 210,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ESCLE",
                },
                new Pentamer
                {
                    FirstIndex = 207,
                    LastIndex = 211,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SCLEE",
                },
                new Pentamer
                {
                    FirstIndex = 208,
                    LastIndex = 212,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "CLEET",
                },
                new Pentamer
                {
                    FirstIndex = 209,
                    LastIndex = 213,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LEETG",
                },
                new Pentamer
                {
                    FirstIndex = 210,
                    LastIndex = 214,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EETGG",
                },
                new Pentamer
                {
                    FirstIndex = 211,
                    LastIndex = 215,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ETGGL",
                },
                new Pentamer
                {
                    FirstIndex = 212,
                    LastIndex = 216,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TGGLG",
                },
                new Pentamer
                {
                    FirstIndex = 213,
                    LastIndex = 217,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GGLGV",
                },
                new Pentamer
                {
                    FirstIndex = 214,
                    LastIndex = 218,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GLGVD",
                },
                new Pentamer
                {
                    FirstIndex = 215,
                    LastIndex = 219,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LGVDI",
                },
                new Pentamer
                {
                    FirstIndex = 216,
                    LastIndex = 220,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GVDIV",
                },
                new Pentamer
                {
                    FirstIndex = 217,
                    LastIndex = 221,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VDIVL",
                },
                new Pentamer
                {
                    FirstIndex = 218,
                    LastIndex = 222,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DIVLD",
                },
                new Pentamer
                {
                    FirstIndex = 219,
                    LastIndex = 223,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IVLDA",
                },
                new Pentamer
                {
                    FirstIndex = 220,
                    LastIndex = 224,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VLDAG",
                },
                new Pentamer
                {
                    FirstIndex = 221,
                    LastIndex = 225,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LDAGV",
                },
                new Pentamer
                {
                    FirstIndex = 222,
                    LastIndex = 226,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DAGVR",
                },
                new Pentamer
                {
                    FirstIndex = 223,
                    LastIndex = 227,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AGVRL",
                },
                new Pentamer
                {
                    FirstIndex = 224,
                    LastIndex = 228,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GVRLY",
                },
                new Pentamer
                {
                    FirstIndex = 225,
                    LastIndex = 229,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VRLYS",
                },
                new Pentamer
                {
                    FirstIndex = 226,
                    LastIndex = 230,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RLYSK",
                },
                new Pentamer
                {
                    FirstIndex = 227,
                    LastIndex = 231,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LYSKD",
                },
                new Pentamer
                {
                    FirstIndex = 228,
                    LastIndex = 232,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "YSKDD",
                },
                new Pentamer
                {
                    FirstIndex = 229,
                    LastIndex = 233,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SKDDE",
                },
                new Pentamer
                {
                    FirstIndex = 230,
                    LastIndex = 234,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KDDEP",
                },
                new Pentamer
                {
                    FirstIndex = 231,
                    LastIndex = 235,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DDEPA",
                },
                new Pentamer
                {
                    FirstIndex = 232,
                    LastIndex = 236,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DEPAV",
                },
                new Pentamer
                {
                    FirstIndex = 233,
                    LastIndex = 237,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EPAVK",
                },
                new Pentamer
                {
                    FirstIndex = 234,
                    LastIndex = 238,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PAVKL",
                },
                new Pentamer
                {
                    FirstIndex = 235,
                    LastIndex = 239,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AVKLQ",
                },
                new Pentamer
                {
                    FirstIndex = 236,
                    LastIndex = 240,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VKLQL",
                },
                new Pentamer
                {
                    FirstIndex = 237,
                    LastIndex = 241,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KLQLL",
                },
                new Pentamer
                {
                    FirstIndex = 238,
                    LastIndex = 242,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LQLLP",
                },
                new Pentamer
                {
                    FirstIndex = 239,
                    LastIndex = 243,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QLLPH",
                },
                new Pentamer
                {
                    FirstIndex = 240,
                    LastIndex = 244,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LLPHK",
                },
                new Pentamer
                {
                    FirstIndex = 241,
                    LastIndex = 245,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LPHKH",
                },
                new Pentamer
                {
                    FirstIndex = 242,
                    LastIndex = 246,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PHKHD",
                },
                new Pentamer
                {
                    FirstIndex = 243,
                    LastIndex = 247,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HKHDI",
                },
                new Pentamer
                {
                    FirstIndex = 244,
                    LastIndex = 248,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KHDII",
                },
                new Pentamer
                {
                    FirstIndex = 245,
                    LastIndex = 249,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HDIIT",
                },
                new Pentamer
                {
                    FirstIndex = 246,
                    LastIndex = 250,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DIITL",
                },
                new Pentamer
                {
                    FirstIndex = 247,
                    LastIndex = 251,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IITLL",
                },
                new Pentamer
                {
                    FirstIndex = 248,
                    LastIndex = 252,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ITLLG",
                },
                new Pentamer
                {
                    FirstIndex = 249,
                    LastIndex = 253,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TLLGV",
                },
                new Pentamer
                {
                    FirstIndex = 250,
                    LastIndex = 254,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LLGVG",
                },
                new Pentamer
                {
                    FirstIndex = 251,
                    LastIndex = 255,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LGVGG",
                },
                new Pentamer
                {
                    FirstIndex = 252,
                    LastIndex = 256,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GVGGH",
                },
                new Pentamer
                {
                    FirstIndex = 253,
                    LastIndex = 257,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VGGHW",
                },
                new Pentamer
                {
                    FirstIndex = 254,
                    LastIndex = 258,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GGHWV",
                },
                new Pentamer
                {
                    FirstIndex = 255,
                    LastIndex = 259,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GHWVT",
                },
                new Pentamer
                {
                    FirstIndex = 256,
                    LastIndex = 260,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HWVTT",
                },
                new Pentamer
                {
                    FirstIndex = 257,
                    LastIndex = 261,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "WVTTE",
                },
                new Pentamer
                {
                    FirstIndex = 258,
                    LastIndex = 262,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VTTEE",
                },
                new Pentamer
                {
                    FirstIndex = 259,
                    LastIndex = 263,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TTEEN",
                },
                new Pentamer
                {
                    FirstIndex = 260,
                    LastIndex = 264,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TEENL",
                },
                new Pentamer
                {
                    FirstIndex = 261,
                    LastIndex = 265,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EENLQ",
                },
                new Pentamer
                {
                    FirstIndex = 262,
                    LastIndex = 266,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ENLQL",
                },
                new Pentamer
                {
                    FirstIndex = 263,
                    LastIndex = 267,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "NLQLD",
                },
                new Pentamer
                {
                    FirstIndex = 264,
                    LastIndex = 268,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LQLDP",
                },
                new Pentamer
                {
                    FirstIndex = 265,
                    LastIndex = 269,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QLDPP",
                },
                new Pentamer
                {
                    FirstIndex = 266,
                    LastIndex = 270,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LDPPD",
                },
                new Pentamer
                {
                    FirstIndex = 267,
                    LastIndex = 271,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DPPDS",
                },
                new Pentamer
                {
                    FirstIndex = 268,
                    LastIndex = 272,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PPDSH",
                },
                new Pentamer
                {
                    FirstIndex = 269,
                    LastIndex = 273,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PDSHC",
                },
                new Pentamer
                {
                    FirstIndex = 270,
                    LastIndex = 274,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DSHCL",
                },
                new Pentamer
                {
                    FirstIndex = 271,
                    LastIndex = 275,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SHCLF",
                },
                new Pentamer
                {
                    FirstIndex = 272,
                    LastIndex = 276,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "HCLFL",
                },
                new Pentamer
                {
                    FirstIndex = 273,
                    LastIndex = 277,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "CLFLK",
                },
                new Pentamer
                {
                    FirstIndex = 274,
                    LastIndex = 278,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LFLKG",
                },
                new Pentamer
                {
                    FirstIndex = 275,
                    LastIndex = 279,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FLKGA",
                },
                new Pentamer
                {
                    FirstIndex = 276,
                    LastIndex = 280,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LKGAT",
                },
                new Pentamer
                {
                    FirstIndex = 277,
                    LastIndex = 281,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KGATL",
                },
                new Pentamer
                {
                    FirstIndex = 278,
                    LastIndex = 282,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GATLA",
                },
                new Pentamer
                {
                    FirstIndex = 279,
                    LastIndex = 283,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ATLAF",
                },
                new Pentamer
                {
                    FirstIndex = 280,
                    LastIndex = 284,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TLAFL",
                },
                new Pentamer
                {
                    FirstIndex = 281,
                    LastIndex = 285,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LAFLN",
                },
                new Pentamer
                {
                    FirstIndex = 282,
                    LastIndex = 286,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AFLND",
                },
                new Pentamer
                {
                    FirstIndex = 283,
                    LastIndex = 287,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FLNDE",
                },
                new Pentamer
                {
                    FirstIndex = 284,
                    LastIndex = 288,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LNDEV",
                },
                new Pentamer
                {
                    FirstIndex = 285,
                    LastIndex = 289,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "NDEVW",
                },
                new Pentamer
                {
                    FirstIndex = 286,
                    LastIndex = 290,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DEVWN",
                },
                new Pentamer
                {
                    FirstIndex = 287,
                    LastIndex = 291,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EVWNL",
                },
                new Pentamer
                {
                    FirstIndex = 288,
                    LastIndex = 292,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VWNLS",
                },
                new Pentamer
                {
                    FirstIndex = 289,
                    LastIndex = 293,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "WNLSN",
                },
                new Pentamer
                {
                    FirstIndex = 290,
                    LastIndex = 294,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "NLSNV",
                },
                new Pentamer
                {
                    FirstIndex = 291,
                    LastIndex = 295,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LSNVQ",
                },
                new Pentamer
                {
                    FirstIndex = 292,
                    LastIndex = 296,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SNVQQ",
                },
                new Pentamer
                {
                    FirstIndex = 293,
                    LastIndex = 297,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "NVQQG",
                },
                new Pentamer
                {
                    FirstIndex = 294,
                    LastIndex = 298,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VQQGK",
                },
                new Pentamer
                {
                    FirstIndex = 295,
                    LastIndex = 299,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QQGKY",
                },
                new Pentamer
                {
                    FirstIndex = 296,
                    LastIndex = 300,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QGKYL",
                },
                new Pentamer
                {
                    FirstIndex = 297,
                    LastIndex = 301,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GKYLC",
                },
                new Pentamer
                {
                    FirstIndex = 298,
                    LastIndex = 302,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KYLCI",
                },
                new Pentamer
                {
                    FirstIndex = 299,
                    LastIndex = 303,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "YLCIL",
                },
                new Pentamer
                {
                    FirstIndex = 300,
                    LastIndex = 304,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LCILK",
                },
                new Pentamer
                {
                    FirstIndex = 301,
                    LastIndex = 305,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "CILKD",
                },
                new Pentamer
                {
                    FirstIndex = 302,
                    LastIndex = 306,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "ILKDV",
                },
                new Pentamer
                {
                    FirstIndex = 303,
                    LastIndex = 307,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LKDVM",
                },
                new Pentamer
                {
                    FirstIndex = 304,
                    LastIndex = 308,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KDVME",
                },
                new Pentamer
                {
                    FirstIndex = 305,
                    LastIndex = 309,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DVMEK",
                },
                new Pentamer
                {
                    FirstIndex = 306,
                    LastIndex = 310,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VMEKL",
                },
                new Pentamer
                {
                    FirstIndex = 307,
                    LastIndex = 311,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "MEKLS",
                },
                new Pentamer
                {
                    FirstIndex = 308,
                    LastIndex = 312,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EKLST",
                },
                new Pentamer
                {
                    FirstIndex = 309,
                    LastIndex = 313,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KLSTG",
                },
                new Pentamer
                {
                    FirstIndex = 310,
                    LastIndex = 314,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LSTGV",
                },
                new Pentamer
                {
                    FirstIndex = 311,
                    LastIndex = 315,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "STGVF",
                },
                new Pentamer
                {
                    FirstIndex = 312,
                    LastIndex = 316,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "TGVFR",
                },
                new Pentamer
                {
                    FirstIndex = 313,
                    LastIndex = 317,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GVFRP",
                },
                new Pentamer
                {
                    FirstIndex = 314,
                    LastIndex = 318,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VFRPQ",
                },
                new Pentamer
                {
                    FirstIndex = 315,
                    LastIndex = 319,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "FRPQL",
                },
                new Pentamer
                {
                    FirstIndex = 316,
                    LastIndex = 320,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RPQLD",
                },
                new Pentamer
                {
                    FirstIndex = 317,
                    LastIndex = 321,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PQLDE",
                },
                new Pentamer
                {
                    FirstIndex = 318,
                    LastIndex = 322,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QLDEP",
                },
                new Pentamer
                {
                    FirstIndex = 319,
                    LastIndex = 323,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LDEPI",
                },
                new Pentamer
                {
                    FirstIndex = 320,
                    LastIndex = 324,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "DEPIP",
                },
                new Pentamer
                {
                    FirstIndex = 321,
                    LastIndex = 325,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EPIPL",
                },
                new Pentamer
                {
                    FirstIndex = 322,
                    LastIndex = 326,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PIPLY",
                },
                new Pentamer
                {
                    FirstIndex = 323,
                    LastIndex = 327,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "IPLYE",
                },
                new Pentamer
                {
                    FirstIndex = 324,
                    LastIndex = 328,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "PLYEA",
                },
                new Pentamer
                {
                    FirstIndex = 325,
                    LastIndex = 329,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "LYEAK",
                },
                new Pentamer
                {
                    FirstIndex = 326,
                    LastIndex = 330,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "YEAKV",
                },
                new Pentamer
                {
                    FirstIndex = 327,
                    LastIndex = 331,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EAKVS",
                },
                new Pentamer
                {
                    FirstIndex = 328,
                    LastIndex = 332,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AKVSM",
                },
                new Pentamer
                {
                    FirstIndex = 329,
                    LastIndex = 333,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KVSME",
                },
                new Pentamer
                {
                    FirstIndex = 330,
                    LastIndex = 334,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VSMEA",
                },
                new Pentamer
                {
                    FirstIndex = 331,
                    LastIndex = 335,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "SMEAV",
                },
                new Pentamer
                {
                    FirstIndex = 332,
                    LastIndex = 336,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "MEAVQ",
                },
                new Pentamer
                {
                    FirstIndex = 333,
                    LastIndex = 337,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "EAVQK",
                },
                new Pentamer
                {
                    FirstIndex = 334,
                    LastIndex = 338,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "AVQKN",
                },
                new Pentamer
                {
                    FirstIndex = 335,
                    LastIndex = 339,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "VQKNQ",
                },
                new Pentamer
                {
                    FirstIndex = 336,
                    LastIndex = 340,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QKNQG",
                },
                new Pentamer
                {
                    FirstIndex = 337,
                    LastIndex = 341,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KNQGR",
                },
                new Pentamer
                {
                    FirstIndex = 338,
                    LastIndex = 342,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "NQGRK",
                },
                new Pentamer
                {
                    FirstIndex = 339,
                    LastIndex = 343,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "QGRKK",
                },
                new Pentamer
                {
                    FirstIndex = 340,
                    LastIndex = 344,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "GRKKQ",
                },
                new Pentamer
                {
                    FirstIndex = 341,
                    LastIndex = 345,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "RKKQV",
                },
                new Pentamer
                {
                    FirstIndex = 342,
                    LastIndex = 346,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KKQVV",
                },
                new Pentamer
                {
                    FirstIndex = 343,
                    LastIndex = 347,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
                    Sequence = "KQVVQ",
                },
                new Pentamer
                {
                    FirstIndex = 344,
                    LastIndex = 348,
                    ProteinName = "QORL1_HUMAN",
                    ProteinGI = 95825,
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

            };

            ListOfProteins = new List<Protein>
            {
                 new Protein
                 {
                   ProteinName = "QORL1_HUMAN",
                   ProteinGI = 95825,
                   Sequence ="MKGLYFQQSSTDEEITFVFQEKEDLPVTEDNFVKLQVKACALSQINTKLLAEMKMKKDLFPVGREIAGIVLDVGSKVSFFQPDDEVVGILPLDSEDPGLCEVVRVHEHYLVHKPEKVTWTEAAGSIRDGVRAYTALHYLSHLSPGKSVLIMDGASAFGTIAIQLAHHRGAKVISTACSLEDKQCLERFRPPIARVIDVSNGKVHVAESCLEETGGLGVDIVLDAGVRLYSKDDEPAVKLQLLPHKHDIITLLGVGGHWVTTEENLQLDPPDSHCLFLKGATLAFLNDEVWNLSNVQQGKYLCILKDVMEKLSTGVFRPQLDEPIPLYEAKVSMEAVQKNQGRKKQVVQF"
                 },
                 new Protein
                 {
                   ProteinName = "RP3A_HUMAN",
                   //ProteinGI = 95825,
                   Sequence ="MTDTVFSNSSNRWMYPSDRPLQSNDKEQLQAGWSVHPGGQPDRQRKQEELTDEEKEIINRVIARAEKMEEMEQERIGRLVDRLENMRKNVAGDGVNRCILCGEQLGMLGSACVVCEDCKKNVCTKCGVETNNRLHSVWLCKICIEQREVWKRSGAWFFKGFPKQVLPQPMPIKKTKPQQPVSEPAAPEQPAPEPKHPARAPARGDSEDRRGPGQKTGPDPASAPGRGNYGPPVRRASEARMSSSSRDSESWDHSGGAGDSSRSPAGLRRANSVQASRPAPGSVQSPAPPQPGQPGTPGGSRPGPGPAGRFPDQKPEVAPSDPGTTAPPREERTGGVGGYPAVGAREDRMSHPSGPYSQASAAAPQPAAARQPPPPEEEEEEANSYDSDEATTLGALEFSLLYDQDNSSLQCTIIKAKGLKPMDSNGLADPYVKLHLLPGASKSNKLRTKTLRNTRNPIWNETLVYHGITDEDMQRKTLRISVCDEDKFGHNEFIGETRFSLKKLKPNQRKNFNICLERVIPMKRAGTTGSARGMALYEEEQVERVGDIEERGKILVSLMYSTQQGGLIVGIIRCVHLAAMDANGYSDPFVKLWLKPDMGKKAKHKTQIKKKTLNPEFNEEFFYDIKHSDLAKKSLDISVWDYDIGKSNDYIGGCQLGISAKGERLKHWYECLKNKDKKIERWHQLQNENHVSSD"
                 },
             };
        }
    }
}


