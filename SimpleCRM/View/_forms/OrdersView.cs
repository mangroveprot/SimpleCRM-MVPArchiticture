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
using SimpleCRM.View._utils;

namespace SimpleCRM.View._forms
{
    public partial class OrdersView : Form, IOrderView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private BaseView baseView;
        public OrdersView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(orderDetails);
            HideDateAndTime(false);

            baseView = new BaseView(
                        searchBtn,
                        searchField,
                        btnAddNew,
                        btnEdit,
                        saveBtn,
                        cancelBtn,
                        btnDelete,
                        tabControl1,
                        ordersListTab,
                        orderDetails,
                        addModeTitle: "Add New Order",
                        editModeTitle: "Edit Order"
                );
            WireUpBaseViewEvents();
        }

        private void WireUpBaseViewEvents()
        {
            baseView.SearchEvent += (s, e) => SearchEvent?.Invoke(s, e);
            baseView.AddNewEvent += (s, e) =>
            {
                AddNewEvent?.Invoke(s, e);

            };
            baseView.EditEvent += (s, e) =>
            {
                EditEvent?.Invoke(s, e);
                HideDateAndTime(true);
            };
            baseView.SaveEvent += (s, e) =>
            {
                SaveEvent?.Invoke(s, e);
                baseView.IsSuccessful = this.IsSuccessful;
                baseView.Message = this.Message;
            };
            baseView.CancelEvent += (s, e) =>
            {
                CancelEvent?.Invoke(s, e);
                HideDateAndTime(false);
            };
            baseView.DeleteEvent += (s, e) =>
            {
                DeleteEvent?.Invoke(s, e);
                baseView.Message = this.Message;
            };
        }

        private void HideDateAndTime(Boolean isHide = true)
        {
            orderDateLabel.Visible = isHide;
            txt_dateAndTime.Visible = isHide;
        }

        public string OrderId
        {
            get { return txt_orderId.Text; }
            set { txt_orderId.Text = value; }
        }

        public string CustomerId
        {
            get { return txt_customerId.Text; }
            set { txt_customerId.Text = value; }
        }

        public string ProductId
        {
            get { return txt_productId.Text; }
            set { txt_productId.Text = value; }
        }

        public string Quantity
        {
            get { return txt_qty.Text; }
            set { txt_qty.Text = value; }
        }

        public string TotalAmount
        {
            get { return txt_totalAmount.Text; }
            set { txt_totalAmount.Text = value; }
        }

        public string Status
        {
            get { return txt_status.Text; }
            set { txt_status.Text = value; }
        }

        public string Date
        {
            get { return txt_dateAndTime.Text; }
            set { txt_dateAndTime.Text = value; }
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

        public void SetOrderBindingSource(BindingSource orderList)
        {
            baseView.SetBindingSource(orderList, orderDataTbl);
        }

        public static OrdersView GetInstance(Form parentContainer)
        {
            return BaseView.GetInstance<OrdersView>(parentContainer);
        }
    }
}
