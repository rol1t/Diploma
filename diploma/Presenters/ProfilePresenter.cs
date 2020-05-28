using diploma.Services;
using diploma.Views;
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

        public void Logout()
        {
            var rmManager = new RememberMeManager();
            rmManager.RemoveUser();
            Environment.Exit(0);
        }
    }
}
