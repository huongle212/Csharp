using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_Project.Model
{
    class Staff
    {
        private String username;
        private String password;
        private String fullname;
        private String role;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Role { get => role; set => role = value; }

        public Staff()
        {
        }

        public Staff(string username, string password, string fullname, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Fullname = fullname;
            this.role = role;
        }

        public String getDisplayName()
        {
            if (fullname != null && fullname.Trim().Length > 0) return fullname.Trim();
            return username;
        }
    }
}
