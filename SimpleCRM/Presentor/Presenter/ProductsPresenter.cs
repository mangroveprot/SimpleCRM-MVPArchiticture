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
    public class ProductsPresenter
    {
        //fields
        private IProductView view;
        private IBaseRepository<ProductModel> repository;
        private BindingSource bindingSource;
        private IEnumerable<ProductModel> productsList;

        public ProductsPresenter(IProductView view, IBaseRepository<ProductModel> repository)
        {
            bindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //sub to event handler methods to view events
            this.view.SearchEvent += SearchProducts;
            this.view.AddNewEvent += AddNewProducts;
            this.view.EditEvent += LoadSelectedProductsToEdit;
            this.view.DeleteEvent += DeleteProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;
            //set customers binding source
            this.view.SetCustomerBindingSource(bindingSource);
            LoadAllProductList();
            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productsList = repository.GetAll();
            bindingSource.DataSource = productsList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearViewFields();
        }

        private void ClearViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.Description = "";
            view.Price = "0.00";
            view.StockQuantity = "0";
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            var model = new ProductModel();
            model.ProductId = Convert.ToInt32(view.ProductId);
            model.ProductName = view.ProductName;
            model.Description = view.Description;
            model.Price = Convert.ToDecimal(view.Price);
            model.StockQuantity = Convert.ToInt32(view.StockQuantity);

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Product edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Product added successfully";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
                ClearViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteProducts(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)bindingSource.Current;
                repository.Delete(product);
                view.IsSuccessful = true;
                view.Message = "Products deleted successfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete products";
            }
        }
        private void LoadSelectedProductsToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)bindingSource.Current;
            view.ProductId = product.ProductId.ToString();
            view.ProductName = product.ProductName;
            view.Description = product.Description;
            view.Price = product.Price.ToString();
            view.StockQuantity = product.StockQuantity.ToString();
            view.IsEdit = true;
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(view.SearchValue);
            if (!emptyValue)
            {
                productsList = repository.GetByValue(view.SearchValue);
            }else
            {
                productsList = repository.GetAll();
            }
            bindingSource.DataSource = productsList;
        }
    }
}
