using AnimalShelter.Data;
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
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        PawUserService pawUserService = new PawUserService();
        private readonly PawUser pawUser;

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
            this.Close();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (!pawUserService.CheckPassword(pawUser, txtPasswordBefore.Password))
            {
                MessageBox.Show("Mevcut Şifreniz Hatalı!");
                return;
            }

            if (txtPasswordNew.Password != txtPasswordNewRepeat.Password)
            {
                MessageBox.Show("Yeni Şifreler uyumlu değil");
                return;
            }

            pawUserService.ChangePassword(pawUser, txtPasswordNew.Password);
            MessageBox.Show("Şifreniz değiştirilmiştir.");
            this.Close();
        }
    }
}
