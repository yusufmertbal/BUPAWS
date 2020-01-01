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

namespace AnimalShelter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void entryButton_Click(object sender, RoutedEventArgs e)
        {
            PawUserService pawUserService = new PawUserService();
            var loginUser = pawUserService.Login(txtUserName.Text, txtUserPassword.Password);
            if(loginUser == null) 
            {
                MessageBox.Show("Bilgiler Yanlış");
                txtUserName.Text = "";
                txtUserPassword.Password = "";
            }
            else 
            {
                DetailWindow detailWindow = new DetailWindow(loginUser);
                detailWindow.Show();
                this.Close();
            }
        }

        private void NewUser_Click(object sender, RoutedEventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
            this.Close();
        }
    }
}
