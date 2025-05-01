using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCRM._Repositories;
using SimpleCRM.Models;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;
using SimpleCRM.Presentor.Presenter;
using SimpleCRM.View;
using SimpleCRM.View._forms;
using SimpleCRM.View._interface;

namespace SimpleCRM.Presentor
{
    public class MainPresentor
    {
        private IMainView mainView;
        private readonly string SqlConnectionString;

        public MainPresentor(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            SqlConnectionString = sqlConnectionString;
            this.mainView.ShowCustomerView += ShowCustomerView;
            this.mainView.ShowProductView += ShowProductView;
        }
        
        //subsribe to the viewer
        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IBaseRepository<ProductModel> repository = new ProductRepository(SqlConnectionString);
            new ProductsPresenter(view, repository);
        }

        private void ShowCustomerView(object? sender, EventArgs e)
        {
            ICustomerView view = CustomerView.GetInstance((MainView)mainView);
            IBaseRepository<CustomerModel> repository = new CustomerRepository(SqlConnectionString);
            new CustomersPresenter(view, repository);
        }
    }
}
