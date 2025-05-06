using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;
using SimpleCRM.View._interface;

namespace SimpleCRM.Presentor._presenter
{
    public class SignupPresenter
    {
        private ISignUpView view;
        private IBaseRepository<UserModel> repository;

        public SignupPresenter(ISignUpView view, IBaseRepository<UserModel> repository)
        {
            this.view = view;
            this.repository = repository;
            this.view.SignUpEvent += OnSignup;
        }

        private void OnSignup(object? sender, EventArgs e)
        {
            try
            {
                var model = new UserModel
                {
                    FullName = view.FullName,
                    Username = view.Username,
                    Password = view.Password,
                    Role = "admin",
                    Email = view.Email
                };

                new Common.ModelDataValidation().Validate(model);
                repository.Add(model);

                view.IsSuccessful = true;
                view.Message = "Signup successfully!";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
    }
}
