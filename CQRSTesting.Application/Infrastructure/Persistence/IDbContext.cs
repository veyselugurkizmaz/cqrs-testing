using CQRSTesting.Application.Entities;
using System.Collections.Generic;

namespace CQRSTesting.Application.Infrastructure.Persistence
{
    public interface IDbContext
    {
        public IList<TodoList> TodoLists { get; }
    }
}
