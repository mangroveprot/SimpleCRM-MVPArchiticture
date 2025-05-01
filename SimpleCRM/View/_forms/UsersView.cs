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

namespace SimpleCRM.View._forms
{
    public partial class UsersView : Form, IUserView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string createdAt;
        private BaseView baseView;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public UsersView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(userDetails);
            baseView = new BaseView(
                searchBtn,
                searchField,
                addNewBtn,
                editBtn,
                saveBtn,
                cancelBtn,
                deleteBtn,
                tabControl1,
                userListTab,
                userDetails,
                addModeTitle: "Add New User",
                editModeTitle: "Edit User"
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

        public string UserId
        {
            get { return txt_userId.Text; }
            set { txt_userId.Text = value; }
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
            get { return txt_role.Text; }
            set { txt_role.Text = value; }
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
        public void SetCustomerBindingSource(BindingSource userList)
        {
            baseView.SetBindingSource(userList, usersDataTbl);
        }
        public static UsersView GetInstance(Form parentContainer)
        {
            return BaseView.GetInstance<UsersView>(parentContainer);
        }
    }
}
