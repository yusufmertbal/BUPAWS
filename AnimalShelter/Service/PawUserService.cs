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
        
    }
}
