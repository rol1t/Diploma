using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Views
{
    public interface IAddUserView
    {
        string Login { get; set; }

        string UserName { get; set; }

        string Password { get; set; }

        string PasswordConfirmation { get; set; }

        bool IsTeacher { get; set; }

        string Message { get; set; }

        public List<User> Users { get; set; }

        public User SelectedUser { get; }
    }
}
