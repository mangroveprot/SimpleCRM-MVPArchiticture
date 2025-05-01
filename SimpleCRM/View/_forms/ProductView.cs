using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc.Formatters;
using SimpleCRM.View._interface;
using SimpleCRM.View._utils;

namespace SimpleCRM.View._forms
{
    public partial class ProductView : Form, IProductView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            TextBoxInputFilter.AllowOnlyDecimal(txt_productPrice);
            tabControl1.TabPages.Remove(productDetails);
        }

        private void AssociateAndRaiseViewEvents()
        {
            searchBtn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            searchField.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //add
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(productsListTab);
                tabControl1.TabPages.Add(productDetails);
                productDetails.Text = "Add New Product";
            };

            //edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(productsListTab);
                tabControl1.TabPages.Add(productDetails);
                productDetails.Text = "Edit Product";
            };
            //save
            saveBtn.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(productDetails);
                    tabControl1.TabPages.Add(productsListTab);
                }
                MessageBox.Show(Message);
            };

            //cancel
            cancelBtn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(productDetails);
                tabControl1.TabPages.Add(productsListTab);
            };
            //delete
            btnDelete.Click += delegate
            {
                //DeleteEvent?.Invoke(this, EventArgs.Empty);
                var result = MessageBox.Show("Are you sure ypu want to delete the selected item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

        }

        public string ProductId
        {
            get { return txt_productId.Text; }
            set { txt_productId.Text = value; }
        }

        public string ProductName
        {
            get { return txt_prodName.Text; }
            set { txt_prodName.Text = value; }
        }

        public string Description
        {
            get { return txt_prodDesc.Text; }
            set { txt_prodDesc.Text = value; }
        }

        public string Price
        {
            get { return txt_productPrice.Text; }
            set { txt_productPrice.Text = value; }
        }

        public string StockQuantity
        {
            get { return txt_qty.Text; }
            set { txt_qty.Text = value; }
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCustomerBindingSource(BindingSource productList)
        {
            productsDataTbl.DataSource = productList;
        }

        //
        private static ProductView instance;
        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
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
