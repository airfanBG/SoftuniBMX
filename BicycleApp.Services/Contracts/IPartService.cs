namespace BicycleApp.Services.Contracts
{
    using System.Threading.Tasks;
    using BicycleApp.Services.Models.Part;

    public interface IPartService
    {
        Task<bool> AddNewPart(PartAddDto partAddDto);

        Task<bool> EditPart(PartEditDto partEditDto);

        Task<PartGetDto> GetCategoties();

        Task<PartFullInfoDto?> GetPartById(int partId);
    }
}
