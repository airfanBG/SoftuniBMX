namespace BicycleApp.Services.Services.HomePage
{
    using System.Threading.Tasks;

    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Order.OrderUser;
    using static BicycleApp.Common.Constants.UserConstants;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.Constants.ApplicationGlobalConstants;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.HomePage;
    using BicycleApp.Services.Models.Comment;
    using BicycleApp.Services.Models.Bike;

    public class HomePageService : IHomePageService
    {
        private readonly BicycleAppDbContext dbContext;
        private readonly IStringManipulator stringManipulator;

        public HomePageService(BicycleAppDbContext dbContext, IStringManipulator stringManipulator)
        {
            this.dbContext = dbContext;
            this.stringManipulator = stringManipulator;
        }

        /// <summary>
        /// This method return dto for the index page with data for the bike models and comments
        /// </summary>
        /// <returns>IndexPageDto or null</returns>
        /// <exception cref="Exception">Throws Exeption if there is an error with the data exptraction from the database</exception>
        public async Task<IndexPageDto?> GetIndexPageData(string httpScheme, string httpHost, string httpPathBase)
        {
            IndexPageDto? indexDto = null;

            try
            {
                //Get the bike models
                var bikes = await dbContext.BikesStandartModels
                    .AsNoTracking()
                    .Include(b => b.BikeModelsParts)
                    .Select(e => new BikeStandartTypeDto()
                    {
                        Id = e.Id,
                        ModelName = e.ModelName,
                        ImageUrl = e.ImageUrl,
                        Price = e.Price,
                        Description = e.Description,
                        OrderParts = e.BikeModelsParts.Select(p => new OrderPartIdDto()
                        {
                            PartId = p.PartId
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
                        ClientImageUrl = stringManipulator.UrlImageMaker(httpScheme, httpHost, httpPathBase, x.Client.Images.Select(i => i.ImageUrl).FirstOrDefault()),
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
    }
}
