namespace BicycleApp.Services.Services.Comment
{
    using System.Threading.Tasks;

    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Comment;
    using Microsoft.EntityFrameworkCore;

    public class CommentService : ICommentService
    {
        private readonly BicycleAppDbContext dbContext;
        private readonly IModelsFactory modelsFactory;

        public CommentService(BicycleAppDbContext dbContext, IModelsFactory modelsFactory)
        {
            this.dbContext = dbContext;
            this.modelsFactory = modelsFactory;
        }

        /// <summary>
        /// This method creates a new comment in the database
        /// </summary>
        /// <param name="commentAddDto">Info</param>
        /// <returns>True/False</returns>
        public async Task<bool> AddNewCommentAsync(CommentAddDto commentAddDto)
        {
            if (commentAddDto == null)
            {
                return false;
            }

            Comment comment = modelsFactory.CreateNewComment(commentAddDto);

            await dbContext.Comments.AddAsync(comment);
            await dbContext.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// This method updates a comment data in the database
        /// </summary>
        /// <param name="commentEditDto">Info</param>
        /// <returns>True/False</returns>
        public async Task<bool> EditCommentAsync(CommentEditDto commentEditDto)
        {
            if (commentEditDto == null)
            {
                return false;
            }

            Comment? comment = await dbContext.Comments
                .FirstOrDefaultAsync(c => c.Id == commentEditDto.Id);

            if (comment == null)
            {
                return false;
            }

            comment.PartId = commentEditDto.PartId;
            comment.ClientId = commentEditDto.ClientId;
            comment.Title = commentEditDto.Title;
            comment.Description = commentEditDto.Description;
            comment.DateUpdated = DateTime.UtcNow;

            await dbContext.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// This method returns a comment info
        /// </summary>
        /// <param name="clientId">Client id</param>
        /// <param name="partId">Part id</param>
        /// <returns>Dto of Null</returns>
        public async Task<CommentEditDto?> GetCommentAsync(string clientId, int partId)
        {
            Comment? comment = await dbContext.Comments
                .FirstOrDefaultAsync(c => c.ClientId == clientId && c.PartId == partId);

            if (comment == null)
            {
                return null;
            }

            return new CommentEditDto()
            {
                Id = comment.Id,
                ClientId = clientId,
                PartId = partId,
                Description = comment.Description,
                Title = comment.Title
            };
        }
    }
}
