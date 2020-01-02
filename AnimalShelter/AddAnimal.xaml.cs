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
            animal.CreatedDate = DateTime.Now;


            db.pawAnimals.Add(animal);

            db.SaveChanges();
            MessageBox.Show("Hayvan Başarıyla Kaydedildi.");
            txtAnimalName.Text = "";
            txtAnimalSpecies.Text = "";
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            BUPawsDb db = new BUPawsDb();
            List<AnimalShelter.Data.PawAnimal> animals = db.pawAnimals.ToList();
            dgAnimals.ItemsSource = animals;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            AnimalShelter.Data.PawAnimal animal = dgAnimals.SelectedItem as AnimalShelter.Data.PawAnimal;
            if (animal != null)
            {
                
                var animalnew = db.pawAnimals.Find(animal.Id);
                animalnew.AnimalName = txtAnimalName.Text;
                animalnew.Species = txtAnimalSpecies.Text;
                animal.Vaccine = cbVaccine.Text;
                animal.Health = cbHealth.Text;
                animal.AnimalArea = cbAreas.Text;

                var selectedArea = cbAreas.SelectedItem as AnimalShelter.Data.PawArea;
                if (selectedArea == null)
                {
                    MessageBox.Show("Bölge seçiniz");
                    return;
                }
                animal.AnimalArea = selectedArea.Name;
                animalnew.AnimalArea = selectedArea.Name;

                var selectedVaccine = cbVaccine.SelectedItem as AnimalShelter.Data.PawVaccine;
                if (selectedVaccine == null)
                {
                    MessageBox.Show("Aşı seçiniz");
                    return;
                }
                animal.Vaccine = selectedVaccine.VaccineName;
                animalnew.Vaccine = selectedVaccine.VaccineName;

                var selectedHealth = cbHealth.SelectedItem as AnimalShelter.Data.PawHealth;
                if (selectedHealth == null)
                {
                    MessageBox.Show("Sağlık durumu seçiniz");
                    return;
                }
                animal.Health = selectedHealth.HealthyOrSick;
                animalnew.Health = selectedHealth.HealthyOrSick;


                db.SaveChanges();
                MessageBox.Show("Seçilen veri güncellendi.");
                txtAnimalName.Text = "";
                txtAnimalSpecies.Text = "";
                LoadAnimals();
            }
            else
            {
                MessageBox.Show("güncellemek için bir hayvan seçmelisin!");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            AnimalShelter.Data.PawAnimal animal = dgAnimals.SelectedItem as AnimalShelter.Data.PawAnimal;
            if (animal != null)
            {

                db.pawAnimals.Remove(animal);
                db.SaveChanges();
                MessageBox.Show("Seçilen sistemden silindi!");
                LoadAnimals();

            }
            else
            {
                MessageBox.Show("Silmek için öğrenci seçmelisin!");
            }
        }

        private void btnTurnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadAnimals();

            var areas = db.pawAreas.OrderBy(d => d.Name).ToList();
            cbAreas.ItemsSource = areas;

            var vaccines = db.pawVaccines.OrderBy(d => d.VaccineName).ToList();
            cbVaccine.ItemsSource = vaccines;

            var health = db.pawHealths.OrderBy(d => d.HealthyOrSick).ToList();
            cbHealth.ItemsSource = health;
        }

        private void dgAnimals_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            AnimalShelter.Data.PawAnimal animal = dgAnimals.SelectedItem as AnimalShelter.Data.PawAnimal;
            if (animal != null)
            {
                txtAnimalName.Text = animal.AnimalName;
                txtAnimalSpecies.Text = animal.Species;
                cbAreas.SelectedItem = animal.AnimalArea;
                cbHealth.SelectedItem = animal.Health;
                cbVaccine.SelectedItem = animal.Vaccine;
            }
        }
    }
}
