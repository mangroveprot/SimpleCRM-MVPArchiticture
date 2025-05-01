using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SimpleCRM.Models._models
{
    public class UserModel
    {
        // fields
        private int userId;
        private string username;
        private string password;
        private string email;
        private string fullName;
        private string role;

        // properties - with validations reflecting DB schema
        [DisplayName("User ID")]
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 255 characters")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DisplayName("Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 100 characters")]
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        [DisplayName("Role")]
        [StringLength(50, ErrorMessage = "Role cannot exceed 50 characters")]
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
