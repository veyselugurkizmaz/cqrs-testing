using CQRSTesting.Application.Infrastructure.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSTesting.Application.Services.TodoLists.CreateTodoList
{
    public class CreateTodoListHandler : IRequestHandler<CreateTodoListRequest, CreateTodoListResponse>
    {
        private readonly IDbContext _dbContext;
        public CreateTodoListHandler(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateTodoListResponse> Handle(CreateTodoListRequest request, CancellationToken cancellationToken)
        {
            var entity = new Entities.TodoList
            {
                Id = GetNextId(),
                Name = request.Name
            };
            _dbContext.TodoLists.Add(entity);
            return CreateTodoListResponse.Create(entity.Id);
        }
        private int GetNextId()
        {
            int? lastId = _dbContext.TodoLists.OrderByDescending(x => x.Id).FirstOrDefault()?.Id;
            return lastId.HasValue ? lastId.Value + 1 : 1;
        }
    }
}
