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
using SimpleCRM.View._base;
using SimpleCRM.View._interface;
using SimpleCRM.View._utils;

namespace SimpleCRM.View._forms
{
    public partial class ProductsView : Form, IProductView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private BaseView baseView;

        //eveent
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public ProductsView()
        {
            InitializeComponent();
            TextBoxInputFilter.AllowOnlyDecimal(txt_productPrice);
            tabControl1.TabPages.Remove(productDetails);

            baseView = new BaseView(
                        searchBtn,
                        searchField,
                        btnAddNew,
                        btnEdit,
                        saveBtn,
                        cancelBtn,
                        btnDelete,
                        tabControl1,
                        productsListTab,
                        productDetails,
                        addModeTitle: "Add New product",
                        editModeTitle: "Edit product"
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

        public void SetCustomerBindingSource(BindingSource productList)
        {
            baseView.SetBindingSource(productList, productsDataTbl);
        }

        //
        public static ProductsView GetInstance(Form parentContainer)
        {
            return BaseView.GetInstance<ProductsView>(parentContainer);
        }
    }
}
