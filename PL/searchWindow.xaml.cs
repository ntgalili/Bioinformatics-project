using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BLAPI;
namespace PL
{
    /// <summary>
    /// Interaction logic for searchWindow.xaml
    /// </summary>
    public partial class searchWindow : Window
    {
        List<BO.Pentamer> Unique=new List<BO.Pentamer>();
        List<BO.Pentamer> SemiUnique = new List<BO.Pentamer>();
        IBL bl;
        public searchWindow(IBL _bl)
        {
            InitializeComponent();
            bl = _bl;
        }
        public void Cut(BO.Protein protein)
        {
            BO.Pentamer pnta;
            BO.UniquenessTest result;

            for (int i = 0; i < protein.Sequence.Length - 4; i++)
            {
                pnta = new BO.Pentamer();
                pnta.Sequence = protein.Sequence.Substring(i, 5);
                pnta.ProteinGI = protein.ProteinGI;
                pnta.ProteinName = protein.ProteinName;
                pnta.LastIndex = i + 4;
                pnta.FirstIndex = i;

                result = bl.search(pnta);
                if (result == BO.UniquenessTest.Unique)
                    Unique.Add(pnta);
                if (result == BO.UniquenessTest.SemiUnique)
                    SemiUnique.Add(pnta);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BO.Protein p = new BO.Protein();
            try
            {
                p = bl.GetProteinBySequence(seqTextBox.Text);
            }
            catch(Exception ex)
            {
                p = new BO.Protein();
                p.Sequence = seqTextBox.Text;
                p.ProteinGI = "";
                p.ProteinName = "";
            }
            Cut(p);
            ResultWindow win = new ResultWindow(bl,p, Unique, SemiUnique);
            win.ShowDialog();
        }
    }
}
