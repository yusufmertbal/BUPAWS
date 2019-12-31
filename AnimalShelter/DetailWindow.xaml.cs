using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AnimalShelter
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public DetailWindow(PawUser loginUser)
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            AddAnimal addAnimal = new AddAnimal();
            addAnimal.Show();
        }

        private void dgAnimals_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            BUPawsDb db = new BUPawsDb();
            List<AnimalShelter.Data.PawAnimal> animals = db.pawAnimals.ToList();
            dgAnimals.ItemsSource = animals;
        }
    }
}
