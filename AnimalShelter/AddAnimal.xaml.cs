using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for AddAnimal.xaml
    /// </summary>
    public partial class AddAnimal : Window
    {
        public AddAnimal()
        {
            InitializeComponent();
        }
        BUPawsDb db = new BUPawsDb();

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            AnimalShelter.Data.PawAnimal animal = new AnimalShelter.Data.PawAnimal();
            animal.AnimalName = txtAnimalName.Text;
            animal.Species = txtAnimalSpecies.Text;

            var selectedArea = cbAreas.SelectedItem as AnimalShelter.Data.PawArea;
            if (selectedArea == null)
            {
                MessageBox.Show("Bölge seçiniz");
                return;
            }
            animal.AnimalArea = selectedArea.Name;

            var selectedVaccine = cbVaccine.SelectedItem as AnimalShelter.Data.PawVaccine;
            if (selectedVaccine == null)
            {
                MessageBox.Show("Aşı seçiniz");
                return;
            }
            animal.Vaccine = selectedVaccine.VaccineName;

            var selectedHealth = cbHealth.SelectedItem as AnimalShelter.Data.PawHealth;
            if (selectedHealth == null)
            {
                MessageBox.Show("Sağlık durumu seçiniz");
                return;
            }
            animal.Health = selectedHealth.HealthyOrSick;


            db.pawAnimals.Add(animal);

            db.SaveChanges();
            MessageBox.Show("Hayvan Başarıyla Kaydedildi.");
            txtAnimalName.Text = "";
            txtAnimalSpecies.Text = "";
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            //var animals = db.pawAnimals.Include(s => s.AnimalName)
                       //.ToList();
            //dgStudents.ItemsSource = animals;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTurnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var areas = db.pawAreas.OrderBy(d => d.Name).ToList();
            cbAreas.ItemsSource = areas;

            var vaccines = db.pawVaccines.OrderBy(d => d.VaccineName).ToList();
            cbVaccine.ItemsSource = vaccines;

            var health = db.pawHealths.OrderBy(d => d.HealthyOrSick).ToList();
            cbHealth.ItemsSource = health;
        }
    }
}
