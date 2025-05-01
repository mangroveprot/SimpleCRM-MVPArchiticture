using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;
using SimpleCRM.View._interface;

namespace SimpleCRM.Presentor.Presenter
{
    public class OrdersPresenter
    {
        private IOrderView view;
        private IBaseRepository<OrderModel> repository;
        private BindingSource bindingSource;
        private IEnumerable<OrderModel> ordersList;

        public OrdersPresenter(IOrderView view, IBaseRepository<OrderModel> repository)
        {
            bindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchOrders;
            this.view.AddNewEvent += AddNewOrder;
            this.view.EditEvent += LoadSelectedOrderToEdit;
            this.view.DeleteEvent += DeleteOrder;
            this.view.SaveEvent += SaveOrder;
            this.view.CancelEvent += CancelAction;

            this.view.SetOrderBindingSource(bindingSource);
            LoadAllOrderList();
            this.view.Show();
        }

        private void LoadAllOrderList()
        {
            ordersList = repository.GetAll();
            bindingSource.DataSource = ordersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearViewFields();
        }

        private void ClearViewFields()
        {
            view.OrderId = "0";
            view.CustomerId = "0";
            view.ProductId = "0";
            view.Quantity = "0";
            view.TotalAmount = "0.00";
            view.Status = "Select a status";
            view.Date = "DD/MM/YR";
        }

        private void SaveOrder(object? sender, EventArgs e)
        {
            var model = new OrderModel();
            model.OrderId = Convert.ToInt32(view.OrderId);
            model.CustomerId = Convert.ToInt32(view.CustomerId);
            model.ProductId = Convert.ToInt32(view.ProductId);
            model.Quantity = Convert.ToInt32(view.Quantity);
            model.TotalAmount = Convert.ToDecimal(view.TotalAmount);
            //model.Date = Convert.ToDateTime(view.Date);
            model.Status = view.Status;

            string[] status = ["paid", "unpaid", "pending"];

            try
            {
                //check if status is valid
                if (!status.Contains(model.Status.ToLower()))
                {
                    throw new Exception("Invalid status.");
                }
                if (!view.IsEdit)
                {
                    DateTime currenDateTime = DateTime.Now;
                    model.Date = currenDateTime;
                }
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Order edited successfully";
                }
                else
                {
                    //todo date
                    repository.Add(model);
                    view.Message = "Order added successfully";
                }
                view.IsSuccessful = true;
                LoadAllOrderList();
                ClearViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteOrder(object? sender, EventArgs e)
        {
            try
            {
                var order = (OrderModel)bindingSource.Current;
                repository.Delete(order);
                view.IsSuccessful = true;
                view.Message = "Order deleted successfully";
                LoadAllOrderList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete order";
            }
        }

        private void LoadSelectedOrderToEdit(object? sender, EventArgs e)
        {
            var order = (OrderModel) bindingSource.Current;
            view.OrderId = order.OrderId.ToString();
            view.CustomerId = order.CustomerId.ToString();
            view.ProductId = order.ProductId.ToString();
            view.Quantity = order.Quantity.ToString();
            view.TotalAmount = order.TotalAmount.ToString();
            view.Status = order.Status;
            view.Date = order.Date.ToString();
            view.IsEdit = true;
        }

        private void AddNewOrder(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchOrders(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(view.SearchValue);
            if (!emptyValue)
            {
                ordersList = repository.GetByValue(view.SearchValue);
            }
            else
            {
                ordersList = repository.GetAll();
            }
            bindingSource.DataSource = ordersList;
        }
    }
}
