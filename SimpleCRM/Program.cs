using System.Configuration;
using SimpleCRM._Repositories;
using SimpleCRM.Models;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;
using SimpleCRM.Presentor;
using SimpleCRM.Presentor._presenter;
using SimpleCRM.Presentor.Presenter;
using SimpleCRM.View;
using SimpleCRM.View._forms;
using SimpleCRM.View._interface;

namespace SimpleCRM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var sessionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "session.json");
            bool isLoggedIn = File.Exists(sessionPath);
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            Form startForm;

            if (isLoggedIn)
            {
                IMainView mainView = new MainView();
                new MainPresenter(mainView, connectionString);
                startForm = (Form)mainView;
            }
            else
            {
                ILoginView loginView = new LogInFormView(connectionString);
                IBaseRepository<UserModel> userRepository = new UserRepository(connectionString);
                new LoginPresenter(loginView, userRepository);
                startForm = (Form)loginView;
            }
            //IMainView mainView = new MainView();
            //new MainPresenter(mainView, connectionString);
            //startForm = (Form)mainView;

            Application.Run(startForm);
        }
    }
}