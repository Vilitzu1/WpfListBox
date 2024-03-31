using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfListBox.Data;

namespace WpfListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name = "Jannick", Age = 30},
            new Person{Name = "Jan", Age = 15},
            new Person{Name = "Maria", Age = 40},
            new Person{Name = "Zachary", Age = 27},
            new Person{Name = "Cary", Age = 29}

        };
        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;
            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}