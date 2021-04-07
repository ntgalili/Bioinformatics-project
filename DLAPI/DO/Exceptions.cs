using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    [Serializable]
    //public class BadPersonIdException : Exception
    //{
    //    public int ID;
    //    public BadPersonIdException(int id) : base() => ID = id;
    //    public BadPersonIdException(int id, string message) : 
    //        base(message) => ID = id;
    //    public BadPersonIdException(int id, string message, Exception innerException) : 
    //        base(message, innerException) => ID = id;
      
    //    public override string ToString() => base.ToString() + $", bad person id: {ID}";
    //}

    public class BadProteinException : Exception
    {
        public string str1;
        public int IG;
        public string str2;
        public BadProteinException(string s1, string message): base() { str1 = s1;}
        public BadProteinException(string s1, string s2, string message) : base() { str1 = s1; str2 = s2; }
        public BadProteinException(int num, string message) : base() { IG = num; }
        //public BadProteinException(int perID, int crsID, string message) :
        //    base(message) { personID = perID; courseID = crsID; }
        //public BadProteinException(int perID, int crsID, string message, Exception innerException) :
        //    base(message, innerException) { personID = perID; courseID = crsID; }
        public override string ToString() => base.ToString() + $", bad protein : {str1} {str2}";
    }
    

    public class BadVirtualSequenceException : Exception
    {
        public string sequence;
        public BadVirtualSequenceException(string Sequence, string message) : base() { Sequence = sequence;}
        //public BadVirtualSequenceException(int perID, int crsID, string message) :
        //    base(message) { personID = perID; courseID = crsID; }
        //public BadVirtualSequenceException(int perID, int crsID, string message, Exception innerException) :
        //    base(message, innerException) { personID = perID; courseID = crsID; }

        public override string ToString() => base.ToString() + $", bad Virtual Sequence Sequence: {sequence} ";
    }

    public class BadPentamerProteinGIException : Exception
    {
        public string ProteinGI;
        public BadPentamerProteinGIException(string Proteingi, string message) : base() { ProteinGI = Proteingi; }
        public override string ToString() => base.ToString() + $", bad Virtual Sequence Sequence: {ProteinGI} ";
    }
    public class BadPentamerProteinNameException : Exception
    {
        public string ProteinName;
        public BadPentamerProteinNameException(string Proteinname, string message) : base() { ProteinName = Proteinname; }
        public override string ToString() => base.ToString() + $", bad Virtual Sequence Sequence: {ProteinName} ";
    }
    public class BadPentamerProteinSequenceException : Exception
    {
        public string ProteinSequence;
        public BadPentamerProteinSequenceException(string Proteinsequence, string message) : base() { ProteinSequence = Proteinsequence; }
        public override string ToString() => base.ToString() + $", bad Virtual Sequence Sequence: {ProteinSequence} ";
    }
    
    public class BadPentamerException : Exception
    {
        public BadPentamerException(string message) : base() {}
        public override string ToString() => base.ToString() + $", bad Pentamer";
    }
    public class XMLFileLoadCreateException : Exception
    {

        public XMLFileLoadCreateException(int c, string message) : base(message) { }
        public XMLFileLoadCreateException(string filePath, string message, Exception innerException) :
            base(message, innerException)
        { }
        public override string ToString() => base.ToString();
    }
}
