namespace BicycleApp.Data.Models.IdentityModels
{
    using System;

    using Microsoft.AspNetCore.Identity;

    public class BaseUser : IdentityUser<string>
    {
        public BaseUser()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
