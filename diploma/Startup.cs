using diploma.Models;
using diploma.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma
{
    public static class Startup
    {
        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<LoginForm>()
                    .AddDbContext<Context>()
                    .AddSingleton<RememberMeManager>();
        }
    }
}
