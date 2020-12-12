using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;

namespace PresentationLayer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);    

            using (var serviceProvider = services.BuildServiceProvider()) {
                var form1 = serviceProvider.GetRequiredService<FormStudents>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services) {
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentBusiness, StudentBusiness>();
            services.AddScoped<FormStudents>();
        }
    }
}
