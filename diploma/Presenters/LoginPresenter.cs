using diploma.Models;
using diploma.Services;
using diploma.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class LoginPresenter : GenericPresenter<ILoginView>
    {
        public LoginPresenter(ILoginView view) : base(view)
        {
        }

        public async Task Login()
        {
            using (var context = new Context())
            {
                View.ErrorMessage = string.Empty;
                var result = await context.Users
                    .FirstOrDefaultAsync(u => u.Login == View.Login && u.Password == View.Password);

                if (result == null)
                {
                    View.ErrorMessage = "Неверный пароль или логин!";
                    View.Password = "";
                }
                else
                {
                    var rmManager = new RememberMeManager();

                    if (View.RememberMe)
                    {
                        rmManager.RememberMe(result);
                    }
                    else
                    {
                        rmManager.RemoveUser();
                    }

                    GetUserDataService.CurrentUser = result;
                    ShowMainForm(result);
                }
            }
        }

        public async Task AutoLogin()
        {
            var rmManager = new RememberMeManager();
            var user = rmManager.GetUser();

            if (user != null)
            {
                using (var context = new Context())
                {
                    var result = await context.Users
                        .FirstOrDefaultAsync(u => u.Login == user.Login && u.Password == user.Password);

                    if (result != null)
                    {
                        ShowMainForm(result);
                    }
                }
            }
        }

        private void ShowMainForm(User result)
        {
            View.LoginForm.Hide();
            var mainForm = new MainForm(result);
            GetUserDataService.CurrentUser = result;
            mainForm.Show();
        }
    }
}
