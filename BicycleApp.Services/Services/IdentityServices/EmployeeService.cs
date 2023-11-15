namespace BicycleApp.Services.Services.IdentityServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.IdentityModels;

    using Microsoft.AspNetCore.Identity;

    using Microsoft.Extensions.Configuration;
    using Microsoft.EntityFrameworkCore;
    using BicycleApp.Data.Models.EntityModels;
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;

    public class EmployeeService : IEmployeeService
    {
        private readonly UserManager<Employee> userManager;
        private readonly SignInManager<Employee> signInManager;
        private readonly BicycleAppDbContext dbContext;
        private readonly IConfiguration configuration;

        public EmployeeService(UserManager<Employee> userManager, SignInManager<Employee> signInManager, BicycleAppDbContext dbContext, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public async Task<bool> RegisterEmployeeAsync(EmployeeRegisterDto employeeRegisterDto)
        {
            if (employeeRegisterDto == null)
            {
                throw new ArgumentNullException(nameof(employeeRegisterDto));
            }

            var existingClient = await userManager.FindByEmailAsync(employeeRegisterDto.Email);
            if (existingClient != null)
            {
                throw new ArgumentException($"Cliennt with email: {employeeRegisterDto.Email} already exists!");
            }

            var employee = new Employee()
            {
                FirstName = employeeRegisterDto.FirstName,
                LastName = employeeRegisterDto.LastName,
                Email = employeeRegisterDto.Email,
                NormalizedEmail = employeeRegisterDto.Email.ToUpper(),
                UserName = employeeRegisterDto.Email,
                NormalizedUserName = employeeRegisterDto.Email.ToUpper(),
                DateCreated = DateTime.UtcNow,
                DateOfHire = DateTime.Parse(employeeRegisterDto.DateOfHire),
                DateOfLeave = null,
                DateUpdated = null,
                IsManeger = employeeRegisterDto.IsManeger,
                PhoneNumber = employeeRegisterDto.PhoneNumber,
                Position = employeeRegisterDto.Position,
                DepartmentId = await this.GetDepartmentIdAsync(employeeRegisterDto.Department),
                IsDeleted = false
            };

            var result = await this.userManager.CreateAsync(employee, employeeRegisterDto.Password);

            if (result == null)
            {
                return false;
            }

            if (result.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<EmployeeReturnDto> LoginEmployeeAsync(EmployeeLoginDto employeeDto)
        {
            if (employeeDto == null)
            {
                throw new ArgumentNullException(nameof(employeeDto));
            }

            var employee = await this.userManager.FindByEmailAsync(employeeDto.Email);

            if (employee == null)
            {
                return new EmployeeReturnDto() { Result = false };
            }

            var passwordMatches = await this.userManager.CheckPasswordAsync(employee, employeeDto.Password);
            if (!passwordMatches)
            {
                return new EmployeeReturnDto() { Result = false };
            }

            var result = await signInManager.PasswordSignInAsync(employeeDto.Email, employeeDto.Password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return new EmployeeReturnDto()
                {
                    EmployeeId = employee.Id,
                    Token = this.GenerateJwtTokenAsync(employee),
                    Result = true
                };
            }
            else
            {
                return new EmployeeReturnDto { Result = false };
            }
        }

        public async Task<EmployeeInfoDto?> GetEmployeeInfoAsync(string Id)
        {
            var employee = await userManager.FindByIdAsync(Id);

            if (employee == null)
            {
                return null;
            }

            string? department = await dbContext.Departments
                .Where(d => d.Id == employee.DepartmentId)
                .Select(d => d.Name)
                .FirstOrDefaultAsync();

            return new EmployeeInfoDto()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Position = employee.Position,
                Department = department,
                PhoneNumber = employee.PhoneNumber,
                DateCreated = employee.DateCreated.ToString(),
                DateOfHire = employee.DateOfHire.ToString(),
                DateOfLeave = employee.DateOfLeave == null ? null: employee.DateOfLeave.ToString(),
                DateUpdated = employee.DateUpdated == null ? null : employee.DateUpdated.ToString(),
                IsManeger = employee.IsManeger
            };
        }

        private async Task<int> GetDepartmentIdAsync(string department)
        {
            var departmentEntity = await dbContext.Departments
                .Where(d => d.Name == department)
                .FirstOrDefaultAsync();

            if (departmentEntity == null)
            {
                var newDepartment = new Department()
                {
                    Name = department,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                };

                await dbContext.Departments.AddAsync(newDepartment);
                await dbContext.SaveChangesAsync();

                int id = await dbContext.Departments
                    .Where(d => d.Name == department)
                    .Select(d => d.Id)
                    .FirstOrDefaultAsync();

                return id;
            }
            else
            {
                return departmentEntity.Id;
            }
        }

        private string GenerateJwtTokenAsync(Employee employee)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, employee.Id.ToString()),
                new Claim(ClaimTypes.Email, employee.Email)
            };

            var expires = DateTime.UtcNow.AddDays(7);

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecret"]));

            var credentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: configuration["JwtIssuer"],
                audience: configuration["JwtAudience"],
                claims: claims,
                expires: expires,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }    
    }
}
