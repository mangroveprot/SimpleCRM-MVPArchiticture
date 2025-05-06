using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCRM._Repositories;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;
using SimpleCRM.Presentor._presenter;
using SimpleCRM.Presentor.Presenter;
using SimpleCRM.View._interface;

namespace SimpleCRM.View._forms
{
    public partial class SignUpFormView : Form, ISignUpView
    {
        private string message;
        private bool isSuccessful;
        private string role;
        private readonly string sqlConnectionString;
        public SignUpFormView(string SqlConnectionString)
        {
            InitializeComponent();
            SqlConnectionString = sqlConnectionString;
            btnSignup.Click += delegate
            {
                SignUpEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    var result = MessageBox.Show(
                  "Registereds Successfully!",
                  "Successful",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        ILoginView loginView = new LogInFormView(sqlConnectionString);
                        IBaseRepository<UserModel> userRepository = new UserRepository(sqlConnectionString);
                        new LoginPresenter(loginView, userRepository);
                        Form startForm = (Form)loginView;
                        startForm.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show(Message);
                }
            };
            btnLogin.Click += delegate
            {
                ILoginView loginView = new LogInFormView(sqlConnectionString);
                IBaseRepository<UserModel> userRepository = new UserRepository(sqlConnectionString);
                new LoginPresenter(loginView, userRepository);
                Form startForm = (Form)loginView;
                startForm.Show();
                this.Hide();
            };
        }

        public string Username
        {
            get { return txt_username.Text; }
            set { txt_username.Text = value; }
        }

        public string Password
        {
            get { return txt_password.Text; }
            set { txt_password.Text = value; }
        }

        public string Email
        {
            get { return txt_email.Text; }
            set { txt_email.Text = value; }
        }

        public string FullName
        {
            get { return txt_fullname.Text; }
            set { txt_fullname.Text = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        // Events
        public event EventHandler ShowLoginView;
        public event EventHandler CancelEvent;
        public event EventHandler SignUpEvent;

    }
}
