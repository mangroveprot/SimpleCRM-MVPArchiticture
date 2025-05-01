using System.Configuration;
using SimpleCRM._Repositories;
using SimpleCRM.Models;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;
using SimpleCRM.Presentor;
using SimpleCRM.Presentor.Presenter;
using SimpleCRM.View;
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

            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, connectionString);
            Application.Run((Form)view);
        }
    }
}