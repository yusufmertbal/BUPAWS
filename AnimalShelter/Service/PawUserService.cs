using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Data;

namespace AnimalShelter
{
    public class PawUserService
    {
        private BUPawsDb db;

        public PawUserService() 
        {
            db = new BUPawsDb();
        }

        public PawUser Login(string UserName, string Password)
        {
            var loginUser = db.PawUsers.FirstOrDefault(u => u.UserName == UserName && u.Password == Password);
            return loginUser;
        }

        public bool CheckPassword(PawUser pawUser, string password)
        {
            return pawUser.Password == password.ToString();
        }

        public void ChangePassword(PawUser pawUser, string password)
        {
            var user = db.PawUsers.Find(pawUser.Id);
            user.Password = password.ToString();
            db.SaveChanges();
        }

    }
}
