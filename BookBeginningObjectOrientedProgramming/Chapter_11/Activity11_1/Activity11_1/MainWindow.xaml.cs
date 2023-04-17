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

namespace Activity11_1
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

        private void MemoViewer_Loaded(object sender, RoutedEventArgs e)
        {
            sbTextBox1.Text = "Ready to load file";
            sbTextBox2.Text = DateTime.Today.ToShortDateString();
        }

        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            //Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; //Default file name
            dlg.DefaultExt = ".txt"; //Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; //Filters file by extension
            //Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();
            //Process open file dialog box results
            if(result == true)
            {
                //Open document and load RichTextBox
                string fileName = dlg.FileName;
                TextRange range;
                System.IO.FileStream fStream;

                if (System.IO.File.Exists(fileName))
                {
                    range = new TextRange(rtbMemo.Document.ContentStart, rtbMemo.Document.ContentEnd);
                    fStream = new System.IO.FileStream(fileName, System.IO.FileMode.OpenOrCreate);
                    range.Load(fStream, System.Windows.DataFormats.Text);
                    fStream.Close();

                }
                sbTextBox1.Text = fileName;
            }
        }

        private void MnuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
