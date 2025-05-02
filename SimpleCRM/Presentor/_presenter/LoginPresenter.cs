using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;
using SimpleCRM.View._interface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCRM.Presentor._presenter
{
    public class LoginPresenter
    {
        private ILoginView view;
        private readonly IBaseRepository<UserModel> userRepository;

        public LoginPresenter(ILoginView loginView, IBaseRepository<UserModel> userRepository)
        {
            this.view = loginView;
            this.userRepository = userRepository;

            this.view.LoginEvent += OnLogin;
        }

        private void OnLogin(object? sender, EventArgs e)
        {
            string _username = view.Username;
            string _password = view.Password;

            var user = userRepository.GetAll().FirstOrDefault(u => u.Username == _username && u.Password == _password);

            try
            {
                if (user == null) throw new Exception("User not found");
                if (user.Role.ToLower() != "admin") throw new Exception("User is not admin!");
                view.IsSuccessful = true;
                view.Message = "Login Successful";

                var session = new LoginSessionModel();
                session.UserId = user.UserId;
                session.Username = user.Username;
                session.Role = user.Role;

                var sessionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "session.json");
                var json = System.Text.Json.JsonSerializer.Serialize(session);
                File.WriteAllText(sessionPath, json);
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
    }
}
