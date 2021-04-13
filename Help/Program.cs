using DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLAPI;
namespace Help
{
    class Program
    {

        static void Main(string[] args)
        {
            IDL dl = DLFactory.GetDL();
            //DO.Protein p = new DO.Protein();

            //string strseq, strname, strGi;

            //for (int i = 0; i < 5; i++)
            //{
            //    strname = Console.ReadLine();
            //    strGi = Console.ReadLine();
            //    strseq = Console.ReadLine();

            //    p.ProteinGI = strGi;
            //    p.ProteinName = strname;
            //    p.Sequence = strseq;
            //    dl.AddProtein(p);
            //}

            DO.Pentamer pent = new DO.Pentamer();
            //foreach (DO.Protein p in dl.GetALLProtein())
            //{
            //try
            //{
            //    dl.GetPentamerByProteinGI(p.ProteinGI);
            //}
            //catch
            //{ 



            //-----------------------------------
            //DO.Protein p = dl.GetALLProtein().ToList()[12];
            //        for (int i = 0; i < p.Sequence.Length - 4; i++)
            //        {
            //            pent.Sequence = p.Sequence.Substring(i, 5);
            //            pent.ProteinName = p.ProteinName;
            //            pent.ProteinGI = p.ProteinGI;
            //            pent.FirstIndex = i;
            //            pent.LastIndex = i + 4;
            //            dl.AddPentamer(pent);
            //        }





            //-----------------------------
            DO.VirtualSequence V = new DO.VirtualSequence();
            foreach(DO.Pentamer p in dl.GetAllPentamer())
            {
                try
                {
                    V.Sequence = p.Sequence;
                    V.Size = 5;
                    dl.AddVirtualSequence(V);
                }
                catch { }
            }







            //}




            //string str = "MDTDSQRSHLSSFTMKLMDKFHSPKIKRTPSKKGKPAEVSVKIPEKPVNKEATDRFLPEGYPLPLDLEQQAVEFMSTSAVASRSQRQKNLSWLEEKEKEVVSALRYFKTIVDKMAIDKKVLEMLPGSASKVLEAILPLVQNDPRIQHSSALSSCYSRVYQSLANLIRWSDQVMLEGVNSEDKEMVTTVKGVIKAVLDGVKELVRLTIEKQGRPSPTSPVKPSSPASKPDGPAELPLTDREVEILNKTTGMSQSTELLPDATDEEVAPPKPPLPGIRVVDNSPPPALPPKKRQSAPSPTRVAVVAPMSRATSGSSLPVGINRQDFDVDCYAQRRLSGGSHSYGGESPRLSPCSSIGKLSKSDEQLSSLDRDSGQCSRNTSCETLDHYDPDYEFLQQDLSNADQIPQQTAWNLSPLPESLGESGSPFLGPPFQLPLGGHPQPDGPLAPGQQTDTPPALPEKKRRSAASQTADGSGCRVSYERHPSQYDNISGEDLQSTAPIPSVPYAPFAAILPFQHGGSSAPVEFVGDFTAPESTGDPEKPPPLPEKKNKHMLAYMQLLEDYSEPQPSMFYQTPQNEHIYQQKNKLLMEVYGFSDSFSGVDSVQELAPPPALPPKQRQLEPPAGKDGHPRDPSAVSGVPGKDSRDGSERAPKSPDALESAQSEEEVDELSLIDHNEIMSRLTLKQEGDDGPDVRGGSGDILLVHATETDRKDLVLYCEAFLTTYRTFISPEELIKKLQYRYEKFSPFADTFKKRVSKNTFFVLVRVVDELCLVELTEEILKLLMELVFRLVCNGELSLARVLRKNILDKVDQKKLLRCATSSQPLAARGVAARPGTLHDFHSHEIAEQLTLLDAELFYKIEIPEVLLWAKEQNEEKSPNLTQFTEHFNNMSYWVRSIIMLQEKAQDRERLLLKFIKIMKHLRKLNNFNSYLAILSALDSAPIRRLEWQKQTSEGLAEYCTLIDSSSSFRAYRAALSEVEPPCIPYLGLILQDLTFVHLGNPDYIDGKVNFSKRWQQFNILDSMRCFQQAHYDMRRNDDIINFFNDFSDHLAEEALWELSLKIKPRNITRRKTDREEKT";
            //for (int i = 0; i < str.Length-4; i++)
            //{
            //    Console.WriteLine("             new Pentamer");
            //    Console.WriteLine("              {");
            //    Console.WriteLine("                 FirstIndex=" + i + ",");
            //    Console.WriteLine("                 LastIndex=" + (i + 4) + ",");
            //    Console.WriteLine("                 ProteinName =  \"RPGF1_HUMAN \" " + ",");
            //    Console.WriteLine("                 ProteinGI = \"13905\"" + ",");
            //    Console.WriteLine("                 Sequence =\"" + str.Substring(i, 5) + "\"" + ",");
            //    Console.WriteLine("            },");
            //}

        }
        //static void Main(string[] args)
        //{
        //    List<DO.VirtualSequence> listS = DataSource.ListOfVS;
        //    List<DO.VirtualSequence> listS2 = new List<DO.VirtualSequence>();
        //    //foreach (DO.Pentamer item in DataSource.ListOfPentamers)
        //    //{
        //    //    if (listS.Find(s => item.Sequence == s) == null)
        //    //    {
        //    //        listS.Add(item.Sequence);
        //    //    }
        //    //}
        //    //foreach(string item in listS)
        //    //{
        //    //    Console.WriteLine("            new VirtualSequence");
        //    //    Console.WriteLine("            {");
        //    //    Console.WriteLine($"                 Sequence={item}");
        //    //    Console.WriteLine($"                 Size={ item.Length}");
        //    //    Console.WriteLine("            },");
        //    //}
        //    //List<string> listS = new List<string>();
        //    string str = "MDTDSQRSHLSSFTMKLMDKFHSPKIKRTPSKKGKPAEVSVKIPEKPVNKEATDRFLPEGYPLPLDLEQQAVEFMSTSAVASRSQRQKNLSWLEEKEKEVVSALRYFKTIVDKMAIDKKVLEMLPGSASKVLEAILPLVQNDPRIQHSSALSSCYSRVYQSLANLIRWSDQVMLEGVNSEDKEMVTTVKGVIKAVLDGVKELVRLTIEKQGRPSPTSPVKPSSPASKPDGPAELPLTDREVEILNKTTGMSQSTELLPDATDEEVAPPKPPLPGIRVVDNSPPPALPPKKRQSAPSPTRVAVVAPMSRATSGSSLPVGINRQDFDVDCYAQRRLSGGSHSYGGESPRLSPCSSIGKLSKSDEQLSSLDRDSGQCSRNTSCETLDHYDPDYEFLQQDLSNADQIPQQTAWNLSPLPESLGESGSPFLGPPFQLPLGGHPQPDGPLAPGQQTDTPPALPEKKRRSAASQTADGSGCRVSYERHPSQYDNISGEDLQSTAPIPSVPYAPFAAILPFQHGGSSAPVEFVGDFTAPESTGDPEKPPPLPEKKNKHMLAYMQLLEDYSEPQPSMFYQTPQNEHIYQQKNKLLMEVYGFSDSFSGVDSVQELAPPPALPPKQRQLEPPAGKDGHPRDPSAVSGVPGKDSRDGSERAPKSPDALESAQSEEEVDELSLIDHNEIMSRLTLKQEGDDGPDVRGGSGDILLVHATETDRKDLVLYCEAFLTTYRTFISPEELIKKLQYRYEKFSPFADTFKKRVSKNTFFVLVRVVDELCLVELTEEILKLLMELVFRLVCNGELSLARVLRKNILDKVDQKKLLRCATSSQPLAARGVAARPGTLHDFHSHEIAEQLTLLDAELFYKIEIPEVLLWAKEQNEEKSPNLTQFTEHFNNMSYWVRSIIMLQEKAQDRERLLLKFIKIMKHLRKLNNFNSYLAILSALDSAPIRRLEWQKQTSEGLAEYCTLIDSSSSFRAYRAALSEVEPPCIPYLGLILQDLTFVHLGNPDYIDGKVNFSKRWQQFNILDSMRCFQQAHYDMRRNDDIINFFNDFSDHLAEEALWELSLKIKPRNITRRKTDREEKT";
        //    for (int i = 0; i < str.Length - 4; i++)
        //    {
        //        bool flag = true;
        //        foreach (DO.VirtualSequence item in listS)
        //        {
        //            if (item.Sequence == str.Substring(i, 5))
        //                flag = false; ;
        //        }
        //        if (flag)
        //        {
        //            listS2.Add(new DO.VirtualSequence { Sequence = str.Substring(i, 5), Size = 5 });
        //            listS.Add(new DO.VirtualSequence { Sequence = str.Substring(i, 5), Size = 5 });
        //        }

        //    }
        //    foreach (DO.VirtualSequence item in listS2)
        //    {
        //        Console.WriteLine("            new VirtualSequence");
        //        Console.WriteLine("            {");
        //        Console.WriteLine($"                 Sequence=\"" + item.Sequence + "\",");
        //        Console.WriteLine($"                 Size=" + 5 + ",");
        //        Console.WriteLine("                     },");
        //    }
        //    Console.ReadKey();
        //}

    }
}

