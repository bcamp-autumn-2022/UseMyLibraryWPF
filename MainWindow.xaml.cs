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
        Cat objectCat;
        public MainWindow()
        {
            InitializeComponent();
            
            InitializeCat();
        }

   

        private void InitializeCat()
        {
            objectCat=new Cat();
            objectCat.Age = 5;
            objectCat.Name = "Garfield";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cat name is " + objectCat.Name + " and it is " + objectCat.Age + "years old");
        }
    }
}
