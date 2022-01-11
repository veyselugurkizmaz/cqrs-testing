using CQRSTesting.Application.Infrastructure.Persistence;
using CQRSTesting.Application.Services.TodoLists.GetAllTodoLists;
using CQRSTesting.UnitTests.Mocks;
using Moq;
using Shouldly;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CQRSTesting.UnitTests.TodoLists.Services
{
    public class CreateTodoListHandlerTests
    {
        private readonly IDbContext _mockDbContext;

        public CreateTodoListHandlerTests()
        {
            _mockDbContext = MockTodoListDbContext.GetDbContext().Object;
        }

        [Fact]
        public async Task GetAllTodoListsTest()
        {
            var handler = new GetAllTodoListsHandler(_mockDbContext);
            var result = await handler.Handle(new GetAllTodoListsRequest(), CancellationToken.None);
            result.ShouldBeOfType<GetAllTodoListsResponse>();
            result.TodoLists.ShouldBeOfType<ReadOnlyCollection<GetAllTodoListsDto>>();
            result.TodoLists.Count.ShouldBe(2);
        }
    }
}
