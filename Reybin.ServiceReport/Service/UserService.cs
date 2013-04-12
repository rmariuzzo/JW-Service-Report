using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reybin.ServiceReport.Model;

namespace Reybin.ServiceReport.Service
{
    public class UserService
    {
        public bool Authenticate(String username, String password)
        {
            using (var ctx = new AppContext())
            {
                return ctx.Users.Any(u => u.Username == username && u.Password == password);
            }
        }

        public void Create(string username, string password)
        {
            using (var ctx = new AppContext())
            {
                ctx.Users.Add(new User { Username = username, Password = password });
            }
        }
    }
}
