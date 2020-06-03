using diploma.Models;
using diploma.Services;
using diploma.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class AddTestPresenter : GenericPresenter<IAddTestView>
    {
        public AddTestPresenter(IAddTestView view) : base(view)
        {
        }

        public void AddTheme()
        {
            IAddTestView v = View;
            if (v.TestName.Length < 2)
            {
                v.Message = "Длина названия темы должна быть больше 2-х символов!";
                return;
            }
            if (!decimal.TryParse(v.Time, out var time))
            {
                v.Message = "Не верный формат времени. (пример 45)";
                return;
            }

            using var context = new Context();

            var test = new Test
            {
                Name = v.TestName,
                Description = v.Description,
                Time = time,
                UserId = GetUserDataService.CurrentUser.Id
            };

            context.Tests.Add(test);

            context.SaveChanges();

            var form = new TestEditor(test);

            form.ShowDialog();
        }
    }
}
