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
    /// Interaction logic for VirtualSequenceWindow.xaml
    /// </summary>
    public partial class VirtualSequenceWindow : Window
    {
        IBL bl;
        BO.VirtualSequence selected;
        public VirtualSequenceWindow(IBL _bl)
        {
            InitializeComponent();
            bl = _bl;
            cutComboBox.ItemsSource = Enum.GetValues(typeof(BO.CuttingType));
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if((sender as ComboBox).SelectedItem.ToString() =="Five")
            virtualSequenceDataGrid.DataContext = bl.GetAllVirtualSequences();
        }

        private void virtualSequenceDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected = (sender as DataGrid).SelectedItem as BO.VirtualSequence;

        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            DetailsWindow detailsWindow = new DetailsWindow (bl, (sender as Button).DataContext as BO.VirtualSequence);
            detailsWindow.Show();
        }
    }
}
