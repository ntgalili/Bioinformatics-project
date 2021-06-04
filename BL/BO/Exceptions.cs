using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DO;

namespace BO
{
    [Serializable]
    public class BadProteinException : Exception
    {
        public string str1;
        public int IG;
        public string str2;
        public BadProteinException(string message, Exception innerException) :
            base(message, innerException) => IG = ((DO.BadProteinException)innerException).IG;
        public BadProteinException(string s1, string message) :
            base(message) => str1 = s1;

        public override string ToString() => base.ToString() + $",  Bad Protein IG: {IG}";
   
    }
    
    public class BadPentamerProteinNameException : Exception
    {
        public string ProteinName;
        public BadPentamerProteinNameException(string message, Exception innerException) :
                base(message, innerException) => ProteinName = ((DO.BadPentamerProteinNameException)innerException).ProteinName;

         
        public override string ToString() => base.ToString() + $", bad Virtual Sequence Sequence: {ProteinName} ";
    }
    
    public class BadPentamerProteinGIException : Exception
    {
        public string ProteinGI;
        public BadPentamerProteinGIException(string message, Exception innerException) :
            base(message, innerException) => ProteinGI = ((DO.BadPentamerProteinGIException)innerException).ProteinGI;
        
        public override string ToString() => base.ToString() + $",bad Virtual Sequence Sequence: {ProteinGI}";
    }
    public class BadPentamerProteinSequenceException : Exception
    {
        public string ProteinSequence;
        public BadPentamerProteinSequenceException(string message, Exception innerException) : base(message, innerException) => ProteinSequence = ((DO.BadPentamerProteinSequenceException)innerException).ProteinSequence;
        public override string ToString() => base.ToString() + $", bad Virtual Sequence Sequence: {ProteinSequence} ";
    }

    public class BadPentamerException : Exception
    {
        public BadPentamerException(string message, Exception ex) : base() { }
        public override string ToString() => base.ToString() + $", bad Pentamer";
    }
    //[Serializable]
    //public class BadStudentIdCourseIDException : Exception
    //{
    //    public int personID;
    //    public int courseID;
    //    public BadStudentIdCourseIDException(string message, Exception innerException) :
    //        base(message, innerException)
    //    {
    //        personID = ((DO.BadPersonIdCourseIDException)innerException).personID;
    //        courseID = ((DO.BadPersonIdCourseIDException)innerException).courseID;
    //    }
    //    public override string ToString() => base.ToString() + $", bad student id: {personID} and course ID: {courseID}";
    //}

    public class BadVirtualSequenceException : Exception
    {
        public BadVirtualSequenceException(string message1, Exception message2) : base() { }
        public override string ToString() => base.ToString() + $", bad Pentamer";
    }
    
}

