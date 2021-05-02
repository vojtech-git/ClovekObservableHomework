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
using System.Text.RegularExpressions;


namespace ClovekObservableHomework
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Human> humans;

        public MainWindow()
        {
            InitializeComponent();
            humans = new ObservableCollection<Human>();
            MainListBox.ItemsSource = humans;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameBox.Text == "" || lastNameBox.Text == "" || birthYearBox.Text == "")
            {
                MessageBox.Show("Všechna pole musí být vyplněna!", "Nevyplněná pole");
            }
            else
            {
                humans.Add(new Human(nameBox.Text, lastNameBox.Text, Convert.ToInt32(birthYearBox.Text)));
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            humans.Remove((Human)MainListBox.SelectedItem);
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {

            MainListBox.SelectedItem = new Human(nameBox.Text, lastNameBox.Text, Convert.ToInt32(birthYearBox.Text));
        }

        private void MainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            nameBox.Text = (MainListBox.SelectedItem as Human).Name;
            lastNameBox.Text = (MainListBox.SelectedItem as Human).LastName;
            birthYearBox.Text = Convert.ToString((MainListBox.SelectedItem as Human).BirthYear);
        }

        private void birthYearBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
