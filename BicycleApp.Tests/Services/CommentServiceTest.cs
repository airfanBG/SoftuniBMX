namespace BicycleApp.Tests.Services
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Services;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Moq.EntityFrameworkCore;

    public class CommentServiceTest
    {
        private readonly Mock<BicycleAppDbContext> _fakeDbContext = new Mock<BicycleAppDbContext>();
        private readonly Mock<IModelsFactory> _fakeModelFactory = new Mock<IModelsFactory>();

        private readonly ICommentService _commentService;

        public CommentServiceTest()
        {
            _commentService = new CommentService(_fakeDbContext.Object, _fakeModelFactory.Object);
        }

        [Test]
        public async Task AddNewCommentAsync_ShouldReturnFals_WhenGivenParameterIsNull()
        {
            //Arrange
            CommentAddDto emptyComment = null;

            //Act
            var actual = await _commentService.AddNewCommentAsync(emptyComment);

            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public async Task AddNewCommentAsync_ShouldReturnIncrementedCountOfAddedComment()
        {
            //Arrange
            CommentAddDto commentAddDto = new CommentAddDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "Test Description",
                PartId = 1,
                Title = "Test Title"
            };

            Comment comment = new Comment
            {
                Id = 1,
                PartId = 1,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Title = "Test Title",
                Description = "Test Description",
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null
            };

            _fakeModelFactory.Setup(x => x.CreateNewComment(It.IsAny<CommentAddDto>())).Returns(comment);
            int actualCountOfAddedComments = 0;
            int actualCountOfAddedComentInContext = 0;

            var fakeCommentDbSet = new Mock<DbSet<Comment>>();
            fakeCommentDbSet.Setup(x => x.AddAsync(comment, It.IsAny<CancellationToken>())).Callback(() => actualCountOfAddedComments++);
            _fakeDbContext.Setup(x => x.Comments).Returns(fakeCommentDbSet.Object);
            _fakeDbContext.Setup(x => x.SaveChangesAsync(It.IsAny<CancellationToken>())).Callback(() => actualCountOfAddedComentInContext++);

            //Act
            var actual = await _commentService.AddNewCommentAsync(commentAddDto);
            int expected = 1;

            //Assert
            Assert.AreEqual(expected, actualCountOfAddedComments);
            Assert.AreEqual(expected, actualCountOfAddedComentInContext);
        }

        [Test]
        public async Task AddNewCommentAsync_ShouldReturnTrue_WhenSuccessfulyAddCommentInDatabase()
        {
            //Arrange
            CommentAddDto commentAddDto = new CommentAddDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "Test Description",
                PartId = 1,
                Title = "Test Title"
            };

            Comment comment = new Comment
            {
                Id = 1,
                PartId = 1,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Title = "Test Title",
                Description = "Test Description",
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null
            };

            _fakeModelFactory.Setup(x => x.CreateNewComment(It.IsAny<CommentAddDto>())).Returns(comment);

            var fakeCommentDbSet = new Mock<DbSet<Comment>>();
            _fakeDbContext.Setup(x => x.Comments).Returns(fakeCommentDbSet.Object);

            //Act
            var actual = await _commentService.AddNewCommentAsync(commentAddDto);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public async Task EditCommentAsync_ShouldReturnFalse_WhenGivenParameterIsNull()
        {
            //Arrange
            CommentEditDto emptyComment = null;

            //Act
            var actual = await _commentService.EditCommentAsync(emptyComment);

            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public async Task EditCommentAsync_ShouldReturnFalse_WhenCommentIsNotInDatabase()
        {
            //Arrange
            int invalidCommentId = 2;

            CommentEditDto commentToEdit = new CommentEditDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "Test Description",
                PartId = 1,
                Title = "Test Title",
                Id = invalidCommentId
            };

            Comment comment = new Comment
            {
                Id = 1,
                PartId = 1,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Title = "Test Title",
                Description = "Test Description",
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null
            };

            _fakeDbContext.Setup(x => x.Comments).ReturnsDbSet(new List<Comment> { comment });

            //Act
            var actual = await _commentService.EditCommentAsync(commentToEdit);

            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public async Task EditCommentAsync_ShouldReturnCorrectedProperties()
        {
            //Arrange

            //There is no need to change client and part.
            CommentEditDto commentToEdit = new CommentEditDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "Edited Description",
                PartId = 1,
                Title = "Edited Title",
                Id = 1,                
            };

            Comment comment = new Comment
            {
                Id = 1,
                PartId = 1,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Title = "Test Title",
                Description = "Test Description",
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null
            };

            _fakeDbContext.Setup(x => x.Comments).ReturnsDbSet(new List<Comment> { comment });

            //Act
            var actual = await _commentService.EditCommentAsync(commentToEdit);
            var editedComment = _fakeDbContext.Object.Comments.First();


            //Assert
            Assert.AreEqual(commentToEdit.Description, editedComment.Description);
            Assert.AreEqual(commentToEdit.Title, editedComment.Title);
        }

        [Test]
        public async Task EditCommentAsync_ShouldReturnTrue_WhenEditIsSuccess()
        {
            //Arrange

            //There is no need to change client and part.
            CommentEditDto commentToEdit = new CommentEditDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "Edited Description",
                PartId = 1,
                Title = "Edited Title",
                Id = 1,
            };

            Comment comment = new Comment
            {
                Id = 1,
                PartId = 1,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Title = "Test Title",
                Description = "Test Description",
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null
            };

            _fakeDbContext.Setup(x => x.Comments).ReturnsDbSet(new List<Comment> { comment });

            //Act
            var actual = await _commentService.EditCommentAsync(commentToEdit);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public async Task GetCommentAsync_ShouldReturnNull_WhenClientDoNotHaveCommentForSpecificPart()
        {
            //Arrange
            string clientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd";
            int partThatHasNoCommentFromClient = 2;

            Comment comment = new Comment
            {
                Id = 1,
                PartId = 1,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Title = "Test Title",
                Description = "Test Description",
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null
            };

            _fakeDbContext.Setup(x => x.Comments).ReturnsDbSet(new List<Comment> { comment });

            //Act
            var actual = await _commentService.GetCommentAsync(clientId, partThatHasNoCommentFromClient);

            //Assert
            Assert.IsNull(actual);
        }

        [Test]
        public async Task GetCommentAsync_ShouldReturnNull_WhenPartDoNotHaveCommentFromClient()
        {
            //Arrange
            string clientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd";
            int partThatHasNoCommentFromClient = 1;

            Comment comment = new Comment
            {
                Id = 1,
                PartId = 1,
                ClientId = "not-ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Title = "Test Title",
                Description = "Test Description",
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null
            };

            _fakeDbContext.Setup(x => x.Comments).ReturnsDbSet(new List<Comment> { comment });

            //Act
            var actual = await _commentService.GetCommentAsync(clientId, partThatHasNoCommentFromClient);

            //Assert
            Assert.IsNull(actual);
        }

        [Test]
        public async Task GetCommentAsync_ShouldReturnCorrectComment()
        {
            //Arrange
            string clientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd";
            int partThatHasNoCommentFromClient = 1;

            Comment comment = new Comment
            {
                Id = 1,
                PartId = 1,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Title = "Test Title",
                Description = "Test Description",
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null
            };

            _fakeDbContext.Setup(x => x.Comments).ReturnsDbSet(new List<Comment> { comment });

            //Act
            var actual = await _commentService.GetCommentAsync(clientId, partThatHasNoCommentFromClient);

            //Assert
            Assert.AreEqual(comment.Id, actual.Id);
            Assert.AreEqual(comment.ClientId, actual.ClientId);
            Assert.AreEqual(comment.Title, actual.Title);
            Assert.AreEqual(comment.Description, actual.Description);
        }
    }
}
