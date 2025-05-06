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
    public partial class CustomersView : Form, ICustomerView
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

        public CustomersView()
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
            baseView.SetBindingSource(customerList, customerDataTbl);
        }

        //singleton
        public static CustomersView GetInstance(Form parentContainer)
        {
            return BaseView.GetInstance<CustomersView>(parentContainer);
        }

    }
}
