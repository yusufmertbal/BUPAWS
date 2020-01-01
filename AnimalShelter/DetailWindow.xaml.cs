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
        

        private void itemExitApp_Click(object sender, RoutedEventArgs e)
        {
            //https://www.wpf-tutorial.com/dialogs/the-messagebox/ adresinden alıp üzerinde oynama yaptım.
            MessageBoxResult result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "ÇIKIŞ", MessageBoxButton.YesNo,MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void itemExitUser_Click(object sender, RoutedEventArgs e)
        {
            //https://www.wpf-tutorial.com/dialogs/the-messagebox/ adresinden alıp üzerinde oynama yaptım.
            MessageBoxResult result = MessageBox.Show("Hesabındanq çıkış yapmak istediğine emin misin?", "ÇIKIŞ", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void itemChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            this.Close();
        }
    }
}
