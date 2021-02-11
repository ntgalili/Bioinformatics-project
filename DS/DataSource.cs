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
        }
    }
}


