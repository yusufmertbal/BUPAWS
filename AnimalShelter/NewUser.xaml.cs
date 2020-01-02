﻿using System;
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
            //bu kısımdaki kodların çoğu cetLibrary ödevinden uyarlanmıştır.
            PawUser pawUser = new PawUser();
            pawUser.Name = txtName.Text;
            pawUser.Surname = txtSurname.Text;
            pawUser.UserName = txtUserName.Text;
            pawUser.Password = txtUserPassword.Password;
            pawUser.CreatedDate = DateTime.Now;

            BUPawsDb db = new BUPawsDb();
            db.PawUsers.Add(pawUser);

            if (txtUserPassword.Password == txtUserPasswordRepeat.Password) 
            {
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Kaydedildi.");
            txtName.Text = "";
            txtSurname.Text = "";
            txtUserName.Text = "";
            txtUserPassword.Password = "";
            txtUserPasswordRepeat.Password = "";
            }

            else { MessageBox.Show("Parolanızın tekrarını yanlış girdiniz. Lütfen düzeltin."); }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
    }
}
