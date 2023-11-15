namespace BicycleApp.Services.Services
{
    using System.Threading.Tasks;

    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.ApplicationGlobalConstants;

    public class HomePageService : IHomePageService
    {
        private readonly BicycleAppDbContext dbContext;

        public HomePageService(BicycleAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// This method return dto for the index page with data for the bike models and comments
        /// </summary>
        /// <returns>IndexPageDto or null</returns>
        /// <exception cref="Exception">Throws Exeption if there is an error with the data exptraction from the database</exception>
        public async Task<IndexPageDto?> GetIndexPageData()
        {
            IndexPageDto? indexDto = null;

            try
            {
                //Get the bike models
                var bikes = await dbContext.BikesStandartModels
                    .AsNoTracking()
                    .Include(b => b.BikeModelsParts)
                    .ThenInclude(bp => bp.Part)
                    .Select(e => new BikeStandartTypeDto()
                    {
                        Id = e.Id,
                        ModelName = e.ModelName,
                        UmageUrl = e.ImageUrl,
                        Parts = e.BikeModelsParts
                                 .Select(bp => new PartShortInfoDto()
                                 {
                                     PartId = bp.PartId,
                                     PartName = bp.Part.Name
                                 })
                                 .ToList()
                    })
                    .ToListAsync();

                //Get all comments id's from the database
                int[] commentsInTheDatabaseCount = await dbContext.Comments
                    .AsNoTracking()
                    .Select(c => c.Id)
                    .ToArrayAsync();
                int count = 2;
                Random random = new Random();

                //Select only 2 on random
                HashSet<int> ids = commentsInTheDatabaseCount.OrderBy(i => random.Next()).Take(count).ToHashSet();

                //Get the 2 comments
                var comments = await dbContext.Comments
                    .AsNoTracking()
                    .Include(c => c.Client)
                    .ThenInclude(cl => cl.Images)
                    .Include(c => c.Part)
                    .Where(c => ids.Contains(c.Id))
                    .Select(x => new CommentInfoDto()
                    {
                        Id = x.Id,
                        PartId = x.PartId,
                        PartName = x.Part.Name,
                        ClientId = x.ClientId,
                        //To be fixed when we set the default client image
                        ClientUmageUrl = x.Client.Images.First().ImageUrl,
                        //To check with Front-End is the FullName of UserName
                        ClientFullName = $"{x.Client.FirstName} {x.Client.LastName}",
                        CommentDescription = x.Description,
                        DateCreated = x.DateCreated.ToString(DefaultDateFormat)
                    })
                    .ToListAsync();

                indexDto = new IndexPageDto()
                {
                    DefaultBikes = bikes,
                    Comments = comments,
                };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return indexDto;
        }

        /// <summary>
        /// This method return dto for the index page with data for the bike models, comments and user
        /// </summary>
        /// <param name="userId">Id of the user</param>      
        /// <returns>IndexPageDto or null</returns>
        public async Task<IndexPageDto?> GetIndexPageData(string userId)
        {
            var dto = await this.GetIndexPageData();

            if (dto == null)
            {
                return null;
            }

            string userFullName = await dbContext.Clients
                .AsNoTracking()
                .Where(u => u.Id == userId)
                .Select(r => $"{r.FirstName} {r.LastName}")
                .FirstAsync();

            dto.UserId = userId;
            dto.UserFullName = userFullName;

            return dto;
        }
    }
}
