using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Services
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ApplicationContext>()
                .To<ApplicationContext>()
                .InSingletonScope();
        }
    }
}
