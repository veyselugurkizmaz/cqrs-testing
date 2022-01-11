using CQRSTesting.Application.Entities;
using System.Collections.Generic;

namespace CQRSTesting.Application.Infrastructure.Persistence
{
    internal class DbContext : IDbContext
    {
        public IList<TodoList> TodoLists { get; } = new List<TodoList>();
    }
}
