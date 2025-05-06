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
    public partial class LogInFormView : Form, ILoginView
    {
        private Boolean isSuccessful;
        private string message;
        private readonly string SqlConnectionString;
        public LogInFormView(string sqlConnectionString)
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            SqlConnectionString = sqlConnectionString;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += delegate
            {
                LoginEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    IMainView mainView = new MainView();
                    new MainPresenter(mainView, SqlConnectionString);
                    Form startForm = (Form)mainView;
                    startForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(Message);
                }
            };
            btnSignup.Click += delegate
            {
                ISignUpView signupView = new SignUpFormView(SqlConnectionString);
                IBaseRepository<UserModel> userRepository = new UserRepository(SqlConnectionString);
                new SignupPresenter(signupView, userRepository);
                Form startForm = (Form)signupView;
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

        public event EventHandler LoginEvent;
        public event EventHandler CancelEvent;
        public event EventHandler ShowSignUpView;
    }
}
