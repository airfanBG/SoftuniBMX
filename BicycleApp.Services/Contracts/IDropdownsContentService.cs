using BicycleApp.Services.Models;

namespace BicycleApp.Services.Contracts
{
    public interface IDropdownsContentService
    {
        Task<ICollection<PartInfoDto>> GetAllFrames();
        Task<ICollection<PartInfoDto>> GetAllCompatibleWheels(int id);
        Task<ICollection<PartInfoDto>> GetAllCompatibleAcsessories(int id);
        Task<PartDto> GetPartByIdAsync(int id);
    }
}
