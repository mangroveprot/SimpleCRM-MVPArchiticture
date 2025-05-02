using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCRM.Models._models;
using SimpleCRM.View._forms;
using SimpleCRM.View._interface;

namespace SimpleCRM.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            SetLoginSession();
            DisplayUser();
            btnUsers.Click += delegate { ShowUserView?.Invoke(this, EventArgs.Empty); };
            btnCustomers.Click += delegate { ShowCustomerView?.Invoke(this, EventArgs.Empty); };
            btnOrders.Click += delegate { ShowOrderView?.Invoke(this, EventArgs.Empty); };
            btnProducts.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            btnLogout.Click += delegate { LogoutEvent?.Invoke(this, EventArgs.Empty); };
        }

        private void SetLoginSession()
        {
            var sessionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "session.json");
            if (File.Exists(sessionPath))
            {
                try
                {
                    string json = File.ReadAllText(sessionPath);
                    var root = System.Text.Json.JsonDocument.Parse(json).RootElement;

                    var session = new LoginSessionModel
                    {
                        UserId = root.GetProperty("UserId").GetInt32(),
                        Username = root.GetProperty("Username").GetString() ?? "",
                        Role = root.GetProperty("Role").GetString() ?? ""
                    };

                    SessionModelHolder.Session = session;
                }
                catch
                {
                    SessionModelHolder.Session = null;
                }
            }
        }

        private void DisplayUser()
        {
            display_user.Text = "Hello " + SessionModelHolder.Session.Username;
        }

        public event EventHandler ShowUsersView;
        public event EventHandler ShowCustomerView;
        public event EventHandler ShowOrderView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowUserView;
        public event EventHandler LogoutEvent;
    }
}
