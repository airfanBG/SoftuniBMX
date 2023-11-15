namespace BicicleApp.Api
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Services;
    using BicycleApp.Services.Services.Email;
    using BicycleApp.Services.Services.Factory;
    using BicycleApp.Services.Services.IdentityServices;
    using BicycleApp.Services.Services.Image;
    using BicycleApp.Services.Services.Order;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services
                .AddDbContext<BicycleAppDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddIdentityCore<Client>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 5;

            })
                .AddRoles<IdentityRole<string>>()
                .AddEntityFrameworkStores<BicycleAppDbContext>();

            builder.Services.AddIdentityCore<Employee>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 5;

            })
                .AddRoles<IdentityRole<string>>()
                .AddEntityFrameworkStores<BicycleAppDbContext>();

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddScoped<SignInManager<Client>>();
            builder.Services.AddScoped<SignInManager<Employee>>();
            builder.Services.AddScoped<IHomePageService, HomePageService>();
            builder.Services.AddScoped<IClientService, ClientService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IFactory, Factory>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IEmailSender, EmailSender>();
            builder.Services.AddScoped<IImageStore, ImageStore>();
            builder.Services.AddScoped<IPictureOrganizerServices, PictureOrganizerServices>();
            builder.Services.AddScoped<IModelsFactory, ModelsFactory>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}