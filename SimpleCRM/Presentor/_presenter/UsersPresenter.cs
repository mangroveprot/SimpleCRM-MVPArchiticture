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
    public class UsersPresenter
    {
        //fields
        private IUserView view;
        private IBaseRepository<UserModel> repository;
        private BindingSource bindingSource;
        private IEnumerable<UserModel> usersList;

        public UsersPresenter(IUserView view, IBaseRepository<UserModel> repository)
        {
            bindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchUsers;
            this.view.AddNewEvent += AddNewUsers;
            this.view.EditEvent += LoadSelectedUsersToEdit;
            this.view.DeleteEvent += DeleteUsers;
            this.view.SaveEvent += SaveUsers;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomerBindingSource(bindingSource);
            LoadAllUsersList();
            this.view.Show();
        }

        private void LoadAllUsersList()
        {
            usersList = repository.GetAll();
            bindingSource.DataSource = usersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearViewFields();
        }

        private void ClearViewFields()
        {
            view.UserId = "0";
            view.FullName = "";
            view.Username = "";
            view.Password = "";
            view.Role = "Select a role";
            view.Email = "";
        }

        private void SaveUsers(object? sender, EventArgs e)
        {
            var model = new UserModel();
            string[] roles = ["admin", "user"];
            model.UserId = Convert.ToInt32(view.UserId);
            model.FullName = view.FullName;
            model.Username = view.Username;
            model.Password = view.Password;
            model.Role = view.Role;
            model.Email = view.Email;

            try
            {

                new Common.ModelDataValidation().Validate(model);
                //check if role is valid
                if (!roles.Contains(model.Role.ToLower()))
                {
                    throw new Exception("Invalid Role.");
                }

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "User edit successfully!";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Users added successfully!";
                }
                view.IsSuccessful = true;
                LoadAllUsersList();
                ClearViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void DeleteUsers(object? sender, EventArgs e)
        {
            try
            {
                var user = (UserModel)bindingSource.Current;
                repository.Delete(user);
                view.IsSuccessful = true;
                view.Message = "User deleted successfully";
                LoadAllUsersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete user";
            }
        }

        private void LoadSelectedUsersToEdit(object? sender, EventArgs e)
        {
            var user = (UserModel)bindingSource.Current;
            view.UserId = user.UserId.ToString();
            view.Username = user.Username;
            view.FullName = user.FullName;
            view.Password = user.Password;
            view.Email = user.Email;
            view.Role = user.Role;
            view.IsEdit = true;
        }

        private void AddNewUsers(object? sender, EventArgs e)
        {
            ClearViewFields();
            view.IsEdit = false;
        }

        private void SearchUsers(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(view.SearchValue);
            if (!emptyValue)
            {
                usersList = repository.GetByValue(view.SearchValue);
            }
            else
            {
                usersList = repository.GetAll();
            }
            bindingSource.DataSource = usersList;
        }
    }
}
