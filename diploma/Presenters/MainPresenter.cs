using diploma.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class MainPresenter : GenericPresenter<IMainView>
    {
        public MainPresenter(IMainView view) : base(view)
        {
        }

        public void SetRoleVisibleSettings()
        {
            //если заходят не под ролью учителя
            //то удаляем страницы добавление тестов и пользователей
            if (View.User.RoleId != 1)
            {
                var adminPages = new[]
                {
                    View.MainForm.addTestPage,
                    View.MainForm.addUserPage
                };

                foreach (var item in adminPages)
                {
                    View.MainForm.msTabControl.TabPages.Remove(item);
                }
            }
        }
    }
}
