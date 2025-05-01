using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCRM.View._interface;

namespace SimpleCRM.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnUsers.Click += delegate { ShowUserView?.Invoke(this, EventArgs.Empty); };
            btnCustomers.Click += delegate { ShowCustomerView?.Invoke(this, EventArgs.Empty); };
            btnOrders.Click += delegate { ShowOrderView?.Invoke(this, EventArgs.Empty); };
            btnProducts.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowUsersView;
        public event EventHandler ShowCustomerView;
        public event EventHandler ShowOrderView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowUserView;
    }
}
