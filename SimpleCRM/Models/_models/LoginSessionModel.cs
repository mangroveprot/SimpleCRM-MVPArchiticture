using System;
using System.ComponentModel;

namespace SimpleCRM.Models._models
{
    public class LoginSessionModel
    {
        private int userId;
        private string username;
        private string role;
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
