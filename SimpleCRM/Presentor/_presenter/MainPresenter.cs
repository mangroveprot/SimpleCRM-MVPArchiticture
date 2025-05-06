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
            this.mainView.SessionLogin += OnSession;
            this.mainView.ShowUserView += ShowUserView;
            this.mainView.ShowCustomerView += ShowCustomerView;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowOrderView += ShowOrderView;
            this.mainView.LogoutEvent += OnLogout();
        }

        private void OnSession(object? sender, EventArgs e)
        {
            var sessionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "session.json");
            if (File.Exists(sessionPath))
            {
                try
                {
                    string json = File.ReadAllText(sessionPath);
                    var root = System.Text.Json.JsonDocument.Parse(json).RootElement;

                    var session = new LoginSessionModel
                    {
                        UserId = root.GetProperty("UserId").GetInt32(),
                        Username = root.GetProperty("Username").GetString() ?? "",
                        Role = root.GetProperty("Role").GetString() ?? ""
                    };

                    SessionModelHolder.Session = session;
                }
                catch
                {
                    SessionModelHolder.Session = null;
                }
            }
        }

        private EventHandler OnLogout()
        {
            return (sender, e) =>
            {
                var result = MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var sessionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "session.json");

                    if (File.Exists(sessionPath))
                    {
                        File.Delete(sessionPath);
                    }

                    Application.Restart();
                }
            };
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
