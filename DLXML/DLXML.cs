using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DLAPI;
using DO;
//using DO;

namespace DL
{
    sealed class DLXML : IDL    //internal
    {
        #region singelton
        static readonly DLXML instance = new DLXML();
        static DLXML() { }// static ctor to ensure instance init is done just before first usage
        DLXML() { } // default => private
        public static DLXML Instance { get => instance; }// The public Instance property to use
        #endregion

        #region DS XML Files
        string ListPentamersPath = @"ListOfPentamersXml.xml"; //XMLSerializer
        string ListProteinsPath = @"ListOfProteinsXml.xml"; //XMLSerializer
        string ListVirthualSequencesPath = @"ListOfVSXml.xml"; //XMLSerializer
        #endregion

        #region Protein

        DO.Protein fromXmlToProtein(XElement element)
        {
            return new Protein
            {
                ProteinGI = (element.Element("ProteinGI").Value),
                ProteinName = (element.Element("ProteinName").Value),
            };
        }

        /// <summary>
        /// return Adjacent Stations
        /// </summary>
        /// <param name="numS1">code of station 1</param>
        /// <param name="numS2">code of station 2</param>
        /// <returns></returns>
        public DO.Protein GetProtein(string ProteinGI, string ProteinName)
        {
            XElement ListProteins = XMLTool.LoadListFromXMLElement(ListProteinsPath);
            XElement protein = (from s in ListProteins.Elements()    //find Adjacent Stations with this stations in the collection of Adjacent Stations
                            where (s.Element("ProteinGI").Value) == ProteinGI && (s.Element("ProteinName").Value) == ProteinName
                            select s).FirstOrDefault();

            if (protein != null) //if the Adjacent Stations is found
                return fromXmlToProtein(protein);
            else //if the Adjacent Stations not found
                throw new BadProteinException(ProteinGI, ProteinName, "Not found");
        }
        public DO.Protein GetProteinBySequence(string sequence)
        {
            XElement ListProteins = XMLTool.LoadListFromXMLElement(ListProteinsPath);
            XElement protein = (from s in ListProteins.Elements()    //find Adjacent Stations with this stations in the collection of Adjacent Stations
                                where (s.Element("Sequence").Value) == sequence
                                select s).FirstOrDefault();

            if (protein != null) //if the Adjacent Stations is found
                return fromXmlToProtein(protein);
            else //if the Adjacent Stations not found
                throw new BadProteinException(sequence, "Not found");
        }
        public DO.Protein GetProteinByName(string name)
        {
            XElement ListProteins = XMLTool.LoadListFromXMLElement(ListProteinsPath);
            XElement protein = (from s in ListProteins.Elements()    //find Adjacent Stations with this stations in the collection of Adjacent Stations
                                where (s.Element("ProteinName").Value) == name
                                select s).FirstOrDefault();

            if (protein != null) //if the Adjacent Stations is found
                return fromXmlToProtein(protein);
            else //if the Adjacent Stations not found
                throw new BadProteinException(name, "Not found");
        }
        public DO.Protein GetProteinByGI(int numOfGI)
        {
            XElement ListProteins = XMLTool.LoadListFromXMLElement(ListProteinsPath);
            XElement protein = (from s in ListProteins.Elements()    //find Adjacent Stations with this stations in the collection of Adjacent Stations
                                where int.Parse(s.Element("ProteinGI").Value) == numOfGI
                                select s).FirstOrDefault();

            if (protein != null) //if the Adjacent Stations is found
                return fromXmlToProtein(protein);
            else //if the Adjacent Stations not found
                throw new BadProteinException(numOfGI, "Not found");
        }
        /// <summary>
        /// add Adjacent Stations
        /// </summary>
        /// <param name="adj">Adjacent Stations to add</param>
        public void AddProtein(DO.Protein protein)
        {
            XElement ListProteins = XMLTool.LoadListFromXMLElement(ListProteinsPath);
            XElement find = (from s in ListProteins.Elements()    //find Adjacent Stations with this stations in the collection of Adjacent Stations
                             where s.Element("ProteinGI").Value == protein.ProteinGI && s.Element("ProteinName").Value == protein.ProteinName
                             select s).FirstOrDefault();
            if (find != null) //If we already have such Adjacent Stations in the list of Adjacent Stations
                throw new BadProteinException(protein.ProteinGI, protein.ProteinName, "Duplicate protein");
            XElement toAdd = new XElement("Protein",
                                  new XElement("ProteinGI", protein.ProteinGI),
                                  new XElement("ProteinName", protein.ProteinName),
                                  new XElement("Sequence", protein.Sequence));

            ListProteins.Add(toAdd);//add Adjacent Stations to the collection of all Adjacent Stations
            XMLTool.SaveListToXMLElement(ListProteins, ListProteinsPath);
        }

        /// <summary>
        /// delete Adjacent Stations
        /// </summary>
        /// <param name="numS2">code of station 1</param>
        /// <param name="numS1">code of station 2</param>
        public void DeleteProtein(string ProteinGI, string ProteinName)
        {
            XElement ListProtein = XMLTool.LoadListFromXMLElement(ListProteinsPath);
            XElement find = (from s in ListProtein.Elements()    //find Adjacent Stations with this stations in the collection of Adjacent Stations
                             where (s.Element("ProteinGI").Value) == ProteinGI && (s.Element("ProteinName").Value) == ProteinName
                             select s).FirstOrDefault();
            if (find == null) //If we already have such Adjacent Stations in the list of Adjacent Stations
                throw new BadProteinException(ProteinGI, ProteinName, "Not found");
            XMLTool.SaveListToXMLElement(ListProtein, ListProteinsPath);
        }
        /// <summary>
        /// return all Adjacent Stations by this code station
        /// </summary>
        /// <param name="code">code of station</param>
        /// <returns>a collection of all Adjacent Stations with this code station</returns>
        public IEnumerable<DO.Protein> GetALLProtein()
        {

            List<DO.Protein> ListProtein = XMLTool.LoadListFromXMLSerializer<DO.Protein>(ListProteinsPath);
            return from p in ListProtein
                   select p;
        }


      

        #endregion

        #region VirtualSequence


        public DO.VirtualSequence fromXmlToVirtualSequence(XElement element)
        {
            return new VirtualSequence
            {
                Sequence = (element.Element("Sequence").Value),
                Size = Int32.Parse(element.Element("Size").Value),
            };
        }

        /// <summary>
        /// return Adjacent Stations
        /// </summary>
        /// <param name="numS1">code of station 1</param>
        /// <param name="numS2">code of station 2</param>
        /// <returns></returns>
        public DO.VirtualSequence GetVirtualSequence(string Sequence)
        {
            XElement ListVirtualSequences = XMLTool.LoadListFromXMLElement(ListVirthualSequencesPath);
            XElement VirtualSequence = (from s in ListVirtualSequences.Elements()    //find Adjacent Stations with this stations in the collection of Adjacent Stations
                                where (s.Element("Sequence").Value) == Sequence
                                select s).FirstOrDefault();
            if (VirtualSequence != null) //if the Adjacent Stations is found
                return fromXmlToVirtualSequence(VirtualSequence);
            else //if the Adjacent Stations not found
                throw new BadVirtualSequenceException(Sequence, "Not found");
        }

        /// <summary>
        /// add Adjacent Stations
        /// </summary>
        /// <param name="adj">Adjacent Stations to add</param>
        public void AddVirtualSequence(DO.VirtualSequence VirtualSequence)
        {
            XElement ListVirtualSequences = XMLTool.LoadListFromXMLElement(ListVirthualSequencesPath);
            XElement find = (from s in ListVirtualSequences.Elements()    //find Adjacent Stations with this stations in the collection of Adjacent Stations
                             where (s.Element("Sequence").Value) == VirtualSequence.Sequence
                             select s).FirstOrDefault();
            if (find != null) //If we already have such Adjacent Stations in the list of Adjacent Stations
                throw new BadVirtualSequenceException(VirtualSequence.Sequence, "Duplicate Virtual Sequence");
            XElement toAdd = new XElement("VirtualSequence",
                                  new XElement("Sequence", VirtualSequence.Sequence),
                                  new XElement("Size", VirtualSequence.Size));
            ListVirtualSequences.Add(VirtualSequence);//add Adjacent Stations to the collection of all Adjacent Stations
            XMLTool.SaveListToXMLElement(ListVirtualSequences, ListVirthualSequencesPath);
        }

        /// <summary>
        /// delete Adjacent Stations
        /// </summary>
        /// <param name="numS2">code of station 1</param>
        /// <param name="numS1">code of station 2</param>
        public void DeleteVirtualSequence(string Sequence)
        {

            XElement ListVirtualSequence = XMLTool.LoadListFromXMLElement(ListVirthualSequencesPath);
            XElement find = (from s in ListVirtualSequence.Elements()    //find Adjacent Stations with this stations in the collection of Adjacent Stations
                             where (s.Element("Sequence").Value) == Sequence
                             select s).FirstOrDefault();

            if (find == null) //If we already have such Adjacent Stations in the list of Adjacent Stations
                throw new BadVirtualSequenceException(Sequence, "Not found");
            XMLTool.SaveListToXMLElement(ListVirtualSequence, ListVirthualSequencesPath);
        }
        /// <summary>
        /// return all Adjacent Stations by this code station
        /// </summary>
        /// <param name="code">code of station</param>
        /// <returns>a collection of all Adjacent Stations with this code station</returns>
        public IEnumerable<DO.VirtualSequence> GetALLVirtualSequencesBySize(int size)
        {
            XElement ListVirtualSequence = XMLTool.LoadListFromXMLElement(ListVirthualSequencesPath);
            return from item in ListVirtualSequence.Elements()
                   where int.Parse(item.Element("Size").Value) == size
                   select fromXmlToVirtualSequence(item);
        }
        public IEnumerable<DO.VirtualSequence> GetAllVirtualSequences()
        {
            List<VirtualSequence> ListVirtualSequence = XMLTool.LoadListFromXMLSerializer<VirtualSequence>(ListVirthualSequencesPath);
            return from item in ListVirtualSequence
                   orderby item.Sequence
                   select item;
        }
        #endregion


        #region Pentamer




        /// <summary>
        /// return all lines
        /// </summary>
        /// <returns>a collection of all lines</returns>
        public IEnumerable<DO.Pentamer> GetAllPentamer()
        {
            List<Pentamer> ListPentamers = XMLTool.LoadListFromXMLSerializer<Pentamer>(ListPentamersPath);
            return from item in ListPentamers
                   select item;
        }
        public IEnumerable<DO.Pentamer> GetPentamersBySequence(string sequence)
        {
            List<Pentamer> ListPentamers = XMLTool.LoadListFromXMLSerializer<Pentamer>(ListPentamersPath);
            return from item in ListPentamers
                   where item.Sequence == sequence
                   select item;
        }
        /// <summary>
        /// return line
        /// </summary>
        /// <param name="num">num of line</param>
        /// <param name="code">runing code of line</param>
        /// <returns>a line that have this code and num line</returns>
        public IEnumerable <DO.Pentamer> GetPentamerByProteinGI(string ProteinGI)
        {
            List<DO.Pentamer> ListPentamers = XMLTool.LoadListFromXMLSerializer<Pentamer>(ListPentamersPath);
            List<DO.Pentamer> ListPentamerstoget = (from p in ListPentamers
                                                where p.ProteinGI == ProteinGI
                                                select p).ToList();
           
            if (ListPentamerstoget.Count != 0) //if the line is found
                return ListPentamerstoget;
            else //if the line is not found 
                throw new DO.BadPentamerProteinGIException(ProteinGI, "Not found");
        }
        public DO.Pentamer GetPentamerByProteinName(string ProteinName)
        {
            List<Pentamer> ListPentamers = XMLTool.LoadListFromXMLSerializer<Pentamer>(ListPentamersPath);
            DO.Pentamer toGet = ListPentamers.Find(p => (p.ProteinName == ProteinName)); //find this line
            if (toGet != null) //if the line is found
                return toGet;
            else //if the line is not found 
                throw new DO.BadPentamerProteinNameException(ProteinName, "Not found");
        }
        public DO.Pentamer GetPentamerBySequence(string Sequence)
        {
            List<Pentamer> ListPentamers = XMLTool.LoadListFromXMLSerializer<Pentamer>(ListPentamersPath);
            DO.Pentamer toGet = ListPentamers.Find(p => (p.Sequence == Sequence)); //find this line
            if (toGet != null) //if the line is found
                return toGet;
            else //if the line is not found 
                throw new DO.BadPentamerProteinSequenceException(Sequence, "Not found");
        }



        /// <summary>
        /// add line
        /// </summary>
        /// <param name="line">line to add</param>
        /// <returns>runing code of this line</returns>
        public void AddPentamer(DO.Pentamer pentamer)
        {

            List<Pentamer> ListPentamers = XMLTool.LoadListFromXMLSerializer<Pentamer>(ListPentamersPath);
            //List<int> configInt = XMLTool.LoadListFromXMLSerializer<int>(ListconfigPath);
            ListPentamers.Add(pentamer); //add line to collection of all lines
            XMLTool.SaveListToXMLSerializer(ListPentamers, ListPentamersPath);
            //XMLTool.SaveListToXMLSerializer(configInt, ListconfigPath);
        }
       
        /// <summary>
        /// delete line
        /// </summary>
        /// <param name="num">num of line to delete</param>
        /// <param name="code">runing code of line to delete</param>
        public void DeletePentamer(string proteinGI, string sequence, int firstIndex)
        {
            List<Pentamer> ListPentamers = XMLTool.LoadListFromXMLSerializer<Pentamer>(ListPentamersPath);
            Pentamer toDel;
            toDel = ListPentamers.FirstOrDefault(p => (p.ProteinGI == proteinGI && p.Sequence == sequence && p.FirstIndex== firstIndex)); //find line that have this num line and runing code
            if (toDel == null) //if the line is not found
                throw new BadPentamerException("This Pentamer is Not found");
            XMLTool.SaveListToXMLSerializer(ListPentamers, ListPentamersPath);
        }
        public IEnumerable<DO.Pentamer> Search(DO.Pentamer pntaDO)
        {
            List<Pentamer> ListPentamers = XMLTool.LoadListFromXMLSerializer<Pentamer>(ListPentamersPath);

           return from P in ListPentamers
            where P.Sequence == pntaDO.Sequence && P.ProteinGI == pntaDO.ProteinGI && P.FirstIndex == pntaDO.FirstIndex
                  select P;
        }
        #endregion
    }
}





