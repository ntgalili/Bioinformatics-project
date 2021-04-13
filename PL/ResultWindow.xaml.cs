using BLAPI;
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

namespace PL
{
    /// <summary>
    /// Interaction logic for ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {

        public ResultWindow(IBL _bl,BO.Protein p, List<BO.Pentamer> Unique, List<BO.Pentamer> SemiUnique)
        {
            InitializeComponent();
            SemiUniqueDataGrid.DataContext = SemiUnique;
            UniqueDataGrid.DataContext = Unique;
            seqtextBox.Text = p.Sequence;
            //richTextBox1.SelectionStart = wordstartIndex;
            //richTextBox1.SelectionLength = word.Length;
            //richTextBox1.SelectionBackColor = Color.Yellow;
            foreach(BO.Pentamer pentamer in SemiUnique)
            {
                seqtextBox.SelectionStart = pentamer.FirstIndex;
                seqtextBox.SelectionLength = pentamer.Sequence.Length;
                //seqtextBox.SelectionTextBrush = Color.FromScRgb(100,32,77,212);
                //#FF1B5AA8;
                seqtextBox.SelectionBrush =new SolidColorBrush(Color.FromScRgb(100, 32, 77, 212));
            }
            foreach (BO.Pentamer pentamer in Unique)
            {
                seqtextBox.SelectionStart = pentamer.FirstIndex;
                seqtextBox.SelectionLength = pentamer.Sequence.Length;
                //seqtextBox.SelectionTextBrush = Color.FromScRgb(100,32,77,212);
                //#FF1B5AA8;
                seqtextBox.SelectionBrush = new SolidColorBrush(Color.FromScRgb(100, 238, 0, 0));
            }
        }

       
    }
}
