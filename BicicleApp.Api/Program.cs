namespace BicicleApp.Api
{
    using System.Text;
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Common;
    using BicycleApp.Common.Providers;
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Services;
    using BicycleApp.Services.Services.Email;
    using BicycleApp.Services.Services.Factory;
    using BicycleApp.Services.Services.IdentityServices;
    using BicycleApp.Services.Services.Image;
    using BicycleApp.Services.Services.Order;
    using BicycleApp.Services.Services.Orders;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.IdentityModel.Tokens;
    using Newtonsoft.Json;

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
                options.SignIn.RequireConfirmedEmail = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 5;

            })
                .AddRoles<IdentityRole<string>>()
                .AddEntityFrameworkStores<BicycleAppDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddIdentityCore<Employee>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 5;

            })
                .AddRoles<IdentityRole<string>>()
                .AddEntityFrameworkStores<BicycleAppDbContext>();

            var jwtSecret = builder.Configuration["JwtSecret"];
            var key = Encoding.ASCII.GetBytes(jwtSecret);
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddScoped<SignInManager<Client>>();
            builder.Services.AddScoped<SignInManager<Employee>>();
            builder.Services.AddScoped<IHomePageService, HomePageService>();
            builder.Services.AddScoped<IClientService, ClientService>();
            builder.Services.AddScoped<IUserImageFactory, UserImageFactory>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IModelsFactory, ModelsFactory>();
            builder.Services.AddScoped<IUserFactory, UserFactory>();
            builder.Services.AddScoped<IOrderManagerService, OrderManagerService>();
            builder.Services.AddScoped<IOrderUserService, OrderUserService>();
            builder.Services.AddScoped<IOrderFactory, OrderFactory>();
            builder.Services.AddScoped<IEmailSender, EmailSender>();
            builder.Services.AddScoped<IImageStore, ImageStore>();
            builder.Services.AddScoped<IPictureOrganizerServices, PictureOrganizerServices>();
            builder.Services.AddScoped<IOptionProvider, OptionProvider>();
            builder.Services.AddScoped<IStringManipulator, StringManipulator>();
            builder.Services.AddScoped<IDateTimeProvider, DateTimeProvider>();
            builder.Services.AddScoped<IDateTimeProvider, DateTimeProvider>();
            builder.Services.AddScoped<IGuidProvider, GuidProvider>();

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