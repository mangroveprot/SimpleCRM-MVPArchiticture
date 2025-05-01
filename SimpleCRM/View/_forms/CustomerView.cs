using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCRM.View._base;
using SimpleCRM.View._interface;

namespace SimpleCRM.View
{
    public partial class CustomerView : Form, ICustomerView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string createdAt;
        private BaseView baseView;

        //events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvenet;
        public event EventHandler CancelEvent;
        public event EventHandler SaveEvent;

        public CustomerView()
        {
            InitializeComponent();
            //AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(customerDetails);

            baseView = new BaseView(
                searchBtn,
                searchField,
                addNewBtn,
                editBtn,
                saveBtn,
                cancelBtn,
                deleteBtn,
                tabControl1,
                customersListTab,
                customerDetails,
                addModeTitle: "Add New Customer",
                editModeTitle: "Edit Customer"
             );

            WireUpBaseViewEvents();
        }

        private void WireUpBaseViewEvents()
        {
            baseView.SearchEvent += (s, e) => SearchEvent?.Invoke(s, e);
            baseView.AddNewEvent += (s, e) => AddNewEvent?.Invoke(s, e);
            baseView.EditEvent += (s, e) => EditEvent?.Invoke(s, e);
            baseView.SaveEvent += (s, e) =>
            {
                SaveEvent?.Invoke(s, e);
                baseView.IsSuccessful = this.IsSuccessful;
                baseView.Message = this.Message;
            };
            baseView.CancelEvent += (s, e) => CancelEvent?.Invoke(s, e);
            baseView.DeleteEvent += (s, e) =>
            {
                DeleteEvent?.Invoke(s, e);
                baseView.Message = this.Message;
            };
        }

        /*
        private void AssociateAndRaiseViewEvents()
        {
            searchBtn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            searchField.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //add
            addNewBtn.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(customersListTab);
                tabControl1.TabPages.Add(customerDetails);
                customerDetails.Text = "Add New Customer";
            };

            //edit
            editBtn.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(customersListTab);
                tabControl1.TabPages.Add(customerDetails);
                customerDetails.Text = "Edit Customer";
            };

            ////save
            saveBtn.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(customerDetails);
                    tabControl1.TabPages.Add(customersListTab);
                }
                MessageBox.Show(Message);
            };

            ////cancel
            cancelBtn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(customerDetails);
                tabControl1.TabPages.Add(customersListTab);
            };

            //delete
            deleteBtn.Click += delegate
            {
                var result = MessageBox.Show("Are you sure ypu want to delete the selected item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

        }
        */

        //fields
        public string CustomerId
        {
            get { return txt_customerId.Text; }
            set { txt_customerId.Text = value; }
        }

        public string FirstName
        {
            get { return txt_firstname.Text; }
            set { txt_firstname.Text = value; }
        }

        public string MiddleName
        {
            get { return txt_middlename.Text; }
            set { txt_middlename.Text = value; }
        }

        public string LastName
        {
            get { return txt_lastname.Text; }
            set { txt_lastname.Text = value; }
        }

        public string Suffix
        {
            get { return txt_suffix.Text; }
            set { txt_suffix.Text = value; }
        }

        public string Email
        {
            get { return txt_email.Text; }
            set { txt_email.Text = value; }
        }

        public string PhoneNumber
        {
            get { return txt_phonenumber.Text; }
            set { txt_phonenumber.Text = value; }
        }

        public string CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public string SearchValue
        {
            get { return searchField.Text; }
            set { searchField.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
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


        public void SetCustomerBindingSource(BindingSource customerList)
        {
            customerDataTbl.DataSource = customerList;
        }

        //singleton
        private static CustomerView instance;
        public static CustomerView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomerView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
