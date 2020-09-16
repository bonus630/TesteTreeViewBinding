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

namespace TesteTreeViewBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            People people = new People("Renato");
            List<People> peoples = new List<People>();
            peoples.Add(new People("Reginaldo"));
            peoples.Add(new People("Regiane"));
            peoples.Add(new People("Osmair"));
            people.Childrens = peoples;


            People people1 = new People("Joaquim");
            List<People> peoples1 = new List<People>();
            People mauricio = new People("Mauricio");
            List<People> peoples2 = new List<People>();
            peoples2.Add(new People("Suzan"));
            mauricio.Childrens = peoples2;


            peoples1.Add(mauricio);
            peoples1.Add(new People("Ferreira"));
            peoples1.Add(new People("Rute"));
            people1.Childrens = peoples1;

            List<People> pais = new List<People>();
            pais.Add(people1);
            pais.Add(people);

            treeViewPeople.ItemsSource = pais;
            Image img = new Image();
            
        }
    }
}
