using diploma.Models;
using diploma.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class AddUserPresenter : GenericPresenter<IAddUserView>
    {
        public AddUserPresenter(IAddUserView view) : base(view)
        {
        }


        public async Task AddUser()
        {
            #region validation
            View.Message = string.Empty;
            if (string.IsNullOrEmpty(View.Login))
            {
                View.Message = "Введите логин!";
                return;
            }
            if (string.IsNullOrEmpty(View.UserName))
            {
                View.Message = "Введите имя пользователя!";
                return;
            }
            if (string.IsNullOrEmpty(View.Password))
            {
                View.Message = "Введите пароль!";
                return;
            }
            if (View.Password != View.PasswordConfirmation)
            {
                View.Message = "Пароли не совпадают!";
                return;
            }
            #endregion
            using (var context = new Context())
            {
                var user = new User
                {
                    Login = View.Login,
                    Password = View.Password,
                    UserName = View.UserName,
                    RoleId = View.IsTeacher ? 1 : 2
                };
                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();
                View.Message = "Пользователь добавлен!";
            }
        }

        public void ClearValue()
        {
            View.IsTeacher = false;
            View.Login = string.Empty;
            View.Message = string.Empty;
            View.Password = string.Empty;
            View.PasswordConfirmation = string.Empty;
            View.UserName = string.Empty;
        }

        internal void LoadUsers()
        {
            using var context = new Context();
            View.Users = context.Users.ToList();
        }

        internal void ShowUser()
        {
            var form = new UserForm(View.SelectedUser.Id);
            form.ShowDialog();
        }
    }
}
