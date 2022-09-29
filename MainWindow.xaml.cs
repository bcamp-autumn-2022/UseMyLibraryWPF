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
using MyLibrary;

namespace UseMyLibraryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Cat> catsCollection;
        public MainWindow()
        {
            InitializeComponent();
            
            InitializeCat();
        }

   

        private void InitializeCat()
        {
            catsCollection = new List<Cat>();
            catsCollection.Add(new Cat { Age = 5, Name = "Garfield" });
            catsCollection.Add(new Cat { Age = 6, Name = "Bob" });
            catsCollection.Add(new Cat { Age = 7, Name = "Jane" });
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            dataGridCats.ItemsSource = catsCollection.ToList();
        }

        private void dataGridCats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                dynamic selectedRow = dataGridCats.SelectedItem;
                var selectedName = selectedRow.Name;
                var selectedAge = selectedRow.Age;
                textSelectedName.Text = selectedName;
                textSelectedAge.Text = selectedAge.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong line");
            }
            
   


        }

        private void btnOpenSecond_Click(object sender, RoutedEventArgs e)
        {
            Second objectSecond = new Second("Testing ");
            objectSecond.Note = "Hello from MainWindow";
            objectSecond.Show();
            //objectSecond.ShowDialog();
        }

        private void btnSetName_Click(object sender, RoutedEventArgs e)
        {
            Singleton si = Singleton.Instance;
            si.Fname = "Teppo";
        }
    }
}
