using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> people = new ObservableCollection<Person>();

        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { FirstName = "Lucas", LastName = "Barbosa"});
            people.Add(new Person { FirstName = "Jonas", LastName = "Washington" });
            people.Add(new Person { FirstName = "Paul", LastName = "Brennon" });

            myComboBox.ItemsSource = people;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello, {firstNameText.Text}", "Hmm...");
            people.Add(new Person { FirstName = firstNameText.Text, LastName = lastNameText.Text });

            firstNameText.Text = "";
            lastNameText.Text = "";
        }
    }
}
