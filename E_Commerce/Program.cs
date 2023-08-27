using E_Commerce.Data.Context;
using E_Commerce.Model;
using E_Commerce.Repository.Interface;
using E_Commerce.Repository.Repository;
using E_Commerce.Repository.UnitOfWork;
using E_Commerce.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace E_Commerce
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddLogging(logging => {
                        logging.AddDebug();
                    });
                    services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer("Data Source=OWAGEH-LT-11120\\SQLEXPRESS;Initial Catalog=ECommerce;Integrated Security=True;TrustServerCertificate=True"));
                    services.AddScoped<Form1>();
                    services.AddScoped<Form2>();
                    services.AddScoped<Form3>();
                    services.AddScoped<UserService>();
                    services.AddScoped<AdminService>();
                    services.AddScoped<CustomerService>();
                    services.AddScoped<IAdminRepository, AdminRepository> ();
                    services.AddScoped<IUserRepository, UserRepository>();
                    services.AddScoped<ICustomerRepository, CustomerRepository>();
                    services.AddScoped<IOrderDetailsRepository, OrderDetailsRepository>();
                    services.AddScoped<IOrderRepository, OrderRepository>();
                    services.AddScoped<IProductRepository, ProductRepository>();
                    services.AddScoped<ICategoryRepository, CategoryRepository>();
                    services.AddScoped<IUnitOfWork, UnitOfWork>();


                });
        }
    }
}