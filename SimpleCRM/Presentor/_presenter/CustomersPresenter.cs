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
    public class CustomersPresenter
    {
        //fields
        private ICustomerView view;
        private IBaseRepository<CustomerModel> repository;
        private BindingSource customersBindingSource;
        private IEnumerable<CustomerModel> customersList;

        public CustomersPresenter(ICustomerView view, IBaseRepository<CustomerModel> repository)
        {
            customersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //sub to event handler methods to view events
            this.view.SearchEvent += SearchCustomers;
            this.view.AddNewEvent += AddNewCustomers;
            this.view.EditEvent += LoadSelectedCustomerToEdit;
            this.view.DeleteEvent += DeleteCustomers;
            this.view.SaveEvent += SaveCustomers;
            this.view.CancelEvent += CancelAction;
            //set customers binding source
            this.view.SetCustomerBindingSource(customersBindingSource);
            LoadAllCustomersList();
            this.view.Show();
        }

        private void LoadSelectedCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (CustomerModel)customersBindingSource.Current;
            view.CustomerId = customer.CustomerId.ToString();
            view.FirstName = customer.FirstName;
            view.MiddleName = customer.MiddleName;
            view.LastName = customer.LastName;
            view.Suffix = customer.Suffix;
            view.Email = customer.Email;
            view.PhoneNumber = customer.PhoneNumber;
            view.IsEdit = true;
        }

        private void LoadAllCustomersList()
        {
            customersList = repository.GetAll();
            customersBindingSource.DataSource = customersList;
        }

        private void SaveCustomers(object? sender, EventArgs e)
        {
            var model = new CustomerModel();
            model.CustomerId = Convert.ToInt32(view.CustomerId);
            model.FirstName = view.FirstName;
            model.MiddleName = view.MiddleName;
            model.LastName = view.LastName;
            model.Suffix = view.Suffix;
            model.Email = view.Email;
            model.PhoneNumber = view.PhoneNumber;
           
            try
            {
                if(!view.IsEdit)
                {
                    DateTime currenDateTime = DateTime.Now;
                    model.CreatedAt = currenDateTime;
                }
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Customer edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Customer added successfully";
                }
                view.IsSuccessful = true;
                LoadAllCustomersList();
                ClearViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void ClearViewFields()
        {
            view.CustomerId = "0";
            view.FirstName = "";
            view.MiddleName = "";
            view.LastName = "";
            view.Suffix = "";
            view.Email = "";
            view.PhoneNumber = "";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearViewFields();
        }

        private void DeleteCustomers(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomerModel)customersBindingSource.Current;
                repository.Delete(customer);
                view.IsSuccessful = true;
                view.Message = "Customer deleted successfully";
                LoadAllCustomersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete user";
            }
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            ClearViewFields();
            view.IsEdit = false;
        }

        private void SearchCustomers(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(view.SearchValue);
            if (!emptyValue)
            {
                customersList = repository.GetByValue(view.SearchValue);
            }
            else
            {
                customersList = repository.GetAll();
            }
            customersBindingSource.DataSource = customersList;
        }
    }
}
