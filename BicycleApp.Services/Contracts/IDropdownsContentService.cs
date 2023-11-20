using BicycleApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleApp.Services.Contracts
{
    public interface IDropdownsContentService
    {
        Task<ICollection<PartInfoDto>> GetAllFrames();
        Task<ICollection<PartInfoDto>> GetAllWheels();
        Task<ICollection<PartInfoDto>> GetAllAcsessories();
        Task<PartDto> GetPartByIdAsync(int id);
    }
}
