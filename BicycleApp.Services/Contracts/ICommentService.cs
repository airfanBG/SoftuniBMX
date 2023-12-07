namespace BicycleApp.Services.Contracts
{
    using System.Threading.Tasks;

    using BicycleApp.Services.Models;

    public interface ICommentService
    {
        Task<bool> AddNewCommentAsync(CommentAddDto commentAddDto);

        Task<bool> EditCommentAsync(CommentEditDto commentEditDto);

        Task<CommentEditDto?> GetCommentAsync(string clientId, int partId);
    }
}
