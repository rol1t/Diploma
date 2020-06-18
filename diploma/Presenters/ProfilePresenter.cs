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
    public class ProfilePresenter : GenericPresenter<IProfileView>
    {
        public ProfilePresenter(IProfileView view) : base(view)
        {
        }

        public void Load()
        {
            using var context = new Context();
            var u = GetUserDataService.CurrentUser;
            View.Login = u.Login;
            View.UserName = u.UserName;
            var role = context.Users
                .Include(u => u.Role)
                .FirstOrDefault(us => us.Id == u.Id).Role;
            View.Role = role.Name;
            var complTest = context.Results
                .Where(r => r.UserId == u.Id)
                .Select(r => new { r.UserId, r.TestId })
                .Distinct()
                .Count();
            View.ComplTest = $"{complTest}";
        }

        public void Logout()
        {
            var rmManager = new RememberMeManager();
            rmManager.RemoveUser();
            Environment.Exit(0);
        }
    }
}
