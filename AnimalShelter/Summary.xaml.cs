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
    /// Interaction logic for Summary.xaml
    /// </summary>
    public partial class Summary : Window
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadAnimals()
        {
            BUPawsDb db = new BUPawsDb();
            List<AnimalShelter.Data.PawAnimal> animals = db.pawAnimals.ToList();
            dgSummary.ItemsSource = animals;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadAnimals();
        }
    }
}
