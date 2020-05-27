using diploma.Models;
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
                    View.LoginForm.Hide();
                    var mainForm = new MainForm(result, View.LoginForm.ServiceProvider);
                    mainForm.Show();
                }
            }
        }
    }
}
