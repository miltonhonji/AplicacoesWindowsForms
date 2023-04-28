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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Activity11_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        pubsDataSet _dsPubs;
        pubsDataSetTableAdapters.authorsTableAdapter _taAuthors;
        pubsDataSet.authorsDataTable _dtAuthors;

        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {
            _dsPubs = new pubsDataSet();
            _taAuthors = new pubsDataSetTableAdapters.authorsTableAdapter();
            _dtAuthors = new pubsDataSet.authorsDataTable();
            _taAuthors.Fill(_dtAuthors);
            this.dgAuthors.DataContext = _dtAuthors;
        }

        private void btnSaveData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _taAuthors.Update(_dtAuthors);
                MessageBox.Show("Data Saved.",
                       "Information", MessageBoxButton.OK,
                       MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cound not save data!",
                        "Warning", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
            }
        }
    }
}
