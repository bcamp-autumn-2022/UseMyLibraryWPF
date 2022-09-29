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

namespace UseMyLibraryWPF
{
    /// <summary>
    /// Interaction logic for Second.xaml
    /// </summary>
    public partial class Second : Window
    {
        public Second( string test)
        {
            InitializeComponent();
            tbInfo.Text= test;
            
        }
        public string Note { get; set; }

        private void btnShowFname_Click(object sender, RoutedEventArgs e)
        {
            Singleton si2 = Singleton.Instance;
            tbFname.Text = si2.Fname;

            tbInfo.Text = Note;
        }
    }
}
