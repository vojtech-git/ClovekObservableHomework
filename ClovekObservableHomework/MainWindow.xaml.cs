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

namespace ClovekObservableHomework
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Human> humans;

        public MainWindow()
        {
            InitializeComponent();
            MainListBox.ItemsSource = humans;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void birthYearBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
