namespace BicycleApp.Services.Contracts
{
    using System.Threading.Tasks;

    using BicycleApp.Services.Models;

    public interface IHomePageService
    {
        Task<IndexPageDto?> GetIndexPageData(string httpScheme, string httpHost, string httpPathBase);
    }
}
