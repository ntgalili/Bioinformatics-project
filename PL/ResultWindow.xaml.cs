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
            seqtextBox.AppendText( p.Sequence);
            //richTextBox1.SelectionStart = wordstartIndex;
            //richTextBox1.SelectionLength = word.Length;
            //richTextBox1.SelectionBackColor = Color.Yellow;
            foreach (BO.Pentamer pentamer in SemiUnique)
            {
                Colorize(pentamer.FirstIndex, pentamer.Sequence.Length, Colors.DarkTurquoise);
                
            }
            foreach (BO.Pentamer pentamer in Unique)
            {
                Colorize(pentamer.FirstIndex, pentamer.Sequence.Length, Colors.Orange);
            }
            TextPointer GetPoint(TextPointer start, int x)
            {
                var ret = start;
                var i = 0;
                while (i < x && ret != null)
                {
                    if (ret.GetPointerContext(LogicalDirection.Backward) ==
            TextPointerContext.Text ||
                        ret.GetPointerContext(LogicalDirection.Backward) ==
            TextPointerContext.None)
                        i++;
                    if (ret.GetPositionAtOffset(1,
            LogicalDirection.Forward) == null)
                        return ret;
                    ret = ret.GetPositionAtOffset(1,
            LogicalDirection.Forward);
                }
                return ret;
            }



            void Colorize(int offset, int length, Color color)
            {
                var textRange = seqtextBox.Selection;
                var start = seqtextBox.Document.ContentStart;
                var startPos = GetPoint(start, offset);
                var endPos = GetPoint(start, offset + length);

                textRange.Select(startPos, endPos);
                textRange.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(color));
                textRange.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            }
        }

       
    }
}
