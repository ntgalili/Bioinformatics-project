using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "MKGLYFQQSSTDEEITFVFQEKEDLPVTEDNFVKLQVKACALSQINTKLLAEMKMKKDLFPVGREIAGIVLDVGSKVSFFQPDDEVVGILPLDSEDPGLCEVVRVHEHYLVHKPEKVTWTEAAGSIRDGVRAYTALHYLSHLSPGKSVLIMDGASAFGTIAIQLAHHRGAKVISTACSLEDKQCLERFRPPIARVIDVSNGKVHVAESCLEETGGLGVDIVLDAGVRLYSKDDEPAVKLQLLPHKHDIITLLGVGGHWVTTEENLQLDPPDSHCLFLKGATLAFLNDEVWNLSNVQQGKYLCILKDVMEKLSTGVFRPQLDEPIPLYEAKVSMEAVQKNQGRKKQVVQF";
            for (int i = 0; i < str.Length - 4; i++)
            {
                Console.WriteLine("new Pentamer");
                Console.WriteLine("{");
                Console.WriteLine("  FirstIndex=" + i+",");
                Console.WriteLine("  LastIndex=" + (i + 4)+",");
                Console.WriteLine("  ProteinName =  \"QORL1_HUMAN\" "+",");
                Console.WriteLine("  ProteinGI = 95825"+",");
                Console.WriteLine("  Sequence =\"" + str.Substring(i, 5)+"\""+",");
                Console.WriteLine("},");
            }

            Console.ReadKey();
        }
    }
}