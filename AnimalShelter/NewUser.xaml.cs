using System;
using System.Collections.Generic;
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
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            PawUser pawUser = new PawUser();
            pawUser.Name = txtName.Text;
            pawUser.Surname = txtSurname.Text;
            pawUser.UserName = txtUserName.Text;
            pawUser.Password = txtUserPassword.Text;




            BUPawsDb db = new BUPawsDb();
            db.PawUsers.Add(pawUser);

            db.SaveChanges();
            MessageBox.Show("Kullanıcı Kaydedildi.");
            //lblStudentId.Content = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            txtUserPasswordRepeat.Text = "";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
    }
}
