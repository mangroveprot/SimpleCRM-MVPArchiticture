using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCRM._Repositories;
using SimpleCRM.Models;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;
using SimpleCRM.View;
using SimpleCRM.View._forms;
using SimpleCRM.View._interface;

namespace SimpleCRM.Presentor.Presenter
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string SqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            SqlConnectionString = sqlConnectionString;

            //subsribe to the viewer
            this.mainView.ShowUserView += ShowUserView;
            this.mainView.ShowCustomerView += ShowCustomerView;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowUserView += ShowOrderView;
        }


        //order
        private void ShowOrderView(object? sender, EventArgs e)
        {
            IOrderView view = OrdersView.GetInstance((MainView)mainView);
            IBaseRepository<OrderModel> repository = new OrderRepository(SqlConnectionString);
            new OrdersPresenter(view, repository);
        }
        //user
        private void ShowUserView(object? sender, EventArgs e)
        {
            IUserView view = UsersView.GetInstance((MainView)mainView);
            IBaseRepository<UserModel> repository = new UserRepository(SqlConnectionString);
            new UsersPresenter(view, repository);
        }
        //customer
        private void ShowCustomerView(object? sender, EventArgs e)
        {
            ICustomerView view = CustomersView.GetInstance((MainView)mainView);
            IBaseRepository<CustomerModel> repository = new CustomerRepository(SqlConnectionString);
            new CustomersPresenter(view, repository);
        }
        //product
        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductsView.GetInstance((MainView)mainView);
            IBaseRepository<ProductModel> repository = new ProductRepository(SqlConnectionString);
            new ProductsPresenter(view, repository);
        }
    }
}
