namespace BicicleApp.Api
{
    using System.Text;
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Common;
    using BicycleApp.Common.Providers;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses;
    using BicycleApp.Services.HelperClasses.Contracts;
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
    using BicycleApp.Services.Services.ManagerServices;
    using BicycleApp.Services.Services.Part;
    using BicycleApp.Services.Services.Bike;
    using BicycleApp.Services.Services.Comment;
    using BicycleApp.Services.Services.DropdownsContent;
    using BicycleApp.Services.Services.HomePage;
    using BicycleApp.Services.Services.Rating;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var bmxCors = "_bmxCors";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(bmxCors,
                                  policy =>
                                  {
                                      policy.WithOrigins("https://extreme-bmx.vercel.app")
                                      //policy.WithOrigins("http://localhost:5173")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                                  });
            });


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services
                .AddDbContext<BicycleAppDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<BaseUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 5;
            })
                .AddRoles<BaseUserRole>()
                .AddEntityFrameworkStores<BicycleAppDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddIdentityCore<Client>()
                .AddEntityFrameworkStores<BicycleAppDbContext>();

            builder.Services.AddIdentityCore<Employee>()
                .AddEntityFrameworkStores<BicycleAppDbContext>();

            builder.Services.AddAuthorization();
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
            builder.Services.AddScoped<IQualityAssuranceService, QualityAssuranceService>();
            builder.Services.AddScoped<IEmployeeOrderService, EmployeeOrderService>();
            builder.Services.AddScoped<IDateTimeProvider, DateTimeProvider>();
            builder.Services.AddScoped<IOptionProvider, OptionProvider>();
            builder.Services.AddScoped<IBikeService, BikeService>();
            builder.Services.AddScoped<ICommentService, CommentService>();
            builder.Services.AddScoped<IPartService, PartService>();
            builder.Services.AddScoped<IDropdownsContentService, DropdownsContentService>();
            builder.Services.AddScoped<IEmployeeFactory, EmployeeFactory>();
            builder.Services.AddScoped<ISupplyManagerService, SupplyManagerService>();
            builder.Services.AddScoped<IManagerSatisticsService, ManagerSatisticsService>();
            builder.Services.AddScoped<IWorkerManagement, WorkerManagement>();
            builder.Services.AddScoped<IRatingService, RatingService>();
            builder.Services.AddScoped<IRatingFactory, RatingFactory>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors(bmxCors);

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}