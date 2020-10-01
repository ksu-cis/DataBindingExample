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
using System.Collections.ObjectModel;

namespace DataBindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person("Bugs", "Bunny", true),
                new Person("Daffy", "Duck", true),
                new Person("Elmer", "Fudd", true),
                new Person("Tazmanian", "Devil", true),
                new Person("Tweety", "Bird", true),
                new Person("Marvin", "Martian", true),
                new Person("Michael", "Jordan"),
                new Person("Charles", "Barkely"),
                new Person("Patrick", "Ewing"),
                new Person("Larry", "Johnson")
            };
            DataContext = people;
        }
    }
}
