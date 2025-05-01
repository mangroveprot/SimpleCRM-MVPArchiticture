using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SimpleCRM.Models._models
{
    public class CustomerModel
    {
        // fields
        private int customerId;
        private string firstName;
        private string middleName;
        private string lastName;
        private string suffix;
        private string email;
        private string phoneNumber;
        private DateTime createdAt;

        // properties - with validations reflecting DB schema
        [DisplayName("Customer ID")]
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        [DisplayName("Customer Firstname")]
        [Required(ErrorMessage = "Customer Firstname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer Firstname must be between 3 and 50 characters")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [DisplayName("Customer Middlename")]
        [StringLength(50, ErrorMessage = "Customer Middlename cannot exceed 50 characters")]
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        [DisplayName("Customer Lastname")]
        [Required(ErrorMessage = "Customer Lastname is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Customer Lastname must be between 1 and 50 characters")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [DisplayName("Suffix")]
        [StringLength(10, ErrorMessage = "Suffix cannot exceed 10 characters")]
        public string Suffix
        {
            get { return suffix; }
            set { suffix = value; }
        }

        [DisplayName("Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DisplayName("Phone Number")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters")]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        [DisplayName("Date Created")]
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
    }
}
