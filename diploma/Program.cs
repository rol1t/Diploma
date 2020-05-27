using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace diploma
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            Startup.ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(form1);
            }
        }
    }
}
