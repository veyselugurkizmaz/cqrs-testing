using CQRSTesting.Application.Entities;
using CQRSTesting.Application.Infrastructure.Persistence;
using Moq;
using System.Collections.Generic;

namespace CQRSTesting.UnitTests.Mocks
{
    public static class MockTodoListDbContext
    {
        public static Mock<IDbContext> GetDbContext()
        {
            IList<TodoList> todoLists = new List<TodoList>
            {
                new TodoList{ Id = 1, Name = "List 1"},
                new TodoList{ Id = 2, Name = "List 2"}
            };
            var mockDbContext = new Mock<IDbContext>();
            mockDbContext.Setup(c => c.TodoLists).Returns(todoLists);
            return mockDbContext;
        }
    }
}
